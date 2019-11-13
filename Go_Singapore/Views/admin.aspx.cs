using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Go_Singapore.Controllers;

namespace Go_Singapore
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("index.aspx");
            }

            AdminDataManager ADMgr = new AdminDataManager();

            DataTable dt = ADMgr.getAttractions();
            GridView1.DataSource = dt;
            GridView1.DataBind();

            DataTable dt2 = ADMgr.getItinerary();
            GridView2.DataSource = dt2;
            GridView2.DataBind();

            DataTable dt3 = ADMgr.getItineraryDoList();
            GridView3.DataSource = dt3;
            GridView3.DataBind();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            AdminDataManager ADMgr = new AdminDataManager();
            bool doit = true;
            string name = "?";
            string image = "?";
            string description = "?";
            try
            {
                name = this.TextBox1.Text.ToString();
                image = this.FileUpload1.FileName.ToString();
                description = this.TextBox3.Text.ToString();
                if (name == "" || image == "" || description == "")
                {
                    doit = false;
                }
            }
            catch (Exception lol)
            {
                doit = false;
            }
            if (doit)
            {
                string path = "~/Views/images/attractions";
                FileUpload1.SaveAs(Server.MapPath(path) + "/" + image);
                ADMgr.createAttraction(name, image, description);
                DataTable dt = ADMgr.getAttractions();
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                this.TextBox15.Text = "Error Encountered. Please try again.";
            }
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            AdminDataManager ADMgr = new AdminDataManager();
            string name = "?";
            int total_days = 0;
            bool doit = true;
            try
            {
                name = this.TextBox4.Text.ToString();
                total_days = Int32.Parse(this.TextBox5.Text);
                if (name == "" || total_days < 1)
                {
                    doit = false;
                }
            }
            catch (Exception)
            {
                doit = false;
            }
            if (doit)
            {
                ADMgr.createItinerary(name, total_days);
                DataTable dt = ADMgr.getItinerary();
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
            else
            {
                this.TextBox15.Text = "Error Encountered. Please try again.";
            }
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            AdminDataManager ADMgr = new AdminDataManager();
            int itineraryID = -1;
            int attractionID = -1;
            int day = -1;
            string startTime = "None";
            string endTime = "None";
            bool doit = true;
            try
            {
                itineraryID = Int32.Parse(this.TextBox6.Text);
                attractionID = Int32.Parse(this.TextBox7.Text);
                day = Int32.Parse(this.TextBox8.Text);
                DateTime d1 = Convert.ToDateTime(this.TextBox9.Text);
                startTime = d1.ToString("HH:mm");
                DateTime d2 = Convert.ToDateTime(this.TextBox10.Text);
                endTime = d2.ToString("HH:mm");
                if (d1 > d2)
                {
                    throw new System.ArgumentException("Times invalid.", "original");
                }
                if (itineraryID <= 0 || attractionID <= 0 || day <= 0)
                {
                    doit = false;
                }
            }
            catch (Exception)
            {
                doit = false;
            }
            if (doit)
            {
                ADMgr.createItineraryDoList(itineraryID, attractionID, day, startTime, endTime);
                DataTable dt = ADMgr.getItineraryDoList();
                GridView3.DataSource = dt;
                GridView3.DataBind();
            }
            else
            {
                this.TextBox15.Text = "Error Encountered. Please try again.";
            }
        }

        public void Button4_Click(object sender, EventArgs e)
        {
            AdminDataManager ADMgr = new AdminDataManager();
            int attractionID = -1;
            int returnresult = -1;
            bool doit = true;
            try
            {
                attractionID = Int32.Parse(this.TextBox11.Text);
                if (attractionID < 1)
                {
                    doit = false;
                }
            }
            catch (Exception)
            {
                doit = false;
            }
            if (doit)
            {
                returnresult = ADMgr.deleteAttraction(attractionID);
                DataTable dt = ADMgr.getAttractions();
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (returnresult < 1)
                {
                    this.TextBox15.Text = "Failure to delete. Please try again.";
                }
                else
                {
                    this.TextBox15.Text = "Deleted successfully.";
                }
            }
            else
            {
                this.TextBox15.Text = "Error Encountered. Please try again.";
            }
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            AdminDataManager ADMgr = new AdminDataManager();
            int itineraryID = -1;
            bool doit = true;
            int returnresult = -1;
            try
            {
                itineraryID = Int32.Parse(this.TextBox12.Text);
                if (itineraryID < 1)
                {
                    doit = false;
                }
            }
            catch (Exception)
            {
                doit = false;
            }
            if (doit)
            {
                returnresult = ADMgr.deleteItinerary(itineraryID);
                DataTable dt = ADMgr.getItinerary();
                GridView2.DataSource = dt;
                GridView2.DataBind();
                if (returnresult < 1)
                {
                    this.TextBox15.Text = "Failure to delete. Please try again.";
                }
                else
                {
                    this.TextBox15.Text = "Deleted successfully.";
                }
            }
            else
            {
                this.TextBox15.Text = "Error Encountered. Please try again.";
            }

        }

        public void Button6_Click(object sender, EventArgs e)
        {
            AdminDataManager ADMgr = new AdminDataManager();
            int itineraryID = -1;
            int attractionID = -1;
            bool doit = true;
            int returnresult = -1;
            try
            {
                itineraryID = Int32.Parse(this.TextBox13.Text);
                attractionID = Int32.Parse(this.TextBox14.Text);
                if (itineraryID < 1 || attractionID < 1)
                {
                    doit = false;
                }
            }
            catch (Exception)
            {
                doit = false;
            }
            if (doit)
            {
                returnresult = ADMgr.deleteItineraryDoList(itineraryID, attractionID);
                DataTable dt = ADMgr.getItineraryDoList();
                GridView3.DataSource = dt;
                GridView3.DataBind();
                if (returnresult < 1)
                {
                    this.TextBox15.Text = "Failure to delete. Please try again.";
                }
                else
                {
                    this.TextBox15.Text = "Deleted successfully.";
                }
            }

        }
    }
}