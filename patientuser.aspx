<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="patientuser.aspx.cs" Inherits="ESmartHealthCard.patientuser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align = "center" 
        
        style="background-image:url('https://thumbs.dreamstime.com/z/healthcare-technology-doctor-using-digital-tablet-icon-medical-network-hospital-background-162019727.jpg'); height: 700px; background-color: #00FFFF;">
        <br />
        <br />
        <br />
        <br />
        <h1 style="color:blue; font-size: 50px; font-weight: bold; font-style: normal; font-variant: normal; text-transform: uppercase; font-family: Algerian;" 
            align="center">E SMART HEALTH CARD</h1>
        <br />
    <center>
    <b>Enter Mobile No.</b>&nbsp; <input type="text" />
     <asp:Button ID="btnlogin0" runat="server" Text="Send OTP" Width="80px" 
            BackColor="#660066" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" Height="40px" 
            onclick="btnlogin_Click" /><br />
        <br />
        Enter OTP&nbsp; <input type="password" /><br />
        <br />
     <asp:Button ID="btnlogin" runat="server" Text="Verify OTP" Width="200px" 
            BackColor="#660066" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" Height="40px" 
            onclick="btnlogin_Click" /><br />
        or<br />
       <asp:Button ID="btnreg" runat="server" Text="Register" Width="200px" 
            BackColor="#660066" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" Height="40px" 
            onclick="btnreg_Click" /><br />
    </center>
    </div>
    </form>
</body>
</html>
