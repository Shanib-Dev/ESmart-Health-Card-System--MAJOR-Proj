<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="branchs.aspx.cs" Inherits="ESmartHealthCard.branchs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align = "center" 
        style="background-image:url('https://thumbs.dreamstime.com/z/healthcare-technology-doctor-using-digital-tablet-icon-medical-network-hospital-background-162019727.jpg'); height: 700px;">
    <div style=" text-align:left; height: 78px;"> 
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txthome" runat="server" Text="HOME" Height="40px" Width="100px" 
                onclick="txthome_Click" BackColor="#6699FF" /> 
        </div>
    <center style="height: 512px; width: 1029px">
    <h1 align="center" 
            style="font-family: Algerian; font-size: xx-large; font-weight: 600; font-style: normal; font-variant: normal; text-transform: uppercase; color: #000080; text-decoration: blink; line-height: 0px; background-image: inherit; height: 57px; width: 1017px;">Branch</h1>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Branch ID &nbsp; <asp:TextBox ID="txtbranchid" runat="server"></asp:TextBox>&nbsp;<asp:Button 
            ID="btnsearch" runat="server" onclick="txtsearch_Click" Text="Search" />

        <br />
        &nbsp;<br />
        Name&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp<asp:TextBox ID="txtname" runat="server"></asp:TextBox><br /><br />
        Address&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;<asp:TextBox ID="txtaddress" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnsave" runat="server" Text="Save" onclick="btnsave_Click" 
            BackColor="#FF99FF" ForeColor="Black" />&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="btnupdate" runat="server" Text="Update" 
            onclick="btnupdate_Click" BackColor="#9999FF"  />&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="btndelete" runat="server" Text="Delete" 
            onclick="btndelete_Click" BackColor="#99CCFF" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="593px" 
            AutoGenerateColumns="false" BorderColor="Black" BorderStyle="Solid" 
            ForeColor="Black">
        <HeaderStyle BackColor="#CCCCCC" ForeColor="White" />
        <Columns>
        <asp:BoundField DataField="branchid" HeaderText="Branch ID" />
         <asp:BoundField DataField="name" HeaderText="Name" />
          <asp:BoundField DataField="address" HeaderText="Address" />
        </Columns>
        </asp:GridView>
        <br />
        </center>
    </div>
    </form>
</body>
</html>
