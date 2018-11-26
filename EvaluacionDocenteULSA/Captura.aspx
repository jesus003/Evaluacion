<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Captura.aspx.cs" Inherits="EvaluacionDocenteULSA.Captura" %>

<html>
<head>
<title>Evaluacion Docente 2018</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
<script src="js/sweetalert2.all.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/core-js/2.4.1/core.js"></script>
<script src="js/sweetalert2.min.js"></script>
<link rel="stylesheet" href="css/sweetalert2.min.css">


</head>

<body>
<!-- navbar -->
	<nav class="navbar navbar-expand-lg navbar-dark" style="background-color: #101d61; color: white;">
	  <a class="navbar-brand" href="#">Evaluacion Docente 2017.</a>
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
<h6 id="cabecera"></h6>
NOMBRE DEL MAESTRO:<br><asp:Label ID="lblMaestro" runat="server" Text="Label"></asp:Label><br><br>MATERIA:<br><asp:Label ID="lblMateria" runat="server" Text="Label"></asp:Label>
<hr>
<p>
<h6>INSTRUCCIONES:</h6>
Conteste en una escala del 1 (muy en
desacuerdo) al 5 (muy de acuerdo)
</p>
<br>
<form method="get" action="#"> 
  <hr>
<label><h5>A. RESPONSABILIDAD <br> <input type="radio" id="a1" name="a1" value="1"> 1
  <input type="radio" id="a1" name="a1" value="2"> 2
  <input type="radio" id="a1" name="a1" value="3"> 3
  <input type="radio" id="a1" name="a1" value="4"> 4
  <input type="radio" id="a1" name="a1" value="5"> 5</h5></label><br>
<label>* El (la) profesor(a) asiste normalmente a
clases y si falta las repone. </label><br><br>
 <label>* Comienza y termina su clase a tiempo.</label><br><br>
 <label><h5>COMENTARIO</h5></label><br>
<input type="text" id="comentarioA" name="comentarioA" style="width:80%;height:150px"><br>
<hr>
  <label><h5>B. PROGRAMA <br> <input type="radio" id="b1" name="b1" value="1"> 1
  <input type="radio" id="b1" name="b1" value="2"> 2
  <input type="radio" id="b1" name="b1" value="3"> 3
  <input type="radio" id="b1" name="b1" value="4"> 4
  <input type="radio" id="b1" name="b1" value="5"> 5</h5></label><br>
<label>* Da a conocer el programa (objetivos,
contenidos, metodología, evaluación,
bibliografía), a principio del curso.</label><br>
 <br><br>
 <label>* El programa se desarrolla a un ritmo
adecuado.</label><br>
  <br><br>
  <label>* Lo explicado en clase responde al
programa de la asignatura.</label><br>
 <br><label><h5>COMENTARIO</h5></label><br>
<input type="text" id="comentarioB" name="comentarioB" style="width:80%;height:150px"><br>

<hr>
  <label><h5>C. CONOCIMIENTO E INTERRELACIÓN DE LA
MATERIA <br> <input type="radio" id="c1" name="c1" value="1"> 1
  <input type="radio" id="c1" name="c1" value="2"> 2
  <input type="radio" id="c1" name="c1" value="3"> 3
  <input type="radio" id="c1" name="c1" value="4"> 4
  <input type="radio" id="c1" name="c1" value="5"> 5</h5></label><br>
<label>* Domina su materia y explica con claridad
los conceptos.</label><br>
 <br><br>
 <label>* Cuando introduce conceptos nuevos los
relaciona, si es posible, con los ya
conocidos.</label><br>
  <br><br>
  <label>* Hay clases prácticas que complementan
los contenidos de la asignatura.</label><br>
  <br><br>
<label>* Se aplica lo aprendido en situaciones
reales propias de mi profesión.</label><br>
  <br><label><h5>COMENTARIO</h5></label><br>
<input type="text" id="comentarioC" name="comentarioC" style="width:80%;height:150px"><br>

  <hr>
  <label><h5>D. METODOLOGÍA <br> <input type="radio" id="d1" name="d1" value="1"> 1
  <input type="radio" id="d1" name="d1" value="2"> 2
  <input type="radio" id="d1" id="d1" name="d1" value="3"> 3
  <input type="radio" id="d1" name="d1" value="4"> 4
  <input type="radio" id="d1" name="d1" value="5"> 5</h5></label><br>
