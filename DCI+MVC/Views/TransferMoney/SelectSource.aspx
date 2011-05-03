<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<DCI_MVC.Controllers.SelectAccountVm>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
  <% using (Html.BeginForm())
     {%>
    <fieldset>
     Select account to trasfer from:
     <div class="editor-field"> <%: Html.DropDownListFor(model => model.SelectedAccountId, Model.Accounts.Select(a => new SelectListItem { Text = a.Name, Value = a.Id.ToString() }))%> </div>
     <input type="submit" value="Next" />
     </fieldset>
 <%  }%>

</asp:Content>
