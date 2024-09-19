using Microsoft.AspNetCore.Mvc;

namespace WebApiSemana4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("DevolverSuma/{Numero1}/{Numero2}")]
        public int DevolverSuma(int Numero1, int Numero2)
        {
            return Numero1 + Numero2;
        }

        [HttpGet("DevolverResta/{Numero1}/{Numero2}")]
        public int DevolverResta(int Numero1, int Numero2)
        {
            int numero;
            numero = 10;
            string saludo = "Hola Mundo";
            bool existe = true;
            double flotante = 15.5;
            DateTime hoy = DateTime.Now;
            return Numero1 - Numero2;
        }

        [HttpGet("DevolverSaludo/{Nombre}")]
        public string DevolverSaludo(string Nombre)
        {
            return "Hola " + Nombre;
        }

        [HttpGet("DevolverValor")]
        public int DevolverValor()
        {
            int num1 = 8;
            int num2 = 5;
            int num3 = num1 - num2;

            num2 = num1 * num3;
            num3 = num2 + num1 * num2;
            num1 = num3 / num1;
            num2 = num1 % num2;
            return num1;
        }

        [HttpGet("DevolverSaludo")]
        public string DevolverSaludo()
        {
            string variable1 = "Pedro";
            string variable2 = "Juan";
            string variable3 = variable1 + variable2;
            int num1 = 7;
            string variable4 = variable3 + num1.ToString();
            string mensaje = "Hola " + variable4;
            return mensaje;
        }

        [HttpGet("DevolverMayor/{num1}/{num2}")]
        public string DevolverMayor(int num1, int num2)
        {
            if (num1 > num2)
            {
                return "El mayor es " + num1.ToString();
            }
            else
            {
                return "El mayor es " + num2.ToString();
            }
        }
        
        [HttpGet("DevolverEstado/{edad}/{Nombre}")]
        public string DevolverEstado(int edad, string Nombre)
        {
            string mensaje = "";
            if (edad >= 18)
            {
                mensaje = "Sr(a) " + Nombre + " es mayor de edad";
            }
            else
            {
                mensaje = "Sr(a) " + Nombre + " es menor de edad";
            }
            return mensaje;
        }

        [HttpGet("DevolverAlumno")]
        public string DevolverAlumno()
        {
            string mensaje = string.Empty;
            Alumno Alumno1= new Alumno();
            Alumno Alumno2 = new Alumno("Juan","Perez","4370258");
            return Alumno2.DevolverDocumento();
        }

        [HttpGet("DevolverEdad")]
        public int DevolverEdad()
        {
            string mensaje = string.Empty;
            Alumno Alumno2 = new Alumno("Edwin", "Paredes", "4370258", new DateTime(1986, 3, 6));
            return Alumno2.DevolverEdad();
        }
    }
}