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


        <asp:ListBox ID="lstStaff" runat="server" OnSelectedIndexChanged="lstStaff_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 287px; width: 273px" BackColor="#FF6666" ForeColor="Black"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 337px; position: absolute" Text="lblError" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblPleaseEnter" runat="server" style="z-index: 1; left: 32px; top: 362px; position: absolute; width: 207px" Text="Please enter a postcode..." Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtStaffSearch" runat="server" style="z-index: 1; left: 33px; top: 392px; position: absolute; width: 220px" BackColor="#FF6666" ForeColor="Black"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 146px; top: 427px; position: absolute; height: 28px;" Text="Apply" OnClick="btnApply_Click" BackColor="#FFB7B7" Font-Bold="True" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 35px; top: 427px; position: absolute; height: 28px;" Text="Display All" OnClick="btnDisplayAll_Click1" BackColor="#FFB7B7" Font-Bold="True" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 34px; top: 468px; position: absolute; height: 26px; width: 50px;" Text="Add" OnClick="btnAdd_Click" BackColor="#FFB7B7" Font-Bold="True" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 90px; top: 468px; position: absolute; width: 50px; height: 26px;" Text="Edit" OnClick="btnEdit_Click1" BackColor="#FFB7B7" Font-Bold="True" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 146px; top: 467px; position: absolute; width: 58px; height: 27px; bottom: 144px;" Text="Delete" OnClick="btnDelete_Click1" BackColor="#FFB7B7" Font-Bold="True" />
    </form>
</body>
</html>
