<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Go_Singapore.Views.index1" %>
<%-- Add content controls here --%>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Go_Singapore.Controllers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Explore<br /> Singapore Today
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topHeader" runat="server">
    <div class="block-17 my-4">
              <div class="d-block d-flex">
                <div class="fields d-block d-flex">
                  <div class="select-wrap one-third">
                    <div class="icon"><span class="ion-ios-arrow-down"></span></div>
                      <asp:DropDownList ID="DDLCurrency" CssClass="form-control" runat="server" ></asp:DropDownList>
                  </div>
				 <div class="select-wrap one-third">
                     <asp:TextBox ID="txtDays" runat="server" CssClass="form-control" placeholder="Total Days in Singapore" TextMode="Number"></asp:TextBox>
                  </div>
				
                </div>
                  <asp:Button ID="btnSearch" CssClass="search-submit btn btn-primary" runat="server" Text="Search" OnClick="btnSearch_Click" />
                		
              </div>
            </div>
             <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="False"></asp:Label><br />
			
			<br><br>
    
</asp:Content>

   <asp:Content ID="Content3" ContentPlaceHolderID="homeContent" runat="server">
 <div class="container">
       <div class="col-md-7 heading-section ftco-animate">
          	<span class="subheading">Weather</span>
            <h2 class="mb-4"><strong>Weather</strong> Forecast</h2>
              
          </div>
     <style>
         .weatherBox{
             height:230px;border:1px solid black;
         }
         .weatherBox i{
             font-size:120px;
         }
         .weatherBox img{
             height:140px;
             width:140px;
         }
         .weatherBox .boxTitle
         {
             font-size:15px;
             font-weight:bold;
         }
     </style>
       <div class="row ftco-animate align-content-center text-center">
           <div class="weatherBox col-lg-2">
               <asp:Label ID="lblDay1" CssClass="boxTitle" runat="server" Text="Day1"></asp:Label><br />
               <i ID="I1" class="" runat="server"></i><br />
               <asp:Label ID="lblCondition1" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-lg-2">
               <asp:Label ID="lblDay2" CssClass="boxTitle" runat="server" Text="Day1"></asp:Label><br />
               <i ID="I2" class="" runat="server"></i><br />
               <asp:Label ID="lblCondition2" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-lg-2">
               <asp:Label ID="lblDay3" CssClass="boxTitle" runat="server" Text="Day1"></asp:Label><br />
               <i ID="I3" class="" runat="server"></i><br />
               <asp:Label ID="lblCondition3" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-lg-2">
               <asp:Label ID="lblDay4" CssClass="boxTitle" runat="server" Text="Day1"></asp:Label><br />
               <i ID="I4" class="" runat="server"></i><br />
               <asp:Label ID="lblCondition4" runat="server" Text="Condition1"></asp:Label>
           </div>
           <div class="weatherBox col-lg-2">
               <asp:Label ID="lblDay5" CssClass="boxTitle" runat="server" Text="Day1"></asp:Label><br />
               <i ID="I5" class="" runat="server"></i><br />
               <asp:Label ID="lblCondition5" runat="server" Text="Condition1"></asp:Label>
           </div>


       </div>
     </div>


    
    <section class="ftco-section ftco-destination">
    	<div class="container">
    		<div class="row justify-content-start mb-5 pb-3">
          <div class="col-md-7 heading-section ftco-animate">
          	<span class="subheading">Featured</span>
            <h2 class="mb-4"><strong>Featured</strong> Destination</h2>
              
          </div>
        </div>
    		<div class="row">
    			<div class="col-md-12">
    				<div class="destination-slider owl-carousel ftco-animate">
                        <%
                            ItineraryManager sm = new ItineraryManager();
                            DataTable dt = sm.GetAttractions();
                            foreach(DataRow row in dt.Rows)
                            {
                                Response.Write("<div class='item'><div class='destination'>");
                                Response.Write("<div class='img d-flex justify-content-center align-items-center' style='background-image: url(images/attractions/" + row["image"].ToString() + ");'></div>");
                                Response.Write("<div class='text p-3'><h3>" + row["name"].ToString() + "</h3></div></div></div>");
                            }

                            %>

    					
    				</div>
    			</div>
    		</div>
    	</div>
    </section>




    <section class="ftco-section testimony-section bg-light">
      <div class="container">
        <div class="row justify-content-start">
          <div class="col-md-5 heading-section ftco-animate">
          	<span class="subheading">Best Explore Singapore Website</span>
            <h2 class="mb-4 pb-3"><strong>Why</strong> Choose Us?</h2>
            <p>We have a huge list of to do list to ensure you fully enjoy your trip.</p>
            <p>We do a breakdown how much to expect here!</p>
           
          </div>
		<div class="col-md-1"></div>

          <div class="col-md-6 heading-section ftco-animate">
          	<span class="subheading">Testimony</span>
            <h2 class="mb-4 pb-3"><strong>Our</strong> Guests Says</h2>
          	<div class="row ftco-animate">
		          <div class="col-md-12">
		            <div class="carousel-testimony owl-carousel">
		              <div class="item">
		                <div class="testimony-wrap d-flex">
		                  <div class="user-img mb-5" style="background-image: url(images/person_1.jpg)">
		                    <span class="quote d-flex align-items-center justify-content-center">
		                      <i class="icon-quote-left"></i>
		                    </span>
		                  </div>
		                  <div class="text ml-md-4">
		                    <p class="mb-5">Best Sinapore Listing site ever! I love it!!! </p>
		                    <p class="name">Wyman Lee</p>
		                    <span class="position">Guest from Singapore</span>
		                  </div>
		                </div>
		              </div>
		              <div class="item">
		                <div class="testimony-wrap d-flex">
		                  <div class="user-img mb-5" style="background-image: url(images/person_2.jpg)">
		                    <span class="quote d-flex align-items-center justify-content-center">
		                      <i class="icon-quote-left"></i>
		                    </span>
		                  </div>
		                  <div class="text ml-md-4">
		                    <p class="mb-5">I used the site to search fo attractions to do before I came. Not disappointed.</p>
		                    <p class="name">Spongebob Square Pants</p>
		                    <span class="position">Guest from Bikini Bottoms</span>
		                  </div>
		                </div>
		              </div>
		              <div class="item">
		                <div class="testimony-wrap d-flex">
		                  <div class="user-img mb-5" style="background-image: url(images/person_3.jpg)">
		                    <span class="quote d-flex align-items-center justify-content-center">
		                      <i class="icon-quote-left"></i>
		                    </span>
		                  </div>
		                  <div class="text ml-md-4">
		                    <p class="mb-5">I love this site!</p>
		                    <p class="name">Bob the Builder</p>
		                    <span class="position">Guest from Building Town</span>
		                  </div>
		                </div>
		              </div>
		            </div>
		          </div>
		        </div>
          </div>
        </div>
      </div>
    </section>

   

  
		


</asp:Content>

