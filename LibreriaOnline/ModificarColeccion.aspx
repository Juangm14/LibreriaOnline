<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarColeccion.aspx.cs" Inherits="LibreriaOnline.ModificarColeccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        <p>
            Nombre Coleccion: <asp:TextBox id="Mod1"  TextMode="SingleLine" Columns="30" runat="server" ></asp:TextBox>
        </p>
        <p>
            Nuevo Nombre: <asp:TextBox id="Mod2"  TextMode="SingleLine" Columns="30" runat="server" ></asp:TextBox>
        </p>
        <p>
            <asp:button runat="server" onclick="Modificar_Coleccion" Text="Modificar"/>
        </p>
        <p>
            <asp:Label ID="Label" runat="server"> </asp:Label>
        </p> 
    </div> 
</asp:Content>
