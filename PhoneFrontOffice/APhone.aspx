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
        <asp:Label ID="lblCapacity" runat="server" Font-Bold="True" style="z-index: 1; left: 138px; top: 62px; position: absolute; bottom: 780px" Text="Capacity : "></asp:Label>
        <asp:Label ID="lblPrice" runat="server" Font-Bold="True" style="z-index: 1; left: 162px; top: 94px; position: absolute; bottom: 751px;" Text="Price :"></asp:Label>
        <asp:Label ID="lblColour" runat="server" Font-Bold="True" style="z-index: 1; left: 150px; top: 126px; position: absolute; bottom: 716px; right: 837px;" Text="Colour :"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" Font-Bold="True" style="z-index: 1; left: 120px; top: 162px; position: absolute" Text="DateAdded : "></asp:Label>
        <asp:Label ID="lblMake" runat="server" Font-Bold="True" style="z-index: 1; left: 148px; top: 262px; position: absolute; width: 50px;" Text="Make :"></asp:Label>
        <asp:Label ID="lblModel" runat="server" Font-Bold="True" style="z-index: 1; left: 144px; top: 298px; position: absolute; height: 19px; width: 53px;" Text="Model : "></asp:Label>
        <asp:Label ID="lblStockStatus" runat="server" Font-Bold="True" style="z-index: 1; left: 105px; top: 331px; position: absolute" Text="Stock Status : "></asp:Label>
        <asp:TextBox ID="txtCapacity" runat="server" style="z-index: 1; left: 221px; top: 63px; position: absolute" BackColor="#B9DCFF"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 221px; top: 95px; position: absolute" BackColor="#B9DCFF"></asp:TextBox>
        <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 221px; top: 125px; position: absolute" BackColor="#B9DCFF"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 221px; top: 161px; position: absolute" BackColor="#B9DCFF"></asp:TextBox>
        <asp:TextBox ID="txtMake" runat="server" style="z-index: 1; left: 221px; top: 263px; position: absolute" BackColor="#B9DCFF"></asp:TextBox>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 220px; top: 297px; position: absolute" BackColor="#B9DCFF"></asp:TextBox>
        <asp:CheckBox ID="chkStockStatus" runat="server" style="z-index: 1; left: 221px; top: 332px; position: absolute; width: 123px;" Text="  " Font-Bold="True" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 150px; top: 561px; position: absolute; width: 60px; height: 26px;" Text="OK" BackColor="#99CCFF" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 237px; top: 559px; position: absolute; height: 28px;" Text="Cancel" BackColor="#99CCFF" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 29px; top: 447px; position: absolute" Text="lblError" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" Font-Bold="True" style="z-index: 1; left: 117px; top: 193px; position: absolute; height: 19px" Text="Description : "></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" BackColor="#B9DCFF" style="z-index: 1; left: 221px; top: 198px; position: absolute; height: 42px; width: 214px"></asp:TextBox>
        <asp:Label ID="lblActive" runat="server" Font-Bold="True" style="z-index: 1; left: 143px; top: 367px; position: absolute" Text="Active : "></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 219px; top: 371px; position: absolute; width: 98px" Text="  " />
    </form>
</body>
</html>
