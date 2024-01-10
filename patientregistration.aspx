<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="patientregistration.aspx.cs" Inherits="ESmartHealthCard.patientregistration" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 503px">
    <form id="form1" runat="server">
    <div align = "center" style="background-image:url('https://thumbs.dreamstime.com/z/healthcare-technology-doctor-using-digital-tablet-icon-medical-network-hospital-background-162019727.jpg'); height: 700px;">
        <div style=" text-align:right; height: 78px;"> 
        <asp:Button ID="txthome" runat="server" BackColor="#6699FF" Height="40px" 
                Text="HOME" Width="100px" onclick="txthome_Click" />
        </div>
        <br />
        <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
        Text="E Smart Health Card" ForeColor="#990099"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Patient Information" 
        Font-Bold="True" ForeColor="#660066"></asp:Label>
    <br />
    <table class="style1">
        <tr>
            <td class="style9">
                Enter Patient ID</td>
            <td class="style10">
                <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="149px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
                <br />
                <asp:Label ID="Label9" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:Panel ID="Panel1" runat="server" Visible="False" BorderColor="Black" 
        BorderStyle="Solid" Height="128px" Width="253px">
    
    <table class="style4" border="1">
        <tr>
            <td colspan="2" style="text-align: center" class="style7">
                <asp:Label ID="Label3" runat="server" Text="E Smart Health Card"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style8" align="left">
                Patient ID :
                <br />
                Name :
                <br />
                Card Type :
                <br />
                Card Validity :&nbsp;
                <br />
                Address :
            </td>
            <td align="left" class="style6">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
        <br />
    <asp:Button ID="Button2" runat="server" Text="Download" onclick="Button2_Click" />
    </asp:Panel>
    </div>
    </form>
</body>
</html>
