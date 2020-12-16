using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Windows.Forms;
using Capanegocio;

namespace sinnombre
{
    public partial class Registro_de_terminales : Form
    {
        public Registro_de_terminales()
        {
            InitializeComponent();
        }


        public static string GetMachingGuid()
        {
            string Location = @"SOFTWARE\Microsoft\Cryptography";
            string Name = "MachineGuid";
            using (RegistryKey LocalMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey Rk = LocalMachineX64View.OpenSubKey(Location))
                {
                    if (Rk == null)
                        throw new KeyNotFoundException(string.Format("Key Not Found: {0}", Name));
                    object MachineGuid = Rk.GetValue(Name);
                    if (MachineGuid == null)
                        throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", Name));
                    return MachineGuid.ToString();
                }
            }
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            string Respuesta = "";
            if (Txtnombre.Text == string.Empty & Txtidenti.Text == string.Empty)
            {
                MessageBox.Show("Faltan datos por ingresar");
                Error.SetError(Txtnombre,"Ingrese un nombre para la terminal");
                Error.SetError(Txtidenti,"Ingrese el identificador unico del terminal");
            }
            else
            {
               Respuesta = Nusuario.Terminal(Txtnombre.Text,Txtidenti.Text,Cmbestatus.Text); 
            }

            if (Respuesta.Equals("OK"))
            {
                MessageBox.Show("Se inserto de forma correcta la terminal");
            }
        }

        private void Btngenerar_Click(object sender, EventArgs e)
        {
            Txtidenti.Text = GetMachingGuid();
        }
    }
}
