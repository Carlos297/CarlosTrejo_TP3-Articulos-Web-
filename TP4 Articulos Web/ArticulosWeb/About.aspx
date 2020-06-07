<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ArticulosWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>--%>


    <h2>Carrito de Compras</h2>


    <div class="jumbotron">

        <h3 align="right">Articulos en el carrito:  <% = carritoCompras.Count() %>  </h3>
        <table class="table">
            <tr>
                <td></td>
                <td>
                    <h4>Nombre </h4>
                </td>
                <td><h4>Descripción</h4> </td>
                <td><h4>Precio Unitario </h4> </td>
                <td><h4>Acción </h4></td>




            </tr>

            <% foreach (var item in carritoCompras)
                {
                    total = total + item.Precio;
            %>

            <tr>
                <td>
                    <img src="<% = item.imagUrl %>" width="100" height="100">
                </td>
                <td class="lead"><% = item.NombreProducto %>  </td>
                <td class="lead"><% = item.Descripcion %>  </td>

                <td class="lead">$ <% = decimal.Round(item.Precio,2) %> </td>

                <td>
                    <%--<a id="btnSumar<% = item.Id %>" href="About.aspx?idArt=<% = item.Id.ToString() %>" class="btn btn-primary" role="button">+</a>
                        <a id="btnRestar<% = item.Id %>" href="About.aspx?idArt=<% = item.Id.ToString() %>" class="btn btn-primary" role="button">-</a>--%>
                    <a href="About.aspx?idQuitar=<% = item.Id.ToString() %>" class="btn btn-danger">Eliminar</a>


                </td>


            </tr>


            <% } %>
        </table>



        <h2 align="right">Total:  $<% = decimal.Round(total,2) %> </h2>




    </div>

    <div class="progress progress-striped active">
        <div class="progress-bar" role="progressbar"
            aria-valuenow="75" aria-valuemin="0" aria-valuemax="100"
            style="width: 75%">
            <span class="sr-only">75% completado</span>
        </div>
    </div>

    <a href="Default.aspx" class="btn btn-primary btn-lg">Continuar Comprando</a>



</asp:Content>
