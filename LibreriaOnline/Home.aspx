<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LibreriaOnline.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        

        <p>
            <asp:GridView runat="server">
            </asp:GridView>
        </p>
    </div>
</asp:Content>
