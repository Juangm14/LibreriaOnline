<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LibreriaOnline.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Inicio" runat="server">
    <div class="container">
        

        <p>
            <asp:GridView runat="server">
            </asp:GridView>
        </p>
    </div>
<div class="card-deck">
  <div class="card container mb-3">
    <a href="SignIn.aspx">

                    <img src="portadafuncional.jpg" alt="Card image cap" style="width:1200px;height:800px; />

                </a>
    <div class="card-body">
      <h5 class="card-title">Cliente</h5>
      <p class="card-text">Hazte cliente de nosotros y haz uso de nuestras herramientas exclusivas .</p>
      
    </div>
  </div>
  <div class="card container mb-3">
    <a href="Criticas.aspx">

                    <img src="pagina2.jpg" alt="Card image cap" style="width:1200px;height:800px; />

                </a>
    <div class="card-body">
      <h5 class="card-title">Críticas</h5>
      <p class="card-text">Haz críticas sobre los libros que quieras.</p>
      
    </div>
  </div>

  <div class="card container mb-3">
     <a href="Relatos.aspx">

                    <img src="pagina3.jpg" alt="Card image cap" style="width:1200px;height:800px; />

                </a>
    <div class="card-body">
      <h5 class="card-title">Relatos</h5>
      <p class="card-text">Date a conocer escribiendo tus relatos y compartiendolos con la comunidad.</p>
      
    </div>
  </div>
    <div class="card container mb-3">
     <a href="Soporte.aspx">

                    <img src="preguntas-y-libros.jpg" alt="Card image cap" style="width:1200px;height:800px; />

                </a>
    <div class="card-body ">
      <h5 class="card-title">Preguntas</h5>
      <p class="card-text">Contacta con nuestro soporte si tienes alguna duda y/o sugerencia. Te atenderemos con la mayor brevedad posible.</p>
      
    </div>
  </div>
</div>

    

    </asp:Content>


   

