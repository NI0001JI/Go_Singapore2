<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="itinerary.aspx.cs" Inherits="Go_Singapore.Views.Itinerary" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Go_Singapore.Controllers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Itinerary
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topHeader" runat="server">
    <link href="css/leaflet-routing-machine.css" rel="stylesheet" />
    <link href="css/leaflet.css" rel="stylesheet" />

    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="https://cdn.onemap.sg/leaflet/onemap-leaflet.js"></script>
    <script src="js/leaflet.js"></script>
    <script src="js/leaflet-routing-machine.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="homeContent" runat="server">
    <asp:ScriptManager runat="server">
            <Scripts>
            </Scripts>
        </asp:ScriptManager>
    <%
        string id = "";
       // id = "1";
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("itineraries.aspx");
        }
        else
        {
            id = Request.QueryString["id"].ToString();
        }

        ItineraryManager im = new ItineraryManager();
        DataTable dt = im.GetItinearyListById(id);
        string name = "";
        string days = "";
        if (dt != null)
        {
            name = dt.Rows[0]["name"].ToString();
            days = dt.Rows[0]["total_days"].ToString();
        }

        lblTitle2.Text = name;
        Label1.Text = days + " days itinerary in Singapore";


        %>
   
    <h1>
        <asp:Label ID="lblTitle2" runat="server" Text="Label"></asp:Label></h1>
    <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="Larger"></asp:Label>
    <br />
    <hr />
    <br />
    <br />


    <style>
        p{
            font-size:13px;
        }
        .planbox img{
            height:250px;
            width:400px;
        }
        .planbox .title
        {
            font-weight:bold;
            font-size:20px;
        }

    </style>


    <%

        List<string> locations = new List<string>();
        
        
        if (dt != null)
            foreach (DataRow row in dt.Rows)
            {
                locations.Add(row["attractionname"].ToString());
                Response.Write("<div class='container planbox'><div class='row'><div class='col-5'>" +
                    "<img src='images/attractions/" + row["image"].ToString() + "'></div><div class='col-7'>" +
          "<div class='title'>" + row["startTime"] + " - " + row["endTime"] + ": " + row["attractionname"] + "</div><br/>"
          + row["description"]
          + "</div></div></div><br/>");
            }

        APIManager ap = new APIManager();
        string loc = ap.getTravelDestination(locations);


        %>
     <asp:HiddenField ID="HiddenField1" runat="server" />
    <%
        Response.Write(HiddenField1.Value);%>

        <div id='mapdiv' style='height: 800px;'></div>

    
<script>
    //co-ordinates from cs
    var waypoint = [];
    var lat;
    var lon;
        L.Icon.Default.imagePath = "images/";
        var center = L.bounds([1.56073, 104.11475], [1.16, 103.502]).getCenter();
        var map = L.map('mapdiv').setView([center.x, center.y], 12);

        var basemap = L.tileLayer('https://maps-{s}.onemap.sg/v3/Default/{z}/{x}/{y}.png', {
            detectRetina: true,
            maxZoom: 18,
            minZoom: 11
        });

        map.setMaxBounds([[1.56073, 104.1147], [1.16, 103.502]]);

        basemap.addTo(map);

        function getLocation() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(showPosition);
                
            }
        }

        //show current position

    function showPosition(position) {
        // marker = new L.Marker([position.coords.latitude, position.coords.longitude], { bounceOnAdd: false }).addTo(map);
        marker = new L.Marker([1.3466028348212702, 103.681355887293], { bounceOnAdd: false }).addTo(map);
        marker.bindPopup("<b>You are here</b>").openPopup();
        var popup = L.popup()
            .setLatLng([position.coords.latitude, position.coords.longitude])
            .setContent('You are here!')
            .openOn(map);
        window.lat = position.coords.latitude;
        window.lon = position.coords.longitude;
        console.log(position.coords.latitude + "+" + position.coords.longitude);
    }
  

   // waypoint.push([lat, lon]);
  //  alert(lat + 'and' + lon);
    waypoint.push([1.3466028348212702, 103.681355887293]);
    
    //show start and end markers
    $(document).ready(function () {
        getLocation();
        plotMarkers();
    });

    var value = '<%=loc%>';
    value = JSON.parse(value);
    var i;
        
        for (i = 0; i < value.length; i++) {
            waypoint.push([value[i].latitude, value[i].longitude]);
        }

        function plotMarkers() {
            var i;
            var count = 1;
           
            for (i = 0; i < value.length; i++) {

                marker = new L.Marker([value[i].latitude, value[i].longitude], { bounceOnAdd: false }).addTo(map);

                    marker.bindPopup("<b>Location " + count + ": " + value[i].siteName + "</b>").openPopup();
                    count++;
       
                   
            }
        
    }

        // create a purple polyline from an array of LatLng points
        var latlngs = waypoint;

    var polyline = L.polyline(latlngs, { color: 'purple' });

            L.Routing.control({
                waypoints: waypoint
            }).addTo(map);


        // zoom the map to the polyline
        map.fitBounds(polyline.getBounds());

    </script>
</asp:Content>
