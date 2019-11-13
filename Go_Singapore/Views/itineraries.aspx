<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="itineraries.aspx.cs" Inherits="Go_Singapore.Itineraries" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Go_Singapore.Controllers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Itineraries
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topHeader" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="homeContent" runat="server">
    <section class="ftco-section bg-light">
        <div class="container">
            <div class="row justify-content-start mb-5 pb-3">
                <div class="col-md-7 heading-section ftco-animate">
                    <span class="subheading">Itineraries</span>
                    <h2><strong>Top</strong> Itineraries</h2>
                </div>
            </div>
            </div>
            <div class="row d-flex">
                <%
                    ItineraryManager im = new ItineraryManager();
                    DataTable dt = im.GetItinearyListOnly();


                    foreach (DataRow row in dt.Rows)
                    {
                        string image = "";
                        DataTable dt2 = im.GetItineraryDoListById(row["Id"].ToString());
                        if (dt2 != null)
                        {
                            image = dt2.Rows[0]["image"].ToString();
                        }
                        //url(images/attractions/" + row["image"].ToString() + ");'
                        Response.Write("<div class='col-md-3 d-flex ftco-animate'><div class='blog-entry align-self-stretch'>" +
                        "<a href='itinerary.aspx?id=" + row["Id"] + "' class='block-20' style='background-image: url(images/attractions/" +
                        image + ");'>" +
                        "</a><div class='text p-4 d-block'>" +
                          "<span class='tag'>" + row["total_days"] + " Day Itinerary</span><h3 class='heading mt-3'>" +
                            "<a href='itinerary.aspx?id=" + row["Id"] + "'>" + row["name"] + "</a></h3></div></div></div>");
                    }

                %>
            </div>
        </div>
    </section>
</asp:Content>
