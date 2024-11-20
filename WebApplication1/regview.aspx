<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regview.aspx.cs" Inherits="WebApplication1.regview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="713px" >
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="name" HeaderText="Name" />
                <asp:BoundField DataField="dateofbirt" HeaderText="Dateofbirth" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />
                <asp:BoundField DataField="age" HeaderText="Age" />
                <asp:BoundField DataField="mobile" HeaderText="Mobileno" />
                <asp:BoundField DataField="pass" HeaderText="Password" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CommandArgument='<%# Eval("id") %>' Text="Edit"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton3"  runat="server" OnClick="LinkButton3_Click" CommandArgument='<%# Eval("id") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server">Edit</asp:LinkButton>
            </EmptyDataTemplate>
        </asp:GridView>
        ID<asp:TextBox ID="TextID" runat="server"></asp:TextBox>
        <p>
            NAME<asp:TextBox ID="TextNAME" runat="server"></asp:TextBox>
        </p>
        DATEOFBIRTH<asp:DropDownList ID="day" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="month" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="year" runat="server">
        </asp:DropDownList>
        <p>
            GENDER<asp:RadioButton ID="male" runat="server" GroupName="gender" Text="male" />
            <asp:RadioButton ID="female" runat="server" GroupName="gender" Text="female" />
        </p>
        AGE<asp:TextBox ID="TextAGE" runat="server"></asp:TextBox>
        <p>
            MOBILENO<asp:TextBox ID="TextMOBILE" runat="server"></asp:TextBox>
        </p>
        PASSWORD<asp:TextBox ID="TextPASS" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="UPDATE" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
