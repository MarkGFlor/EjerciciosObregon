using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Multitask
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumero.Text) && int.TryParse(txtNumero.Text, out int num))
            {
                
                using (StreamWriter outputFile = new StreamWriter("E:\\45\\Archivo.txt"))
                {
                    for (int i = 1; i <= num; i++)
                    {
                        progressBar1.Maximum = i;
                        outputFile.WriteLine(i);
                        progressBar1.Value = i;
                    }
                }

               
            }
        }
    }
}
    