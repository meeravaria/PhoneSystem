<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 47px; top: 141px; position: absolute; width: 60px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 118px; top: 141px; position: absolute; width: 68px" Text="No" OnClick="btnNo_Click" />
        <asp:Label ID="lblDeleteStaff" runat="server" style="z-index: 1; left: 46px; top: 97px; position: absolute; width: 219px" Text="Are you sure you want to delete this Staff?"></asp:Label>
    </form>
</body>
</html>
