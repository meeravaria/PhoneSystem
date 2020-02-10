<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 47px; top: 68px; position: absolute; bottom: 478px; width: 43px" Text="StaffID"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 46px; top: 102px; position: absolute" Text="FirstName"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 48px; top: 135px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="lblGender" runat="server" style="z-index: 1; left: 48px; top: 167px; position: absolute" Text="Gender"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 49px; top: 199px; position: absolute" Text="DateOfBirth"></asp:Label>
        <asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 50px; top: 231px; position: absolute" Text="Street"></asp:Label>
        <asp:Label ID="lblCounty" runat="server" style="z-index: 1; left: 50px; top: 263px; position: absolute" Text="County"></asp:Label>
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 51px; top: 293px; position: absolute" Text="Postcode"></asp:Label>
        <asp:Label ID="lblTelephone" runat="server" style="z-index: 1; left: 51px; top: 325px; position: absolute" Text="Telephone"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 109px; top: 68px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 119px; top: 102px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 125px; top: 136px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 135px; top: 198px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 98px; top: 231px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 117px; top: 292px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTelephone" runat="server" style="z-index: 1; left: 121px; top: 325px; position: absolute"></asp:TextBox>
        <asp:ListBox ID="lstCounty" runat="server" style="z-index: 1; left: 103px; top: 258px; position: absolute; height: 26px; width: 129px"></asp:ListBox>
        <asp:ListBox ID="lstGender" runat="server" style="z-index: 1; left: 107px; top: 166px; position: absolute; height: 22px; width: 133px"></asp:ListBox>
        <asp:CheckBox ID="Active" runat="server" style="z-index: 1; left: 49px; top: 372px; position: absolute; right: 721px" OnCheckedChanged="Active_CheckedChanged" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 55px; top: 404px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 164px; top: 368px; position: absolute; width: 58px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 228px; top: 368px; position: absolute; margin-bottom: 0px" Text="Cancel" />
    </form>
</body>
</html>
