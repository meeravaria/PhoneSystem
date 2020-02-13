<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APhone.aspx.cs" Inherits="APhone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCapacity" runat="server" Font-Bold="True" style="z-index: 1; left: 135px; top: 139px; position: absolute; bottom: 504px" Text="Capacity : "></asp:Label>
        <asp:Label ID="lblPrice" runat="server" Font-Bold="True" style="z-index: 1; left: 160px; top: 172px; position: absolute; bottom: 470px;" Text="Price :"></asp:Label>
        <asp:Label ID="lblColour" runat="server" Font-Bold="True" style="z-index: 1; left: 134px; top: 213px; position: absolute; bottom: 433px; right: 260px;" Text="Colour :"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" Font-Bold="True" style="z-index: 1; left: 119px; top: 247px; position: absolute" Text="DateAdded : "></asp:Label>
        <asp:Label ID="lblMake" runat="server" Font-Bold="True" style="z-index: 1; left: 152px; top: 107px; position: absolute; width: 50px;" Text="Make :"></asp:Label>
        <asp:Label ID="lblModel" runat="server" Font-Bold="True" style="z-index: 1; left: 150px; top: 70px; position: absolute; height: 19px; width: 53px;" Text="Model : "></asp:Label>
        <asp:Label ID="lblStockStatus" runat="server" Font-Bold="True" style="z-index: 1; left: 112px; top: 282px; position: absolute" Text="Stock Status : "></asp:Label>
        <asp:TextBox ID="txtCapacity" runat="server" style="z-index: 1; left: 222px; top: 137px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 222px; top: 172px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 222px; top: 209px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 221px; top: 245px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtMake" runat="server" style="z-index: 1; left: 222px; top: 103px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 222px; top: 68px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkStockStatus" runat="server" style="z-index: 1; left: 262px; top: 283px; position: absolute" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 227px; top: 333px; position: absolute; width: 60px; height: 26px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 311px; top: 331px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 173px; top: 398px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
