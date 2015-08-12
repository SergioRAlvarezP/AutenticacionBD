using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AutenticaciónBD
{
    public partial class Form1 : Form
    {

        conexion conecta = new conexion();
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
            }
            catch (Exception ex){}
            ds = conecta.comparar();

            foreach(DataTable tablas in ds.Tables)
            {
                foreach (DataRow renglon in tablas.Rows)
                {
                    string cadena = "Usuario: "+renglon.ItemArray[0]+" Contraseña: "+renglon.ItemArray[1];
                    MessageBox.Show(cadena);
                }
            }

            /*for(int i=0;i<=ds.Tables.Count-1;i++)
            {
                for(int ii=0;ii<=ds.Tables[i].Rows.Count-1;ii++)
                {
                    for (int iii = 0; i <= ds.Tables[i].Columns.Count; iii++)
                    {
                        MessageBox.Show(ds.Tables[i].Rows[ii].ItemArray[iii].ToString());
                    }
                }
            }*/
            
            MessageBox.Show("Consulta realizada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataTable tablas in ds.Tables)
            {
                foreach (DataRow renglon in tablas.Rows)
                {
                    if (textBox1.Text.Equals(renglon.ItemArray[0].ToString()) && textBox2.Text.Equals(renglon.ItemArray[1]))
                    {
                        MessageBox.Show("Usuario Encontrado");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                    //string cadena = "Usuario: " + renglon.ItemArray[0] + " Contraseña: " + renglon.ItemArray[1];
                    //MessageBox.Show(cadena);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int w = 228,a=0;
            if (button3.Text==">>")
            {
                button3.Text = "<<";
                for (int i = 228; i < 328; i++)
                {
                    this.Width = i;
                    a = i;
                }
            }
            else
            {
                for (int s = a; s == w; s--)
                {
                    this.Width = s;
                }
                button3.Text = ">>";
            }
            this.Width = 328;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
