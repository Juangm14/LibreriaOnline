<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Coleccion.aspx.cs" Inherits="LibreriaOnline.Coleccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        <p>
            <asp:Button class="btn-sm btn-success" runat="server" onclick="Nueva_Coleccion" text="Nueva colección"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" runat="server" onclick="Mod_Coleccion" text="Modificar colección"/> &nbsp;
            <asp:Button class="btn-sm btn-danger" runat="server" onclick="Borrar_Coleccion" text="Borrar colección"/>
        </p>

        <p>
            <asp:GridView id="GridColeccion" class="container" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="1058px">
                
                <AlternatingRowStyle BackColor="White" />

                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="Coleccion" SortExpression="Titulo" />
                    <asp:BoundField DataField="titulo" HeaderText="Libros" SortExpression="Libros" />
                </Columns>

                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT c.[nombre], [titulo] FROM [Coleccion] c, [Libros] l, [ColeccionLibros] cl where cl.ISBN=l.ISBN"></asp:SqlDataSource>
        </p>
    </div>
</asp:Content>
