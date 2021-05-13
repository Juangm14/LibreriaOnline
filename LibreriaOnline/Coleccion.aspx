<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Coleccion.aspx.cs" Inherits="LibreriaOnline.Coleccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        <p>
            <asp:Button class="btn-sm btn-success" runat="server" onclick="Unnamed_Click" text="Nueva colección"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" runat="server" onclick="Unnamed_Click1" text="Modificar colección"/> &nbsp;
            <asp:Button class="btn-sm btn-danger" runat="server" onclick="Unnamed_Click2" text="Borrar colección"/>
        </p>

        <p>
            <asp:GridView runat="server">
            </asp:GridView>
        </p>
    </div>
</asp:Content>
