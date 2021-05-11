<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Criticas.aspx.cs" Inherits="LibreriaOnline.Criticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
        <div class="container">
        <p>
            <asp:Button class="btn-sm btn-success" runat="server" onclick="nuevaCritica_Click" text="Nueva critica"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" runat="server" onclick="Unnamed_Click1" text="Modificar critica"/> &nbsp;
            <asp:Button class="btn-sm btn-danger " runat="server" onclick="Unnamed_Click2" text="Borrar critica"/>
        </p>
        </div>

        <div class="container"  id="nuevaC">
            <div class="mb-3">
              <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Título</asp:label>
              <asp:TextBox runat="server" class="form-control" id="x" placeholder="Introduce un título"></asp:TextBox>
            </div>

            <div class="mb-3">
              <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Crítica</asp:label>
              <asp:TextBox runat="server" class="form-control" id="y" placeholder="Introduce tu crítica" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </div>
           
            <asp:Button class="btn-sm btn-primary" runat="server" onclick="g" text="Enviar"/> 

            <p>
                <asp:GridView runat="server">
                </asp:GridView>
            </p>
        </div>
</asp:Content>
