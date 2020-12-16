using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capanegocio;
using System.Security.Cryptography;
using Capapresentacion;
using Capadatos.SQLserver;

namespace sinnombre
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Facturacion_CedanoEntities3 Fac = new Facturacion_CedanoEntities3();
        private void Txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.DimGray;

            }
        }

        private void Txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void Txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "PASSWORD")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.DimGray;
                //txtpassword.UseSystemPasswordChar = true;

            }
        }

        private void Txtpassword_Leave(object sender, EventArgs e)
        {

            if (txtpassword.Text == "")
            {
                txtpassword.Text = "PASSWORD";
                txtpassword.ForeColor = Color.DimGray;
                //  txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void Msgerror(string msg)
        {
            lblmsg.Text = "   " + msg;
            lblmsg.Visible = true;
        }

        private void Linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperarcontraseña = new Capapresentacion.Recuperaciondecontraseña();
            recuperarcontraseña.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();           
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public Usuario loguin(string User, string Password)
        {
<<<<<<< HEAD
            var Usuar = Fac.Usuarios.SingleOrDefault(a => a.Usuario1.Equals(User));
=======
            var Usuar = Fac.Usuario.SingleOrDefault(a => a.Usuario1.Equals(User));
>>>>>>> eb6a654beff551655a11eec0317c5009a9f4e607
            if (Usuar != null)
            {
                if (BCrypt.Net.BCrypt.Verify(Password, Usuar.claveusu))
                {
                    Datoscahe.Idusuario = Usuar.idusuario;
                    return Usuar;
                }
            }
            return null;
        }


        private void Btnlogin_Click(object sender, EventArgs e)
        {
            Nusuario N = new Nusuario();
            var Log = N.Login2();
            if (Log == true)  
            {
                if (txtusuario.Text != "USUARIO" & txtpassword.TextLength > 2 & txtpassword.Text != "PASSWORD")
                {
                    var usuario = loguin(txtusuario.Text, txtpassword.Text);
                    if (usuario != null)
                    {
                        Frmprimcipal D = new Frmprimcipal();
                        D.Show();
                        D.FormClosed += Cerrarsesion;
                        this.Hide();
                    }
                    else
                    {
                        Msgerror("Usuario o contraseña incorrectos.\n por favor intente de nuevo");
                        txtpassword.Clear();
                        txtpassword.Text = "PASSWORD";
                        txtusuario.Clear();
                        txtusuario.Focus();
                    }
                }
            }
            else
            {
                Msgerror("Terminal no esta registrada en el sistema");
            }
        }


//         if (txtusuario.Text != "USUARIO" & txtusuario.TextLength > 2 & txtpassword.Text != "PASSWORD")
//                    {
//                        var validologin = user.Loginusuario(txtusuario.Text, txtpassword.Text);

//                        if (validologin == true)
//                        {
//                            Frmprimcipal D = new Frmprimcipal();
//        D.Show();
//                            D.FormClosed += Cerrarsesion;
//                            this.Hide();
//    }
//                        else Msgerror("Usuario o contraseña incorrectos.\n por favor intente de nuevo");
//    txtpassword.Text = "PASSWORD";
//                        txtusuario.Focus();
//                    }
//                    else
//{
//    Msgerror("porfavor introdusca la contraseña.");
//}






private void Cerrarsesion(object sender, FormClosedEventArgs e)
    {
            txtpassword.Clear();
            //  txtusuario.Clear();
            lblmsg.Visible = false;
            this.Show();
            txtusuario.Focus();
    }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           // label1.Text = DateTime.Now.ToString();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

<<<<<<< HEAD
        private void Terminal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro_de_terminales F = new Registro_de_terminales();
            F.ShowDialog();
=======
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro_Terminal Re = new Registro_Terminal();
            Re.ShowDialog();
>>>>>>> eb6a654beff551655a11eec0317c5009a9f4e607
        }
    }
}
