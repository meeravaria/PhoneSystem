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
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 536px; top: 57px; position: absolute; height: 250px; width: 306px" OnSelectedIndexChanged="lstStaff_SelectedIndexChanged"></asp:ListBox>
        <asp:ListBox ID="lstPhones" runat="server" style="z-index: 1; left: 23px; top: 64px; position: absolute; height: 281px; width: 219px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 578px; top: 420px; position: absolute; height: 30px; width: 60px;" Text="Add" BackColor="White" OnClick="btnAdd_Click1" />
        <asp:Button ID="btnEdit" runat="server" BackColor="White" style="z-index: 1; left: 653px; top: 420px; position: absolute; width: 59px; height: 28px; right: 798px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" BackColor="White" style="z-index: 1; left: 729px; top: 420px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnApply" runat="server" BackColor="White" style="z-index: 1; left: 583px; top: 385px; position: absolute; width: 86px; right: 841px; margin-bottom: 2px" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" BackColor="White" style="z-index: 1; left: 685px; top: 384px; position: absolute" Text="Display All" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 544px; top: 318px; position: absolute; height: 17px" Text="lblError"></asp:Label>
        <asp:TextBox ID="txtBox" runat="server" style="z-index: 1; left: 571px; top: 351px; position: absolute; width: 239px"></asp:TextBox>
        <asp:Label runat="server" style="z-index: 1; left: 642px; top: 321px; position: absolute" Text="Please enter a postcode"></asp:Label>
    </form>
</body>
</html>
