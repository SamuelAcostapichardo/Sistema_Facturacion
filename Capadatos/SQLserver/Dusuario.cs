using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using Capadatos.SQLserver;

namespace Capadatos
{
    public class Dusuario:Conexion 
    {

        private int _Idusuario;
        private string _Nombre;
        private string _Apellidos;
        private string _Sexo;
        private DateTime _Fecha_Nacimiento;
        private string _Num_Documento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;        
        private string _Usuario;
        private string _Password;
        private string _TextoBuscar;

        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public DateTime Fecha_Nacimiento { get => _Fecha_Nacimiento; set => _Fecha_Nacimiento = value; }
        public string Num_Documento { get => _Num_Documento; set => _Num_Documento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }






        public Dusuario()
        {

        }



        public Dusuario(int idusuario, string nombre, string apellidos, string sexo,
           DateTime fecha_nacimiento, string num_documento, string direccion, string telefono,
           string email, string usuario, string password, string textobuscar)
        {
            this.Idusuario = idusuario;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Sexo = sexo;
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Num_Documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Usuario = usuario;
            this.Password = password;
            this.TextoBuscar = textobuscar;

        }


        public string Insertar(Dusuario Usuario)
        {
            using (var SqlCon = Getconection())
            {
                string Respuesta;
                SqlCon.Open();
                try
                {
                    using(var SqlCmd = GetSqlCommand())
                    {
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "spinsertar_usu";
                        SqlCmd.CommandType = CommandType.StoredProcedure;


                        SqlParameter ParIdtrabajador = new SqlParameter
                        {
                            ParameterName = "@Idusuario ",
                            SqlDbType = SqlDbType.Int,
                            Direction = ParameterDirection.Output
                        };
                        SqlCmd.Parameters.Add(ParIdtrabajador);

                        SqlParameter ParNombre = new SqlParameter
                        {
                            ParameterName = "@Nombre",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 20,
                            Value = Usuario.Nombre
                        };
                        SqlCmd.Parameters.Add(ParNombre);

                        SqlParameter ParApellidos = new SqlParameter
                        {
                            ParameterName = "@Apellidos",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 30,
                            Value = Usuario.Apellidos
                        };
                        SqlCmd.Parameters.Add(ParApellidos);

                        SqlParameter ParSexo = new SqlParameter
                        {
                            ParameterName = "@Sexo",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 1,
                            Value = Usuario.Sexo
                        };
                        SqlCmd.Parameters.Add(ParSexo);

                        SqlParameter ParFecha_Nacimiento = new SqlParameter
                        {
                            ParameterName = "@fecha_nac",
                            SqlDbType = SqlDbType.Date,
                            Size = 50,
                            Value = Usuario.Fecha_Nacimiento
                        };
                        SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                        SqlParameter ParNum_Documento = new SqlParameter
                        {
                            ParameterName = "@num_doc",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 8,
                            Value = Usuario.Num_Documento
                        };
                        SqlCmd.Parameters.Add(ParNum_Documento);

                        SqlParameter ParDireccion = new SqlParameter
                        {
                            ParameterName = "@Direccion",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 100,
                            Value = Usuario.Direccion
                        };
                        SqlCmd.Parameters.Add(ParDireccion);

                        SqlParameter ParTelefono = new SqlParameter
                        {
                            ParameterName = "@Telefono",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 10,
                            Value = Usuario.Telefono
                        };
                        SqlCmd.Parameters.Add(ParTelefono);

                        SqlParameter ParEmail = new SqlParameter
                        {
                            ParameterName = "@Email",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 50,
                            Value = Usuario.Email
                        };
                        SqlCmd.Parameters.Add(ParEmail);

                        SqlParameter ParUsuario = new SqlParameter
                        {
                            ParameterName = "@Usuario",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 20,
                            Value = Usuario.Usuario
                        };
                        SqlCmd.Parameters.Add(ParUsuario);

                        SqlParameter ParPassword = new SqlParameter
                        {
                            ParameterName = "@claveusu",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 20,
                            Value = Usuario.Password
                        };
                        SqlCmd.Parameters.Add(ParPassword);



                        Respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se inserto el Registro";
                    }
                }
                catch (Exception ex)
                {
                    Respuesta = ex.Message;
                    
                }
                return Respuesta;
            }
        }

