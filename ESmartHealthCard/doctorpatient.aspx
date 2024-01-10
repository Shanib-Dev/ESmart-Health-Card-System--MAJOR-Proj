<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="doctorpatient.aspx.cs" Inherits="ESmartHealthCard.doctor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="background-image:url('https://thumbs.dreamstime.com/z/healthcare-technology-doctor-using-digital-tablet-icon-medical-network-hospital-background-162019727.jpg'); height: 736px;">
    <center style="height: 696px">
    <div style=" text-align:left; height: 78px;" align="center"> 
            <br />
             <div style="text-align:right; height: 78px;"> 
<asp:Button ID="btnlogout" runat="server" Text="Log Out" Height="40px" Width="100px" 
                BackColor="#FF66FF" onclick="btnlogout_Click" />
                </div>
                <br />
    Patient ID&nbsp;
        <asp:TextBox ID="txtpatientid" runat="server" Width="136px"></asp:TextBox>&nbsp&nbsp&nbsp
        <asp:Button ID="Button4" runat="server" Text="Search" onclick="Button4_Click"/>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <br />

            <br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" 
            Width="793px">
            <HeaderStyle BackColor="#CCCCCC" ForeColor="White" />
            <Columns>
            <asp:BoundField DataField="patientid" HeaderText="patientid" />
            <asp:BoundField DataField="name" HeaderText="name" />
            <asp:BoundField DataField="mobile" HeaderText="mobile" />
            <asp:BoundField DataField="email" HeaderText="email" />
            <asp:BoundField DataField="cardtype" HeaderText="cardtype" />
            <asp:BoundField DataField="cardno" HeaderText="cardno" />
            <asp:BoundField DataField="cardvalidity" HeaderText="cardvalidity" />
            <asp:BoundField DataField="address" HeaderText="address" />
            </Columns>
        </asp:GridView>
        <br />
         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" 
            Width="793px">
            <HeaderStyle BackColor="#CCCCCC" ForeColor="White" />
            <Columns>
            <asp:BoundField DataField="doctorid" HeaderText="doctorid" />
            <asp:BoundField DataField="name" HeaderText="name" />
            <asp:BoundField DataField="patientid" HeaderText="PatientId" />
            <asp:BoundField DataField="treatmentremark" HeaderText="TreatmentRemark" />
            <asp:BoundField DataField="treatmentdate" HeaderText="TreatmentDate" />
            </Columns>
        </asp:GridView>
            <br />
            <span class="style1"><strong>Treatment Remark :</strong></span><br /><br />
&nbsp;<asp:TextBox ID="TextTrtRmk" runat="server" Height="90px" TextMode="MultiLine" 
            Width="782px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
