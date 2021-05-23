﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Libros.aspx.cs" Inherits="LibreriaOnline.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
        <div class="container">
        <p>
            <asp:Button class="btn-sm btn-success" ID="NuevoLibro" runat="server" onclick="NuevoLibro_Click" text="Nuevo libro"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" ID="EditarLibro" runat="server" onclick="EditarLibro_Click" text="Modificar libro"/> &nbsp;
            <asp:Button class="btn-sm btn-danger " ID="BorrarLibro" runat="server" onclick="BorrarLibro_Click" text="Borrar libro"/>
        </p>

        <div id="FormularioCreacionLibro" class="container">
            <div class="mb-1">
              <asp:label runat="server" id="GeneroLibro" for="exampleFormControlInput3" class="form-label">Genero</asp:label>
                <br />
              <asp:DropDownList id="GeneroDesplegable" runat="server">
                  <asp:ListItem>Personal</asp:ListItem>
                  <asp:ListItem>Ciencia Ficción</asp:ListItem>
                  <asp:ListItem>Aventura</asp:ListItem>
                  <asp:ListItem>Intriga</asp:ListItem>
                  <asp:ListItem>Histórico</asp:ListItem>
                  <asp:ListItem>Terror</asp:ListItem>
                  <asp:ListItem>Otros</asp:ListItem>
              </asp:DropDownList>
            </div>

            <div class="mb-3">
                <asp:label runat="server" id="LabelTitulo" for="exampleFormControlInput1" class="form-label">Titulo</asp:label>
                <asp:TextBox runat="server" class="form-control" id="TextBox1" placeholder="Introduce el título del libro" TextMode="SingleLine"></asp:TextBox>
                <asp:label runat="server" id="ISBN" for="exampleFormControlInput1" class="form-label">ISBN</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextISBN" placeholder="Introducir ISBN"></asp:TextBox>
                <asp:label runat="server" id="Autores" for="exampleFormControlInput1" class="form-label">Autores</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextAutores" placeholder="Introducir autor/es"></asp:TextBox>
                <asp:label runat="server" id="Titulo" for="exampleFormControlInput1" class="form-label">Titulo</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextTitulo" placeholder="Introducir titulo"></asp:TextBox>
                <asp:label runat="server" id="Editorial" for="exampleFormControlInput1" class="form-label">Editorial</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextEditorial" placeholder="Introducir Editorial"></asp:TextBox>
                <asp:label runat="server" id="Genero" for="exampleFormControlInput1" class="form-label">Genero</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextGenero" placeholder="Introducir Genero"></asp:TextBox>
                <asp:label runat="server" id="Proveedor" for="exampleFormControlInput1" class="form-label">Proveedor</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextProveedor" placeholder="Introducir Proveedor"></asp:TextBox>
                <asp:label runat="server" id="Precio" for="exampleFormControlInput1" class="form-label">Precio</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextPrecio" placeholder="Introducir Precio"></asp:TextBox>
                <asp:Button runat="server" ID="Boton_crearLibro" text="Crear libro" OnClick="Boton_crear" class="btn-sm mt-2 btn-success" />
                <asp:Label runat="server" ID="LabelCrear" />

            </div>
           
        </div>


    </div>
</asp:Content>
