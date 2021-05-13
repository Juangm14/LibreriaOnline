<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BorrarColeccion.aspx.cs" Inherits="LibreriaOnline.BorrarColeccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <p>
        Nombre Coleccion: <asp:TextBox id="borrarColeccion"  TextMode="SingleLine" Columns="30" runat="server" ></asp:TextBox>
    </p>

    <p>
        <asp:button runat="server" Text="Borrar"/>
    </p>
       
</asp:Content>
