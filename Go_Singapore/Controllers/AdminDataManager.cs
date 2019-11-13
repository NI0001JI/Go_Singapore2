using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Go_Singapore.Models;

namespace Go_Singapore.Controllers
{
    public class AdminDataManager
    {
        // GET: AdminDataManager
        public DataTable getAttractions()
        {
            string query = "SELECT * FROM Attractions";
            DataTable dt = new DataTable();
            dt = Database.getTable(query);
            return dt;
        }

        public DataTable getItinerary()
        {
            string query = "SELECT * FROM Itinerary";
            DataTable dt = new DataTable();
            dt = Database.getTable(query);
            return dt;
        }

        public DataTable getItineraryDoList()
        {
            string query = "SELECT * FROM ItineraryDoList";
            DataTable dt = new DataTable();
            dt = Database.getTable(query);
            return dt;
        }

        public void createAttraction(string name, string image, string description)
        {   
            string command = "INSERT INTO Attractions(name, image, description) VALUES ('"+ name + "','" + image + "','" + description + "')";
            Database.ExecuteSQLCommand(command);
            return;
        }

        public void createItinerary(string name, int total_days)
        {
            string query = "SELECT MAX(Id) AS maxi FROM itinerary";
            DataTable dt = Database.getTable(query);
            DataRow dtr = dt.Rows[0];
            int id = dtr.Field<int>("maxi")+1;
            string command = "INSERT INTO itinerary(Id, name, total_days) VALUES ('"+id+"','"+ name + "','" + total_days + "')";
            Database.ExecuteSQLCommand(command);
            return;
        }

        public void createItineraryDoList(int itineraryId, int attractionId, int day, string startTime, string endTime)
        {
            string command = "INSERT INTO ItineraryDoList(itineraryId, attractionId, day, startTime, endTime) VALUES ('" + itineraryId + "','" + attractionId + "','" + day + "','" + startTime + "','" + endTime + "')";
            Database.ExecuteSQLCommand(command);
            return;
        }

        public int deleteAttraction(int attractionId)
        {
            string query = "DELETE FROM Attractions WHERE Id = '" + attractionId + "'";
            int value = Database.ExecuteSQLCommand(query);
            return value;
        }

        public int deleteItinerary(int itineraryId)
        {
            string query = "DELETE FROM Itinerary WHERE Id = '" +itineraryId + "'";
            int value = Database.ExecuteSQLCommand(query);
            return value;
        }

        public int deleteItineraryDoList(int itineraryId, int attractionId)
        {
            string query = "DELETE FROM ItineraryDoList WHERE itineraryId = '" + itineraryId + "' AND attractionId = '"+attractionId+"'";
            int value = Database.ExecuteSQLCommand(query);
            return value;
        }
    }
}