<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQs.aspx.cs" Inherits="LibreriaOnline.FAQs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">

    <div style="text-align:center">
        <h2>Preguntas Frecuentes</h2>
    </div>
    
    <p>
        <asp:GridView ID="GridView1" Class="container" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Pregunta" HeaderText="Pregunta" SortExpression="Pregunta" />
                <asp:BoundField DataField="Respuesta" HeaderText="Respuesta" SortExpression="Respuesta" />
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
    </p>
    <div class=" container mb-3"> 

        Si su pregunta no ha sido respondida, dirigase a

        <a href="Soporte.aspx">
            <span style="color:blue";>Soporte</span>
        </a>
     </div> 

</asp:Content>
