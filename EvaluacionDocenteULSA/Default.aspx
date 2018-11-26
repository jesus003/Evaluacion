<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EvaluacionDocenteULSA._Default" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <!-- This file has been downloaded from Bootsnipp.com. Enjoy! -->
    <title>Inicio</title>
        <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="http://netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css" rel="stylesheet">
   <link href="css/style.css" rel="stylesheet">
    <script src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
    <script src="http://netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js"></script>
</head>
<body>
<div class="container">
    
    <div class="row">
        <div class="col-sm-6 col-md-4 col-md-offset-4">
            <h1 class="text-center login-title">Evaluacion docente Ago-Dic 2018</h1>
            <div class="account-wall">
               <center> <img class="profile-img" src="http://corporativobuendiasc.com.mx/img/enlaces/universidad_la_salle.jpg"
                    alt=""></center>
                <form class="form-signin">
                <input type="text" runat="server" class="form-control" placeholder="Usuario" name="Usuario" id="Usuario" required autofocus>
				<br>
                <input type="password" runat="server" class="form-control" placeholder="Password" name="Password" id="Password" required>
                    <form runat="server" >
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-lg btn-primary btn-block" Text="Iniciar Sesion." OnClick="Button1_Click" />
                   </form>
               
                
                </form>
            </div>
           
        </div>
    </div>
</div>
<script type="text/javascript">

</script>
</body>
</html>
