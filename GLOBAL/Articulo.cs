using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    class Articulo
    {
        private int codigo_articulo;
        private string nombre_articulo;
        private string nombre_proveedor;
        private string tipo;
        private int  posicion_estante;
        private int fecha_vencimiento;
        private double precio;
        public double size;

        private struct articulo
        {
            public int codigo_articulo;
            public string nombre_articulo;
            public string nombre_proveedor;
            public string tipo;
            public int posicion_estante;
            public int fecha_vencimiento;
            public double precio;
            
        };

        private static articulo[] articulos;

        //constructor
        public Articulo()
        {
            codigo_articulo = 0;
            nombre_articulo = "";
            nombre_proveedor = "";
            tipo = "";
            posicion_estante = 0;
            fecha_vencimiento = 0;
            precio = 0;
        }

        //contructor con parámetros
        public Articulo(int id, string nombre, string proveedor,string tipo,int  pos,int fecha, double precio)
        {
            codigo_articulo = id;
            nombre_articulo = nombre;
            nombre_proveedor = proveedor;
            this.tipo = tipo;
            posicion_estante = pos;
            fecha_vencimiento = fecha;
            this.precio = precio;
        }

        
        //propiedades 
        public void Setcodigo_articulo(int id)
        {
            codigo_articulo = id;
        }

        public int Getcodigo_articulo()
        {
            return codigo_articulo;
        }

        public void Setnombre_articulo(string nombre)
        {
            nombre_articulo = nombre;
        }

        public string Getnombre_articulo()
        {
            return nombre_articulo;
        }

        public void Setnombre_proveedor(string proveedor)
        {
            nombre_proveedor = proveedor;
        }

        public string Getnombre_proveedor()
        {
            return nombre_proveedor;
        }

        public void Settipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string Gettipo()
        {
            return tipo;
        }

        public void Setposicion_estante(int pos)
        {
            posicion_estante = pos;
        }

        public int Getposicion_estante()
        {
            return posicion_estante;
        }

        public void Setfecha_vencimiento(int fecha)
        {
            fecha_vencimiento = fecha;
        }

        public int Getfecha_vencimiento()
        {
            return fecha_vencimiento;
        }

        public void Setprecio(double precio)
        {
            this.precio = precio;
        }

        public double Getprecio()
        {
            return precio;
        }

        public void SetSize(int Size)
        {
            size = Size;
            articulos = new articulo[Size];
        }

        public void Initdata()
        {
            //inicializar
            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i].codigo_articulo = 0;
                articulos[i].nombre_articulo = "";
                articulos[i].nombre_proveedor = "";
                articulos[i].tipo = "";
                articulos[i].posicion_estante = 0;
                articulos[i].fecha_vencimiento = 0;
                articulos[i].precio = 0;


            }
        }

        public bool AddData(Global.Articulo articulo)
        {
            //agregar datos
            int i;
            for (i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].codigo_articulo == 0)
                {
                    break;
                }
            }

            if (i < articulos.Length)
            {
                articulos[i].codigo_articulo = articulo.codigo_articulo;
                articulos[i].nombre_articulo = articulo.nombre_articulo;
                articulos[i].nombre_proveedor = articulo.nombre_proveedor;
                articulos[i].tipo = articulo.tipo;
                articulos[i].posicion_estante = articulo.posicion_estante;
                articulos[i].fecha_vencimiento = articulo.fecha_vencimiento;
                articulos[i].precio = articulo.precio;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SeekData(int record)
        {
            //buscar datos
            int i;
            for (i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].codigo_articulo == record)
                {
                    break;
                }
            }

            if (i < articulos.Length)
            {
                codigo_articulo = articulos[i].codigo_articulo;
                nombre_articulo = articulos[i].nombre_articulo;
                nombre_proveedor = articulos[i].nombre_proveedor;
                tipo = articulos[i].tipo;
                posicion_estante = articulos[i].posicion_estante;
                fecha_vencimiento = articulos[i].fecha_vencimiento;
                precio = articulos[i].precio;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateData(Global.Articulo articulo, int record)
        {
            //actualizar datos
            int i;
            for (i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].codigo_articulo == record)
                {
                    break;
                }
            }

            if (i < articulos.Length)
            {
                articulos[i].codigo_articulo = articulo.codigo_articulo;
                articulos[i].nombre_articulo = articulo.nombre_articulo;
                articulos[i].nombre_proveedor = articulo.nombre_proveedor;
                articulos[i].tipo = articulo.tipo;
                articulos[i].posicion_estante = articulo.posicion_estante;
                articulos[i].fecha_vencimiento = articulo.fecha_vencimiento;
                articulos[i].precio = articulo.precio;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteData(int record)
        {
            //borrar datos
            int i;
            for (i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].codigo_articulo == record)
                {
                    break;
                }
            }

            if (i < articulos.Length)
            {
                articulos[i].codigo_articulo = 0;
                articulos[i].nombre_articulo = "";
                articulos[i].nombre_proveedor = "";
                articulos[i].tipo = "";
                articulos[i].posicion_estante = 0;
                articulos[i].fecha_vencimiento = 0;
                articulos[i].precio = 0;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintData(int pos)
        {
            //imprimir todo el registro
            codigo_articulo = articulos[pos].codigo_articulo;
            nombre_articulo = articulos[pos].nombre_articulo;
            nombre_proveedor = articulos[pos].nombre_proveedor;
            tipo = articulos[pos].tipo;
            posicion_estante = articulos[pos].posicion_estante;
            fecha_vencimiento = articulos[pos].fecha_vencimiento;
            precio = articulos[pos].precio;
        }

        // destructor
        ~Articulo()
        {

        }
    }
}
