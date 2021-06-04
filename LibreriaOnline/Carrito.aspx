<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"  CodeBehind="Carrito.aspx.cs" Inherits="LibreriaOnline.Carrito" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <h2 class="container">
        Tu carrito de Bookend
    </h2>
    <div class="container">
        <asp:DataList ID="DataList2" runat="server" DataKeyField="ISBN" RepeatColumns="3"  CssClass="table table-responsive">
            <ItemTemplate>
                <asp:Image ID="Image1" width="140" height="160" runat="server" ImageUrl='<%# Eval("imagen") %>' CssClass="img-fluid mb-2" />
                <br />
                <asp:Button runat="server" Text="+1" onCommand="agregar" CommandArgument='<%# Eval("Cantidad") + ";1;" + Eval("ISBN") %>'  CssClass="btn btn-sm btn-secondary"></asp:Button>
                <asp:Button runat="server" Text="+5" onCommand="agregar" CommandArgument='<%# Eval("Cantidad") + ";5;" + Eval("ISBN") %>' CssClass="btn btn-sm btn-secondary"></asp:Button>
                <asp:Button runat="server" Text="+10" onCommand="agregar" CommandArgument='<%# Eval("Cantidad") + ";10;" + Eval("ISBN") %>' CssClass="btn btn-sm btn-secondary"></asp:Button>
                <asp:Button runat="server" Text="-1" onCommand="agregar" CommandArgument='<%# Eval("Cantidad") + ";-1;" + Eval("ISBN") %>' CssClass="btn btn-sm btn-secondary"></asp:Button>
                <asp:Button runat="server" Text="-5" onCommand="agregar" CommandArgument='<%# Eval("Cantidad") + ";-5;" + Eval("ISBN") %>' CssClass="btn btn-sm btn-secondary"></asp:Button>
                <asp:Button runat="server" Text="-10" onCommand="agregar" CommandArgument='<%# Eval("Cantidad") + ";-10;" + Eval("ISBN") %>'  CssClass="btn btn-sm btn-secondary "></asp:Button>
                <asp:Button runat="server" Text="Eliminar" onCommand="eliminarElemento_Command" CommandArgument='<%# Eval("ISBN") %>' CssClass="btn btn-sm btn-danger"></asp:Button>
                <br />
                <br />
                ISBN:
                <asp:Label ID="ISBNLabel" runat="server" Text='<%# Eval("ISBN") %>' />
                <br />
                titulo:
                <asp:Label ID="tituloLabel" runat="server" Text='<%# Eval("titulo") %>' />
                <br />
                Precio:
                <asp:Label ID="PrecioLabel" runat="server" Text='<%# Eval("Precio") %>' />
                <br />
                Cantidad:
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Cantidad") %>' />
                <br />
            </ItemTemplate>
        </asp:DataList>

        <asp:Label id="mensajeSession" runat="server">
            <a href="SignIn.aspx" style="color:blue">aquí.</a>
        </asp:Label>
        </div>
    </asp:Content>
