<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
Transfered <%= ViewData["Amount"] %> from <%= ViewData["Source"] %> to <%= ViewData["Destination"] %>
<p>
 <a href="../TransferMoney/" title="">Do another transfer...</a><br /> 
 <a href="../AccountOverview">Overview of accounts</a>
</p>
</asp:Content>
