<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="AmirNews.UIL.LoginPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Login Page</title>
    <link href="styles/login.css" rel="stylesheet" />
    <link rel="icon" href="raw/icon.png" />

</head>

<body>

    <h2>به امیر مارکت خوش آمدید</h2>
    <h4>ادمین میتواند با نام کاربری و رمز عبور 'root' وارد شود</h4>

    <form runat="server">
        <div class="imgcontainer">
            <img src="raw/img_avatar.png" alt="Avatar" class="avatar">
        </div>

        <div class="container">
            <label for="uname"><b>نام کاربری</b></label>
            <asp:TextBox ID="txtUserName" runat="server" type="text" placeholder="نام کاربری را وارد کنید" name="uname" required></asp:TextBox>

            <br />
            <br />

            <label for="psw"><b>رمز عبور</b></label>
            <asp:TextBox ID="txtPassword" runat="server" type="password" placeholder="رمز عبور را وارد کنید" name="psw" required></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="وارد شوید" type="submit" OnClick="btnSubmit_Click"/>

        </div>

    </form>

</body>
</html>
