<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>My silly little bank</h2>
    <p>
         <%: Html.ActionLink("Transfer money", controllerName:"TransferMoney", actionName:"SelectSource" )%><br />
         <%: Html.ActionLink("Overview of accounts", controllerName:"AccountOverview", actionName:"Index") %>
    </p>
</asp:Content>
