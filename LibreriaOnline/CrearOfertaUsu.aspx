<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CrearOfertaUsu.aspx.cs" Inherits="LibreriaOnline.CrearOfertaUsu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">

      <div class="container">
            ISBN
            <asp:TextBox id="TextBoxISBN"  runat="server" class="form-control" placeholder="Introduzca el ISBN del libro a vender."></asp:TextBox>
            Precio
            &nbsp;
            <asp:TextBox id="TextBoxPrecio"  runat="server" class="form-control" placeholder="Introduzca el precio de la oferta."></asp:TextBox>
            <asp:Button class="btn-sm btn-success" id="NuevaOferta" runat="server" onclick="NuevaOfertaClick" text="Crear oferta"/> 
            <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
            <asp:Label ID="problema" runat="server" Text="Label"></asp:Label> 
            <asp:Label id="mensajeSession" runat="server">
            <a href="SignIn.aspx" style="color:blue">aquí.</a>
            </asp:Label>
            <a ID="volver" href="VentaEntreUsuarios.aspx">
            <span style="color:blue";>Volver</span>
        </a>
        </div>
        <p>
          
        </p>
</asp:Content>
