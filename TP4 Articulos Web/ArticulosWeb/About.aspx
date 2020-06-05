<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ArticulosWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>--%>


    <h2>Carrito de Compras</h2>


    <div class="jumbotron">


        <table class="table">
            <tr>
                <td>Nombre </td>
                <td>Codigo Producto </td>
                <td>Imagen </td>
                <td>Precion Unitario </td>
                <td>Acción </td>



            </tr>

            <% foreach (var item in carritoCompras)
                {
            %>

            <tr>
                <td><% = item.NombreProducto %>  </td>
                <td><% = item.CodigoProducto %>  </td>
                <td>
                    <img src="<% = item.imagUrl %>" width="100" height="100">
                </td>

                <td>$ <% = item.Precio %> </td>

                <td>
                    <%--<a id="btnSumar<% = item.Id %>" href="About.aspx?idArt=<% = item.Id.ToString() %>" class="btn btn-primary" role="button">+</a>
                        <a id="btnRestar<% = item.Id %>" href="About.aspx?idArt=<% = item.Id.ToString() %>" class="btn btn-primary" role="button">-</a>--%>
                    <a href="About.aspx?idQuitar=<% = item.Id.ToString() %>" class="btn btn-primary">Eliminar</a>
                    
                   
                </td>
                

            </tr>
                

            <% } %>
        </table>

        <a href="Default.aspx" class="btn btn-primary">Continuar Comprando</a>
        <h3>Articulos en el carrito:  <% = carritoCompras.Count() %>  </h3>
        <h3>Total a Pagar:  <%   %>  </h3>
        



    </div>














</asp:Content>
