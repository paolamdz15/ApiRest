using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_API_REST
{
    public partial class Form1 : Form
    {
        DBApi dBApi = new DBApi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://reqres.in/api/users?page=1");
            pictureBox1.ImageLocation = respuesta.data[1].avatar.ToString();
            txtNombreGET.Text = respuesta.data[1].first_name.ToString();
            txtApellidoGET.Text = respuesta.data[1].last_name.ToString();
            txtEmail.Text = respuesta.data[1].email.ToString();
        }     
    }
}

