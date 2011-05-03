<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <div>
        <% using (Html.BeginForm())
           { %>
        <p> Source account:
    <%= Html.DropDownList("SourceAccounts")%>
    Destination account:
    <%= Html.DropDownList("DestinationAccounts")%>
    Amount:
    <%= Html.TextBox("Amount") %>
        </p>

         <input type="submit" value="Transfer" />
        <%} %>
    </div>

</asp:Content>
