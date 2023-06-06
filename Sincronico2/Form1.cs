using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sincronico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            loading.Visible = true;
            //await Task.Delay(5000);
            await Esperar();
            MessageBox.Show("pasaron los 5 segundos");
            loading.Visible = false;
        }
        private async Task Esperar()
        {
            await Task.Delay(5000);
        }
    }
}
