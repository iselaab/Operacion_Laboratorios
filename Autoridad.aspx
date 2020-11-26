<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autoridad.aspx.cs" Inherits="OperacionLaboratorios.Autoridad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="estilos.css" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Autoridad</title>
</head>
<body>
    <form id="form1" runat="server">
      <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
    <a class="navbar-brand">Operación de laboratorios</a>
    
    <ul class="navbar-nav mr-auto">
      <li class="nav-item">
        <a class="nav-link" href="Objetivo.aspx">Objetivo </a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="Alcance.aspx">Alcance</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="Responsabilidad.aspx">Responsabilidad</a>
      </li>
       <li class="nav-item active">
        <a class="nav-link disabled" href="Autoridad.aspx">Autoridad</a>
      </li>
      <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            Docente
          </a>
          <div class="dropdown-menu btn btn-outline-dark" aria-labelledby="dropdownMenuLink">
            <a class="dropdown-item" href="PresentacionDocente.aspx">Presentacion del docente</a>
            <a class="dropdown-item" href="DemostracionDeEquipo.aspx">Demostración del equipo</a>
            <a class="dropdown-item" href="EvaluacionPracticas.aspx">Evaluación de las prácticas</a>
          </div>
        </li>
        <li class="nav-item">
        <a class="nav-link " href="Login.aspx">Cerrar Sesión</a>
      </li>
     </ul>
    </nav>
        <div class="container">
            <h1 class="text-center">Autoridad</h1>
            <hr />
            <p class="text-center">
                El responsable de que se cumpla esta instrucción de trabajo, tiene la autoridad para:</p>
                <p class="text-center otrot">La delcarada en el <a href="http://transparencia.uanl.mx/secciones/normatividad_vigente/archivos/reglamentos_internos_facultades/reg_int_ingenieriamecanicayelectrica.pdf">reglamento interno de la facultad</a>
                      </p>  
        </div>
    </form>
     <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js" integrity="sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s" crossorigin="anonymous"></script>
</body>
</html>
