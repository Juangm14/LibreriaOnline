<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Criticas.aspx.cs" Inherits="LibreriaOnline.Criticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
        <div class="container">
        <p>
            <asp:Button class="btn-sm btn-success" runat="server" onclick="Unnamed_Click" text="Nueva critica"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" runat="server" onclick="Unnamed_Click1" text="Modificar critica"/> &nbsp;
            <asp:Button class="btn-sm btn-danger " runat="server" onclick="Unnamed_Click2" text="Borrar critica"/>
        </p>

        <p>
            <asp:GridView runat="server">
            </asp:GridView>
        </p>
    </div>
</asp:Content>
