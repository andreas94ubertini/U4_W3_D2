﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cinema.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="row justify-content-center align-items-center">
            <div class="col-12 text-center mt-3">
                <h2>Effettua il Log-In per poter comprare un ticket</h2>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Username</p>
                <asp:TextBox ID="UsernameBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>

            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Inserisci Password</p>
                <asp:TextBox ID="PasswordBox" TextMode="Password" CssClass="form-control w-50" runat="server"></asp:TextBox>
            </div>
            <div class="col-6 mt-5 d-flex justify-content-center align-items-center">
                <asp:Button ID="ButtonLogin" runat="server" Text="Log-In" CssClass="btn btn-success w-50" OnClick="ButtonLogin_Click" />
                
            </div>
            
        </div>
    </form>
</body>
</html>
