<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Criticas.aspx.cs" Inherits="LibreriaOnline.Criticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
        <div class="container">
        <p>
            <asp:Button class="btn-sm btn-success" id="DesplegarCritica" runat="server" onclick="desplegarNuevaCritica" text="Nueva critica"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" id="DesplegarModificacion"  runat="server" onclick="desplegarModCrit_Click" text="Modificar critica"/> &nbsp;
            <asp:Button class="btn-sm btn-danger " id="DesplegarEliminacion" runat="server" onclick="desplegarElimCrit_Click" text="Borrar critica"/>
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
              <asp:label id="LabelNuevoLibro" runat="server">Libro</asp:label>&nbsp; 
                
              <asp:DropDownList id="ListaNuevosLibros" runat="server" Height="32px" Width="200px" DataSourceID="SqlDataSource4" DataTextField="Titulo" DataValueField="Titulo">
              </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Titulo FROM [Leidos], [Libros] where Leidos.ISBN = Libros.ISBN"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [titulo] FROM [Libros]"></asp:SqlDataSource>
            </div>

            <div class="mb-3">
              <asp:label id="NuevoTextoLabel" runat="server" for="exampleFormControlInput1" class="form-label">Crítica</asp:label>
              <asp:TextBox id="NuevoTextoCritica" runat="server" class="form-control" placeholder="Introduce tu crítica" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </div>
           
            <asp:Button ID="EnviarNuevaCritica" class="btn-sm btn-success" runat="server" onclick="NuevaCritica_Click" text="Enviar"/>
            <asp:Label id="ConfirmacionNuevaCritica" runat="server"></asp:Label>

            <p>
                <asp:Label ID="MsgCritica" runat="server"></asp:Label>

                <asp:Label id="mensajeSession" runat="server">
                    <a href="SignIn.aspx" style="color:blue">aquí.</a>
                </asp:Label>
            </p>

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
              <asp:label id="ModLabelListaLibros" runat="server">Libro</asp:label>&nbsp; 
                
              <asp:DropDownList id="ModListaLibros" runat="server" Width="200px"  DataSourceID="SqlDataSource1" DataTextField="titulo" DataValueField="titulo">
              </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [titulo] FROM [Libros]"></asp:SqlDataSource>
            </div>

            <div class="mb-3">
              <asp:label id="ModTextoLabel" runat="server" for="exampleFormControlInput1" class="form-label">Crítica</asp:label>
              <asp:TextBox id="ModTextoText" class="form-control" runat="server"  placeholder="Introduce tu crítica" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </div>
           
            <asp:Button ID="ModButton" class="btn-sm btn-warning mb-3" runat="server" onclick="ModificarCritica_Click" text="Modificar"/>
            <asp:Label id="ConfirmarModificacionCritica" runat="server"></asp:Label>
        </div>

        <div class="container">
            <div class="mb-3">
                <asp:Label id="ElimBuscarLabel" runat="server" Text="Titulo"></asp:Label>
                <asp:TextBox ID="ElimBuscarText" class="form-control" runat="server" placeholder="Introduce el titulo de la critica a eliminar"></asp:TextBox>
                <asp:Button ID="ElimBuscarBoton" class="btn-danger btn-sm mt-3" runat="server" Text="Eliminar" OnClick="ElimBuscarBoton_Click"/>
                <asp:Label id="ConfirmarEliminacionCritica" runat="server"></asp:Label>
            </div>
        </div>

            <p>
                <asp:GridView id="GridCritica" class="container" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" DataKeyNames="titulo" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" ReadOnly="True" />
                        <asp:BoundField DataField="texto" HeaderText="texto" SortExpression="texto"></asp:BoundField>
                        <asp:BoundField DataField="nota" HeaderText="nota" SortExpression="nota" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [titulo], [texto], [nota] FROM [Critica]"></asp:SqlDataSource>
            </p>
</asp:Content>
