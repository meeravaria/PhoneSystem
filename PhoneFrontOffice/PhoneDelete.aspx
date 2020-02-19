<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhoneDelete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" BackColor="#99CCFF" BorderStyle="Solid" OnClick="btnYes_Click" style="z-index: 1; left: 13px; top: 116px; position: absolute; width: 54px" Text="YES " />
        <asp:Button ID="btnNO" runat="server" BackColor="#99CCFF" BorderStyle="Solid" style="z-index: 1; left: 88px; top: 116px; position: absolute; width: 53px" Text="NO " />
        <asp:Label ID="lblAreYouSure" runat="server" Font-Bold="True" style="z-index: 1; left: 10px; top: 75px; position: absolute" Text="Are you sure you want to delete this phone? "></asp:Label>
    </form>
</body>
</html>
