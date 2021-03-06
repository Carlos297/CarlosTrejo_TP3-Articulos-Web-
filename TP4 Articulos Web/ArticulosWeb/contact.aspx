﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="ArticulosWeb.Contact" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%--<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>--%>

    <div class="jumbotron">

        <div class="card" style="width: 25%">
            <img src="<% = articulo.ImagenURL %>" class="card-img-top" alt="..." wight="190" height="190">
            <div class="card-body">
                <h5 class="card-title" align="center"><% = articulo.Nombre %></h5>
                <p class="card-text" align="center"><% = articulo.Descripcion %></p>
                <p class="card-text" align="center"><% = articulo.Marca.Descripcion %></p>
                <p class="card-text" align="center"><% = articulo.Categoria.Descripcion %></p>
                <p class="card-text" align="center">$ <% = decimal.Round(articulo.Precio,2) %></p>


            </div>


        </div>
    </div>

    <div class="progress progress-striped active">
        <div class="progress-bar" role="progressbar"
            aria-valuenow="25" aria-valuemin="0" aria-valuemax="100"
            style="width: 25%">
            <span class="sr-only">25% completado</span>
        </div>
    </div>

    <a href="Default.aspx" class="btn btn-primary btn-lg">Regresar al Listado</a>

</asp:Content>
