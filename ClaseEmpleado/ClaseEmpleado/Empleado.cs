using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEmpleado
{
    internal class Empleado
    {
        public string nombre;
        public string id;
        public int sueldo;
        public int horas;


        public Empleado(string a, string b, int c, int d)
        {
            this.nombre = a;
            this.id = b;
            this.sueldo = c;
            this.horas = d;
        }
        public int retornarSalario(int a)
        {
            int salario = sueldo * a;
            sueldo = salario;
            return salario;
        }
        public int incrementar()
        {
            
            if(sueldo <= 1500000)
            {
                sueldo += 100000;
            }
            return sueldo;
        }
        public int horasExtra()
        {

            if (horas > 6)
            {
                sueldo += 5000;
            }
            return sueldo;
        }

        public override string ToString()
        {
            return $"El sueldo del empleado {nombre} es de {sueldo}";
        }


    }
}
