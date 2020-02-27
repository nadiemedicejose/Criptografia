using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.InteropServices;

namespace Criptografia
{
    public partial class interfaz : Form
    {
        bool nuevo = false;
        public interfaz()
        {
            InitializeComponent();
        }

        private void chPritaveKey_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !chContraseña.Checked;
        }

        private void cbDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbOpciones.SelectedItem.Equals("Archivo") || cbOpciones.SelectedItem.Equals("Imagen"))
            {
                txtFileLocation.Enabled = true;
                btnBuscar.Enabled = true;
                txtTextoPlano.Enabled = false;
                txtTextoCifrado.Enabled = false;
            }
            else if (cbOpciones.SelectedItem.Equals("Texto plano"))
            {
                txtFileLocation.Enabled = false;
                btnBuscar.Enabled = false;
                txtTextoPlano.Enabled = true;
                txtTextoCifrado.Enabled = true;
            }

            txtFileLocation.Text = "";
            txtTextoPlano.Text = "";
            txtTextoCifrado.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbOpciones.SelectedItem.Equals("Archivo"))
                {
                    if (abrirArchivo.ShowDialog() == DialogResult.OK)
                    {
                        txtFileLocation.Text = abrirArchivo.FileName;
                    }
                }
                else if (cbOpciones.SelectedItem.Equals("Imagen"))
                {
                    if (abrirImagen.ShowDialog() == DialogResult.OK)
                    {
                        txtFileLocation.Text = abrirImagen.FileName;
                    }
                }
            } catch (ArgumentNullException)
            {
                MessageBox.Show("Debes seleccionar un tipo de fichero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        byte[] Encriptar(byte[] bytesAencriptar, byte[] clave)
        {
            byte[] bytesEncriptados = null;
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(clave, salt, 1000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.Zeros;
                    using (var crp = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        crp.Write(bytesAencriptar, 0, bytesAencriptar.Length);
                        crp.Close();
                    }
                    bytesEncriptados = ms.ToArray();
                }
            }
            return bytesEncriptados;
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                string contraseña = txtContraseña.Text;

                if (cbOpciones.SelectedItem.Equals("Archivo"))
                {
                    var data = abrirArchivo.FileName;
                    byte[] archivoAencriptar = File.ReadAllBytes(data);
                    byte[] clave = Encoding.UTF8.GetBytes(contraseña);
                    clave = SHA256.Create().ComputeHash(clave);
                    byte[] archivoEncriptado = Encriptar(archivoAencriptar, clave);
                    File.WriteAllBytes(data, archivoEncriptado);
                    MessageBox.Show("Encriptaste el archivo " + abrirArchivo.FileName);
                }else if (cbOpciones.SelectedItem.Equals("Imagen"))
                {
                    var data = abrirImagen.FileName;
                    byte[] imagenAencriptar = File.ReadAllBytes(data);
                    byte[] clave = Encoding.UTF8.GetBytes(contraseña);
                    clave = SHA256.Create().ComputeHash(clave);
                    byte[] imagenEncriptada = Encriptar(imagenAencriptar, clave);
                    File.WriteAllBytes(data, imagenEncriptada);
                    MessageBox.Show("Encriptaste la imagen " + abrirImagen.FileName);
                }
                else if (cbOpciones.SelectedItem.Equals("Texto plano"))
                {
                    string data = txtTextoPlano.Text;
                    byte[] textoAencriptar = Encoding.UTF8.GetBytes(data);
                    byte[] clave = Encoding.UTF8.GetBytes(contraseña);
                    clave = SHA256.Create().ComputeHash(clave);
                    byte[] textoEncriptado = Encriptar(textoAencriptar, clave);
                    txtTextoCifrado.Text = Convert.ToBase64String(textoEncriptado);

                    txtTextoPlano.Text = null;
                } else
                {
                    MessageBox.Show("Debes seleccionar un fichero a encriptar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtContraseña.Text = null;
                chContraseña.Checked = false;
            } catch (ArgumentNullException)
            {
                MessageBox.Show("Debes seleccionar un fichero a encriptar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        byte[] Desencriptar(byte[] bytesAdesencriptar, byte[] clave)
        {
            byte[] bytesDesencriptados = null;
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(clave, salt, 1000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.Zeros;
                    using (var crp = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        crp.Write(bytesAdesencriptar, 0, bytesAdesencriptar.Length);
                        crp.Clear(); // Arroja error cuando un fichero encriptado requiere una contraseña y no se proporciona
                    }
                    bytesDesencriptados = ms.ToArray();
                }
            }
            return bytesDesencriptados;
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            try
            {
                string contraseña = txtContraseña.Text;

                if (cbOpciones.SelectedItem.Equals("Archivo"))
                {
                    var data = abrirArchivo.FileName;
                    byte[] archivoAdesencriptar = File.ReadAllBytes(data);
                    byte[] clave = Encoding.UTF8.GetBytes(contraseña);
                    clave = SHA256.Create().ComputeHash(clave);
                    byte[] archivoDesencriptado = Desencriptar(archivoAdesencriptar, clave);
                    File.WriteAllBytes(data, archivoDesencriptado);
                    MessageBox.Show("Desencriptaste el archivo " + abrirArchivo.FileName);
                }
                else if (cbOpciones.SelectedItem.Equals("Imagen"))
                {
                    var data = abrirImagen.FileName;
                    byte[] imagenAdesencriptar = File.ReadAllBytes(data);
                    byte[] clave = Encoding.UTF8.GetBytes(contraseña);
                    clave = SHA256.Create().ComputeHash(clave);
                    byte[] imagenDesencriptada = Desencriptar(imagenAdesencriptar, clave);
                    File.WriteAllBytes(data, imagenDesencriptada);
                    MessageBox.Show("Desencriptaste la imagen " + abrirImagen.FileName);
                }
                else if (cbOpciones.SelectedItem.Equals("Texto plano"))
                {
                    string data = txtTextoCifrado.Text;
                    byte[] textoAdesencriptar = Convert.FromBase64String(data);
                    byte[] clave = Encoding.UTF8.GetBytes(contraseña);
                    clave = SHA256.Create().ComputeHash(clave);
                    byte[] textoDesencriptado = Desencriptar(textoAdesencriptar, clave);
                    txtTextoPlano.Text = Encoding.UTF8.GetString(textoDesencriptado);

                    txtTextoCifrado.Text = null;
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un fichero a desencriptar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtContraseña.Text = null;
                chContraseña.Checked = false;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Debes seleccionar un fichero a desencriptar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
