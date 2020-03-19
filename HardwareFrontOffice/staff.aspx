<%@ Page Language="C#" AutoEventWireup="true" CodeFile="staff.aspx.cs" Inherits="staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            StaffID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            StaffName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            StaffAddress&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            StaffDOB&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="StaffManager" runat="server" />
            <br />
            <asp:Label ID="lblError" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />&nbsp;
            <asp:Button ID="btnCan" runat="server" Text="Cancel" OnClick="btnCan_Click" />
            
        </div>
    </form>
</body>
</html>
