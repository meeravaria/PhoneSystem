<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" Debug="true" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 46px; top: 102px; position: absolute" Text="FirstName"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 48px; top: 135px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="lblGender" runat="server" style="z-index: 1; left: 48px; top: 167px; position: absolute" Text="Gender"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 49px; top: 199px; position: absolute" Text="DateOfBirth"></asp:Label>
        <asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 50px; top: 231px; position: absolute" Text="Street"></asp:Label>
        <asp:Label ID="lblCounty" runat="server" style="z-index: 1; left: 50px; top: 263px; position: absolute; right: 1416px;" Text="County"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 51px; top: 293px; position: absolute" Text="Postcode"></asp:Label>
        <asp:Label ID="lblTelephone" runat="server" style="z-index: 1; left: 51px; top: 325px; position: absolute" Text="Telephone"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 119px; top: 102px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 125px; top: 136px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 135px; top: 198px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 98px; top: 231px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 119px; top: 292px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTelephone" runat="server" style="z-index: 1; left: 121px; top: 325px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="Active" runat="server" style="z-index: 1; left: 50px; top: 363px; position: absolute; right: 528px" OnCheckedChanged="Active_CheckedChanged" Text="Active Staff" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 55px; top: 419px; position: absolute; width: 302px; height: 125px;"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 164px; top: 405px; position: absolute; width: 58px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 228px; top: 404px; position: absolute; margin-bottom: 0px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtCounty" runat="server" style="z-index: 1; left: 113px; top: 263px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtGender" runat="server" style="z-index: 1; left: 124px; top: 166px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
