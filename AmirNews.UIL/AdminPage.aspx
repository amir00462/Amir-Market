<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="AmirNews.UIL.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Page</title>
    <link rel="icon" href="raw/icon.png" />
</head>
<body>

    <form id="form1" runat="server" style="padding-bottom: 10px">
        
        <div>

            <h1>Hello Admin</h1>

            <br />

            <h3>Add new Product to database =></h3>
            <div>
                <asp:TextBox ID="TextBoxName" runat="server" type="text" placeholder="enter name"></asp:TextBox>
                <asp:TextBox ID="TextBoxPrice" runat="server" type="text" placeholder="enter price"></asp:TextBox>
                <asp:TextBox ID="TextBoxTeacher" runat="server" type="text" placeholder="enter teacher name"></asp:TextBox>
                <asp:Button ID="ButtonAdd" runat="server" Text="Add this Product" type="submit" OnClick="ButtonAdd_Click" />
            </div>

            <br />
            <br />

            <h3>Remove a Product in database by its Name =></h3>
            <div>
                <asp:TextBox ID="TextBoxNameRemove" runat="server" type="text" placeholder="enter name"></asp:TextBox>
                <asp:Button ID="ButtonRemove" runat="server" Text="Remove this Product" type="submit" OnClick="ButtonRemove_Click" />
            </div>

        </div>


        <br />
        <br />

        <asp:GridView ID="gridServiceAdmin" runat="server" AutoGenerateColumns="true" ShowFooter="true" Width="50%" CellPadding="10" HorizontalAlign="Center">
        </asp:GridView>

    </form>

</body>
</html>
