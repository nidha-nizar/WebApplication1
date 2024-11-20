<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropbind.aspx.cs" Inherits="WebApplication1.dropview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        EMPLLOYEE<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <p>
            SALARY<asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
    </form>
</body>
</html>
