<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPerson.aspx.cs" Inherits="ContosoWeb.People.AddPerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <div class="form-group">
    <label for ="txtFirstName">FirstName</label>
    <%--<input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email">--%>
        <asp:TextBox runat="server" ID ="txtFirstName" CssClass ="form-control"/>
  </div>

  <div class="form-group">
    <label for ="txtLasttName">LastName</label>
    <%--<input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email">--%>
        <asp:TextBox runat="server" ID ="txtLastName" CssClass ="form-control"/>
  </div>

  <div class="form-group">
    <label for ="txtMiddletName">MiddleName</label>
    <%--<input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email">--%>
        <asp:TextBox runat="server" ID ="txtMiddleName" CssClass ="form-control"/>
  </div >

  <div class="form-group">
    <label for ="txtAge">Age</label>
        <asp:TextBox runat="server" ID ="TextAge" CssClass ="form-control"/>
  </div >

  <div class="form-group">
    <label for ="txtAddress">Address</label>
        <asp:TextBox runat="server" ID ="TextAdderss" CssClass ="form-control"/>
  </div >

    <div class="form-group">
        <label for ="">State</label>
        <asp:DropDownList runat="server" ID ="ddlStates" CssClass ="form-control">

        </asp:DropDownList>
    </div>
    <asp:Button Text="SavePerson" runat="server"  ID ="btnSave" OnClick ="btnSave_Click" CssClass ="btn btn-primary"/>
</asp:Content>
