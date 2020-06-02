YÖNETİCİ GİRİŞİ İÇİN KOMUT DOSYALARI:
YÖNETİCİ LOGİN SAYFASI:
@model mvcbir.Models.Entity.PERSONEL
    @{
        Layout = null;
    }

    <!--
    Author: W3layouts
    Author URL: http://w3layouts.com
    License: Creative Commons Attribution 3.0 Unported
    License URL: http://creativecommons.org/licenses/by/3.0/
    -->
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <title>YOBÜPARK</title>
        <!-- Meta-Tags -->
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta charset="utf-8">
        <meta name="keywords" content="Business Login Form a Responsive Web Template, Bootstrap Web Templates, Flat Web Templates, Android Compatible Web Template, Smartphone Compatible Web Template, Free Webdesigns for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design">
        <script>
        addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
        </script>
        <!-- //Meta-Tags -->
        <!-- css files -->
        <link href="~/Web/web/css/font-awesome.min.css" rel="stylesheet" type="text/css" media="all">
        <link href="~/Web/web/css/style.css" rel="stylesheet" type="text/css" media="all" />
        <!-- //css files -->
        <!-- google fonts -->
        <link href="//fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">
        <!-- //google fonts -->

    </head>
    <body>

        <div class="signupform">
            <div class="container">
                <!-- main content -->
                <div class="agile_info">
                    <div class="w3l_form">
                        <div class="left_grid_info">

                            <h1>YOBÜPARKA HOŞGELDİNİZ!</h1>
                            <p></p>
                            <p></p>
                            <p></p>
                            <p></p>
                            <p></p>
                            <p></p>
                            <p>YÖNETİCİ GİRİŞİ</p>
                            <img src="~/Web/web/images/" alt="" />
                        </div>
                    </div>
                    <div class="w3_info">
                        <h2>YÖNETİCİ HESABINA GİRİŞ YAP</h2>
                        <p>Bilgilerinizi Giriniz.</p>

                        @using (Html.BeginForm("GİRİSYAP", "GÜVENLİK", FormMethod.Post))
                        {
                            <label>Email Adresi</label>
                            <div class="input-group">
                                <span class="fa fa-envelope" aria-hidden="true"></span>
                                <input type="email" placeholder="Enter Your Email" required="" name="yöneticiad">
                            </div>
                            <label>Şifre</label>
                            <div class="input-group">
                                <span class="fa fa-lock" aria-hidden="true"></span>
                                <input type="Password" placeholder="Enter Password" required="" name="yöneticisifre">
                            </div>
                            <div class="login-check">
                                <label class="checkbox"><input type="checkbox" name="checkbox" checked=""><i> </i> BENİ HATIRLA.</label>
                            </div>
                            <button class="btn btn-danger btn-block" type="submit">GİRİŞ YAP</button>
                        }
                        @*<p class="account">BİZİMLE İLETİŞİM KUR.<a href="#">YOBÜ OTOPARK</a></p>*@
                        @*<p class="account1">BİR HESABIN YOK MU? <a href="#">BURADAN KAYDOL</a></p>*@
                    </div>
                </div>
                <!-- //main content -->
            </div>
            <!-- footer -->
            <div class="footer">
                @*<p>&copy; 2019 Business login form. All Rights Reserved | Design by <a href="https://w3layouts.com/" target="blank">W3layouts</a></p>*@
            </div>
            <!-- footer -->
        </div>

    </body>
</html>





PARK BİLGİLERİ SAYFASININ KOMUT DOSYASI:
@using mvcbir.Models.Entity
@model List<PARKBILGISI>

@{
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
}


<table class="table table-bordered">
    <tr>
        <th>PARK YERİ NUMARASI</th>
        <th>PARK BİLGİSİ DURUMU</th>


    </tr>
    <tbody>
        @foreach(var parkbil in Model)
        {
            <tr>
                <td>@parkbil.parkID</td>
                <td>@parkbil.parkbilgisi1</td>
            </tr>
        }



    </tbody>


