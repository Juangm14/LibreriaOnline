<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Proveedores.aspx.cs" Inherits="LibreriaOnline.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">

    <div class="container">

        <div class="mb-3">
          <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Email</asp:label>
          <asp:TextBox runat="server" TextMode="Email" class="form-control" id="registroEmail" placeholder="name@example.com"></asp:TextBox>
        </div>
        
        <div class="mb-3">
          <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Nombre empresa</asp:label>
          <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="registroNombre" placeholder="Introduce el nombre de la empresa"></asp:TextBox>
        </div>

        <div class="mb-3">
          <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Telefono</asp:label>
          <asp:TextBox runat="server" TextMode="Phone"  class="form-control" id="registroTelefono" placeholder="Intoduce un número de telefono aqui" maxlength="999999999" min="000000001"></asp:TextBox>
        </div>

        <div class="mb-3">
          <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Contraseña</asp:label>
          <asp:TextBox runat="server" TextMode="password" class="form-control" id="registroContraseña" placeholder="Contraseña"></asp:TextBox>
        </div>
           
        <div class="mb-3">
          <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Repite la contraseña</asp:label>
          <asp:TextBox runat="server" TextMode="password" class="form-control" id="registroContraseña2" placeholder="Contraseña"></asp:TextBox>
        </div>

        <asp:Button class="btn-sm btn-success mb-3" runat="server" onclick="Registro_Click" text="Registrarse"/> &nbsp;

         <asp:Label ID="Msg" runat="server"></asp:Label>
    </div>
</asp:Content>