<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Go_Singapore.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topHeader" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="homeContent" runat="server">
    <asp:TextBox ID="TextBox15" runat="server" Text="System Output" ReadOnly="True"></asp:TextBox>
    <br/>
    Attractions
    <br/>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br/>
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Name"></asp:TextBox>
    <asp:FileUpload ID="FileUpload1" runat="server" placeholder="Image File"/>
    <asp:Button runat="server" Text="Update" id="Button1" OnClick="Button1_Click" />
    <br/>
    <br/>
    <asp:TextBox ID="TextBox3" runat="server" placeholder="Description" CausesValidation="True" Width="1000"></asp:TextBox>
    <br/>
    <br/>
    <asp:TextBox ID="TextBox11" runat="server" placeholder="AttractionID"></asp:TextBox>
    <asp:Button runat="server" Text="Delete" id="Button4" OnClick="Button4_Click" />
    <br/>
    <br/>
    Itinerary Items
    <br/>
    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
    <br/>
    <asp:TextBox ID="TextBox4" runat="server" placeholder="Name"></asp:TextBox>
    <asp:TextBox ID="TextBox5" runat="server" placeholder="Total Days"></asp:TextBox>
    <asp:Button runat="server" Text="Update" id="Button2" OnClick="Button2_Click" />
    <br/>
    <br/>
    <asp:TextBox ID="TextBox12" runat="server" placeholder="ItineraryID"></asp:TextBox>
    <asp:Button runat="server" Text="Delete" id="Button5" OnClick="Button5_Click" />
    <br/>
    <br/>
    Itinerary Lists
    <br/>
    <asp:GridView ID="GridView3" runat="server"></asp:GridView>
    <br/>
    <asp:TextBox ID="TextBox6" runat="server" placeholder="itineraryID"></asp:TextBox>
    <asp:TextBox ID="TextBox7" runat="server" placeholder="attractionID"></asp:TextBox>
    <asp:TextBox ID="TextBox8" runat="server" placeholder="day"></asp:TextBox>
    <asp:TextBox ID="TextBox9" runat="server" placeholder="startTime" MaxLength="5"></asp:TextBox>
    <asp:TextBox ID="TextBox10" runat="server" placeholder="endTime" MaxLength="5"></asp:TextBox>
    <asp:Button runat="server" Text="Update" id="Button3" OnClick="Button3_Click" />
    <br/>
    <br/>
    <asp:TextBox ID="TextBox13" runat="server" placeholder="itineraryID"></asp:TextBox>
    <asp:TextBox ID="TextBox14" runat="server" placeholder="attractionID"></asp:TextBox>
    <asp:Button runat="server" Text="Delete" id="Button6" OnClick="Button6_Click" />
</asp:Content>
