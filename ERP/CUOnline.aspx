<%@ Page Title="CUOnline" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CUOnline.aspx.cs" Inherits="ERP.CUOnline" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:content id="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="https://getbootstrap.com/docs/3.3/examples/dashboard/dashboard.css" rel="stylesheet">
   <div class="container-fluid">
      <div class="row">
        <div class="col-sm-3 col-md-2 sidebar">
          <ul class="nav nav-sidebar">
            <li class="active"><a href="#">Overview <span class="sr-only">(current)</span></a></li>
            <li><a href="#">Subjects Report</a></li>
            <li><a href="#">Analytics</a></li>
            <li><a href="#">Export</a></li>
          </ul>
          <ul class="nav nav-sidebar">
            <li><a href="#">Assignments</a></li>
            <li><a href="#">Submit Assignment(s)</a></li>
            <li><a href="#">Quizz's</a></li>
          </ul>
        </div>
        <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main">
          <h1 class="page-header"><span class="label label-info">Dashboard</span></h1>

          <div class="row placeholders">
            <div class="col-xs-6 col-sm-3 placeholder">
              <img src="cuchartimages/1.png" width="200" height="200" class="img-responsive" alt="Generic placeholder thumbnail">
              <h4>Attendence</h4>
              <span class="text-muted">89%</span>
            </div>
            <div class="col-xs-6 col-sm-3 placeholder">
              <img src="cuchartimages/2.png" width="200" height="200" class="img-responsive" alt="Generic placeholder thumbnail">
              <h4>Assignments</h4>
              <span class="text-muted">85%</span>
            </div>
            <div class="col-xs-6 col-sm-3 placeholder">
              <img src="cuchartimages/3.png" width="200" height="200" class="img-responsive" alt="Generic placeholder thumbnail">
              <h4>Quizz's</h4>
              <span class="text-muted">56%</span>
            </div>
            <div class="col-xs-6 col-sm-3 placeholder">
              <img src="cuchartimages/4.png" width="200" height="200" class="img-responsive" alt="Generic placeholder thumbnail">
              <h4>GPA</h4>
              <span class="text-muted">3.29</span>
            </div>
          </div>

          <h2 class="sub-header"><span class="label label-info">Subjects Summary</span></h2>
          <div class="table-responsive">
            <table class="table table-striped table-hover table-bordered" id="subjects_table" runat="server">
              <thead>
                <tr>
                  <th>#</th>
                  <th>Subjects</th>
                  <th>Attendance</th>
                  <th>Lectures</th>
                  <th>Absents</th>
                </tr>
              </thead>
              <tbody>
                   
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
</asp:content>
