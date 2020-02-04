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
        <asp:Label ID="lblPhoneID" runat="server" Font-Bold="True" style="z-index: 1; left: 15px; top: 55px; position: absolute" Text="Phone ID : "></asp:Label>
        <asp:Label ID="lblCapacity" runat="server" Font-Bold="True" style="z-index: 1; left: 19px; top: 89px; position: absolute; bottom: 556px" Text="Capacity : "></asp:Label>
        <asp:Label ID="lblPrice" runat="server" Font-Bold="True" style="z-index: 1; left: 44px; top: 122px; position: absolute" Text="Price :"></asp:Label>
        <asp:Label ID="lblColour" runat="server" Font-Bold="True" style="z-index: 1; left: 34px; top: 155px; position: absolute" Text="Colour :"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" Font-Bold="True" style="z-index: 1; left: 6px; top: 187px; position: absolute" Text="DateAdded : "></asp:Label>
        <asp:Label ID="lblMake" runat="server" Font-Bold="True" style="z-index: 1; left: 39px; top: 218px; position: absolute" Text="Make :"></asp:Label>
        <asp:Label ID="lblModel" runat="server" Font-Bold="True" style="z-index: 1; left: 36px; top: 252px; position: absolute" Text="Model : "></asp:Label>
        <asp:Label ID="lblStockStatus" runat="server" Font-Bold="True" style="z-index: 1; left: 4px; top: 282px; position: absolute" Text="Stock Status : "></asp:Label>
        <asp:TextBox ID="txtPhoneID" runat="server" style="z-index: 1; left: 98px; top: 54px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCapacity" runat="server" style="z-index: 1; left: 98px; top: 87px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 98px; top: 124px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 98px; top: 156px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 98px; top: 186px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtMake" runat="server" style="z-index: 1; left: 98px; top: 220px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 98px; top: 253px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkStockStatus" runat="server" style="z-index: 1; left: 110px; top: 284px; position: absolute" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 92px; top: 325px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 157px; top: 323px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
