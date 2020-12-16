using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Windows.Forms;

namespace sinnombre
{
    public partial class Registro_Terminal : Form
    {
        public Registro_Terminal()
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


        private void Btngen_Click(object sender, EventArgs e)
        {
            try
            {
                Txtid.Text = GetMachingGuid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
