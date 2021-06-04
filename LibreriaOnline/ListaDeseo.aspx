<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListaDeseo.aspx.cs" Inherits="LibreriaOnline.ListaDeseo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .nuevoEstilo1 {
            font-family: "Times New Roman", Times, serif;
        }
        .nuevoEstilo1 {
            font-family: "Times New Roman", Times, serif;
            line-height: 10px;
            vertical-align: 0%;
            background-color: #800000;
            border-style: solid;
            border-width: thin;
            color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
   
    <div class ="container mb-3" >
     <h1>
         <span class="nuevoEstilo1">&nbsp;&nbsp;
        TÚ LISTA DE DESEADOS&nbsp;&nbsp; </span>
    </h1>
        <br />
    <asp:GridView runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
            <asp:BoundField DataField="autores" HeaderText="autores" SortExpression="autores" />
            <asp:BoundField DataField="genero" HeaderText="genero" SortExpression="genero" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT titulo, autores, genero FROM [ListaDeseo], [Libros] where ListaDeseo.ISBN = Libros.ISBN"></asp:SqlDataSource>
    <div class="mb-3">
         <asp:label id="LabelNuevoLibro" runat="server">Libro</asp:label>&nbsp; 
                
         <asp:DropDownList id="ListaLibros" runat="server" Height="32px" Width="200px" DataSourceID="SqlDataSource3" DataTextField="Titulo" DataValueField="Titulo">
         </asp:DropDownList>
         <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [titulo] FROM [Libros]"></asp:SqlDataSource>
    </div>
    &nbsp;
           
         <p>
            <asp:Button class="btn-sm btn-success" id="NuevoLibroDeseo" runat="server" onclick="Anyadir_Click" text="Añadir Libro"/> &nbsp;
            <asp:Button class="btn-sm btn-danger " id="DesplegarEliminacion" runat="server" onclick="EliminarLibro" text="Eliminar Libro"/>
        </p>
    </div>

</asp:Content>
