using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeria
{
    public partial class Form_Album : Form
    {
        public Form_Album()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Result.Text = "Funciona";
        }

        private void Form_Album_Load(object sender, EventArgs e)
        {

        }
    }
}
