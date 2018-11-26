<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="EvaluacionDocenteULSA.Inicio" %>

<html>
<head><meta http-equiv="Content-Type" content="text/html; charset=gb18030">

<title>Evaluacion Docente 2017</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>

</head>

<body onload="loadJSON();">
<!-- navbar -->
	<nav class="navbar navbar-expand-lg navbar-dark" style="background-color: #101d61; color: white;">
	  <a class="navbar-brand" href="#">Evaluacion Docente Ago-Dic 2018. </a>
	  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
	    <span class="navbar-toggler-icon"></span>
	  </button>
	  <div class="collapse navbar-collapse" id="navbarText">
	    <ul class="navbar-nav ml-auto">
	      <li class="nav-item active">
	        <a class="nav-link" href="Default.aspx">Salir <span class="sr-only">(current)</span></a>
	      </li>
	      
	    </ul>
	    
  </div>
</nav>


<div class="container">
<center><img src="http://www.ulsachihuahua.edu.mx/investigacion/_Media/logo_ulsa_med_hr.jpeg" class="img-fluid">
<h4>Seleccione un docente de la siguiente lista para empezar la evaluación.</h4>
<br>
<form runat="server" >

    <asp:DropDownList CssClass="form-control" ID="cmbx_maestros" runat="server"></asp:DropDownList>
<br>
<br>
<br>
<asp:Button CssClass="btn btn-primary" ID="btnIniciar" runat="server" Text="Iniciar Evaluacion" OnClick="btnIniciar_Click"></asp:Button>

</form>
</center>
<br>
<br>
<br><br>
<br>
<br>
</div>

</body>

</html>