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


        //CREAR UNA MATRIZ - 5 alumnos y 3 notas cada uno
        int[,] matNotas = new int[5,3];
        private void btnCrear_Click(object sender, EventArgs e)
        {
            //cargar toda la matriz con datos aleatorios
            int ifila = 0;
            int icolumna = 0;
            
            Random datoAleatorio = new Random();

            while (ifila < matNotas.GetLength(0))
            {
                icolumna = 0;
                while (icolumna < matNotas.GetLength(1))
                {
                    //SI BUSCO DATOS, AQUI ESCRIBIRIA UN IF

                    //voy a cargar datos aleatorios
                    
                    matNotas[ifila, icolumna] = datoAleatorio.Next(1, 10);

                    icolumna++;
                }

                ifila++;
            }
        }

        private void btnListarMatriz_Click(object sender, EventArgs e)
        {
            //for (int ifila = 0; ifila < matNotas.GetLength(0); ifila++)
            //{
            //    for (int icolumna = 0; icolumna < matNotas.GetLength(1); icolumna++)
            //    {
            //        dgvNotas.Rows.Add(matNotas[ifila, icolumna].ToString());
            //    }
            //}

            //for (int ifila = 0; ifila < matNotas.GetLength(0); ifila++)
            //{
                
            //    dgvNotas.Rows.Add(matNotas[ifila, 0].ToString(),
            //        matNotas[ifila, 1].ToString(),
            //        matNotas[ifila, 2].ToString());
                
            //}

            
            for (int ifila = 0; ifila < matNotas.GetLength(0); ifila++)
            {
                dgvNotas.Rows.Add("nombre mozo", "columna 2");
            }

        }
    }
}
