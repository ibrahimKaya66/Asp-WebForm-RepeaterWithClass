<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Asp_WebForm_RepeaterWithClass.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" OnItemCreated="Repeater1_ItemCreated">
                <HeaderTemplate>
                    <asp:Label ID="lblHeader" runat="server" Text="Label" Font-Bold="true"></asp:Label> <br />
                </HeaderTemplate>
                <ItemTemplate>
                    <%# Eval("Id") %> &emsp;
                    <%# Eval("Name") %> &emsp;
                    <%# Eval("EmployeeCount") %> <br />
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Label ID="lblFooter" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
