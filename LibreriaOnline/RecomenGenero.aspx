<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RecomenGenero.aspx.cs" Inherits="LibreriaOnline.RecomenGenero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
     <div class ="container mb-3" >
     <asp:Label ID="Label2" runat="server" Font-Bold ="true" Font-Size ="X-Large" Text=""></asp:Label>
      <br />   
      <br />          

       <asp:GridView runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
        <Columns>
            <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
            <asp:BoundField DataField="autores" HeaderText="autores" SortExpression="autores" />
            <asp:BoundField DataField="genero" HeaderText="genero" SortExpression="genero" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
        </Columns>
        
         <FooterStyle BackColor="#CCCCCC" />
         <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
         <RowStyle BackColor="White" />
         <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
         <SortedAscendingCellStyle BackColor="#F1F1F1" />
         <SortedAscendingHeaderStyle BackColor="#808080" />
         <SortedDescendingCellStyle BackColor="#CAC9C9" />
         <SortedDescendingHeaderStyle BackColor="#383838" />
        
    </asp:GridView>
    
     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [titulo], [autores], [genero], [Precio] FROM [Libros] WHERE ([genero] = @genero)">
         <SelectParameters>
             <asp:QueryStringParameter DefaultValue="NULL" Name="genero" QueryStringField="genero" Type="String" />
         </SelectParameters>
     </asp:SqlDataSource>
    <br /> 
      <p>
            <asp:Button class="btn-sm btn-success" id="Back" runat="server" onclick="PaVolver" text="Volver"/> &nbsp;
        </p>   
  <br /> 
    </div>
</asp:Content>
