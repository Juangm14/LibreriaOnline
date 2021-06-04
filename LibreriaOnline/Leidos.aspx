<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Leidos.aspx.cs" Inherits="LibreriaOnline.Leidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        <p>
            <asp:Button ID="NuevoLibroLeido" class="btn-sm btn-success" runat="server" onclick="Libro_Leido" text="Marcar Libro como leído"/> &nbsp;
            <asp:Button ID="ModLibroLeido" class="btn-sm btn-warning" runat="server" onclick="Mod_Libro_Leido" text="Modificar Puntuaciones"/> &nbsp;
            <asp:Button ID="ElimLibroLeido" class="btn-sm btn-danger" runat="server" onclick="Libro_No_Leido" text="Quitar Libro como leído"/> &nbsp;
        </p>

    </div>
</asp:Content>
