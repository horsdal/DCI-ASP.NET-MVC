<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>My silly little bank</h2>
    <p>
         <a href="../TransferMoney/" title="">Transfer money</a><br />
         <a href="../AccountOverview/">Overview of accounts</a>
    </p>
</asp:Content>