</table>

ARAÇ GİRİŞ/ÇIKIŞ SAYFASININ KOMUT DOSYALARI:
@using mvcbir.Models.Entity
@model List<ARACGİRCIK>

@{
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
}

<table class="table table-bordered">
    <tr>
        @*<th>OTOPARK ID</th>*@
        <th>PARK YERİ NUMARASI </th>
        <th>MÜŞTERİ AD</th>
        <th>MÜŞTERİ SOYAD</th>
        <th>MÜŞTERİ PLAKA</th>
        <th>ARAÇ GİRİŞ TARİHİ</th>
        <th>ARAÇ ÇIKIŞ TARİHİ</th>
        <th>ARAÇ GİRİŞ SAATİ</th>
        <th>ARAÇ ÇIKIŞ SAATİ</th>

    </tr>
    <tbody>
        @foreach(var aracgir in Model)
        {
            <tr>
                @*<td>@aracgir.otoid</td>*@
                <td>@aracgir.otoyerid</td>
                <td>@aracgir.otomüsteriad</td>
                <td>@aracgir.otomüsterisoyad</td>
                <td>@aracgir.otomüsteriplaka</td>
                <td>@aracgir.aracgiristarihi</td>
                <td>@aracgir.araccıkıstarihi</td>
                <td>@aracgir.aracgirissaat</td>
                <td>@aracgir.araccıkıssaat</td>
            </tr>
        }
    </tbody>
</table>


OTOPARK ÜCRET BİLGİSİNİN TUTULDUĞU KOMUT SATIRI:
@using mvcbir.Models.Entity
@model List<ÜCRET>
@{
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
}

<table class="table table-bordered">
    <tr>
        @*<th>ÜCRET ID</th>*@
        <th>MÜŞTERİ ADI VE SOYADI</th>
        <th>ARAÇ GİRİŞ TARİHİ</th>
        <th>ARAÇ ÇIKIŞ TARİHİ</th>
        <th>SAAT </th>
        <th>TUTAR</th>
        

    </tr>
    <tbody>
        @foreach (var ücrt in Model)
        {
            <tr>
                @*<td>@ücrt.ücretid</td>*@
                <td>@ücrt.müsterid</td>
                <td>@ücrt.giristarihi</td>
                <td>@ücrt.cikistarihi</td>
                <td>@ücrt.saat</td>
                <td>@ücrt.tutar</td>
                
            </tr>
        }
    </tbody>


</table>

MÜŞTERİ SAYFASININ LİSTELENDİĞİ KOMUT SATIRI:
@using mvcbir.Models.Entity
@model List<MÜSTERI>
@{
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
}

<table class="table table-bordered">
    <tr>
        @*<th>MÜŞTERİ NUMARASI</th>*@
        <th>MÜŞTERİ AD</th>
        <th>MÜŞTERİ SOYAD</th>
        <th>MÜŞTERİ TC NO </th>
        <th>MÜŞTERİ TELEFON NUMARASI</th>
        <th>MÜŞTERİ ARAÇ PLAKASI</th>
        @*<th>SİL</th>
        <th>GÜNCELLE</th>*@
        

    </tr>
    <tbody>
        @foreach (var müstr in Model)
        {
        <tr>
            @*<td>@müstr.müsteriid</td>*@
            <td>@müstr.müsteriad</td>
            <td>@müstr.müsterisoyad</td>
            <td>@müstr.müsteritcno</td>
            <td>@müstr.müsteritel</td>
            <td>@müstr.müsteriplaka</td>
            @*<td><a href="/MÜSTERİ/SİL/@müstr.müsteriid" class="btn btn-danger">SİL</a></td>
            <td><a href="/MÜSTERİ/GÜNCELLE/@müstr.müsteriid" class="btn btn-success">GÜNCELLE</a></td>*@
        </tr>
        }
    </tbody>


