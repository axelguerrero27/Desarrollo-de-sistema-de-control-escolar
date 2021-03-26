<html>
<!-- Soto Gonzalez Maria Luisa
Factorial de un numero
09/10/2020
-->
    <head>
        <title> Factorial de un numero</title>
    </head>
    <body>
        <form method="post" action="factorial.php">
            <h1> Obtener el factorial del numero proporcionado por el usuario</h1>
          Numero: <input type="text" name="Numero" required>
            <br><br>
            <input type="submit" name="button" value="Calcular">
        </form>
    </body>
</html>
<?php
if(isset($_POST["Calcular"])){
}
function factorial($num){
    $fact='';
    for( $m = $num ; $m >= 1; $m--)
    {
        $fact=$fact*$m;
        }
    return $fact;
}
$resultado=factorial($num);
?>