using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Galeria
{
    public partial class Registrar_Persona : Form
    {
        Database DB = new Database();
        
        public Registrar_Persona()
        {
            InitializeComponent();
       
        }
        Form_Album FB = new Form_Album();

        private void Guardar_Click(object sender, EventArgs e)
        {
            int sw = 0;
            string IDPersona = CedulaPersona.Text;
            string NamePersona = NombrePersona.Text;
            string Nick = NickName.Text;
            string Av = Avatar.Text;
            
            if(IDPersona == "" || NamePersona == "" || Nick == "" || Av == "")
            {
                sw = 1;
            }
            if (sw == 0)
            {
                Usuario user = new Usuario(Nick, Av, IDPersona, NamePersona);

                sw = DB.insertdate(user);
            }
                if (sw == 1)
                    
            {
                MessageBox.Show("Verifique los campos de nuevo >:(");
                CedulaPersona.Focus();
            }
            else
            {
                FB.Show();
                this.Hide();
            }
        }

        private void Registrar_Persona_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
