<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<DCI_MVC.Controllers.SelectAmountVm>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
  <% using (Html.BeginForm(controllerName:"TransferMoney", actionName: "SelectAmount"))
     {%>
    <fieldset>
     Select account to trasfer to:
     <div class="editor-field"> <%: Html.TextBoxFor(model => model.SelectedAmount)%> </div>
     <input type="submit" value="Next"/>
     </fieldset>
 <%  }%>

</asp:Content>
