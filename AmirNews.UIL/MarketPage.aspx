<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketPage.aspx.cs" Inherits="AmirNews.UIL.MarketPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta charset="UTF-8" />

    <title>Market Page</title>

    <link href="styles/market.css" rel="stylesheet" />
    <link href="styles/bootstrap.min.css" rel="stylesheet" />

    <script src="script/bootstrap.bundle.min.js"></script>
    <script src="script/jquery.slim.min.js"></script>

    <link rel="icon" href="raw/icon.png" />
</head>

<body>


    <div class="py-2 pb-lg-5 hero header ">

        <div class="overlay"></div>

        <div class="align-items-center container">

            <div class="my-3 row">
                <div class="order-lg-0 order-1 mt-3 mt-lg-0 col-12 col-lg-12">
                    <h3 class="hero-description text-center" style="margin-bottom: 24px;">در بین هزاران ساعت آموزش جستجو کنید و به جمع میلیونی
            دانشجویان بپیوندید
                    </h3>
                </div>

            </div>

            <div class="justify-content-center my-3 row hero-description text-center main-statistics-row" style="padding-bottom: 18px;">

                <div class="col-lg-2 col-sm-4">
                    <span class="statistics-number categoriesCount" data-from="0" data-to="" data-refresh-interval="80"
                        data-speed="3000">۱۱۰</span>
                    <span class="statistics-title">حوزه تخصصی
                    </span>
                </div>

                <div class="col-lg-2 col-sm-4">
                    <span class="statistics-number" data-from="0" data-to="" data-refresh-interval="80"
                        data-speed="3000">۴,۸۰۰</span>
                    <span class="statistics-title">عنوان ‌آموزشی
                    </span>
                </div>
                <div class="col-lg-2 col-sm-4">
                    <span class="statistics-number" data-from="0" data-to="" data-refresh-interval="80"
                        data-speed="3000">۱۸,۰۰۰</span>
                    <span class="statistics-title">ساعت آموزش
                    </span>
                </div>
                <div class="col-lg-2 col-sm-4">
                    <span class="statistics-number" data-from="0" data-to="" data-refresh-interval="80"
                        data-speed="3000">۱,۳۰۰,۰۰۰</span>
                    <span class="statistics-title">نفر دانشجو
                    </span>
                </div>

            </div>

        </div>

    </div>

    <div class="container">
        <div class="row">

            <div class="col">
            </div>


        </div>
    </div>


    <form runat="server" style=" padding-bottom:10px ">

        <asp:GridView ID="gridService" runat="server" AutoGenerateColumns="true" ShowFooter="true" Width="50%" CellPadding="10" HorizontalAlign="Center" >

            

        </asp:GridView>

    </form>

</body>

</html>
