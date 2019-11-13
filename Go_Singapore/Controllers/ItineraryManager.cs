using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Go_Singapore.Models;

namespace Go_Singapore.Controllers
{
    public class ItineraryManager
    {
        public DataTable GetItinearyList()
        {
            ItineraryEntity ie = new ItineraryEntity();
            return ie.GetItinearyList();
        }

        public DataTable GetItinearyListById(string id)
        {
            ItineraryEntity ie = new ItineraryEntity();
            return ie.GetItinearyListById(id);
        }

        public DataTable GetItineraryDoListById(string id)
        {
            ItineraryEntity ie = new ItineraryEntity();
            return ie.GetItineraryDoListById(id);
        }

        public DataTable GetItinearyListOnly()
        {
            ItineraryEntity ie = new ItineraryEntity();
            return ie.GetItinearyListOnly();
        }

        public int UpdateItinerary(string sql)
        {
            ItineraryEntity ie = new ItineraryEntity();
            return ie.UpdateItinerary(sql);
        }

        public DataTable GetAttractions()
        {
            ItineraryEntity ie = new ItineraryEntity();
            return ie.GetAttractions();
        }
    }
}