<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Relatos.aspx.cs" Inherits="LibreriaOnline.Relatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
        <div class="container">
        <p>
            <asp:Button class="btn-sm btn-success" runat="server" onclick="Unnamed_Click" text="Nuevo relato"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" runat="server" OnClick="Unnamed_Click1" text="Modificar relato"/> &nbsp;
            <asp:Button class="btn-sm btn-danger " runat="server" OnClick="Unnamed_Click2" text="Borrar relato"/>
        </p>

        <p>
            <asp:GridView runat="server">
            </asp:GridView>
        </p>
    </div>
</asp:Content>
