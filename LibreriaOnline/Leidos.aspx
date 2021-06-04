<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Leidos.aspx.cs" Inherits="LibreriaOnline.Leidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        <p>
            <asp:Button ID="NuevoLibroLeido" class="btn-sm btn-success" runat="server" onclick="Libro_Leido" text="Marcar Libro como leído"/> &nbsp;
            <asp:Button ID="ModLibroLeido" class="btn-sm btn-warning" runat="server" onclick="Mod_Libro_Leido" text="Modificar Puntuaciones"/> &nbsp;
            <asp:Button ID="ElimLibroLeido" class="btn-sm btn-danger" runat="server" onclick="Libro_No_Leido" text="Quitar Libro como leído"/> &nbsp;
        </p>
    </div>

    <div class="container">
        <p>
            <asp:label id="LabelLibro" runat="server">Libro:</asp:label>&nbsp; 
                
            <asp:DropDownList id="ListaLibros" runat="server" Height="32px" Width="200px" DataSourceID="SqlDataSource" DataTextField="Titulo" DataValueField="Titulo">
            </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [titulo] FROM [Libros]"></asp:SqlDataSource>
        </p>

        <p>
            <asp:label id="LabelNota" runat="server">Nota:</asp:label>&nbsp; 
                
           <asp:DropDownList id="ListaPuntuacion" runat="server" Height="30px" Width="51px">
                      <asp:ListItem>1</asp:ListItem>
                      <asp:ListItem>2</asp:ListItem>
                      <asp:ListItem>3</asp:ListItem>
                      <asp:ListItem>4</asp:ListItem>
                      <asp:ListItem>5</asp:ListItem>
                      <asp:ListItem>6</asp:ListItem>
                      <asp:ListItem>7</asp:ListItem>
                      <asp:ListItem>8</asp:ListItem>
                      <asp:ListItem>9</asp:ListItem>
                      <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList>
        </p>

        <p>
            <asp:label id="Msg" runat="server"></asp:label>
        </p>
    </div>
        <p>
            <asp:GridView id="GridLeidos" class="container" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="1058px">
                
                <AlternatingRowStyle BackColor="White" />

                <Columns>
                    <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                    <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                    <asp:BoundField DataField="Nota" HeaderText="Nota" SortExpression="Nota" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT le.[ISBN], li.[titulo], le.[Nota] FROM [Libros] li, [Leidos] le where le.ISBN=li.ISBN"></asp:SqlDataSource>
        </p>
</asp:Content>
