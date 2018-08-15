<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Doviztakipsystem.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <title>Döviz Takip System VER.1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>Döviz Kur Sistemi</h1>
            <img src="img/SEUR.png" />
            <img src="img/SGBP.png" />
            <img src="img/SUSD.png" />

        </div>

        <div class="container">
            <table class="table">
                <tr>
                    <td>Dolar</td>
                    <td>Alış
                        <asp:Label ID="dolaral" runat="server" Text="-"></asp:Label>
                    </td>
                    <td>Satış
                        <asp:Label ID="dolarsat" runat="server" Text="-"></asp:Label></td>
                </tr>
                <tr>
                    <td>ingiliz Sterlin</td>
                    <td>Alış
                        <asp:Label ID="euroal" runat="server" Text="-"></asp:Label>
                    </td>
                    <td>Satış
                        <asp:Label ID="eurosat" runat="server" Text="-"></asp:Label></td>
                </tr>

            </table>
        </div>
        <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="4000">
        </asp:Timer>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </form>
</body>
</html>
