using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Go_Singapore.Models;

namespace Go_Singapore.Controllers
{
    public class APIManager
    {
        private const string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOjM0MzYsInVzZXJfaWQiOjM0MzYsImVtYWlsIjoid2xlZTA3NUBlLm50dS5lZHUuc2ciLCJmb3JldmVyIjpmYWxzZSwiaXNzIjoiaHR0cDpcL1wvb20yLmRmZS5vbmVtYXAuc2dcL2FwaVwvdjJcL3VzZXJcL3Nlc3Npb24iLCJpYXQiOjE1NzMyOTI5MzksImV4cCI6MTU3MzcyNDkzOSwibmJmIjoxNTczMjkyOTM5LCJqdGkiOiI0ZTQ5MTg1ZmExZjkyZTdiZTYzMzdjNTJiN2RkMjgzMSJ9.NOd8opw5X-wuD63OfDJXLg9GPxSobPQKHbfTm2Uj56o";
        private string countryAPI = String.Format("https://restcountries.eu/rest/v2/all?fields=name;currencies");
        private string weatherPI = String.Format("https://api.data.gov.sg/v1/environment/24-hour-weather-forecast");
        private string costAPI = String.Format("http://www.budgetyourtrip.com/api/v3/costs/country/SG");
        private string currencyAPI = String.Format("http://data.fixer.io/api/latest?access_key=58c1104541e6b2a3b5438cba29cd46ce&format=1");
        private string attractionAPI = String.Format("https://www.visitsingapore.com/ysapi-services/RequestAPI?format=details&locale=en&pageid=84");
        WebRequest requestObject;
        HttpWebResponse responseObject;

        public Datum[] GetCost()
        {
            requestObject = WebRequest.Create(costAPI);
            requestObject.Method = "GET";
            responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            CostBreakDown costBreakDown = new JavaScriptSerializer().Deserialize<CostBreakDown>(strresulttest);
            return costBreakDown.data;

        }
        public Rates GetCurrency()
        {
            requestObject = WebRequest.Create(currencyAPI);
            requestObject.Method = "GET";
            responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            RateAPI rates = new JavaScriptSerializer().Deserialize<RateAPI>(strresulttest);
            return rates.rates;
        }

        public Item getWeatherForeCast()
        {
            requestObject = WebRequest.Create(weatherPI);
            requestObject.Method = "GET";
            responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            Item[] weatherForecast = new JavaScriptSerializer().Deserialize<Item[]>(strresulttest);
            return weatherForecast[0];
        }
    

        public Country[] GetCountryList()
        {
            requestObject = WebRequest.Create(countryAPI);
            requestObject.Method = "GET";
            responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            Country[] countryList = new JavaScriptSerializer().Deserialize<Country[]>(strresulttest);
            return countryList;
            }

        public string getTravelDestination(List<string> locations)
        {
            var coord = new List<Coordinates>();
            

            for (int i = 0; i < locations.Count; i++)
            {
                //get coords for each location
                var names = GetAddress(locations[i]);
                coord.Add(new Coordinates(names.Item1, names.Item2, names.Item3));
            }

            //get point to point directions
            for (int i = 0; i < coord.Count - 1; i++)
            {
                GetInstructions(coord[i].latitude, coord[i].longitude, coord[i + 1].latitude, coord[i + 1].longitude);
            }
            //pass list of coords as json from code behind to javascript via hiddenvar. Stupid but works.
            return Newtonsoft.Json.JsonConvert.SerializeObject(coord);
        }

        private Tuple<float, float, string> GetAddress(string address)
        {
            float lat = 0;
            float lon = 0;
            string site = " ";
            //GET METHOD for destination search query
            string strurltest = String.Format("https://developers.onemap.sg/commonapi/search?searchVal=" + address + "&returnGeom=Y&getAddrDetails=Y&pageNum=");
            WebRequest requestObjGet = WebRequest.Create(strurltest);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string strresulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }
            //display search recommendations
            Address searchAddress = new JavaScriptSerializer().Deserialize<Address>(strresulttest);
            foreach (var item in searchAddress.results)
            {
                if (item.building == address.ToUpper().Trim())
                {
                    lat = float.Parse(item.latitude);
                    lon = float.Parse(item.longitude);
                    site = item.building;
                    return Tuple.Create(lat, lon, site);
                }
            }
            return Tuple.Create(lat, lon, site);
        }

        //GET METHOD for route query
        private void GetInstructions(float startLat, float startLon, float endLat, float endLon)
        {
                string strurltest = String.Format("https://developers.onemap.sg/privateapi/routingsvc/route?start=" +
                            startLat + "," + startLon + "&end=" + endLat + "," + endLon + "&" +
                            "routeType=" + "drive" + "&token=" + token);
                WebRequest requestObjGet = WebRequest.Create(strurltest);
                requestObjGet.Method = "GET";
                HttpWebResponse responseObjGet = null;
                responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                string strresulttest = null;
                using (Stream stream = responseObjGet.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    strresulttest = sr.ReadToEnd();
                    sr.Close();
                }

                Route route = new JavaScriptSerializer().Deserialize<Route>(strresulttest);
                //display route instructions

        }

        private Tuple<float, float, string> GetAddressTrial(string address)
        {
            float lat = 0;
            float lon = 0;
            string site = " ";
            //GET METHOD for destination search query
            string strurltest = String.Format("https://developers.onemap.sg/commonapi/search?searchVal=" + address + "&returnGeom=Y&getAddrDetails=Y&pageNum=");
            WebRequest requestObjGet = WebRequest.Create(strurltest);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string strresulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }
            //display search recommendations
            Address searchAddress = new JavaScriptSerializer().Deserialize<Address>(strresulttest);
            foreach (var item in searchAddress.results)
            {
                if (item.building == address.ToUpper().Trim())
                {
                    lat = float.Parse(item.latitude);
                    lon = float.Parse(item.longitude);
                    site = item.building;
                    return Tuple.Create(lat, lon, site);
                }
            }
            return Tuple.Create(lat, lon, site);
        }


    }
}