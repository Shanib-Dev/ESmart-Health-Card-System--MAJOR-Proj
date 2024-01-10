<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ESmartHealthCard.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 679px">
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
    <label style="font-family: 'times New Roman', Times, serif; font-size: medium; font-weight: bold">E-Mail ID</label>
    <asp:TextBox ID="txtUser" name="txtUser" runat="server"></asp:TextBox>
        <br />
        <br />
    <label style="font-size: medium; font-weight: bold">Password</label>
    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
    <label style="font-size: medium; font-weight: bold">Role&nbsp; </label>
       &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="18px" 
            Width="150px" BackColor="White">
            <asp:ListItem>Chairman</asp:ListItem>
            <asp:ListItem>Manager</asp:ListItem>
            <asp:ListItem>Doctor</asp:ListItem>
            <asp:ListItem>Receptionist</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <label><input type= "reset" /></label>
        <label>&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="Login" 
            onclick="Button1_Click" BackColor="#FFCCFF" /></label>
    </div>
    </form>
</body>
</html>
