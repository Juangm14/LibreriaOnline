<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="LibreriaOnline.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <h2 class="container">
        Tu carrito de Bookend
    </h2>
    <div class="container">
        <asp:DataList ID="DataList2" runat="server" DataKeyField="ISBN" DataSourceID="SqlDataSource1" RepeatColumns="3"  CssClass="table table-responsive">
            <ItemTemplate>
                <asp:Image ID="Image1" width="140" height="120" runat="server" ImageUrl='<%# Eval("imagen") %>' CssClass="img-fluid" />
                <br />
                <br />
                ISBN:
                <asp:Label ID="ISBNLabel" runat="server" Text='<%# Eval("ISBN") %>' />
                <br />
                autores:
                <asp:Label ID="autoresLabel" runat="server" Text='<%# Eval("autores") %>' />
                <br />
                titulo:
                <asp:Label ID="tituloLabel" runat="server" Text='<%# Eval("titulo") %>' />
                <br />
                editorial:
                <asp:Label ID="editorialLabel" runat="server" Text='<%# Eval("editorial") %>' />
                <br />
                genero:
                <asp:Label ID="generoLabel" runat="server" Text='<%# Eval("genero") %>' />
                <br />
                proveedor:
                <asp:Label ID="proveedorLabel" runat="server" Text='<%# Eval("proveedor") %>' />
                <br />
                Precio:
                <asp:Label ID="PrecioLabel" runat="server" Text='<%# Eval("Precio") %>' />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" CommandName="Seleccionar" OnClick="AgregarCarrito_Click" Text="Agregar al Carrito" CssClass="btn btn-success" />
                <br />
            </ItemTemplate>

        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Libros]"></asp:SqlDataSource>
        </div>
    </asp:Content>
