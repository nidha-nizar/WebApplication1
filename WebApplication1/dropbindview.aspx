<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropbindview.aspx.cs" Inherits="WebApplication1.dropbindview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="s_id" HeaderText="id" />
                <asp:BoundField DataField="name" HeaderText="name" />
                <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
