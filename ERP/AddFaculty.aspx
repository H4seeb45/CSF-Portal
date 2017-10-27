<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddFaculty.aspx.cs" Inherits="ERP.AddFaculty" %>





<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
  <h2>Add a New FacultyMember</h2>
  <p>Fill up the fields below to add a new FacultyMember.</p>
    <div class="form-group">
      <label for="FacultyMemberName">Name: (15 Characters Max)</label>
      <input runat="server" type="text" pattern="[a-zA-Z\s]+{1,15}" class="form-control" id="FacultyMemberName" required>
    </div>
    <div class="form-group">
      <label for="CNIC">CNIC / B-From No: (XXXXX-XXXXXX-X)</label>
      <input runat="server" type="text" pattern="^\d{5}-\d{7}-\d{1}" class="form-control" id="CNIC" required>
       </div>

      <div class="form-group">
      <label for="MobileNo">Mobile No: (XXXX-XXXXXXX)</label>
      <input runat="server" type="text" pattern="^\d{4}-\d{7}" class="form-control" id="MobileNo" required>
       </div>

        <div class="form-group">
      <label for="Age">Age (2 Digits)</label>
      <input type="text" pattern="[0-9]{2,2}" min="16" class="form-control" id="Age" required runat ="server">
       </div>

      <div class="form-group">
      <label for="Qualification">Qualification</label>
      <input runat="server" type="text" pattern="[a-zA-Z]{1,20}"  class="form-control" id="Qualification" required>
       </div>

      <div class="form-group">
      <label for="Designation">Designation (max 20 characters)</label>
      <input runat="server" type="text" pattern="[a-zA-Z]{1,20}" class="form-control" id="Designation" required>
       </div>

       <div class="form-group">
      <label for="Responsibilty">Responsibility </label>
      <input runat="server" type="text" pattern="[a-zA-Z]{1,50}" class="form-control" id="Responsibility" required>
       </div>

       <div class="form-group">
      <label for="Status">Status </label>
      <input runat="server" type="text" pattern="[a-zA-Z]{1,15}" class="form-control" id="Status" required>
       </div>

        <div class="form-group">
      <label for="Department">Department </label>
      <input runat="server" type="text" pattern="[a-zA-Z]{1,15}" class="form-control" id="Department" required>
       </div>
      
    


  

       <asp:button runat="server" Text = "Submit" type="submit" class="btn btn-primary" id="btnSubmit" OnClick="btnSubmit_Click1"/>
</div>


   


</asp:Content>
