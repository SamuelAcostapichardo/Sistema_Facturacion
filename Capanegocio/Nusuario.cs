using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capadatos;
using System.Data;

namespace Capanegocio
{                                   
   public class Nusuario: Conexion
    {
        

        public static string Insertar(string nombre, string apellidos, string sexo,
         DateTime fecha_nacimiento, string num_documento,
         string direccion, string telefono, string email,
         string usuario, string password)
        {
            Dusuario Obj = new Dusuario
            {
                Nombre = nombre,
                Apellidos = apellidos,
                Sexo = sexo,
                Fecha_Nacimiento = fecha_nacimiento,
                Num_Documento = num_documento,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                Usuario = usuario,
                Password = password
            };

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DTrabajador
        //de la CapaDatos
        public static string Editar(int idtrabajador, string nombre, string apellidos,
            string sexo,
            DateTime fecha_nacimiento, string num_documento,
            string direccion, string telefono, string email, string usuario,
            string password)
        {
            Dusuario Obj = new Dusuario
            {
                Idusuario = idtrabajador,
                Nombre = nombre,
                Apellidos = apellidos,
                Sexo = sexo,
                Fecha_Nacimiento = fecha_nacimiento,
                Num_Documento = num_documento,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                Usuario = usuario,
                Password = password
            };
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DTrabajador
        //de la CapaDatos
        public static string Eliminar(int idtrabajador)
        {
            Dusuario Obj = new Dusuario
            {
                Idusuario = idtrabajador
            };
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DTrabajador
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dusuario().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DTrabajador de la CapaDatos

        public static DataTable BuscarApellidos(string textobuscar)
        {
            Dusuario Obj = new Dusuario
            {
                TextoBuscar = textobuscar
            };
            return Obj.Buscarapellidos(Obj);
        }

        //Método BuscarNum_Documento que llama al método BuscarNum_Documento
        //de la clase DTRabajador de la CapaDatos

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            Dusuario Obj = new Dusuario
            {
                TextoBuscar = textobuscar
            };
            return Obj.Buscarnum_doc(Obj);
        }


        public bool Loginusuario(string usuario, string password)
        {
            Dusuario Form = new Dusuario();
            return Form.Login(usuario,password);
        }


        public bool Validaropcion(int codigo, string nombreopcion)
        {
            Dusuario Form = new Dusuario();
            return Form.ValidarOpcion(codigo,nombreopcion);
        }
    }
}