        public string Editar(Dusuario Usuario)
        {
            using (var SqlCon = Getconection())
            {
                string Respuesta = "";
                SqlCon.Open();
                try
                {
                    
                    using (var SqlCmd = new SqlCommand())
                    {
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "speditar_usu";
                        SqlCmd.CommandType = CommandType.StoredProcedure;


                        SqlParameter ParIdtrabajador = new SqlParameter
                        {
                            ParameterName = "@Idusuario",
                            SqlDbType = SqlDbType.Int,
                            Value = Usuario.Idusuario
                        };
                        SqlCmd.Parameters.Add(ParIdtrabajador);

                        SqlParameter ParNombre = new SqlParameter
                        {
                            ParameterName = "@Nombre",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 20,
                            Value = Usuario.Nombre
                        };
                        SqlCmd.Parameters.Add(ParNombre);

                        SqlParameter ParApellidos = new SqlParameter
                        {
                            ParameterName = "@Apellidos",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 30,
                            Value = Usuario.Apellidos
                        };
                        SqlCmd.Parameters.Add(ParApellidos);

                        SqlParameter ParSexo = new SqlParameter
                        {
                            ParameterName = "@Sexo",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 1,
                            Value = Usuario.Sexo
                        };
                        SqlCmd.Parameters.Add(ParSexo);

                        SqlParameter ParFecha_Nacimiento = new SqlParameter
                        {
                            ParameterName = "@fecha_nac",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 50,
                            Value = Usuario.Fecha_Nacimiento
                        };
                        SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                        SqlParameter ParNum_Documento = new SqlParameter
                        {
                            ParameterName = "@num_doc",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 8,
                            Value = Usuario.Num_Documento
                        };
                        SqlCmd.Parameters.Add(ParNum_Documento);

                        SqlParameter ParDireccion = new SqlParameter
                        {
                            ParameterName = "@Direccion",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 100,
                            Value = Usuario.Direccion
                        };
                        SqlCmd.Parameters.Add(ParDireccion);

                        SqlParameter ParTelefono = new SqlParameter
                        {
                            ParameterName = "@Telefono",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 10,
                            Value = Usuario.Telefono
                        };
                        SqlCmd.Parameters.Add(ParTelefono);

                        SqlParameter ParEmail = new SqlParameter
                        {
                            ParameterName = "@Email",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 50,
                            Value = Usuario.Email
                        };
                        SqlCmd.Parameters.Add(ParEmail);

                        SqlParameter ParUsuario = new SqlParameter
                        {
                            ParameterName = "@Usuario",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 20,
                            Value = Usuario.Usuario
                        };
                        SqlCmd.Parameters.Add(ParUsuario);

                        SqlParameter ParPassword = new SqlParameter
                        {
                            ParameterName = "@claveusu",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 20,
                            Value = Usuario.Password
                        };
                        SqlCmd.Parameters.Add(ParPassword);


                        Respuesta = SqlCmd.ExecuteNonQuery()==1 ? "OK":"No se Actalizo el Registro";
                        
                    }
                }
                catch (Exception ex)
                {

                    Respuesta = ex.Message;
                   
                }
                return Respuesta;
            }
        }

        public string Eliminar(Dusuario Usuario)
        {
            using (var SqlCon = Getconection())
            {
                string Respuesta = "";
                SqlCon.Open();
                try
                {
                    using (var SqlCmd = new SqlCommand())
                    {
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "speliminar_usu";
                        SqlCmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter ParIdtrabajador = new SqlParameter
                        {
                            ParameterName = "@Idusuario",
                            SqlDbType = SqlDbType.Int,
                            Value = Usuario.Idusuario
                        };
                        SqlCmd.Parameters.Add(ParIdtrabajador);

                        Respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Registro";
                    }
                }
                catch (Exception ex)
                {

                    Respuesta = ex.Message;
                   
                }
                return Respuesta;
            }
        }

        public DataTable Mostrar()
        {
            using (var SqlCon = Getconection())
            {
                SqlCon.Open();
                using ( var Dtresultado = GetDataTable("Usuario"))
                {
                    try
                    {
                        using (var SqlCmd = GetSqlCommand())
                        {
                            SqlCmd.Connection = SqlCon;
                            SqlCmd.CommandText = "spmostar_usuario";
                            SqlCmd.CommandType = CommandType.StoredProcedure;

                            using (var sqldat = Getdataadapter(SqlCmd))
                            {
                                sqldat.Fill(Dtresultado);
                            }
                        }
                    }
                    catch (Exception)
                    {                      
                    }
                    return Dtresultado;
                }
            }
        }

        public DataTable Buscarapellidos(Dusuario Usuario)
        {
            using(var SqlCon = Getconection())
            {
                using (var Dtresultado = GetDataTable("Usuario"))
                {
                    try
                    {
                        using (var SqlCmd = GetSqlCommand())
                        {
                            SqlCmd.Connection = SqlCon;
                            SqlCmd.CommandText = "spbuscar_apellidos_usu";
                            SqlCmd.CommandType = CommandType.StoredProcedure;

                            SqlParameter ParTextoBuscar = new SqlParameter
                            {
                                ParameterName = "@texto",
                                SqlDbType = SqlDbType.VarChar,
                                Size = 50,
                                Value = Usuario.TextoBuscar
                            };
                            SqlCmd.Parameters.Add(ParTextoBuscar);

                            using (var sqldat = Getdataadapter(SqlCmd))
                            {
                                sqldat.Fill(Dtresultado);
                            }
                        }
                    }
                    catch (Exception)
                    {

                        
                    }
                    return Dtresultado;
                }
            }
        }

