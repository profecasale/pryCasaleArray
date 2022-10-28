using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCasaleArray
{
    public partial class frmMain : Form
    {
        //zona de declaracion de variables globales para el form

        //string vecNombres;
        string[] vecNombres = new string[3];
        int indice = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (indice < vecNombres.Length)
            {
                vecNombres[indice] = txtNumero.Text;
                indice++; //indice = indice + 1;
            }

            txtNumero.Text = "";
            txtNumero.Focus();

            if (indice == vecNombres.Length)
            {
                txtNumero.Enabled = false;
                btnCargar.Enabled = false;
            }
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstNombres.Items.Clear();   
            int indicerecorrido = 0;
            while (indicerecorrido < vecNombres.Length)
            {
                lstNombres.Items.Add(vecNombres[indicerecorrido]);
                indicerecorrido++;
            }
        }
    }
}
