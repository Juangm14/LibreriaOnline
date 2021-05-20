<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Soporte.aspx.cs" Inherits="LibreriaOnline.Soporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        <a style="text-align:center" >
            <h2>
                ¿En que podemos ayudarte?
            </h2>
        </a>

        <select>
            <option>Pregunta</option>
            <option>Sugerencia</option>
        </select>

        <p>Asunto
        <br />
        <asp:textbox runat="server" Width="314px"></asp:textbox>
        <br />
        </p>

        <p>Pregunta
        <br />
        <asp:textbox runat="server" Width="987px" Height="80px" TextMode="MultiLine"></asp:textbox>
        </p>
        <asp:Button class="btn-sm btn-primary mb-3" runat="server" Text="Enviar" OnClick="Enviar_Click"></asp:Button>
    </div>
</asp:Content>
