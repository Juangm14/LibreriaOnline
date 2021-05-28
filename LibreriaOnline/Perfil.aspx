<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="LibreriaOnline.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
        <p>
            <asp:Button class="btn-sm btn-success" runat="server" onclick="editar_Click" text="Editar perfil" Width="135px"/>
            <asp:Button ID="ElimUsuario" class="btn-danger btn-sm mt-2" runat="server" Text="Eliminar Cuenta" OnClick="EliminarUsuario_Click" />
            <asp:Button ID="GuardarUsuario" class="btn-danger btn-sm mt-2" runat="server" Text="Guardar Cambios" OnClick="GuardarUsuario_Click" />
             
        <br />
        </p>
     
   <div class="container mb-3">
     
        <br />
        <img src="perfil.jpg" style="height: 89px; width: 114px"/>
        <label for="formFile" class="form-label"></label>
        <input class="form-control form-control-sm" id="formFileSm" type="file">
        <br />
        
       <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Email</asp:label>
       <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="mostrarEmail" ReadOnly="true" ></asp:TextBox>
        
        <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Contraseña</asp:label>
       <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="mostrarContraseña" ReadOnly="true" ></asp:TextBox>

       <asp:label runat="server" for="exampleFormControlInput1" class="form-label">Nick</asp:label>
       <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="mostrarNick" ReadOnly="true" ></asp:TextBox>
         
        <asp:Label runat="server">Nombre</asp:Label><br />
        <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="mostrarNombre" ReadOnly="true" ></asp:TextBox>
        <asp:Label runat="server">Apellidos</asp:Label><br />
               <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="mostrarApellido" ReadOnly="true" ></asp:TextBox>

        <asp:Label runat="server">Telefono</asp:Label><br />
               <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="mostrarTelefono" ReadOnly="true" ></asp:TextBox>

        <asp:Label runat="server">Direccion</asp:Label><br />
               <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="mostrarDireccion"  ReadOnly="true" ></asp:TextBox>

        <asp:Label runat="server">Edad</asp:Label><br />
               <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="mostrarEdad" ReadOnly="true" ></asp:TextBox>
                

    </div>  
</asp:Content>