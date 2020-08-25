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

namespace ESQUEMA_ASIGNATURAS
{
    public partial class Form_asignatura : Form
    {
        public string codigo_asig;
        public Form_asignatura(Form1.datos info)
        {
            InitializeComponent();
            txt_nombre_asignatura.Text = info.nombre;
            txt_cod.Text = info.codigo;
            codigo_asig = info.codigo;
            txt_cuatri.Text = info.cuatri;
            textBox_estado.Text = info.estado;
            txt_a.Text = info.a;
            textBox_nota.Text = info.nota;
            txt_categoria.Text = info.categoria;
            txt_corr.Text = info.correlativas;
            txt_corr_a.Text = info.correlativa_a;
            label_barra_control.Text = info.codigo + " - " + info.nombre;
            if(info.estado == "APROBADA")
            {
                uncheck_aprobada.Visible = false;
                check_aprobada.Visible = true;
                textBox_nota.Enabled = true;
                uncheck_no_aprobada.Enabled = false;
                uncheck_intermedia.Enabled = false;
            }
            if (info.estado == "NO APROBADA")
            {
                uncheck_no_aprobada.Visible = false;
                check_no_aprobada.Visible = true;
                textBox_nota.Enabled = false;
                uncheck_aprobada.Enabled = false;
                uncheck_intermedia.Enabled = false;
            }
            if (info.estado == "INSCRIPTO")
            {
                uncheck_intermedia.Visible = false;
                check_intermedia.Visible = true;
                textBox_nota.Enabled = false;
                uncheck_aprobada.Enabled = false;
                uncheck_no_aprobada.Enabled = false;
            }
        }

        private void boton_cerrar_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int posY = 0;
        int posX = 0;

        private void panel_control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void label_barra_control_MouseMove(object sender, MouseEventArgs e)
        {
            panel_control_MouseMove(sender, e);
        }

        private void uncheck_aprobada_Click(object sender, EventArgs e)
        {
            uncheck_aprobada.Visible = false;
            check_aprobada.Visible = true;
            textBox_nota.Enabled = true;
            uncheck_no_aprobada.Enabled = false;
            uncheck_intermedia.Enabled = false;
            textBox_estado.Text = "APROBADA";
        }

        private void check_aprobada_Click(object sender, EventArgs e)
        {
            uncheck_aprobada.Visible = true;
            check_aprobada.Visible = false;
            textBox_nota.Enabled = false;
            textBox_nota.Clear();
            uncheck_no_aprobada.Enabled = true;
            uncheck_intermedia.Enabled = true;
            textBox_estado.Clear();
        }

        private void uncheck_no_aprobada_Click(object sender, EventArgs e)
        {
            uncheck_no_aprobada.Visible = false;
            check_no_aprobada.Visible = true;
            textBox_nota.Enabled = false;
            textBox_nota.Clear();
            uncheck_intermedia.Enabled = false;
            uncheck_aprobada.Enabled = false;
            textBox_estado.Text = "NO APROBADA";
        }

        private void check_no_aprobada_Click(object sender, EventArgs e)
        {
            uncheck_no_aprobada.Visible = true;
            check_no_aprobada.Visible = false;
            uncheck_intermedia.Enabled = true;
            uncheck_aprobada.Enabled = true;
            textBox_estado.Clear();
        }

        private void uncheck_intermedia_Click(object sender, EventArgs e)
        {
            uncheck_intermedia.Visible = false;
            check_intermedia.Visible = true;
            textBox_nota.Enabled = false;
            textBox_nota.Clear();
            uncheck_aprobada.Enabled = false;
            uncheck_no_aprobada.Enabled = false;
            textBox_estado.Text = "INSCRIPTO";
        }

        private void check_intermedia_Click(object sender, EventArgs e)
        {
            uncheck_intermedia.Visible = true;
            check_intermedia.Visible = false;
            uncheck_aprobada.Enabled = true;
            uncheck_no_aprobada.Enabled = true;
            textBox_estado.Clear();
        }

        private void Form_asignatura_Load(object sender, EventArgs e)
        {
            
        }


        private void Form_asignatura_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("temp.txt");

            try
            {
                StreamReader sr = new StreamReader("materias.txt");
                string linea;
                string[] cadena;
                while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    cadena = linea.Split('-');
                    if (cadena[0] != codigo_asig)
                    {
                        sw.WriteLine(linea);
                    }
                }
                sw.WriteLine(txt_cod.Text + "-" + textBox_estado.Text + "-" + txt_nombre_asignatura.Text + "-" + textBox_nota.Text + "-" + txt_corr_a.Text + "-" + txt_categoria.Text + "-" + txt_corr.Text + "-" + txt_a.Text + "-" + txt_cuatri.Text);
                sr.Close();
                sw.Close();

                File.Delete("materias.txt");

                StreamWriter sw_c = new StreamWriter("materias.txt");
                StreamReader sr_c = new StreamReader("temp.txt");

                string linea_c;

                while (!sr_c.EndOfStream)
                {
                    linea_c = sr_c.ReadLine();
                    sw_c.WriteLine(linea_c);
                }
                sw_c.Close();
                sr_c.Close();

                File.Delete("temp.txt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
