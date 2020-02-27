using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class configuracion : Form
    {
        string algoritmo, modo, hash;
        public configuracion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // validar selección de algoritmo de encriptación
            if (algoritmoAES.Checked == true)
            {
                algoritmo = "AES";
            }
            else if (algoritmoAES.Checked == true)
            {
                algoritmo = "DES";
            }
            else if (algoritmo3DES.Checked == true)
            {
                algoritmo = "3DES";
            }
            else if (algoritmoRijndael192.Checked == true)
            {
                algoritmo = "Rijndael192";
            }
            else if (algoritmoRijndael256.Checked == true)
            {
                algoritmo = "Rijndael256";
            }
            else if (algoritmoTwofish.Checked == true)
            {
                algoritmo = "Twofish";
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún algoritmo de encriptación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // validar selección de modo de encriptación
            if (modoECB.Checked == true)
            {
                modo = "ECB";
            }
            else if (modoOFB.Checked == true)
            {
                modo = "OFB";
            }
            else if (modoNOFB.Checked == true)
            {
                modo = "NOFB";
            }
            else if (modoCBC.Checked == true)
            {
                modo = "CBC";
            }
            else if (modoCFB.Checked == true)
            {
                modo = "CFB";
            }
            else if (modoNCFB.Checked == true)
            {
                modo = "NCFB";
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún modo de encriptación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // validar selección de hash
            if (hashSHA256.Checked == true)
            {
                hash = "SHA256";
            }
            else if (hashSHA512.Checked == true)
            {
                hash = "SHA512";
            }
            else if (hashNinguno.Checked == true)
            {
                hash = "Ninguno";
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún hash", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Guardar valores
            if (string.IsNullOrEmpty(algoritmo) || string.IsNullOrEmpty(modo) || string.IsNullOrEmpty(hash))
            {
                groupBox1.Focus();
            } else
            {
                interfaz objInterfaz = new interfaz();
                objInterfaz.Show();
                this.Hide();
            }
        }
    }
}
