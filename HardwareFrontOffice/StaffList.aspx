<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server"></asp:ListBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <br />
        Enter a name
        <asp:TextBox ID="txtfilter" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
&nbsp;<asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
