using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
  /*  public class stations
    {
        string id { get; }
        string device_id { get; }
        string name { get; }

    }
    public class location
    {
        double latitude { get; }
        double longitude { get;  }

    }

    public class items
    {
        string timestamp{get;}
    }

    public class readings
    {
        string station_id { get; }
        double value { get;  }

    }*/

    class Program
    {
        static void GetTemperature()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.data.gov.sg/v1/environment/air-temperature");
                var json = web.DownloadString(url);
                JObject result = JObject.Parse(json);
                //      Console.WriteLine(result);
                JObject ojObject = (JObject)result["metadata"];
                JArray array = (JArray)ojObject["stations"];
           //     string id = array[0].ToString();
           //     Console.WriteLine(id);
                string[] names = new string[array.Count];//top list


                JObject itemArray = (JObject)result["items"][0];
                JArray readingsArray = (JArray)itemArray["readings"];

                Console.WriteLine(readingsArray.Count+" "+array.Count);
                string[] temperature = new string[readingsArray.Count];


                for (int i = 0; i < array.Count; i++)//array of namess from metadata(contains info on stations)
                {
                    names[i] = array[i]["name"].ToString();
                    Console.WriteLine((i+1)+". "+names[i]);//only to display

                }

                for (int j = 0; j < readingsArray.Count; j++)//array of namess from metadata(contains info on stations)
                {
                    Console.WriteLine(temperature[j]);//testing
                    temperature[j] = readingsArray[j]["value"].ToString();

                }
                int userOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The temperature at " + names[userOption] + " is " + temperature[userOption]);
                
            }


            
        }

        static void GetRainfall()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.data.gov.sg/v1/environment/rainfall");
                var json = web.DownloadString(url);
                JObject result = JObject.Parse(json);
                //      Console.WriteLine(result);
                JObject ojObject = (JObject)result["metadata"];
                JArray array = (JArray)ojObject["stations"];
                //     string id = array[0].ToString();
                //     Console.WriteLine(id);
                string[] names = new string[array.Count];//top list


                JObject itemArray = (JObject)result["items"][0];
                JArray readingsArray = (JArray)itemArray["readings"];

                Console.WriteLine(readingsArray.Count + " " + array.Count);
                string[] temperature = new string[readingsArray.Count];


                for (int i = 0; i < array.Count; i++)//array of namess from metadata(contains info on stations)
                {
                    names[i] = array[i]["name"].ToString();
                    Console.WriteLine((i + 1) + ". " + names[i]);//only to display

                }

                for (int j = 0; j < readingsArray.Count; j++)//array of namess from metadata(contains info on stations)
                {
                    Console.WriteLine(temperature[j]);//testing
                    temperature[j] = readingsArray[j]["value"].ToString();

                }
                int userOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The temperature at " + names[userOption] + " is " + temperature[userOption]);

            }



        }
        static void userOptions()
        {
            //Console.WriteLine("Please select the place where you want to check weather conditions.");
            
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the place where you want to check weather conditions.");

            GetTemperature();

        }
    }
}
