using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolgui
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if(txt_nombre.Text != "" && txt_apellido.Text != "" && txt_email.Text != "" && txt_password.Text != "")

            {
                Person objperson = new Person(1, Convert.ToString(txt_nombre.Text), Convert.ToString(txt_apellido.Text), Convert.ToString(txt_email.Text), Convert.ToString(txt_password.Text), "18/06/2021", "18/06/2021");
                txt_password.Clear();
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_email.Clear();

                lbl_resultado.Text = objperson.ToString();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
           

        }

    }
}