<label>* La conducción de la clase es interesante y
variada: consigue que estemos motivados
en la misma.</label><br>
  <br><br>
 <label>* Las clases están bien preparadas,
organizadas y estructuradas.</label><br>
  <br><br>
  <label>* En sus explicaciones, se ajusta bien al
nivel de conocimiento de los estudiantes.</label><br>
  <br><br>
<label>* Se me encargan trabajos e
investigaciones que me permiten ampliar
mis conocimientos.</label><br>
 <br><label><h5>COMENTARIO</h5></label><br>
<input type="text" id="comentarioD" name="comentarioD" style="width:80%;height:150px"><br>

  <hr>
  <label><h5>E. MATERIALES <br> <input type="radio" id="e1" name="e1" value="1"> 1
  <input type="radio" id="e1" name="e1" value="2"> 2
  <input type="radio" id="e1" name="e1" value="3"> 3
  <input type="radio" id="e1" name="e1" value="4"> 4
  <input type="radio" id="e1" name="e1" value="5"> 5</h5></label><br>
<label>* Los materiales de estudio (textos, apuntes,
etc.) son adecuados.</label><br>
 <br><br>
 <label>* Usamos otros recursos (tecnológicos,
bibliográficos, didácticos, etc.) para
conseguir los aprendizajes.</label><br>
  <br><label><h5>COMENTARIO</h5></label><br>
<input type="text" id="comentarioE" name="comentarioE" style="width:80%;height:150px"><br>


<hr>
  <label><h5>F. ACTITUD<br><input type="radio" id="f1" name="f1" value="1"> 1
  <input type="radio" id="f1" name="f1" value="2"> 2
  <input type="radio" id="f1" name="f1" value="3"> 3
  <input type="radio" id="f1" name="f1" value="4"> 4
  <input type="radio" id="f1" name="f1" value="5"> 5</h5></label><br>
<label>* Es respetuoso/a y accesible con los
estudiantes.</label><br>
  <br><br>
 <label>* Favorece la participación de los alumnos
en clase.</label><br>
  <br><br>
  <label>* Aclara las dudas que le expresan los
alumnos.</label><br>
  <br><br>
<label>* La comunicación profesor – estudiante es
fluida y espontánea, creando un clima de
confianza.</label><br>
 <br><label><h5>COMENTARIO</h5></label><br>
<input type="text" id="comentarioF" name="comentarioF" style="width:80%;height:150px"><br>

<hr>
  <label><h5>G. EVALUACIÓN<br><input type="radio" id="g1" name="g1" value="1"> 1
  <input type="radio" id="g1" name="g1" value="2"> 2
  <input type="radio" id="g1" name="g1" value="3"> 3
  <input type="radio" id="g1" name="g1" value="4"> 4
  <input type="radio" id="g1" name="g1" value="5"> 5</h5></label><br>
<label>* Conozco los criterios y procedimientos de
evaluación y me parecen adecuados y
justos.</label><br>
  <br><br>
 <label>* La evaluación mide el conocimiento
adquirido.</label><br>
<br><br>
  <label>* Se me informa el resultado de las tareas,
exámenes y ejercicios.</label><br>
 <br><br>
<label>* La evaluación me ayuda a darme cuenta
de aspectos a mejorar.</label><br>
<br><label><h5>COMENTARIO</h5></label><br>
<input type="text" id="comentarioG" name="comentarioG" style="width:80%;height:150px"><br>

<hr>
  <label><h5>H. SATISFACCIÓN</h5></label><br>
<label>* Considerando todos los aspectos
anteriores, considero que el desempeño
del profesor es: 1= Pésimo 2=Malo
3=Regular 4=Bueno 5=Excelente.</label><br>
  <input type="radio" id="h1" name="h1" value="1"> 1
  <input type="radio" id="h1" name="h1" value="2"> 2
  <input type="radio" id="h1" name="h1" value="3"> 3
  <input type="radio" id="h1" name="h1" value="4"> 4
  <input type="radio" id="h1" name="h1" value="5"> 5<br><br>
 <label>* Recomiendo a este profesor para otras
clases:</label><br>
  <input type="radio" id="h2" name="h2" value="0"> SI
  <input type="radio" id="h2" name="h2" value="1"> NO<br><br>
  <hr>
<label><h5>COMENTARIOS</h5></label><br>
<input type="text" id="comentario" name="comentario" style="width:80%;height:150px">
 <br><br>
    <input id="Button1" type="submit" Class="btn btn-primary" value="Registrar" />

</form>
</div>

</body>

</html>