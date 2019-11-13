<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="Go_Singapore.Views.about" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    About Us
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topHeader" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="homeContent" runat="server">
    <section class="ftco-section">
    	<div class="container">
    		<div class="row d-md-flex">
	    		<div class="col-md-6 ftco-animate img about-image" style="background-image: url(images/about.jpg);">
	    		</div>
	    		<div class="col-md-6 ftco-animate p-md-5">
		    		<div class="row">
		          <div class="col-md-12 nav-link-wrap mb-5">
		            <div class="nav ftco-animate nav-pills" id="v-pills-tab" role="tablist" aria-orientation="vertical">
		              <a class="nav-link active" id="v-pills-whatwedo-tab" data-toggle="pill" href="#v-pills-whatwedo" role="tab" aria-controls="v-pills-whatwedo" aria-selected="true">What we do</a>

		              <a class="nav-link" id="v-pills-mission-tab" data-toggle="pill" href="#v-pills-mission" role="tab" aria-controls="v-pills-mission" aria-selected="false">Our mission</a>

		              <a class="nav-link" id="v-pills-goal-tab" data-toggle="pill" href="#v-pills-goal" role="tab" aria-controls="v-pills-goal" aria-selected="false">Our goal</a>
		            </div>
		          </div>
		          <div class="col-md-12 d-flex align-items-center">
		            
		            <div class="tab-content ftco-animate" id="v-pills-tabContent">

		              <div class="tab-pane fade show active" id="v-pills-whatwedo" role="tabpanel" aria-labelledby="v-pills-whatwedo-tab">
		              	<div>
			                <h2 class="mb-4">Provide Attraction Information about Singapore</h2>
			              	<p>We try to help people create their dream itinery because we want people to have a great time in Singapore.We try to help people create their dream itinery because we want people to have a great time in Singapore.</p>
			                <p>Singapore is a very fun place to hang out because there are many things to do! We hope that you enjoy your time here! </p>
				            </div>
		              </div>

		              <div class="tab-pane fade" id="v-pills-mission" role="tabpanel" aria-labelledby="v-pills-mission-tab">
		                <div>
			                <h2 class="mb-4">Help you have fun in Singapore</h2>
			              	<p>We want you to have an easy time planning your itinery in Singapore, as well as access all the useful tools, all compiled into this application! We want you to have an easy time planning your itinery in Singapore, as well as access all the useful tools, all compiled into this application!</p>
			                <p>Singapore is a very fun place to hang out because there are many things to do! We hope that you enjoy your time here!</p>
				            </div>
		              </div>

		              <div class="tab-pane fade" id="v-pills-goal" role="tabpanel" aria-labelledby="v-pills-goal-tab">
		                <div>
			                <h2 class="mb-4">Let Singapore be a travel destination!</h2>
			              	<p>There are hidden gems within Singapore that we want you to find out about! There are hidden gems within Singapore that we want you to find out about! There are hidden gems within Singapore that we want you to find out about!</p>
			                <p>Singapore is a very fun place to hang out because there are many things to do! We hope that you enjoy your time here!</p>
				            </div>
		              </div>
		            </div>
		          </div>
		        </div>
		      </div>
		    </div>
    	</div>
    </section>

        <section class="ftco-section bg-light">
    	<div class="container">
    		<div class="row justify-content-start mb-5 pb-3">
          <div class="col-md-7 heading-section ftco-animate">
          	<span class="subheading">FAQS</span>
            <h2 class="mb-4"><strong>Frequently</strong> Asked Questions</h2>
          </div>
        </div>  
    		<div class="row">
    			<div class="col-md-12 ftco-animate">
    				<div id="accordion">
    					<div class="row">
    						<div class="col-md-6">
    							<div class="card">
						        <div class="card-header">
										  <a class="card-link" data-toggle="collapse"  href="#menuone" aria-expanded="true" aria-controls="menuone"> How accurate is the data provided?<span class="collapsed"><i class="icon-plus-circle"></i></span><span class="expanded"><i class="icon-minus-circle"></i></span></a>
						        </div>
						        <div id="menuone" class="collapse show">
						          <div class="card-body">
												<p>We use data from APIs that were created by accurate sources.We use data from APIs that were created by accurate sources.We use data from APIs that were created by accurate sources.We use data from APIs that were created by accurate sources.We use data from APIs that were created by accurate sources.</p>
						          </div>
						        </div>
						      </div>

						      <div class="card">
						        <div class="card-header">
										  <a class="card-link" data-toggle="collapse"  href="#menutwo" aria-expanded="false" aria-controls="menutwo"> Why is Singapore a great travel destination? <span class="collapsed"><i class="icon-plus-circle"></i></span><span class="expanded"><i class="icon-minus-circle"></i></span></a>
						        </div>
						        <div id="menutwo" class="collapse">
						          <div class="card-body">
												<p>Because Singapore has lots of place to hang out! Because Singapore has lots of place to hang out! Because Singapore has lots of place to hang out! Because Singapore has lots of place to hang out! Because Singapore has lots of place to hang out! Because Singapore has lots of place to hang out!</p>
						          </div>
						        </div>
						      </div>

						      <div class="card">
						        <div class="card-header">
										  <a class="card-link" data-toggle="collapse"  href="#menu3" aria-expanded="false" aria-controls="menu3"> How expensive is it to have a holiday in Singapore? <span class="collapsed"><i class="icon-plus-circle"></i></span><span class="expanded"><i class="icon-minus-circle"></i></span></a>
						        </div>
						        <div id="menu3" class="collapse">
						          <div class="card-body">
												<p>Not very expensive. In fact, it is very affordable! Not very expensive. In fact, it is very affordable! Not very expensive. In fact, it is very affordable! Not very expensive. In fact, it is very affordable! Not very expensive. In fact, it is very affordable! Not very expensive. In fact, it is very affordable!</p>
						          </div>
						        </div>
						      </div>
    						</div>

    						<div class="col-md-6">
    							<div class="card">
						        <div class="card-header">
										  <a class="card-link" data-toggle="collapse"  href="#menu4" aria-expanded="false" aria-controls="menu4"> What should I do in Singapore? <span class="collapsed"><i class="icon-plus-circle"></i></span><span class="expanded"><i class="icon-minus-circle"></i></span></a>
						        </div>
						        <div id="menu4" class="collapse">
						          <div class="card-body">
												<p>You can check out our application and browse all the activities that Singapore has to offer! You can check out our application and browse all the activities that Singapore has to offer! You can check out our application and browse all the activities that Singapore has to offer! </p>
						          </div>
						        </div>
						      </div>

						      <div class="card">
						        <div class="card-header">
										  <a class="card-link" data-toggle="collapse"  href="#menu5" aria-expanded="false" aria-controls="menu5"> Is it difficult to travel in Singapore? <span class="collapsed"><i class="icon-plus-circle"></i></span><span class="expanded"><i class="icon-minus-circle"></i></span></a>
						        </div>
						        <div id="menu5" class="collapse">
						          <div class="card-body">
												<p>No, Singapore has an efficient public transport system. You can plan routes using our map app too! No, Singapore has an efficient public transport system. You can plan routes using our map app too! No, Singapore has an efficient public transport system. You can plan routes using our map app too! No, Singapore has an efficient public transport system. You can plan routes using our map app too!</p>
						          </div>
						        </div>
						      </div>

						      <div class="card">
						        <div class="card-header">
										  <a class="card-link" data-toggle="collapse"  href="#menu6" aria-expanded="false" aria-controls="menu6"> How is the weather in Singapore right now? <span class="collapsed"><i class="icon-plus-circle"></i></span><span class="expanded"><i class="icon-minus-circle"></i></span></a>
						        </div>
						        <div id="menu6" class="collapse">
						          <div class="card-body">
												<p>You can check out our weather forecast app to tell how is it like in Singapore! You can check out our weather forecast app to tell how is it like in Singapore! You can check out our weather forecast app to tell how is it like in Singapore! You can check out our weather forecast app to tell how is it like in Singapore!</p>
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
