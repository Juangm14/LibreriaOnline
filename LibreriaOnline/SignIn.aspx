<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="LibreriaOnline.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">

        <div class="mb-3">
          <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Email o nick</asp:label>
          <asp:TextBox runat="server" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com" TextMode="Email"></asp:TextBox> 
        </div>

        <div class="mb-3">
          <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Contraseña</asp:label>
          <asp:TextBox runat="server" TextMode="Password" class="form-control" id="exampleFormControlInput2" placeholder="Contraseña"></asp:TextBox>
        </div>
           
        <asp:Button class="btn-sm btn-success" runat="server" onclick="InicioSesion_Click" text="Iniciar Sesion"/> 
        <p>
            <asp:Label ID="Msg" runat="server"></asp:Label>
        </p>

        <p>
            
            ¿No tienes cuenta?
             <a  href="Registro.aspx">
                 <span style="color:blue";>Regístrate</span>
             </a >
        </p>

    </div>
</asp:Content>
