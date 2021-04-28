<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQs.aspx.cs" Inherits="LibreriaOnline.FAQs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">

    <div style="text-align:center">
        <h2>Preguntas Frecuentes</h2>
    </div>
    
    <p>
        <asp:GridView runat="server">
        </asp:GridView>
    </p>
    <div class=" container mb-3"> 

        Si no encuentra la pregunta que se le redirigira a

        <a href="Soporte.aspx">
            <span style="color:blue";>Soporte</span>
        </a>
     </div> 

</asp:Content>
