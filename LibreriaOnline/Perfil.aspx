<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="LibreriaOnline.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div style="text-align:center">
        <br />
        <img src="perfil.jpg" style="height: 89px; width: 114px"/>
        <br />
        <asp:Label runat="server">Nick</asp:Label><br />
        <asp:Label runat="server">Nombre</asp:Label> &nbsp;
        <asp:Label runat="server">Apellidos</asp:Label><br />
        <asp:Label runat="server">Telefono</asp:Label><br />
        <asp:Label runat="server">Direccion</asp:Label><br />
        <asp:Label runat="server">Edad</asp:Label><br />
    </div>  
</asp:Content>
