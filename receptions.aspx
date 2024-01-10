<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="receptions.aspx.cs" Inherits="ESmartHealthCard.receptions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div align = "center" 
        
        style="background-image:url('https://thumbs.dreamstime.com/z/healthcare-technology-doctor-using-digital-tablet-icon-medical-network-hospital-background-162019727.jpg'); height: 736px;">
    <center style="height: 696px">
    <div style=" text-align:left; height: 78px;"> 
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtlogout" runat="server" Text="HOME" Height="40px" Width="100px" 
                 BackColor="#9966FF" onclick="txtlogout_Click"  /> 
        </div>
    <h1 align="center" 
            style="font-family: Algerian; font-size: xx-large; font-weight: 600; font-style: normal; font-variant: normal; text-transform: uppercase; color: #000080; text-decoration: blink; line-height: 0px; background-image: inherit; height: 57px; width: 1017px;">Receptionist</h1>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         Reception ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtreceptionid" runat="server"></asp:TextBox>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnsearch" runat="server" Text="Search" 
            onclick="btnsearch_Click" />
          <br />
          <br />
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <br />
        Mobile&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
        <br />
        <br />
        Address&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;Branch&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="134px">
            <asp:ListItem>Kandivali</asp:ListItem>
            <asp:ListItem>Borivali</asp:ListItem>
            <asp:ListItem>Andheri</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        E-Mail&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtemail" runat="server" Width="139px"></asp:TextBox>
        <br />
        <br />
        Password&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpassword" runat="server" Width="143px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnsave" runat="server" Text="Save" onclick="btnsave_Click" />&nbsp&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnedit" runat="server" Text="Edit" onclick="btnedit_Click" />&nbsp&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btndelete" runat="server" Text="Delete" 
        
            onclientclick="return confirm('Are you sure you want to delete ?');" 
            onclick="btndelete_Click" />&nbsp&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnload" runat="server" Text="Load" onclick="btnload_Click" 
             />
          <br />
          <br />

          <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" 
            Width="793px">
            <HeaderStyle BackColor="#CCCCCC" ForeColor="White" />
            <Columns>
            <asp:BoundField DataField="managerid" HeaderText="doctorid" />
            <asp:BoundField DataField="name" HeaderText="name" />
            <asp:BoundField DataField="mobile" HeaderText="mobile" />
            <asp:BoundField DataField="address" HeaderText="address" />
            <asp:BoundField DataField="branch" HeaderText="branch" />
            <asp:BoundField DataField="emailid" HeaderText="emailid" />
            <asp:BoundField DataField="password" HeaderText="password" />
            </Columns>
        </asp:GridView><br />
        </center>
    </div>
    </form>
</body>
</html>
