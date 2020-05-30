<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ArticulosWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>


    <div class="jumbotron">


        <div class="card-columns" style="margin-left: 5px; margin-right: 5px;">

            <%--<asp:Repeater runat="server" ID="repetidor" OnItemCommand="repetidor_ItemCommand">
            <ItemTemplate>
                <div class="card">
                    <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre")%></h5>
                        <p class="card-text"><%#Eval("Descripcion")%></p>
                    </div>
                    <a class="btn btn-primary" href="PokemonDetail.aspx?idpkm=<%#Eval("IdArt")%>">Seleccionar</a>
                    <asp:Button ID="btnArgumento" CssClass="btn btn-primary" Text="Argumento to Back" CommandArgument='<%#Eval("IdArt")%>' CommandName="idPokemon" runat="server" OnClick="btnArgumento_Click" />
                </div>
            </ItemTemplate>
        </asp:Repeater>--%>


            <% foreach (var item in listaArticulos)
                { %>
            <div class="card" style="width: 60%;">
                <img src="<% = item.ImagenURL %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><% = item.Nombre %></h5>
                    <%--<p class="card-text"><% = item.Marca.Descripcion %></p>--%>
                    <a href="Contact.aspx?idArt=<% = item.Id.ToString() %>" class="btn btn-primary">Ver Detalles</a>
                </div>
            </div>
            <% } %>

           


            <%-- Esto reemplaza el foreach. Vean que cambia la forma de pasar el argumento a cada tag.
            En este caso se usa el numeral (#) y la función Eval que recibe por parámetro como string
            el nombre de la property de tu objeto. El repeater va a iterar lo que esté dentro de la colección
             que le asignamos en el LOAD. Se lo asignamos directamente por ID, en este caso, repetidor.--%>


                    <%--<asp:Repeater runat="server" ID="repetidor" OnItemCommand="repetidor_ItemCommand">
            <ItemTemplate>
                <div class="card">
                    <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre")%></h5>
                        <p class="card-text"><%#Eval("Descripcion")%></p>
                    </div>
                    <a class="btn btn-primary" href="PokemonDetail.aspx?idpkm=<%#Eval("IdArt")%>">Seleccionar</a>
                    <asp:Button ID="btnArgumento" CssClass="btn btn-primary" Text="Argumento to Back" CommandArgument='<%#Eval("IdArt")%>' CommandName="idPokemon" runat="server" OnClick="btnArgumento_Click" />
                </div>
            </ItemTemplate>
        </asp:Repeater>--%>
        </div>

         
    </div>


    <a href="About.aspx<%  %>" class="btn btn-primary">Ir a ver el Carrito</a>


    <asp:TextBox ID="txtFiltro" runat="server" Width="223px"></asp:TextBox>

</asp:Content>
