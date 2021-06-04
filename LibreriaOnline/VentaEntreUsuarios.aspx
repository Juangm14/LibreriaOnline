<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VentaEntreUsuarios.aspx.cs" Inherits="LibreriaOnline.VentaEntreUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">

        <div class="container">
            <p>
            <asp:Button class="btn-sm btn-success" id="NuevaOferta" runat="server" onclick="CrearOfertaClick" text="Crear oferta"/> &nbsp;
                <asp:Button class="btn-sm btn-danger" id="BorrarOferta" runat="server" onclick="BorrarOfertaClick" text="Borrar oferta"/> &nbsp;
                <asp:Button class="btn-sm btn-primary" id="ComprarOferta" runat="server" onclick="ComprarOfertaClick" text="Añadir oferta al carrito"/> &nbsp;
                </p>
            <asp:TextBox id="TextBoxOferta"  runat="server" class="form-control" placeholder="Introduzca la ID de la oferta deseada" Width="266px"></asp:TextBox>
            <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                    <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
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
            
            <asp:Label ID="problema" runat="server" Text="Label"></asp:Label> 
        </asp:Label>
            
        </div>
</asp:Content>
