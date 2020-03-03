<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultStaff.aspx.cs" Inherits="DefaultStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>


        <asp:ListBox ID="lstStaff" runat="server" OnSelectedIndexChanged="lstStaff_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 287px; width: 317px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 337px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblPleaseEnter" runat="server" style="z-index: 1; left: 31px; top: 369px; position: absolute; width: 156px" Text="Please enter ..."></asp:Label>
        <asp:TextBox ID="txtStaffSearch" runat="server" style="z-index: 1; left: 33px; top: 392px; position: absolute; width: 220px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 32px; top: 430px; position: absolute" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 104px; top: 430px; position: absolute" Text="Display All" OnClick="btnDisplayAll_Click1" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 34px; top: 468px; position: absolute; height: 26px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 89px; top: 467px; position: absolute" Text="Edit" OnClick="btnEdit_Click1" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 146px; top: 468px; position: absolute" Text="Delete" OnClick="btnDelete_Click1" />
        <asp:ListBox ID="lstStaff" runat="server" Height="257px" Width="285px"></asp:ListBox>
    </form>
</body>
</html>
