using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio_09_JaenCarlo
{
    class Program
    {
        static void Main(string[] args)
        {

            Libro libro1 = new Libro("titulo");
            Libro libro2 = new Libro("titulo");
            // Metodos Libro
            Console.WriteLine("Metodos Libro\n");
            //Setter

            libro1.SetAutor("JaenCarlo");
            libro1.SetTitulo("La programacion");
            libro1.SetCodigoLibro(1145);
            libro1.SetCantidadPaginas(550);
            libro1.SetPrecioLibro(10.5);
            libro1.SetAnioPublicacion(DateTime.Now);

            libro2.SetAutor("Santiago");
            libro2.SetTitulo("Familia Linux");
            libro2.SetCodigoLibro(1151);
            libro2.SetCantidadPaginas(800);
            libro2.SetPrecioLibro(6.2);
            libro2.SetAnioPublicacion(DateTime.Now);

            //setters que modifiquen varios atributos

            libro1.SetModificarPrecioYtituloLibro(5.7,"NuevoTitulo");
            libro2.SetModificarDatosLibro("NuevoAutor",1000, new DateTime(2003,4,2));

            //Getter 
            Console.WriteLine($"Autor: {libro1.GetAutor()}");
            Console.WriteLine($"Titulo: {libro1.GetTitulo()}");
            Console.WriteLine($"Codigo Libro: {libro1.GetCodigoLibro()}");
            Console.WriteLine($"Cantidad de paginas: {libro1.GetcantidadPaginas()}");
            Console.WriteLine($"Precio: ${libro1.GetPrecio()}");
            Console.WriteLine($"Añio de publicacion: {libro1.GetAnioPubli()}");
            Console.WriteLine();
            Console.WriteLine($"Autor: {libro2.GetAutor()}");
            Console.WriteLine($"Titulo: {libro2.GetTitulo()}");
            Console.WriteLine($"Codigo Libro: {libro2.GetCodigoLibro()}");
            Console.WriteLine($"Cantidad de paginas: {libro2.GetcantidadPaginas()}");
            Console.WriteLine($"Precio: ${libro2.GetPrecio()}");
            Console.WriteLine($"Añio de publicacion: {libro2.GetAnioPubli()}");

            // Getters que retornan varios datos
            Console.WriteLine();
            Console.WriteLine(libro1.GetVerPrecioYcodigo());
            Console.WriteLine();
            Console.WriteLine(libro2.GetDatosCompletosLibro());

            // Al menos 3 métodos que realicen alguna funcionalidad para la clase. Uno de estos métodos debe tener 3 sobrecargas.
            Console.WriteLine( "\nEl precio de pedir 4 libros es " + libro1.PrecioComprarLibros(4)); 
           /////////////////////////////////////////////////


           Cliente cliente1 = new Cliente("nombre");
            Cliente cliente2 = new Cliente("nombre");

            // Metodos cliente
            Console.WriteLine("\nMetodos Cliente\n");

            //Setter

            cliente1.SetNombreCliente("Fernanda");
            cliente1.SetCedula("2-5774-2544");
            cliente1.SetGenero("Femenino");
            cliente1.SetEdad(28);
            cliente1.SetCorreo("fernanda@gmail.com");
            cliente1.SetTelefono("8456-5841");

            cliente2.SetNombreCliente("Maria");
            cliente2.SetCedula("2-6545-5445");
            cliente2.SetGenero("Femenino");
            cliente2.SetEdad(18);
            cliente2.SetCorreo("maria@gmail.com");
            cliente2.SetTelefono("1456-8441");

            //setters que modifiquen varios atributos
            cliente1.SetModificarDatosContacto("nuevoCorreo@gmail.com", "6061-1409");
            cliente2.SetModificarDatosCliente("Jose",25,"Masculino");

            // Getter
            Console.WriteLine();
            Console.WriteLine($"Nombre Cliente: {cliente1.GetNombreCliente()}");
            Console.WriteLine($"Cedula: {cliente1.GetCedula()}");
            Console.WriteLine($"Genero: {cliente1.GetGenero()}");
            Console.WriteLine($"Edad: {cliente1.GetEdad()}");
            Console.WriteLine($"Correo: {cliente1.GetCorreoCliente()}");
            Console.WriteLine($"Celular: {cliente1.GetTelefono()}");
            Console.WriteLine();
            Console.WriteLine($"Nombre Cliente: {cliente2.GetNombreCliente()}");
            Console.WriteLine($"Cedula: {cliente2.GetCedula()}");
            Console.WriteLine($"Genero: {cliente2.GetGenero()}");
            Console.WriteLine($"Edad: {cliente2.GetEdad()}");
            Console.WriteLine($"Correo: {cliente2.GetCorreoCliente()}");
            Console.WriteLine($"Celular: {cliente2.GetTelefono()}");

            // Getters que retornan varios datos
            Console.WriteLine();
            Console.WriteLine(cliente2.GetContactarCliente());
            Console.WriteLine();
            Console.WriteLine(cliente1.GetDatosCompletosCliente());

            //////////////////////////////////////////////////
            Console.ReadKey();
        }
    }

    class Libro
    {
        private string autor;
        private string titulo;
        private int codigoLibro;
        private int cantidadPaginas;
        private double precio;
        private DateTime anioPublicacion;


        //3 Constructores con sobre carga

        public Libro(string autor)
        {
            this.autor = autor;
        }

        public Libro(string titulo, int codigoLibro, double precio)
        {
            this.titulo = titulo;
            this.codigoLibro = codigoLibro;
            this.precio = precio;
        }

        public Libro(DateTime anio, int cantidadPaginas)
        {
            anioPublicacion = anio;
            this.cantidadPaginas = cantidadPaginas;
           
        }
        // Metodos de acceso - libro
        // Getter
        public string GetAutor()
        {
            return autor;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public int GetCodigoLibro()
        {
            return codigoLibro;
        }

        public int GetcantidadPaginas()
        {
            return cantidadPaginas;
        }

        public double GetPrecio()
        {
            return precio;
        }
        
        public DateTime GetAnioPubli()
        {
            return anioPublicacion.Date;
        }

        /// Getter que retornan varios atributos
        public string GetVerPrecioYcodigo()
        {
            string info = $"El codigo del libro es {codigoLibro} y el precio del libro es: {precio}" ;
            return info;
        }
        
        public string GetDatosCompletosLibro()
        {
            string info = $"El autor del libro es {autor}\n" +
                $"El titulo del libro es {titulo}\n" +
                $"El codigo del libro es {codigoLibro}\n" +
                $"El libro tiene {cantidadPaginas} de paginas en total\n" +
                $"El precio del libro es ${precio}\n" +
                $"La fecha de publicacion del libro es: {anioPublicacion}";
            return info;
        }
        // Setter

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void SetCodigoLibro(int codigoLibro)
        {
            this.codigoLibro = codigoLibro;
        }

        public void SetCantidadPaginas(int cantidadPaginas)
        {
            this.cantidadPaginas = cantidadPaginas;
        }

        public void SetPrecioLibro(double precio)
        {
            this.precio = precio;
        }

        public void SetAnioPublicacion(DateTime anio)
        {
            anioPublicacion = anio;
        }

        //setters que modifiquen varios atributos

        public void SetModificarPrecioYtituloLibro(double precio, string titulo)
        {
            this.precio = precio;
            this.titulo = titulo;
        }

        public void SetModificarDatosLibro(string autor, int cantidadPaginas, DateTime anio)
        {
            this.autor = autor;
            this.cantidadPaginas = cantidadPaginas;
            this.anioPublicacion = anio;
        }

        //Al menos 3 métodos que realicen alguna funcionalidad para la clase.Uno de estos métodos debe tener 3 sobrecargas.
        public double PrecioComprarLibros(int cantidad)
        {
            double precioLibro;

            precioLibro = precio;

            precioLibro = precioLibro * cantidad;

            return precioLibro;
        }
    }

    class Cliente{
        private string nombreCliente;
        private string cedula;
        private string genero;
        private int edad;
        private string correoCliente;
        private string telefono;


        //3 Constructores con sobre carga

        public Cliente(string nombreCliente)
        {
            this.nombreCliente = nombreCliente;
        }

        public Cliente(string cedula, string genero, int edad)
        {
            this.cedula = cedula;
            this.genero = genero;
            this.edad = edad;
        }

        public Cliente(string correo, string telefono)
        {
            correoCliente = correo;
            this.telefono = telefono;

        }
        // Metodos de acceso Cliente
        // Getter
        public string GetNombreCliente()
        {
            return nombreCliente;
        }

        public string GetCedula()
        {
            return cedula;
        }

        public string GetGenero()
        {
            return genero;
        }

        public int GetEdad()
        {
            return edad;
        }

        public string GetCorreoCliente()
        {
            return correoCliente;
        }

        public string GetTelefono()
        {
            return telefono;
        }

        /// Getter que retornan varios atributos
        public string GetContactarCliente()
        {
            string info = $"Contactar Cliente:\n" +
                $"Correo: {correoCliente}\n" +
                $"Telefono: {telefono}";
            return info;
        }

        public string GetDatosCompletosCliente()
        {
            string info = $"El Nombre del cliente es {nombreCliente}\n" +
                $"La cedula del cliente es {cedula}\n" +
                $"El genero del cliente es {genero}\n" +
                $"La edad del cliente es {edad}\n" +
                $"El correo del cliente es {correoCliente}\n" +
                $"El telefono del cliente es {telefono}";
            return info;
        }
        // Setter

        public void SetNombreCliente(string nombre)
        {
            nombreCliente = nombre;
        }

        public void SetCedula(string cedula)
        {
            this.cedula = cedula;
        }

        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetCorreo(string correo)
        {
            correoCliente = correo;
        }

        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        //setters que modifiquen varios atributos

        public void SetModificarDatosContacto(string correo, string telefono)
        {
            correoCliente = correo;
            this.telefono = telefono;
        }

        public void SetModificarDatosCliente(string nombre, int edad, string genero)
        {
            nombreCliente = nombre;
            this.edad = edad;
            this.genero = genero;
        }
    }
}
