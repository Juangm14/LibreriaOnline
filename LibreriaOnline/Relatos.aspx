<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Relatos.aspx.cs" Inherits="LibreriaOnline.Relatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container mb-3">
        <asp:Label runat="server" id="LabelError"></asp:Label>
        <asp:Label id="mensajeSession" runat="server">
            <a href="SignIn.aspx" style="color:blue">aquí.</a>
        </asp:Label>

        <asp:GridView class="container mb-3" id="GridRelato" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                <asp:BoundField DataField="genero" HeaderText="genero" SortExpression="genero" />
                <asp:BoundField DataField="text" HeaderText="text" SortExpression="text" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </div>
</asp:Content>