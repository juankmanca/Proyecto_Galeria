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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database database = new Database();
        }
        
        private void Registrar_Click(object sender, EventArgs e)
        {
            Registrar_Persona RegPersona = new Registrar_Persona();
            RegPersona.Show();
            this.Hide();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            Form_Album FormAlb = new Form_Album();
            FormAlb.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
