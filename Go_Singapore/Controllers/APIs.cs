using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Go_Singapore.Controllers
{

    public class CostBreakDown
    {
        public bool status { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string category_id { get; set; }
        public string value_budget { get; set; }
        public string value_midrange { get; set; }
        public string value_luxury { get; set; }
        public string country_code { get; set; }
    }



    public class RateAPI
    {
        public bool success { get; set; }
        public int timestamp { get; set; }
        public string _base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
    }

    public class Rates
    {
        public float AED { get; set; }
        public float AFN { get; set; }
        public float ALL { get; set; }
        public float AMD { get; set; }
        public float ANG { get; set; }
        public float AOA { get; set; }
        public float ARS { get; set; }
        public float AUD { get; set; }
        public float AWG { get; set; }
        public float AZN { get; set; }
        public float BAM { get; set; }
        public float BBD { get; set; }
        public float BDT { get; set; }
        public float BGN { get; set; }
        public float BHD { get; set; }
        public float BIF { get; set; }
        public float BMD { get; set; }
        public float BND { get; set; }
        public float BOB { get; set; }
        public float BRL { get; set; }
        public float BSD { get; set; }
        public float BTC { get; set; }
        public float BTN { get; set; }
        public float BWP { get; set; }
        public float BYN { get; set; }
        public float BYR { get; set; }
        public float BZD { get; set; }
        public float CAD { get; set; }
        public float CDF { get; set; }
        public float CHF { get; set; }
        public float CLF { get; set; }
        public float CLP { get; set; }
        public float CNY { get; set; }
        public float COP { get; set; }
        public float CRC { get; set; }
        public float CUC { get; set; }
        public float CUP { get; set; }
        public float CVE { get; set; }
        public float CZK { get; set; }
        public float DJF { get; set; }
        public float DKK { get; set; }
        public float DOP { get; set; }
        public float DZD { get; set; }
        public float EGP { get; set; }
        public float ERN { get; set; }
        public float ETB { get; set; }
        public int EUR { get; set; }
        public float FJD { get; set; }
        public float FKP { get; set; }
        public float GBP { get; set; }
        public float GEL { get; set; }
        public float GGP { get; set; }
        public float GHS { get; set; }
        public float GIP { get; set; }
        public float GMD { get; set; }
        public float GNF { get; set; }
        public float GTQ { get; set; }
        public float GYD { get; set; }
        public float HKD { get; set; }
        public float HNL { get; set; }
        public float HRK { get; set; }
        public float HTG { get; set; }
        public float HUF { get; set; }
        public float IDR { get; set; }
        public float ILS { get; set; }
        public float IMP { get; set; }
        public float INR { get; set; }
        public float IQD { get; set; }
        public float IRR { get; set; }
        public float ISK { get; set; }
        public float JEP { get; set; }
        public float JMD { get; set; }
        public float JOD { get; set; }
        public float JPY { get; set; }
        public float KES { get; set; }
        public float KGS { get; set; }
        public float KHR { get; set; }
        public float KMF { get; set; }
        public float KPW { get; set; }
        public float KRW { get; set; }
        public float KWD { get; set; }
        public float KYD { get; set; }
        public float KZT { get; set; }
        public float LAK { get; set; }
        public float LBP { get; set; }
        public float LKR { get; set; }
        public float LRD { get; set; }
        public float LSL { get; set; }
        public float LTL { get; set; }
        public float LVL { get; set; }
        public float LYD { get; set; }
        public float MAD { get; set; }
        public float MDL { get; set; }
        public float MGA { get; set; }
        public float MKD { get; set; }
        public float MMK { get; set; }
        public float MNT { get; set; }
        public float MOP { get; set; }
        public float MRO { get; set; }
        public float MUR { get; set; }
        public float MVR { get; set; }
        public float MWK { get; set; }
        public float MXN { get; set; }
        public float MYR { get; set; }
        public float MZN { get; set; }
        public float NAD { get; set; }
        public float NGN { get; set; }
        public float NIO { get; set; }
        public float NOK { get; set; }
        public float NPR { get; set; }
        public float NZD { get; set; }
        public float OMR { get; set; }
        public float PAB { get; set; }
        public float PEN { get; set; }
        public float PGK { get; set; }
        public float PHP { get; set; }
        public float PKR { get; set; }
        public float PLN { get; set; }
        public float PYG { get; set; }
        public float QAR { get; set; }
        public float RON { get; set; }
        public float RSD { get; set; }
        public float RUB { get; set; }
        public float RWF { get; set; }
        public float SAR { get; set; }
        public float SBD { get; set; }
        public float SCR { get; set; }
        public float SDG { get; set; }
        public float SEK { get; set; }
        public float SGD { get; set; }
        public float SHP { get; set; }
        public float SLL { get; set; }
        public float SOS { get; set; }
        public float SRD { get; set; }
        public float STD { get; set; }
        public float SVC { get; set; }
        public float SYP { get; set; }
        public float SZL { get; set; }
        public float THB { get; set; }
        public float TJS { get; set; }
        public float TMT { get; set; }
        public float TND { get; set; }
        public float TOP { get; set; }
        public float TRY { get; set; }
        public float TTD { get; set; }
        public float TWD { get; set; }
        public float TZS { get; set; }
        public float UAH { get; set; }
        public float UGX { get; set; }
        public float USD { get; set; }
        public float UYU { get; set; }
        public float UZS { get; set; }
        public float VEF { get; set; }
        public float VND { get; set; }
        public float VUV { get; set; }
        public float WST { get; set; }
        public float XAF { get; set; }
        public float XAG { get; set; }
        public float XAU { get; set; }
        public float XCD { get; set; }
        public float XDR { get; set; }
        public float XOF { get; set; }
        public float XPF { get; set; }
        public float YER { get; set; }
        public float ZAR { get; set; }
        public float ZMK { get; set; }
        public float ZMW { get; set; }
        public float ZWL { get; set; }
    }


    public class Currency
    {
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Country
    {
        public List<Currency> currencies { get; set; }
        public string name { get; set; }
    }

    public class Rootobject
    {
        public Item[] items { get; set; }
        public Api_Info api_info { get; set; }
    }

    public class Api_Info
    {
        public string status { get; set; }
    }

    public class Item
    {
        public DateTime update_timestamp { get; set; }
        public DateTime timestamp { get; set; }
        public Valid_Period valid_period { get; set; }
        public General general { get; set; }
        public Period[] periods { get; set; }
    }

    public class Valid_Period
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

    public class General
    {
        public string forecast { get; set; }
        public Relative_Humidity relative_humidity { get; set; }
        public Temperature temperature { get; set; }
        public Wind wind { get; set; }
    }

    public class Relative_Humidity
    {
        public int low { get; set; }
        public int high { get; set; }
    }

    public class Temperature
    {
        public int low { get; set; }
        public int high { get; set; }
    }

    public class Wind
    {
        public Speed speed { get; set; }
        public string direction { get; set; }
    }

    public class Speed
    {
        public int low { get; set; }
        public int high { get; set; }
    }

    public class Period
    {
        public Time time { get; set; }
        public Regions regions { get; set; }
    }

    public class Time
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

    public class Regions
    {
        public string west { get; set; }
        public string east { get; set; }
        public string central { get; set; }
        public string south { get; set; }
        public string north { get; set; }
    }

    public class Address
    {
        public List<SearchAddress> results { get; set; }
    }

    public class SearchAddress
    {
        public string building { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }


    public class PublicTransport
    {
        public Requestparameters requestParameters { get; set; }
        public Plan plan { get; set; }
        public Debugoutput debugOutput { get; set; }
        public Elevationmetadata elevationMetadata { get; set; }
    }

    public class Requestparameters
    {
        public string date { get; set; }
        public string preferredRoutes { get; set; }
        public string walkReluctance { get; set; }
        public string fromPlace { get; set; }
        public string transferPenalty { get; set; }
        public string maxWalkDistance { get; set; }
        public string maxTransfers { get; set; }
        public string otherThanPreferredRoutesPenalty { get; set; }
        public string numItineraries { get; set; }
        public string waitAtBeginningFactor { get; set; }
        public string mode { get; set; }
        public string arriveBy { get; set; }
        public string showIntermediateStops { get; set; }
        public string toPlace { get; set; }
        public string time { get; set; }
    }

    public class Plan
    {
        public long date { get; set; }
        public From from { get; set; }
        public To to { get; set; }
        public Itinerary[] itineraries { get; set; }
    }

    public class From
    {
        public string name { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }
        public string orig { get; set; }
        public string vertexType { get; set; }
    }

    public class To
    {
        public string name { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }
        public string orig { get; set; }
        public string vertexType { get; set; }
    }

    public class Itinerary
    {
        public int duration { get; set; }
        public long startTime { get; set; }
        public long endTime { get; set; }
        public int walkTime { get; set; }
        public int transitTime { get; set; }
        public int waitingTime { get; set; }
        public float walkDistance { get; set; }
        public bool walkLimitExceeded { get; set; }
        public int elevationLost { get; set; }
        public int elevationGained { get; set; }
        public int transfers { get; set; }
        public Leg[] legs { get; set; }
        public bool tooSloped { get; set; }
        public string fare { get; set; }
    }

    public class Leg
    {
        public long startTime { get; set; }
        public long endTime { get; set; }
        public int departureDelay { get; set; }
        public int arrivalDelay { get; set; }
        public bool realTime { get; set; }
        public float distance { get; set; }
        public bool pathway { get; set; }
        public string mode { get; set; }
        public string route { get; set; }
        public int agencyTimeZoneOffset { get; set; }
        public bool interlineWithPreviousLeg { get; set; }
        public From1 from { get; set; }
        public To1 to { get; set; }
        public Leggeometry legGeometry { get; set; }
        public bool rentedBike { get; set; }
        public bool transitLeg { get; set; }
        public int duration { get; set; }
        public object[] intermediateStops { get; set; }
        public Step[] steps { get; set; }
        public int numIntermediateStops { get; set; }
        public string agencyName { get; set; }
        public string agencyUrl { get; set; }
        public int routeType { get; set; }
        public string routeId { get; set; }
        public string agencyId { get; set; }
        public string tripId { get; set; }
        public string serviceDate { get; set; }
        public string routeShortName { get; set; }
        public string routeLongName { get; set; }
    }

    public class From1
    {
        public string name { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }
        public long departure { get; set; }
        public string orig { get; set; }
        public string vertexType { get; set; }
        public long arrival { get; set; }
        public string stopId { get; set; }
        public int stopIndex { get; set; }
        public int stopSequence { get; set; }
    }

    public class To1
    {
        public string name { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }
        public long arrival { get; set; }
        public long departure { get; set; }
        public string vertexType { get; set; }
        public string stopId { get; set; }
        public int stopIndex { get; set; }
        public int stopSequence { get; set; }
        public string orig { get; set; }
    }

    public class Leggeometry
    {
        public string points { get; set; }
        public int length { get; set; }
    }

    public class Step
    {
        public float distance { get; set; }
        public string relativeDirection { get; set; }
        public string streetName { get; set; }
        public string absoluteDirection { get; set; }
        public bool stayOn { get; set; }
        public bool area { get; set; }
        public bool bogusName { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }
        public object[] elevation { get; set; }
    }

    public class Debugoutput
    {
        public int precalculationTime { get; set; }
        public int pathCalculationTime { get; set; }
        public int[] pathTimes { get; set; }
        public int renderingTime { get; set; }
        public int totalTime { get; set; }
        public bool timedOut { get; set; }
    }

    public class Elevationmetadata
    {
        public float ellipsoidToGeoidDifference { get; set; }
        public bool geoidElevation { get; set; }
    }


    public class Route
    {
        public string status_message { get; set; }
        public string route_geometry { get; set; }
        public int status { get; set; }
        public List<List<object>> route_instructions { get; set; }
        public List<string> route_name { get; set; }
        public RouteSummary route_summary { get; set; }
        public string viaRoute { get; set; }
        public string subtitle { get; set; }
        public Phyroute phyroute { get; set; }
    }

    public class RouteSummary
    {
        public string start_point { get; set; }
        public string end_point { get; set; }
        public int total_time { get; set; }
        public int total_distance { get; set; }
    }

    public class Phyroute
    {
        public string status_message { get; set; }
        public string route_geometry { get; set; }
        public int status { get; set; }
        public List<List<object>> route_instructions { get; set; }
        public List<string> route_name { get; set; }
        public RouteSummary route_summary { get; set; }
        public string viaRoute { get; set; }
        public string subtitle { get; set; }
    }

    public class Geocodeinfo
    {
        public string BUILDINGNAME { get; set; }
        public string BLOCK { get; set; }
        public string ROAD { get; set; }
        public string POSTALCODE { get; set; }
        public string XCOORD { get; set; }
        public string YCOORD { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }
        public string LONGTITUDE { get; set; }
    }

    public struct Coordinates
    {
        public Coordinates(float lat, float lon, string site)
        {
            latitude = lat;
            longitude = lon;
            siteName = site;
        }
        public float latitude
        {
            get;
            private set;
        }
        public float longitude
        {
            get;
            private set;
        }

        public string siteName
        {
            get;
            private set;
        }
    }





}