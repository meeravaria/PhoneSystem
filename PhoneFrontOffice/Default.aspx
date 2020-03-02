<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPhones" runat="server" style="z-index: 1; left: 23px; top: 64px; position: absolute; height: 281px; width: 236px" BackColor="#BFDFFF" OnSelectedIndexChanged="lstPhones_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" BackColor="#99CCFF" BorderStyle="Solid" style="z-index: 1; left: 32px; top: 511px; position: absolute; height: 26px; width: 74px; right: 503px;" Text="ADD" />
        <asp:Button ID="btnEdit" runat="server" BackColor="#99CCFF" BorderStyle="Solid" style="z-index: 1; left: 109px; top: 511px; position: absolute; width: 74px; margin-bottom: 0px" Text="EDIT" OnClick="btnEdit_Click" />
        <asp:Button ID="btnApply" runat="server" BackColor="#99CCFF" BorderStyle="Solid" style="z-index: 1; left: 28px; top: 468px; position: absolute; width: 109px" Text="APPLY" />
        <asp:Button ID="btnDisplayAll" runat="server" BackColor="#99CCFF" BorderStyle="Solid" style="z-index: 1; top: 466px; position: absolute; width: 111px; left: 150px" Text="DISPLAY ALL" />
        <asp:Label ID="lblError" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 27px; top: 356px; position: absolute; height: 20px; width: 55px" Text="lblError"></asp:Label>
        <asp:Label ID="lblPleaseEnter" runat="server" Font-Bold="True" style="z-index: 1; left: 26px; top: 392px; position: absolute; width: 125px" Text="Please Enter a ...."></asp:Label>
        <asp:TextBox ID="txtPhoneSearch" runat="server" BackColor="#CCE6FF" style="z-index: 1; left: 26px; top: 424px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 188px; top: 513px; position: absolute" Text="DELETE" BackColor="#99CCFF" BorderStyle="Solid" OnClick="btnDelete_Click1" />
    </form>
</body>
</html>
