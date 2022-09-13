namespace ClaseEmpleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sueldo;
            string nombre;
            string id;
            int horas;
            string opcion;
            Console.WriteLine("ingrese un nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su id");
            id = Console.ReadLine();
            Console.WriteLine("ingrese el sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese las horas de trabajo");
            horas = Convert.ToInt32(Console.ReadLine());

            Empleado empleado = new Empleado(nombre, id, sueldo, horas);

            empleado.retornarSalario(horas);
            Console.WriteLine("Desa hacer un incremento de salario si/no");
            opcion = Console.ReadLine();
            if(opcion == "si")
            {
                empleado.incrementar();

            }
            empleado.horasExtra();
            Console.WriteLine(empleado);
        }
    }
}