        public DataTable Buscarnum_doc(Dusuario Usuario)
        {
            using (var SqlCon = Getconection())
            {
                using (var Dtresultado = GetDataTable("Usuario"))
                {
                    try
                    {
                        using (var SqlCmd = GetSqlCommand())
                        {
                            SqlCmd.Connection = SqlCon;
                            SqlCmd.CommandText = "spnum_doc_usu";
                            SqlCmd.CommandType = CommandType.StoredProcedure;

                            SqlParameter ParTextoBuscar = new SqlParameter
                            {
                                ParameterName = "@texto",
                                SqlDbType = SqlDbType.VarChar,
                                Size = 50,
                                Value = Usuario.TextoBuscar
                            };
                            SqlCmd.Parameters.Add(ParTextoBuscar);

                            using (var Sqldat = Getdataadapter(SqlCmd))
                            {
                                Sqldat.Fill(Dtresultado);
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    return Dtresultado;
                }
            }
        }

        public bool Login(string Nombre, string Contraseña)
        {
            using (var conection = Getconection())
            {
                conection.Open();
                using (var command = GetSqlCommand())
                {
                    command.Connection = conection;
                    command.CommandText = "select * from Usuario where Usuario = @Usuario and claveusu =@claveusu";
                    command.Parameters.AddWithValue("@Usuario", Nombre);
                    command.Parameters.AddWithValue("@claveusu", Contraseña);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Datoscahe.Idusuario = reader.GetInt32(0);
                            Datoscahe.Nombre = reader.GetString(1);

                             Obtenerrol();


                        }
                        return true;

                    }
                    else
                        return false;
                }
            }
        }

        public void Obtenerrol()
        {
            using (var conection = Getconection())
            {
                conection.Open();
                using (var command = GetSqlCommand())
                {

                    command.Connection = conection;
                    command.CommandText = (" select * from Roles_usuario where Codigousuario = @Codigousuario ");
                    command.Parameters.AddWithValue("@Codigousuario", Datoscahe.Idusuario);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader Reader = command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            while (Reader.Read())
                                Datoscahe.Idrol = Reader.GetInt32(1);

                        }
                    }

                }

            }

        }

        public bool ValidarOpcion(int codigorol, string nombreopcion)
        {
            using (var conection = Getconection())
            {
                conection.Open();
                string strsql = "select * from vistapermisos where codigorol = '" + codigorol + "' and subopcion like  '" + nombreopcion + "' ";
                using (DataTable dt = GetDataTable(""))
                {
                    using (SqlDataAdapter da = Getsqlcon(strsql, conection))
                    {
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {

                            return bool.Parse(dt.Rows[0]["acceder"].ToString());

                        }
                        else
                        {
                            return true;
                        }
                    }
                 
                }
               
            }

        }

        //public string Passwordrecovery(string usuariopregunta)
        //{
        //    using (var conection = Getconection())
        //    {
        //        conection.Open();
        //        using (var command = new SqlCommand())
        //        {
        //            command.Connection = conection;
        //            command.CommandText = "select *from Empleado where Nombre_emp=@Nombre_emp or Correo_emp=@Correo_emp";
        //            command.Parameters.AddWithValue("@Nombre_emp", usuariopregunta);
        //            command.Parameters.AddWithValue("@Correo_emp", usuariopregunta);
        //            command.CommandType = CommandType.Text;
        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.Read() == true)
        //            {
        //                string nombreusuario = reader.GetString(1) + ", " + reader.GetString(2);
        //                string emailusuario = reader.GetString(4);
        //                string contraseña = reader.GetString(5);

        //                var soportedesistema = new Emailservice.soportedesistema();
        //                soportedesistema.SendMail(
        //                    subject: "SYSTEM: recuperacion de contraseña",
        //                    body: "Hola " + nombreusuario + "\n solicitud de recuperacion de contraseña.\n" +
        //                    "your current pasword is: " + contraseña +
        //                    "\n Debe cambiar la contraseña despues que inicie sesion en el sistema.",
        //                    recipienteMail: new List<string> { emailusuario }
        //                    );
        //                return "Hola " + nombreusuario + "\n pediste una recuperacion de tu contraseña.\n" +
        //                    "Por favor revise su correo:" + emailusuario + "\n Debe cambiar su contraseña inmediatamente inisie sesion en el systema.";

        //            }
        //            else
        //                return "Lo sentimos al parecer no tiene una cuenta registrada con nosotros";
        //        }
        //    }
        //}
    }
}
