<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="LibreriaOnline.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">

        <div class="mb-3">
          <label for="exampleFormControlInput1" class="form-label">Email</label>
          <asp:TextBox runat="server" TextMode="Email" class="form-control" id="registroEmail" placeholder="name@example.com"></asp:TextBox>
        </div>
        
        <div class="mb-3">
          <label for="exampleFormControlInput1" class="form-label">Nick</label>
          <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="registroNick" placeholder="Introduce tu nick aqui"></asp:TextBox>
        </div>

        <div class="mb-3">
          <label for="exampleFormControlInput1" class="form-label">Telefono</label>
          <asp:TextBox runat="server" TextMode="Phone"  class="form-control" id="registroTelefono" placeholder="Intoduce tu telefono aqui" maxlength="999999999" min="000000001"></asp:TextBox>
        </div>

        <div class="mb-3">
          <label for="exampleFormControlInput1" class="form-label">Edad</label>
          <asp:TextBox runat="server" TextMode="Number" min="0" max="99" class="form-control" id="registroEdad"  placeholderText="Introduce tu edad aqui" ></asp:TextBox>
        </div>

        <div class="mb-3">
          <label for="exampleFormControlInput1" class="form-label">Contraseña</label>
          <asp:TextBox runat="server" TextMode="password" class="form-control" id="registroContraseña" placeholder="Contraseña"></asp:TextBox>
        </div>
           
        <div class="mb-3">
          <label for="exampleFormControlInput1" class="form-label">Repite la contraseña</label>
          <asp:TextBox runat="server" TextMode="password" class="form-control" id="registroContraseña2" placeholder="Contraseña"></asp:TextBox>
        </div>

        <asp:Button class="btn-sm btn-success mb-3" runat="server" onclick="Registro_Click" text="Registrarse"/> 

         &nbsp;<asp:Label ID="Msg" runat="server"></asp:Label>
    </div>
</asp:Content>