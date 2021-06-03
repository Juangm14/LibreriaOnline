<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Recomendaciones.aspx.cs" Inherits="LibreriaOnline.Recomendaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
     <div class ="container mb-3" >
     <h3>
         Los libros recomendados por la Crítica:
     </h3>
    <br />
     <asp:GridView runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
            <asp:BoundField DataField="autores" HeaderText="autores" SortExpression="autores" />
            <asp:BoundField DataField="genero" HeaderText="genero" SortExpression="genero" />
            <asp:BoundField DataField="nota" HeaderText="nota" SortExpression="nota" />
        </Columns>
        
         <EditRowStyle BackColor="#999999" />
         <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
         <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
         <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
         <SortedAscendingCellStyle BackColor="#E9E7E2" />
         <SortedAscendingHeaderStyle BackColor="#506C8C" />
         <SortedDescendingCellStyle BackColor="#FFFDF8" />
         <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        
    </asp:GridView>
    
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Libros.titulo, Libros.autores, Libros.genero, Critica.nota FROM Libros INNER JOIN Critica ON Libros.ISBN = Critica.ISBN  ORDER BY Critica.Nota DESC"></asp:SqlDataSource>
    
        <br />   
     <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
         <br />

    <asp:DropDownList id="ListaLibros" runat="server" Height="32px" Width="200px" DataSourceID="SqlDataSource3" DataTextField="Genero" DataValueField="Genero">
         </asp:DropDownList>
         <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [genero] FROM [Libros]"></asp:SqlDataSource>
    
         <br />
         <br />
        <p>
            <asp:Button class="btn-sm btn-success" id="NuevaReco" runat="server" onclick="BuscReco" text="Buscar por género"/> &nbsp;
        </p>    
     </div>
</asp:Content>
