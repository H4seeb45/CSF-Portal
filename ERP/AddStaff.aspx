<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="ERP.AddStaff" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
  <h2>Add a New Staff Member</h2>
  <p>Fill up the fields below to add a new Staff Member.</p>
  
    <div class="form-group">
      <label for="Member Name">Name: (15 Characters Max)</label>
      <input type="text" title="Member Name" pattern="[a-zA-Z\s]+{1,15}" class="form-control" id="MemberName" required runat ="server"> 
    </div>

    <div class="form-group">
      <label for="CNIC">CNIC / B-From No: (XXXXX-XXXXXX-X)</label>
      <input type="text" title="CNIC" pattern="^\d{5}-\d{7}-\d{1}" class="form-control" id="CNIC" required runat ="server">
       </div>

      <div class="form-group">
      <label for="MobileNo">Mobile No: (XXXX-XXXXXXX)</label>
      <input type="text" title="Mobile No" pattern="^\d{4}-\d{7}" class="form-control" id="MobileNo" required runat ="server">
       </div>

      <div class="form-group">
      <label for="Age">Age (2 Digits)</label>
      <input type="text" title="Age" pattern="[0-9]{2,2}" min="16" class="form-control" id="Age" required runat ="server">
       </div>

      <div class="form-group">
      <label for="Designation">Designation (Max 20)</label>
      <input type="text" title="Designation" pattern="[a-zA-Z]{1,15}" class="form-control" id="Designation" required runat ="server">
       </div>

       <div class="form-group">
      <label for="Address">Address </label>
      <input type="text" title="Address" pattern="[a\s-zA\s-Z\s-Z0-9\s]+" class="form-control" id="Address" required runat ="server">
       </div>

       <div class="form-group">
      <label for="StaffType">Staff Type </label>
      <input type="text" title="Staff Type" pattern="[a-zA-Z\s]+" class="form-control" id="StaffType" required runat ="server">
       </div>
      
    


  

       <asp:button runat="server" Text = "Submit" type="submit" class="btn btn-primary" id="btnSubmit" OnClick="btnSubmit_Click1" />
</div>


    


</asp:Content>


