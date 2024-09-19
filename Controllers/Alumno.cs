namespace WebApiSemana4.Controllers
{
    public class Alumno
    {
        // Creando propiedades
        string Nombre;
        string Apellido;
        string DNI;
        DateTime fechaNacimiento;

        //Constructor sin parametros
        public Alumno()
        { 
        Nombre = string.Empty;
        Apellido = string.Empty;
        DNI = string.Empty;
        fechaNacimiento = DateTime.Now;
        }

        //Constructor con parametros
        public Alumno(string pNombre, string pApellido, string pDNI)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            DNI = pDNI;
        }

        public Alumno(string pNombre, string pApellido, string pDNI, DateTime pfechaNacimiento)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            DNI = pDNI;
            fechaNacimiento = pfechaNacimiento;
        }

        public string DevolverNombreCompleto()
        { 
            return Nombre + " " + Apellido; 
        }

        public string DevolverDocumento()
        {
            return DNI;
        }

        public int DevolverEdad()
        {
            return DateTime.Now.Year - fechaNacimiento.Year;
        }
    }
}