</table>


PERSONELLERİN LİSTELENDİĞİ SAYFANIN KOMUT DOSYALARI:
@using mvcbir.Models.Entity
@model List<PERSONEL>
@{
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
}


<table class="table table-bordered">
    <tr>
        @*<th>PERSONEL ID</th>*@
        <th>PERSONEL AD</th>
        <th>PERSONEL SOYAD</th>
        <th>PERSONEL TC NO </th>
        <th>PERSONEL TELEFON NUMARASI</th>
        @*<th>PERSONEL ŞİFRESİ</th>*@
        <th>SİL</th>
        <th>GÜNCELLE</th>

    </tr>
    <tbody>
        @foreach (var per in Model)
        {
            <tr>
                @*<td>@per.personelid</td>*@
                <td>@per.personelad</td>
                <td>@per.personelsoyad</td>
                <td>@per.personeltcno</td>
                <td>@per.personeltel</td>
                @*<td>@per.personelsifre</td>*@
                <td><a href="/PERSONEL/SİL/@per.personelid" class="btn btn-danger">SİL</a></td>
                <td><a href="/PERSONEL/PERSONELGETİR/@per.personelid" class="btn btn-success ">GÜNCELLE</a></td>

            </tr>
            }
    </tbody>


</table>
<a href="/PERSONEL/YENİPERSONEL/" class="btn btn-primary">YENİ PERSONEL EKLE</a>
PERSONEL EKLEME/SİLME/GÜNCELLEME SAYFALARININ KOMUT DOSYALARI:
YENİ PERSONEL SİLME/GÜNCELLEME SAYFASI:
@model mvcbir.Models.Entity.PERSONEL
@{
    ViewBag.Title = "PERSONELGETİR";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
}

@using (Html.BeginForm("GÜNCELLE", "PERSONEL", FormMethod.Post))
{
<div class="form-group ">
    PERSONEL NUMARASI
    @Html.TextBoxFor(p => p.personelid, new { @class = "form-control" })
    <br />
    PERSONEL ADI

    @Html.TextBoxFor(p => p.personelad, new { @class = "form-control" })
    <br />
    PERSONEL SOYADI

    @Html.TextBoxFor(p => p.personelsoyad, new { @class = "form-control" })
    <br />
    PERSONEL TC NO

    @Html.TextBoxFor(p => p.personeltcno, new { @class = "form-control" })
    <br />
    PERSONEL TELEFON

    @Html.TextBoxFor(p => p.personeltel, new { @class = "form-control" })
    <br />
    PERSONEL ŞİFRE

    @Html.TextBoxFor(p => p.personelsifre, new { @class = "form-control" })

</div>
    <div>
        <button class="btn btn-warning">PERSONEL GÜNCELLE</button>
    </div>

}

YENİ PERSONEL EKLEME SAYFASININ KOMUT SATIRI:
@model mvcbir.Models.Entity.PERSONEL
@{
    ViewBag.Title = "YENİPERSONEL";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
}

<form class="form-group " method="post">
    <div>
        <label>PERSONEL AD</label>
        <input type="text" class="form-control" name="PERSONELAD" required="" />
    </div>
    <div>
        <label>PERSONEL SOYAD</label>
        <input type="text" class="form-control" name="PERSONELSOYAD" required="" />
    </div>
    <div>
        <label>PERSONEL TC NO</label>
        <input type="text" class="form-control" name="PERSONELTCNO" required=""/>
    </div>
    <div>
        <label>PERSONEL TELEFON NO</label>
        <input type="text" class="form-control" name="PERSONELTELEFONNO" required="" />
    </div>
    

    <div style="margin-top:15px">
        <button class="btn btn-info " id="btn1">PERSONEL EKLE </button>
    </div>
    <script>
        $('#btn1').click(function () {
            alert('PERSONEL EKLEME İŞLEMİ YAPILDI...');
        }
        );
    </script>
</form>





