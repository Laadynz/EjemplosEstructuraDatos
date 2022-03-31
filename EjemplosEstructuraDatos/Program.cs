using EjemplosEstructuraDatos;

List<Alumno> lista = new List<Alumno>();

Alumno alumno1 = new Alumno();
alumno1.Nombres = "Antonio";
alumno1.ApellidoPaterno = "Rogel";
alumno1.Matricula = "123";
alumno1.FechaNacimiento = new DateTime(1985,03,05);


Alumno alumno2 = new Alumno();
alumno2.Nombres = "Lady";
alumno2.ApellidoPaterno = "Nuñez";
alumno2.Matricula = "2130050";
alumno2.FechaNacimiento = new DateTime(1988,12,21);


Alumno alumno3 = new Alumno();
alumno3.Nombres = "Eyva Lucia";
alumno3.ApellidoPaterno = "Rogel";
alumno3.ApellidoMaterno = "Nuñez";
alumno3.Matricula = "123456";
alumno3.FechaNacimiento = new DateTime(2017,08,21);

lista.Add(alumno1);
lista.Add(alumno2);
lista.Add(alumno3);

foreach (Alumno alumnoEnLista in lista) 
{
    Console.WriteLine(
        " Nombre: "
        + alumnoEnLista.NombreCompleto 
        + " Matricula: " 
        + alumnoEnLista.Matricula 
        + " fecha nacimiento: " 
        + alumnoEnLista.FechaNacimiento.ToString("dd-MM-yyyy"));
}