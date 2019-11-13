using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Go_Singapore.Controllers;
using Newtonsoft.Json.Linq;

namespace Go_Singapore.Views
{
    public partial class index1 : System.Web.UI.Page
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        APIManager apiManager = new APIManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Country[] countryList = apiManager.GetCountryList();
            foreach (var country in countryList)
            {
                ListItem li = new ListItem();
                li.Text = country.name;
                li.Value = country.name;
                // DDLCountry.Items.Add(li);
                DDLCurrency.Items.Add(li);
            }



            updateWeather();
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int day;
            
            bool error = false;
            string errorLine = "";

            string country = DDLCurrency.SelectedItem.Text;
            string days = txtDays.Text;

            if (!int.TryParse(days, out day))
            {
                error = true;
                errorLine += "Please enter a valid number" + Environment.NewLine;
            }
            else if (day <= 0)
            {
                error = true;
                errorLine += "Please enter a valid number from the range of 1-365" + Environment.NewLine;
            }
            else if (day > 365)
            {
                error = true;
                errorLine += "Please enter a valid number from the range of 1-365" + Environment.NewLine;
            }



            if (error)
            {
                lblError.Visible = true;
                lblError.Text = errorLine;
            }
            else
            {
                string url = "search.aspx?country=" + country + "&days=" + day;
                Response.Redirect(url);
            }
        }

        public int returnImage(string weatherString)
        {
            int hourNow = System.DateTime.Now.Hour;
            if (weatherString.Contains("Partly Cloudy"))
            {
                if ((hourNow >= 7) && (hourNow < 19))
                {
                    //I1.Attributes.Add("class", "fas fa-cloud-sun");
                    return 1;
                }
                else
                {
                    //I1.Attributes.Add("class", "fas fa-cloud-moon");
                    return 2;
                }
            }
            else if (weatherString.Contains("showers"))
            {
                if (weatherString.Contains("thundery"))
                {
                    //I1.Attributes.Add("class", "fas fa-cloud-showers-heavy");
                    return 3;
                }
                else
                {
                    //I1.Attributes.Add("class", "fas fa-cloud-rain");
                    return 4;
                }

            }
            else
            {
                if ((hourNow >= 7) && (hourNow < 19))
                {
                    //I1.Attributes.Add("class", "fas fa-sun");
                    return 5;
                }
                else
                {
                    //I1.Attributes.Add("class", "fas fa-moon");
                    return 6;
                }
            }

        }

        public void updateWeather()
        {
            int image1;
            int image2;
            int image3;
            int image4; 
            try
            {
                using (WebClient web = new WebClient())
                {

                    int hourNow = System.DateTime.Now.Hour;//gives the hour in int form.

                    string current = string.Format("https://api.data.gov.sg/v1/environment/24-hour-weather-forecast");
                    var currentjson = web.DownloadString(current);
                    JObject currentresult = JObject.Parse(currentjson);
                    JObject ojObject = (JObject)currentresult["items"][0];
                    string currentWeather = ojObject["general"]["forecast"].ToString();
                    /*end of current weather*/

                    string forecast = string.Format("https://api.data.gov.sg/v1/environment/4-day-weather-forecast");
                    var forecastjson = web.DownloadString(forecast);
                    JObject forecastresult = JObject.Parse(forecastjson);
                    JObject forecastObject = (JObject)forecastresult["items"][0];
                    JArray forecastArray = (JArray)forecastObject["forecasts"];
                    /*end of forecasted weather*/

                    lblCondition1.Text = currentWeather;
                    lblCondition2.Text = forecastArray[0]["forecast"].ToString();
                    lblCondition3.Text = forecastArray[1]["forecast"].ToString();
                    lblCondition4.Text = forecastArray[2]["forecast"].ToString();
                    lblCondition5.Text = forecastArray[3]["forecast"].ToString();

                    /*if-else for all days*/

                    if (currentWeather.Contains("Partly Cloudy"))
                    {
                        if ((hourNow >= 7) && (hourNow < 19))
                        {
                            I1.Attributes.Add("class", "fas fa-cloud-sun");
                        }
                        else
                        {
                            I1.Attributes.Add("class", "fas fa-cloud-moon");
                        }
                    }
                    else if (currentWeather.Contains("Showers"))
                    {
                        if (currentWeather.Contains("Thundery"))
                        {
                            I1.Attributes.Add("class", "fas fa-cloud-showers-heavy");
                        }
                        else
                        {
                            I1.Attributes.Add("class", "fas fa-cloud-rain");
                        }

                    }
                    else
                    {
                        if ((hourNow >= 7) && (hourNow < 19))
                        {
                            I1.Attributes.Add("class", "fas fa-sun");
                        }
                        else
                        {
                            I1.Attributes.Add("class", "fas fa-moon");
                        }
                    }

                    image1 = returnImage(forecastArray[0]["forecast"].ToString());
                    image2 = returnImage(forecastArray[1]["forecast"].ToString());
                    image3 = returnImage(forecastArray[2]["forecast"].ToString());
                    image4 = returnImage(forecastArray[3]["forecast"].ToString());
                    //image1
                    if (image1 == 1)
                    {
                        I2.Attributes.Add("class", "fas fa-cloud-sun");
                    }
                    else if (image1 == 2)
                    {
                        I2.Attributes.Add("class", "fas fa-cloud-moon");
                    }
                    else if (image1 == 3)
                    {
                        I2.Attributes.Add("class", "fas fa-cloud-showers-heavy");
                    }
                    else if (image1 == 4)
                    {
                        I2.Attributes.Add("class", "fas fa-cloud-rain");
                    }
                    else if (image1 == 5)
                    {
                        I2.Attributes.Add("class", "fas fa-sun");
                    }
                    else if (image1 == 6)
                    {
                        I2.Attributes.Add("class", "fas fa-moon");
                    }
                    //image2
                    if (image2 == 1)
                    {
                        I3.Attributes.Add("class", "fas fa-cloud-sun");
                    }
                    else if (image2 == 2)
                    {
                        I3.Attributes.Add("class", "fas fa-cloud-moon");
                    }
                    else if (image2 == 3)
                    {
                        I3.Attributes.Add("class", "fas fa-cloud-showers-heavy");
                    }
                    else if (image2 == 4)
                    {
                        I3.Attributes.Add("class", "fas fa-cloud-rain");
                    }
                    else if (image2 == 5)
                    {
                        I3.Attributes.Add("class", "fas fa-sun");
                    }
                    else if (image2 == 6)
                    {
                        I3.Attributes.Add("class", "fas fa-moon");
                    }
                    //image3
                    if (image3 == 1)
                    {
                        I4.Attributes.Add("class", "fas fa-cloud-sun");
                    }
                    else if (image3 == 2)
                    {
                        I4.Attributes.Add("class", "fas fa-cloud-moon");
                    }
                    else if (image3 == 3)
                    {
                        I4.Attributes.Add("class", "fas fa-cloud-showers-heavy");
                    }
                    else if (image3 == 4)
                    {
                        I4.Attributes.Add("class", "fas fa-cloud-rain");
                    }
                    else if (image3 == 5)
                    {
                        I4.Attributes.Add("class", "fas fa-sun");
                    }
                    else if (image3 == 6)
                    {
                        I4.Attributes.Add("class", "fas fa-moon");
                    }
                    //image5
                    if (image4 == 1)
                    {
                        I5.Attributes.Add("class", "fas fa-cloud-sun");
                    }
                    else if (image4 == 2)
                    {
                        I5.Attributes.Add("class", "fas fa-cloud-moon");
                    }
                    else if (image4 == 3)
                    {
                        I5.Attributes.Add("class", "fas fa-cloud-showers-heavy");
                    }
                    else if (image4 == 4)
                    {
                        I5.Attributes.Add("class", "fas fa-cloud-rain");
                    }
                    else if (image4 == 5)
                    {
                        I5.Attributes.Add("class", "fas fa-sun");
                    }
                    else if (image4 == 6)
                    {
                        I5.Attributes.Add("class", "fas fa-moon");
                    }
                }
                DateTime date = DateTime.Now;
                lblDay1.Text = date.ToString("dddd");
                lblDay2.Text = date.AddDays(1).ToString("dddd");
                lblDay3.Text = date.AddDays(2).ToString("dddd");
                lblDay4.Text = date.AddDays(3).ToString("dddd");
                lblDay5.Text = date.AddDays(4).ToString("dddd");

                I1.Style.Value = "fas fa-sun";
            }
            catch (Exception ex)
            {

            }


            
               
    }
    }
}