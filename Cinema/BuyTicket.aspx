<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuyTicket.aspx.cs" Inherits="Cinema.BuyTicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="row">
            <div class="col-12 text-center mt-4">
                <h2 id="user" runat="server"></h2>
            </div>
            <div class="col-12 d-flex flex-column align-items-center gap-4 mt-3">
                <asp:DropDownList CssClass="form-select" ID="RoomSelectionList" runat="server" OnSelectedIndexChanged="RoomSelectionList_SelectedIndexChanged">
                    <asp:ListItem Value="0" Text="Sala Nord"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Sala Sud"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Sala Est"></asp:ListItem>
                </asp:DropDownList>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault" runat="server"/>
                    <label class="form-check-label" for="flexCheckDefault">
                        Prezzo ridotto?
                    </label>
                </div>
                <asp:Button ID="Confirm" runat="server" Text="Conferma Biglietto" OnClick="Confirm_Click" CssClass="btn btn-success" />
            </div>
            <div class="col-12 d-flex flex-column align-items-center mt-5">
                <h3>Ecco il riassunto di tutti i biglietti
                </h3>
                <div id="desc" runat="server" class="w-75">
                </div>
            </div>
            <div class="col-12 text-center">
                <asp:Button ID="Logout" runat="server" Text="Log-Out" onclick="Logout_Click" CssClass="btn btn-danger w-50 mt-5"/>
            </div>
        </div>
    </form>
</body>
</html>
