<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generate.aspx.cs" Inherits="ESmartHealthCard.Generate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div align = "center" style="background-image:url('https://thumbs.dreamstime.com/z/healthcare-technology-doctor-using-digital-tablet-icon-medical-network-hospital-background-162019727.jpg'); height: 700px;">
   <div style="text-align:right; height: 78px;">
   <asp:Button ID="txthome" runat="server" Text="LOG OUT" Height="40px" Width="100px" 
                 BackColor="#CC33FF" onclick="txthome_Click" /> 
    </div>
    <h1 style="color:blue;">Generate Bill</h1>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    PatientId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPatientId" runat="server"></asp:TextBox>
    &nbsp;
    <asp:Button 
            ID="btnsearch" runat="server" onclick="txtsearch_Click" Text="Search" />
        <br />
        <br />
        PatientName&nbsp; <asp:TextBox ID="txtname" runat="server"></asp:TextBox><br /><br />
CardType&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCardType" runat="server"></asp:TextBox><br /><br />
Amount&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox><br /><br />
Discount&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox><br /><br />
Final Amount <asp:TextBox ID="txtFinalAmount" runat="server"></asp:TextBox>
        <br />
        <br />
Payment Mode&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="dripPaymode" runat="server" 
            Height="20px" Width="156px">
    <asp:ListItem>Cash</asp:ListItem>
            <asp:ListItem>Card</asp:ListItem>
            <asp:ListItem>UPI</asp:ListItem>
        </asp:DropDownList>       
        
        <br />
        
        <br />
<asp:Button ID="btnDiscount" runat="server" Text="Calculate Discount"
            BackColor="#FF99FF" ForeColor="Black" onclick="btnDiscount_Click" 
            style="margin-left: 7px" Width="151px" />&nbsp&nbsp&nbsp&nbsp<br />
        <br />

&nbsp;

<asp:Button ID="btnConfirmPayment" runat="server" Text="Confirm Payment"
            BackColor="#FF99FF" ForeColor="Black" onclick="btnConfirmPayment_Click" />&nbsp&nbsp&nbsp&nbsp

    </div>
    </form>
</body>
</html>
