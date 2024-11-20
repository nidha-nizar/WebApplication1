<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication1.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Name<asp:TextBox ID="Textname" runat="server"></asp:TextBox>
        </p>
        <p>
            Date Of Birth<asp:DropDownList ID="day" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="month" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="year" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            Gender<asp:RadioButton ID="male" runat="server" GroupName="gender" Text="Male" />
            <asp:RadioButton ID="female" runat="server" GroupName="gender" Text="FeMale" />
        </p>
        <p>
            Age<asp:TextBox ID="Textage" runat="server"></asp:TextBox>
        </p>
        <p>
            Mobileno<asp:TextBox ID="Textno" runat="server"></asp:TextBox>
        </p>
        <p>
            Password<asp:TextBox ID="Textpass" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
    </form>
</body>
</html>
