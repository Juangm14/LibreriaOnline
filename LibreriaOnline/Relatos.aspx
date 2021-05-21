<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Relatos.aspx.cs" Inherits="LibreriaOnline.Relatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
        <div class="container">
        <p>
            <asp:Button class="btn-sm btn-success" ID="NuevoRelato" runat="server" onclick="NuevoRelato_Click" text="Nuevo relato"/> &nbsp;
            <asp:Button class="btn-sm btn-warning" ID="EditarRelato" runat="server" onclick="EditarRelato_Click" text="Modificar relato"/> &nbsp;
            <asp:Button class="btn-sm btn-danger " ID="BorrarRelato" runat="server" onclick="BorrarRelato_Click" text="Borrar relato"/>
        </p>

        <div id="FormularioCreacionRelato" class="container">
            <div class="mb-3">
              <asp:label runat="server" id="TituloRelato" for="exampleFormControlInput1" class="form-label">Titulo</asp:label>
              <asp:TextBox runat="server" class="form-control" id="exampleFormControlInput1" placeholder="Relato 1" TextMode="SingleLine"></asp:TextBox> 
            </div>

            <div class="mb-3">
              <asp:label runat="server" id="GeneroRelato" for="exampleFormControlInput3" class="form-label">Genero</asp:label>
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
                <asp:label runat="server" id="TextoRelato" for="exampleFormControlInput1" class="form-label">Texto</asp:label>
                <asp:TextBox runat="server" TextMode="MultiLine" class="form-control" id="exampleFormControlInput2" placeholder="Texto" Height="150px"></asp:TextBox>
                <asp:Button class="btn-sm btn-success mb-2 mt-2" id="CrearRelatoButton" runat="server" onclick="CrearNuevoRelato_Click" text="Crear"/> 
                <asp:label runat="server" id="LabelCrear" for="exampleFormControlInput1" class="form-label"></asp:label>
            </div>
           
            <p>
                <asp:Label ID="MsgRelato" runat="server"></asp:Label>

                <asp:Label id="mensajeSession" runat="server">
                    <a href="SignIn.aspx" style="color:blue">aquí.</a>
                </asp:Label>
            </p>
        </div>

        <div id="FormularioModificarRelato" class="container">
            <div class="mb-3">
              <asp:label id="ModLabelTitulo" runat="server" for="exampleFormControlInput1" class="form-label">Titulo del relato</asp:label>
              <asp:TextBox id="ModTextTitulo" runat="server" class="form-control"  placeholder="Escribe el titulo del relato que quieres modificar" TextMode="SingleLine" Width="800px"></asp:TextBox> 
              <asp:Button ID="ModBuscarTitulo" class="btn-primary btn-sm mt-2" runat="server" Text="Buscar" OnClick="BuscarRelato_Click" />
                <asp:Label id="ModMsgBuscar" runat="server"></asp:Label>
            </div>

            <div class="mb-3">
            <asp:label runat="server" id="ModLabelNewTitulo" for="exampleFormControlInput1" class="form-label">Titulo</asp:label>
              <asp:TextBox runat="server" class="form-control" id="ModTextNewTitulo" placeholder="Escribe el nuevo Titulo del relato" TextMode="SingleLine"></asp:TextBox> 
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
              <asp:label runat="server" id="ModLabelTexto" for="exampleFormControlInput1" class="form-label">Texto</asp:label>
              <asp:TextBox runat="server" TextMode="MultiLine" class="form-control" id="ModTextTexto" placeholder="Texto" Height="150px"></asp:TextBox>
            </div>
           
            <asp:Button class="btn-sm btn-warning" id="ModButton" runat="server" onclick="ModificarRelato_Click" text="Modificar Relato"/> 
            <asp:Label id="ModLabelUpdateRelato" runat="server"></asp:Label>
            <p>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </p>
        </div>


        <div id="FormularioEliminarRelato" class="container">
            <div class="mb-3">
              <asp:label id="ElimLabelRelato" runat="server" for="exampleFormControlInput1" class="form-label">Titulo</asp:label>
              <asp:TextBox id="ElimTituloRelato" runat="server" class="form-control"  placeholder="Escribe el titulo del relato que quieres eliminar" TextMode="SingleLine"></asp:TextBox> 
              <asp:Button ID="ElimBotonRelato" class="btn-danger btn-sm mt-2" runat="server" Text="Eliminar" OnClick="EliminarRelato_Click" />
              <asp:Label ID="ElimMsg" runat="server"></asp:Label>
            </div>
        </div>
        <p>
            <asp:GridView id="GridRelatosShow" class="container" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="1058px">
                
                <AlternatingRowStyle BackColor="White" />

                <Columns>
                    <asp:BoundField DataField="genero" HeaderText="genero" SortExpression="genero" />
                    <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                    <asp:BoundField DataField="text" HeaderText="text" SortExpression="text" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [genero], [Titulo], [text] FROM [Relato]"></asp:SqlDataSource>
        </p>
    </div>
</asp:Content>