<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
Transfered <%= ViewData["Amount"] %> from <%= ViewData["Source"] %> to <%= ViewData["Destination"] %>
<p>
<%: Html.ActionLink("Do another transfer...", controllerName:"TransferMoney", actionName:"SelectSource" )%><br />
<%: Html.ActionLink("Overview of accounts", controllerName:"AccountOverview", actionName:"Index") %>
</p>
</asp:Content>
