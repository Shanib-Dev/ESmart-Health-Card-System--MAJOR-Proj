<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="patient.aspx.cs" Inherits="ESmartHealthCard.patient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Patient</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align = "center" style="background-image:url('https://thumbs.dreamstime.com/z/healthcare-technology-doctor-using-digital-tablet-icon-medical-network-hospital-background-162019727.jpg'); height: 700px;">
   <div style="text-align:right; height: 78px;">
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txthome" runat="server" Text="HOME" Height="40px" Width="100px" 
                onclick="txthome_Click" BackColor="#CC33FF" /> 
        </div>
    <h1 style="color:blue;">PATIENT</h1>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Patient ID&nbsp;
        <asp:TextBox ID="txtpatientid" runat="server" Width="136px"></asp:TextBox>&nbsp&nbsp&nbsp
        <asp:Button ID="Button4" runat="server" Text="Search" onclick="Button4_Click" />
        &nbsp;
        <br />
        <br />
    Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:TextBox ID="txtname" 
            runat="server" Width="135px"></asp:TextBox>
        <br />
        <br />
    Mobile&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtmobile" 
            runat="server" Width="133px"></asp:TextBox>
        <br />
        <br />
    Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
        <asp:TextBox ID="txtemail" runat="server" Width="136px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        Card Type&nbsp; 
        <asp:DropDownList ID="DropDownList1" runat="server" 
            Height="20px" Width="156px">
    <asp:ListItem>Gold</asp:ListItem>
            <asp:ListItem>Silver</asp:ListItem>
            <asp:ListItem>Platinum</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
    CardCard No&nbsp;&nbsp; <asp:TextBox ID="txtcardno" 
            runat="server" Height="23px" Width="136px"></asp:TextBox>
        <br />
        <br />
        Card Validity&nbsp;&nbsp;       <asp:DropDownList ID="DropDownList2" runat="server" 
            Height="21px" Width="156px">
    <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
             <asp:ListItem>5</asp:ListItem>
              <asp:ListItem>6</asp:ListItem>
               <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                 <asp:ListItem>9</asp:ListItem>
                  <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
    Address&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
        <asp:TextBox ID="txtaddress" runat="server" Height="69px" TextMode="MultiLine" 
            Width="148px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Edit" onclick="Button2_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete" onclick="Button3_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Load" onclick="Button5_Click" />
        <br />
        <br />
        <asp:Button ID="buttoncard" runat="server" Text="Generate Card" 
            onclick="btncard" />
   
        
    &nbsp;<br /><br /><br />
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
        <br />
   
        
    </center>
    </div>
    </form>
</body>
</html>
