﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chairman.aspx.cs" Inherits="ESmartHealthCard.Director" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align = "center" style="background-image:url('https://thumbs.dreamstime.com/z/healthcare-technology-doctor-using-digital-tablet-icon-medical-network-hospital-background-162019727.jpg'); height: 700px; font-family: Algerian; font-size: xx-large; font-weight: bolder; font-style: normal; text-transform: uppercase; color: #0000FF;">
   <div style="text-align:right; height: 78px;"> 
   <asp:Button ID="btnlogout" runat="server" Text="Log Out" Height="40px" 
           Width="100px" onclick="btnlogout_Click" BackColor="#FF66FF" />
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   </div>
    <br /><br />
        E SMART HEALTH CARD<br />
        <br /><br />
    <center>
    <asp:Button ID="Button1" runat="server" Text="Patient" onclick="Button1_Click" 
            Height="54px" Width="200px" BackColor="#660066" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" />&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Manager" onclick="Button2_Click" 
            Height="53px" Width="186px" BackColor="#660066" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" />&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="Branch" onclick="Button3_Click" 
            Height="52px" Width="192px" BackColor="#660066" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" />
            &nbsp;&nbsp;
            <asp:Button ID="btndoc" runat="server" Text="Doctor"  
            Height="52px" Width="192px" BackColor="#660066" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" onclick="btndoc_Click"  /> &nbsp;&nbsp;
    <asp:Button ID="Btnreception" runat="server" Text="Receptionist"  
            Height="52px" Width="192px" BackColor="#660066" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" onclick="Btnreception_Click" />
            
    <asp:Button ID="Button4" runat="server" Text="Generate Bill"  
            Height="52px" Width="192px" BackColor="#660066" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" onclick="Button4_Click"  />
            
    </center>
    </div>
    </form>
</body>
</html>
