using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Go_Singapore.Models
{
    public class ItineraryEntity
    {
        public DataTable GetItinearyList()
        {
            DataTable dt = new DataTable ();
            string sql = "SELECT * FROM Itinerary, ItineraryDoList WHERE Itinerary.Id = ItineraryDoList.itineraryId";
            dt = Database.getTable(sql);
            return dt;
        }

        public DataTable GetItinearyListOnly()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Itinerary";
            dt = Database.getTable(sql);
            return dt;
        }

        public DataTable GetItineraryDoListById(string itineraryId)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM ItineraryDoList, Attractions WHERE Attractions.Id=ItineraryDoList.attractionId AND" +
                " itineraryId=" + itineraryId;
            dt = Database.getTable(sql);
            return dt;
        }

        public DataTable GetItinearyListById(string id)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT A.Id, A.name as attractionname, A.image, A.description, " +
                "I.Id, I.name, I.total_days, " +
                "IDL.itineraryId, IDL.attractionId, IDL.day, IDL.startTime, IDL.endTime " +
                "FROM Itinerary AS I, ItineraryDoList AS IDL, Attractions AS A " +
                "WHERE I.Id = IDL.itineraryId " +
                "AND A.Id=IDL.attractionId";
            sql += " AND I.Id=" + id;
            dt = Database.getTable(sql);
            return dt;
        }

        public DataTable GetAttractions()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Attractions";
            dt = Database.getTable(sql);
            return dt;
        }

       
        public int UpdateItinerary(string sql)
        {
            return Database.ExecuteSQLCommand(sql); //return 0 if failed, return 1 if suggest
        }

    }
}