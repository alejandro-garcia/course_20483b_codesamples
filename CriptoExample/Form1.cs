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

namespace CriptoExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClavesAsimetricasEnviador_Click(object sender, EventArgs e)
        {
            CrearClavesAsimetricas(ref txtPrivadaAsimetricaEnviador, ref txtPublicaAsimetricaEnviador);

        }

        private void btnClavesAsimetricasReceptor_Click(object sender, EventArgs e)
        {
            CrearClavesAsimetricas(ref txtPrivadaAsimetricaReceptor, ref txtPublicaAsimetricaReceptor);
        }

        private void CrearClavesAsimetricas(ref TextBox _texto1, ref TextBox _texto2)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            _texto1.Text = rsa.ToXmlString(true);
            _texto2.Text = rsa.ToXmlString(false);
        }

        private void btnSimetricaReceptor_Click(object sender, EventArgs e)
        {
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.GenerateIV();
            tdes.GenerateKey();
            txtSimetricaIVReceptor.Text = Convert.ToBase64String(tdes.IV);
            txtSimetricaKeyReceptor.Text = Convert.ToBase64String(tdes.Key);
        }

        private void btnEncriptarInformacionClave_Click(object sender, EventArgs e)
        {
            EncriptarClaves();
            txtValorHashReceptor.Text = Convert.ToBase64String(CrearValorHashReceptor(txtClaveEncriptadaReceptor.Text));
            CrearFirmaSimetricaValorHash();
        }

        private void EncriptarClaves()
        {
            Byte[] iv, encriptadaIV;
            Byte[] key, encriptadaKEY;

            iv = Convert.FromBase64String(txtSimetricaIVReceptor.Text);
            key = Convert.FromBase64String(txtSimetricaKeyReceptor.Text);
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(txtPublicaAsimetricaEnviador.Text);
            encriptadaIV = rsa.Encrypt(iv, false);
            encriptadaKEY = rsa.Encrypt(key, false);
            Byte[] salida = new Byte[2 * 4 + encriptadaIV.Length + encriptadaKEY.Length];

            Array.Copy(BitConverter.GetBytes(encriptadaIV.Length), 0, salida, 0, 4);
            Array.Copy(BitConverter.GetBytes(encriptadaKEY.Length), 0, salida, 4, 4);
            Array.Copy(encriptadaIV, 0, salida, 8, encriptadaIV.Length);
            Array.Copy(encriptadaKEY, 0, salida, 8 + encriptadaIV.Length, encriptadaKEY.Length);
            txtClaveEncriptadaReceptor.Text = Convert.ToBase64String(salida);
        }

        private Byte[] CrearValorHashReceptor(string _claveEncriptada)
        {
            UnicodeEncoding ue = new UnicodeEncoding();
            Byte[] mensaje = ue.GetBytes(_claveEncriptada);
            SHA1Managed sha1M = new SHA1Managed();
            return sha1M.ComputeHash(mensaje);
        }

        private void CrearFirmaSimetricaValorHash()
        {
            Byte[] valorFirmado;
            // usar la clave privada del receptor
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(txtPrivadaAsimetricaReceptor.Text);
            // crear y fomatear la firma
            RSAPKCS1SignatureFormatter firma = new RSAPKCS1SignatureFormatter(rsa);
            firma.SetHashAlgorithm("SHA1");
            valorFirmado = firma.CreateSignature(Convert.FromBase64String(txtValorHashReceptor.Text));
            txtFirmaReceptor.Text = Convert.ToBase64String(valorFirmado);
        }

        private void btn_ExtraerInformacionClaveEnviador_Click(object sender, EventArgs e)
        {
            txtClaveEncriptadaEnviador.Text = txtClaveEncriptadaReceptor.Text;
            txtFirmaEnviador.Text = txtFirmaReceptor.Text;
            txtClavePublicaEnviador.Text = txtPublicaAsimetricaReceptor.Text;
        }

        private void btnValidarClavePublica_Click(object sender, EventArgs e)
        {
            Byte[] valorHash, firma;
            //crear el hash esperado
            valorHash = CrearValorHashReceptor(txtClaveEncriptadaEnviador.Text);
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(txtClavePublicaEnviador.Text);
            RSAPKCS1SignatureDeformatter deformateador = new RSAPKCS1SignatureDeformatter(rsa);
            deformateador.SetHashAlgorithm("SHA1");
            firma = Convert.FromBase64String(txtFirmaEnviador.Text);
            if (deformateador.VerifySignature(valorHash, firma))
            {
                txtClaveEncriptadaEnviador.BackColor = Color.Green;
            }
            else
            {
                txtClaveEncriptadaEnviador.BackColor = Color.Red;
            }
        }

        private void btnDesencriptarClaveSimetricaEnviador_Click(object sender, EventArgs e)
        {
            Byte[] iv, key;
            Byte[] salida = Convert.FromBase64String(txtClaveEncriptadaEnviador.Text);
            iv = new Byte[BitConverter.ToInt32(salida, 0)];
            key = new Byte[BitConverter.ToInt32(salida, 4)];
            Array.Copy(salida, 8, iv, 0, iv.Length);
            Array.Copy(salida, 8 + iv.Length, key, 0, key.Length);
            //usar la clave privada del enviador
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(txtPrivadaAsimetricaEnviador.Text);
            //desencriptar las claves simetricas
            txtSimetricaIVEnviador.Text = Convert.ToBase64String(rsa.Decrypt(iv, false));
            txtSimetricaKeyEnviador.Text = Convert.ToBase64String(rsa.Decrypt(key, false));
        }
    }
}
