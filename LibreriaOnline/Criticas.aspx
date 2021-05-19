<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Criticas.aspx.cs" Inherits="LibreriaOnline.Criticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
        <div class="container">
        <p>
            <asp:Button class="btn-sm btn-success" runat="server" onclick="desplegarNuevaCritica" text="Nueva critica"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" runat="server" onclick="desplegarModCrit_Click" text="Modificar critica"/> &nbsp;
            <asp:Button class="btn-sm btn-danger " runat="server" onclick="desplegarElimCrit_Click" text="Borrar critica"/>
        </p>
        </div>

        <div class="container"  id="nuevaC">
            <div class="mb-3">
              <asp:label id="NuevoTituloLabel" runat="server" for="exampleFormControlInput1" class="form-label">Título</asp:label>
              <asp:TextBox id="NuevoTituloCritica"  runat="server" class="form-control" placeholder="Introduce un título para tu critica"></asp:TextBox>
            </div>

            <div class="mb-3">
              <asp:label id="NuevaValidacionLabel" runat="server">Valoración</asp:label>&nbsp; 
                
              <asp:DropDownList id="NuevaValoracionText" runat="server" Height="30px" Width="51px">
                  <asp:ListItem>1</asp:ListItem>
                  <asp:ListItem>2</asp:ListItem>
                  <asp:ListItem>3</asp:ListItem>
                  <asp:ListItem>4</asp:ListItem>
                  <asp:ListItem>5</asp:ListItem>
              </asp:DropDownList>
            </div>

            <div class="mb-3">
              <asp:label id="NuevoTextoLabel" runat="server" for="exampleFormControlInput1" class="form-label">Crítica</asp:label>
              <asp:TextBox id="NuevoTextoCritica" runat="server" class="form-control" placeholder="Introduce tu crítica" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </div>
           
            <asp:Button ID="EnviarNuevaCritica" class="btn-sm btn-success" runat="server" onclick="NuevaCritica_Click" text="Enviar"/>
            <asp:Label id="ConfirmacionNuevaCritica" runat="server"></asp:Label>

        </div>

        <div class="container" id="modificarCritica">

            <div class="mb-3">
                <asp:Label id="ModBuscarTituloLabel" runat="server" Text="Titulo"></asp:Label>
                <asp:TextBox id="ModBuscarTituloText" class="form-control" runat="server" placeholder="Introduce el titulo de la critica a modificar"></asp:TextBox>
                <asp:Button ID="ModBuscarTituloBoton" CssClass="btn-primary btn-sm mt-3" runat="server" Text="Buscar" OnClick="ModBuscarTituloBoton_Click"/>
                <asp:Label id="ConfirmarBusquedaCritica" runat="server"></asp:Label>
            </div>

            <div class="mb-3">
                <asp:label id="ModTituloLabel" runat="server" for="exampleFormControlInput1" class="form-label">Título</asp:label>
                <asp:TextBox id="ModTituloText" class="form-control" runat="server"  placeholder="Introduce un título para tu critica"></asp:TextBox>
            </div>

            <div class="mb-3">
              <asp:label id="ModValoracionLabel" runat="server">Valoración</asp:label>&nbsp; 
                
              <asp:DropDownList id="ModValoracionText" runat="server" Height="30px" Width="51px">
                  <asp:ListItem>1</asp:ListItem>
                  <asp:ListItem>2</asp:ListItem>
                  <asp:ListItem>3</asp:ListItem>
                  <asp:ListItem>4</asp:ListItem>
                  <asp:ListItem>5</asp:ListItem>
              </asp:DropDownList>
            </div>

            <div class="mb-3">
              <asp:label id="ModTextoLabel" runat="server" for="exampleFormControlInput1" class="form-label">Crítica</asp:label>
              <asp:TextBox id="ModTextoText" class="form-control" runat="server"  placeholder="Introduce tu crítica" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </div>
           
            <asp:Button ID="ModButton" class="btn-sm btn-warning mb-3" runat="server" onclick="NuevaCritica_Click" text="Modificar"/>
            <asp:Label id="ConfirmarModificacionCritica" runat="server"></asp:Label>
        </div>

        <div class="container">
            <div class="mb-3">
                <asp:Label id="ElimBuscarLabel" runat="server" Text="Titulo"></asp:Label>
                <asp:TextBox ID="ElimBuscarText" class="form-control" runat="server" placeholder="Introduce el titulo de la critica a eliminar"></asp:TextBox>
                <asp:Button ID="ElimBuscarBoton" class="btn-danger btn-sm mt-3" runat="server" Text="Eliminar" />
                <asp:Label id="ConfirmarEliminacionCritica" runat="server"></asp:Label>
            </div>
        </div>

            <p>
                <asp:GridView id="GridCritica" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                    <Columns>
                        <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
<asp:BoundField DataField="titulo1" HeaderText="titulo1" SortExpression="titulo1"></asp:BoundField>
                        <asp:BoundField DataField="texto" HeaderText="texto" SortExpression="texto" />
                        <asp:BoundField DataField="nota" HeaderText="nota" SortExpression="nota" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Libros].[titulo], [Critica].[titulo], [texto], [nota] FROM [Critica],[Libros] where  [Libros].[ISBN] = [Critica].[ISBN]"></asp:SqlDataSource>
            </p>
</asp:Content>
