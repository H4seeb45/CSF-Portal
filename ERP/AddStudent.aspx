<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="AddStudent.aspx.cs" Inherits="ERP.AddStudent" EnableEventValidation="false" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
  <h2>Add a New Student</h2>
  <p>Fill up the fields below to add a new Student.</p>
    <div class="form-group">
      <label for="StudentName">Name: (15 Characters Max)</label>
      <input runat="server" type="text" title="15 Characters Max" pattern="[a-zA-Z\s]+{1,15}" class="form-control" id="StudentName" required>
    </div>
    <div class="form-group">
      <label for="CNIC">CNIC / B-From No: (XXXXX-XXXXXXX-X)</label>
      <input type="text" runat="server" title="XXXXX-XXXXXX-X" pattern="^\d{5}-\d{7}-\d{1}" class="form-control" id="CNIC" required>
       </div>

      <div class="form-group">
      <label for="MobileNo">Mobile No: (XXXX-XXXXXXX)</label>
      <input type="text" runat="server" title="XXXX-XXXXXXX" pattern="^\d{4}-\d{7}" class="form-control" id="MobileNo" required>
       </div>

      <div class="form-group">
      <label for="Age">Age (2 Digits)</label>
      <input type="text" runat="server" title="2 Digits" pattern="[0-9]{2,2}" class="form-control" id="Age" required>
       </div>

      <div class="form-group">
      <label for="TenthMarks">10th Marks (3 or 4 Digits)</label>
      <input type="text" runat="server" title="3 or 4 Digits" pattern="[0-9]{3,4}" class="form-control" id="TenthMarks" required>
       </div>

       <div class="form-group">
      <label for="FSCMarks">FSC Marks (3 or 4 Digits)</label>
      <input type="text" runat="server" title="3 or 4 Digits" pattern="[0-9]{3,4}" class="form-control" id="FSCMarks" required>
       </div>

       <div class="form-group">
      <label for="NTSMarks">NTS Marks (1 or 2 Digits)</label>
      <input type="text" runat="server" title="1 or 2 Digits" pattern="[0-9]{1,2}" class="form-control" id="NTSMarks" required>
       </div>


        <div class="form-group">
      <label for="Program">Program </label>
      <input type="text" runat="server" title="Enter Program Name" pattern="^[a-zA-Z]{1,15}" class="form-control" id="Program" required>
       </div>
      
    


       <asp:button runat="server" Text = "Submit" type="submit" class="btn btn-primary" id="btnSubmit" OnClick="btnSubmit_Click1" OnClientClick="btnSubmit_Click1"/>
</div>



</asp:Content>


