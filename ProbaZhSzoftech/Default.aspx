<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProbaZhSzoftech._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p class="lead">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </div>

    <div>
        <asp:Image ID="title" runat="server" ImageUrl= "Image/adnijo.jpg"/>

    </div>
    

</asp:Content>
