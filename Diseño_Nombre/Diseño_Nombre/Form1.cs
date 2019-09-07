using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_Nombre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;

            Font fo = txtnombre.Font;
            lblnombrediseño.Font = new Font("Forte", emSize: 22, style: FontStyle.Bold);
            lblnombrediseño.ForeColor = Color.Blue;
            lblnombrediseño.Visible = true;

            lblnombrediseño.Text = txtnombre.Text;

        }
    }
}
