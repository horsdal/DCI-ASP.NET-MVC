<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Site.Master" %>
<%@ Import Namespace="DCI_MVC.Models" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
<% foreach (var account in ViewData["Accounts"] as IEnumerable<Account>)
    {
    %>
Account: <%=account.Name%> has balance <%=account.Balance%> <br />
<%
    }%> 
</asp:Content>

