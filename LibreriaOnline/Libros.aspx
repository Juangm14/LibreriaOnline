<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Libros.aspx.cs" Inherits="LibreriaOnline.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">

    <div class="container mt-2">
        <p>
            <asp:Button class="btn-sm btn-success" ID="NuevoLibro" runat="server" onclick="NuevoLibro_Click" text="Nuevo libro"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" ID="EditarLibro" runat="server" onclick="EditarLibro_Click" text="Modificar libro"/> &nbsp;
            <asp:Button class="btn-sm btn-danger " ID="BorrarLibro" runat="server" onclick="BorrarLibro_Click" text="Borrar libro"/>
        </p>
        </div>

        <div id="FormularioCreacionLibro" class="container">
            <div class="mb-1">
              <asp:label runat="server" id="GeneroLibro" for="exampleFormControlInput3" class="form-label">Genero</asp:label>
                <br />
              <asp:DropDownList id="GeneroDesplegable" runat="server">
                  <asp:ListItem>Personal</asp:ListItem>
                  <asp:ListItem>Ciencia Ficción</asp:ListItem>
                  <asp:ListItem>Aventura</asp:ListItem>
                  <asp:ListItem>Intriga</asp:ListItem>
                  <asp:ListItem>Histórico</asp:ListItem>
                  <asp:ListItem>Terror</asp:ListItem>
                  <asp:ListItem>Otros</asp:ListItem>
              </asp:DropDownList>
            </div>

            <div class="mb-3">
                <asp:label runat="server" id="Titulo" for="exampleFormControlInput1" class="form-label">Titulo</asp:label>
                <asp:TextBox runat="server" class="form-control" id="TextTitulo" placeholder="Introduce el título del libro" TextMode="SingleLine"></asp:TextBox>
                <asp:label runat="server" id="ISBN" for="exampleFormControlInput1" class="form-label">ISBN</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextISBN" placeholder="Introducir ISBN"></asp:TextBox>
                <asp:label runat="server" id="Autores" for="exampleFormControlInput1" class="form-label">Autores</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextAutores" placeholder="Introducir autor/es"></asp:TextBox>
                <asp:label runat="server" id="Editorial" for="exampleFormControlInput1" class="form-label">Editorial</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextEditorial" placeholder="Introducir Editorial"></asp:TextBox>
                <asp:label runat="server" id="Genero" for="exampleFormControlInput1" class="form-label">Genero</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextGenero" placeholder="Introducir Genero"></asp:TextBox>
                <asp:label runat="server" id="Proveedor" for="exampleFormControlInput1" class="form-label">Proveedor</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextProveedor" placeholder="Introducir Proveedor"></asp:TextBox>
                <asp:label runat="server" id="Precio" for="exampleFormControlInput1" class="form-label">Precio</asp:label>
                <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="TextPrecio" placeholder="Introducir Precio"></asp:TextBox>
                <asp:label runat="server" id= "Imagen" for="exampleFormControlInput1" class="form-label">Imagen</asp:label>
                <asp:TextBox runat="server" class="form-control mt-2" type="file" id="formFile" ></asp:TextBox>
                <asp:Button runat="server" ID="Boton_crearLibro" text="Crear libro" OnClick="Boton_crear" class="btn-sm mt-2 btn-success" />
                <asp:Label runat="server" ID="LabelCrear" />

            </div>
           
        </div>

        <div id="FormularioModificarLibro" class="container">
            <div class="mb-3">
              <asp:label id="ModLabelISBN" runat="server" for="exampleFormControlInput1" class="form-label">ISBN del libro</asp:label>
              <asp:TextBox id="ModTextISBN" runat="server" class="form-control"  placeholder="Escribe el ISBN del libro que quieres modificar" TextMode="SingleLine" Width="800px"></asp:TextBox> 
              <asp:Button ID="ModBuscarISBN" class="btn-primary btn-sm mt-2" runat="server" Text="Buscar" OnClick="BuscarLibro_Click" />
                <asp:Label id="ModMsgBuscar" runat="server"></asp:Label>
            </div>

            <div class="mb-3">
            <asp:label runat="server" id="ModLabelNewAutor" for="exampleFormControlInput1" class="form-label">Autor</asp:label>
              <asp:TextBox runat="server" class="form-control" id="ModTextNewAutor" placeholder="Escribe el nuevo autor del libro" TextMode="SingleLine"></asp:TextBox> 
              <asp:label runat="server" id="ModGenero" for="exampleFormControlInput3" class="form-label">Genero</asp:label>
                <br />
              <asp:DropDownList id="ModDropDownList1" runat="server">
                  <asp:ListItem>Personal</asp:ListItem>
                  <asp:ListItem>Ciencia Ficción</asp:ListItem>
                  <asp:ListItem>Aventura</asp:ListItem>
                  <asp:ListItem>Intriga</asp:ListItem>
                  <asp:ListItem>Histórico</asp:ListItem>
                  <asp:ListItem>Terror</asp:ListItem>
                  <asp:ListItem>Otros</asp:ListItem>
              </asp:DropDownList>
            </div>

            <div class="mb-3">
              <asp:label runat="server" id="ModLabelTitulo" for="exampleFormControlInput1" class="form-label">Titulo</asp:label>
              <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="ModTextTitulo" placeholder="Titulo" Height="70px"></asp:TextBox>
            </div>

            <div class="mb-3">
              <asp:label runat="server" id="ModLabelEditorial" for="exampleFormControlInput1" class="form-label">Editorial</asp:label>
              <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="ModTextEditorial" placeholder="Editorial" Height="70px"></asp:TextBox>
            </div>

            <div class="mb-3">
              <asp:label runat="server" id="ModLabelPrecio" for="exampleFormControlInput1" class="form-label">Precio</asp:label>
              <asp:TextBox runat="server" TextMode="SingleLine" class="form-control" id="ModTextPrecio" placeholder="Precio" Height="70px"></asp:TextBox>
            </div>
            <div class="mb-3">
              <asp:label runat="server" id= "ModLabelImagen" for="exampleFormControlInput1" class="form-label">Imagen</asp:label>
              <asp:TextBox runat="server" class="form-control" type="file" id="TextImagen"></asp:TextBox>
            </div>
           
            <asp:Button class="btn-sm btn-warning" id="ModButton" runat="server" onclick="ModificarLibro_Click" text="Modificar Libro"/> 
            <asp:Label id="ModLabelUpdateLibro" runat="server"></asp:Label>
            <p>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </p>
        </div>

        <div id="FormularioEliminarLibro" class="container">
            <div class="mb-3">
              <asp:label id="ElimLabelLibro" runat="server" for="exampleFormControlInput1" class="form-label">ISBN</asp:label>
              <asp:TextBox id="ElimISBNLibro" runat="server" class="form-control"  placeholder="Escribe el ISBN del libro que quieres eliminar" TextMode="SingleLine"></asp:TextBox> 
              <asp:Button ID="ElimBotonLibro" class="btn-danger btn-sm mt-2" runat="server" Text="Eliminar" OnClick="EliminarLibro_Click" />
              <asp:Label ID="ElimMsg" runat="server"></asp:Label>
            </div>
        </div>

        <div class="container">

        <asp:DataList ID="DataList2" runat="server" DataKeyField="ISBN" DataSourceID="SqlDataSource1" RepeatColumns="3"  CssClass="table table-responsive">
            <ItemTemplate>
                <asp:Image ID="Image1" width="140" height="180" runat="server" ImageUrl='<%# Eval("imagen") %>' CssClass="img-fluid" />
                <br />
                <br />
                ISBN:
                <asp:Label ID="ISBNLabel" runat="server" Text='<%# Eval("ISBN") %>' />
                <br />
                autores:
                <asp:Label ID="autoresLabel" runat="server" Text='<%# Eval("autores") %>' />
                <br />
                titulo:
                <asp:Label ID="tituloLabel" runat="server" Text='<%# Eval("titulo") %>' />
                <br />
                editorial:
                <asp:Label ID="editorialLabel" runat="server" Text='<%# Eval("editorial") %>' />
                <br />
                genero:
                <asp:Label ID="generoLabel" runat="server" Text='<%# Eval("genero") %>' />
                <br />
                proveedor:
                <asp:Label ID="proveedorLabel" runat="server" Text='<%# Eval("proveedor") %>' />
                <br />
                Precio:
                <asp:Label ID="PrecioLabel" runat="server" Text='<%# Eval("Precio") %>' />
                <br />
                <asp:Button ID="AgregarCarrito" OnCommand="AgregarCarrito_Command" CommandArgument='<%# Bind("ISBN") %>' runat="server" Text="Agregar al Carrito" CssClass="btn btn-success" />
            </ItemTemplate>

        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Libros]"></asp:SqlDataSource>
        <asp:Label runat="server" ID="ErrorCarrito" ForeColor="red"></asp:Label>
        </div>

        

        

</asp:Content>
