<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NuevaColeccion.aspx.cs" Inherits="LibreriaOnline.NuevaColeccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        <p>
            Nombre: <asp:TextBox id="cp"  TextMode="SingleLine" Columns="30" runat="server" ></asp:TextBox>
        </p>
        <p>
            Libros: <asp:TextBox id="pass" Columns="30" runat="server" />
        </p>
    </div>
</asp:Content>
