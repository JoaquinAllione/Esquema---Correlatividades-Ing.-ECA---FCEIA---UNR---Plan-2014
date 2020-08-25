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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posX = 0;
        int posY = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
            panel1_MouseMove(sender, e);
        }

        public void cargar()
        {
            try
            {
                StreamReader sr = new StreamReader("materias.txt");
                string linea;
                string[] cadena;
                while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    cadena = linea.Split('-');

                    switch (cadena[0])
                    {
                        case "FB1":
                            colorear_boton(boton_FB1, cadena[1]);
                            break;
                        case "FB2":
                            colorear_boton(boton_FB2, cadena[1]);
                            break;
                        case "FB3":
                            colorear_boton(boton_FB3, cadena[1]);
                            break;
                        case "FB4":
                            colorear_boton(boton_FB4, cadena[1]);
                            break;
                        case "FB5":
                            colorear_boton(boton_FB5, cadena[1]);
                            break;
                        case "FB6":
                            colorear_boton(boton_FB6, cadena[1]);
                            break;
                        case "FB7":
                            colorear_boton(boton_FB7, cadena[1]);
                            break;
                        case "FB8":
                            colorear_boton(boton_FB8, cadena[1]);
                            break;
                        case "FB9":
                            colorear_boton(boton_FB9, cadena[1]);
                            break;
                        case "FB10":
                            colorear_boton(boton_FB10, cadena[1]);
                            break;
                        case "FB11":
                            colorear_boton(boton_FB11, cadena[1]);
                            break;
                        case "FB18":
                            colorear_boton(boton_FB18, cadena[1]);
                            break;
                        case "FB20":
                            colorear_boton(boton_FB20, cadena[1]);
                            break;
                        case "FB14":
                            colorear_boton(boton_FB14, cadena[1]);
                            break;
                        case "FB12":
                            colorear_boton(boton_FB12, cadena[1]);
                            break;
                        case "A1":
                            colorear_boton(boton_A1, cadena[1]);
                            break;
                        case "A2":
                            colorear_boton(boton_A2, cadena[1]);
                            break;
                        case "A3":
                            colorear_boton(boton_A3, cadena[1]);
                            break;
                        case "A4":
                            colorear_boton(boton_A4, cadena[1]);
                            break;
                        case "A5":
                            colorear_boton(boton_A5, cadena[1]);
                            break;
                        case "A6":
                            colorear_boton(boton_A6, cadena[1]);
                            break;
                        case "A7":
                            colorear_boton(boton_A7, cadena[1]);
                            break;
                        case "A8":
                            colorear_boton(boton_A8, cadena[1]);
                            break;
                        case "A9":
                            colorear_boton(boton_A9, cadena[1]);
                            break;
                        case "A10":
                            colorear_boton(boton_A10, cadena[1]);
                            break;
                        case "A11":
                            colorear_boton(boton_A11, cadena[1]);
                            break;
                        case "A12":
                            colorear_boton(boton_A12, cadena[1]);
                            break;
                        case "A13":
                            colorear_boton(boton_A13, cadena[1]);
                            break;
                        case "A14":
                            colorear_boton(boton_A14, cadena[1]);
                            break;
                        case "A15":
                            colorear_boton(boton_A15, cadena[1]);
                            break;
                        case "A16":
                            colorear_boton(boton_A16, cadena[1]);
                            break;
                        case "A17":
                            colorear_boton(boton_A17, cadena[1]);
                            break;
                        case "A18":
                            colorear_boton(boton_A18, cadena[1]);
                            break;
                        case "A19":
                            colorear_boton(boton_A19, cadena[1]);
                            break;
                        case "A20":
                            colorear_boton(boton_A20, cadena[1]);
                            break;
                        case "A21":
                            colorear_boton(boton_A21, cadena[1]);
                            break;
                        case "A22":
                            colorear_boton(boton_A22, cadena[1]);
                            break;
                        case "FI1":
                            colorear_boton(boton_FI1, cadena[1]);
                            break;
                        case "FI2":
                            colorear_boton(boton_FI2, cadena[1]);
                            break;
                        case "FI3":
                            colorear_boton(boton_FI3, cadena[1]);
                            break;
                        case "FI4":
                            colorear_boton(boton_FI4, cadena[1]);
                            break;
                        case "FI5":
                            colorear_boton(boton_FI5, cadena[1]);
                            break;
                        case "FI6":
                            colorear_boton(boton_FI6, cadena[1]);
                            break;
                        case "FI7":
                            colorear_boton(boton_FI7, cadena[1]);
                            break;
                        case "FI8":
                            colorear_boton(boton_FI8, cadena[1]);
                            break;
                        case "ECE1":
                            colorear_boton(boton_ECE1, cadena[1]);
                            break;
                        case "ECE2":
                            colorear_boton(boton_ECE2, cadena[1]);
                            break;
                        case "OP1":
                            colorear_boton(boton_OP1, cadena[1]);
                            break;
                        case "OP2":
                            colorear_boton(boton_OP2, cadena[1]);
                            break;
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void colorear_boton(Button b, string estado)
        {
            if(estado == "APROBADA")
            {
                b.BackColor = Color.FromArgb(94, 193, 128);
            }if(estado == "NO APROBADA")
            {
                b.BackColor = Color.FromArgb(223, 0, 44);
            }if(estado == "INSCRIPTO")
            {
                b.BackColor = Color.FromArgb(68, 131, 184);
            }
        }

        string estado_asignatura;
        string nota;
        string categ;
        string cod;
        string corre;
        string nombre;
        string corr_a;
        string a;
        string cua;

        private void buscar(string asignatura)
        {
            try
            {
                StreamReader sr = new StreamReader("materias.txt");
                string linea;
                string[] cadena;
                while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    cadena = linea.Split('-');
                    if(cadena[0] == asignatura)
                    {
                        cod = cadena[0];
                        estado_asignatura = cadena[1];
                        nombre = cadena[2];
                        nota = cadena[3];
                        corre = cadena[4];
                        categ = cadena[5];
                        corr_a = cadena[6];
                        a = cadena[7];
                        cua = cadena[8];
                    }
                }
                sr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public struct datos
        {
            public string codigo;
            public string estado;
            public string nombre;
            public string nota;
            public string a;
            public string cuatri;
            public string correlativa_a;
            public string correlativas;
            public string categoria;
        }

        datos informacion;

        public void mostrar_info()
        {
            informacion.codigo = cod;
            informacion.estado = estado_asignatura;
            informacion.nombre = nombre;
            informacion.nota = nota;
            informacion.a = a;
            informacion.cuatri = cua;
            informacion.correlativas = corr_a;
            informacion.correlativa_a = corre;
            informacion.categoria = categ;
            Form_asignatura form = new Form_asignatura(informacion);
            form.ShowDialog();
        }
        
        private void boton_A1_Click(object sender, EventArgs e)
        {
            buscar("A1");
            mostrar_info();
        }

        private void boton_FB3_Click(object sender, EventArgs e)
        {
            buscar("FB3");
            mostrar_info();
        }

        private void boton_FB1_Click(object sender, EventArgs e)
        {
            buscar("FB1");
            mostrar_info();
        }

        private void boton_FB2_Click(object sender, EventArgs e)
        {
            buscar("FB2");
            mostrar_info();
        }

        private void boton_FB7_Click(object sender, EventArgs e)
        {
            buscar("FB7");
            mostrar_info();
        }

        private void boton_FB4_Click(object sender, EventArgs e)
        {
            buscar("FB4");
            mostrar_info();
        }

        private void boton_FB5_Click(object sender, EventArgs e)
        {
            buscar("FB5");
            mostrar_info();
        }

        private void boton_FB6_Click(object sender, EventArgs e)
        {
            buscar("FB6");
            mostrar_info();
        }

        private void boton_FI4_Click(object sender, EventArgs e)
        {
            buscar("FI4");
            mostrar_info();
        }

        private void boton_FI3_Click(object sender, EventArgs e)
        {
            buscar("FI3");
            mostrar_info();
        }

        private void boton_FI1_Click(object sender, EventArgs e)
        {
            buscar("FI1");
            mostrar_info();
        }

        private void boton_FB9_Click(object sender, EventArgs e)
        {
            buscar("FB9");
            mostrar_info();
        }

        private void boton_FB10_Click(object sender, EventArgs e)
        {
            buscar("FB10");
            mostrar_info();
        }

        private void boton_FB8_Click(object sender, EventArgs e)
        {
            buscar("FB8");
            mostrar_info();
        }

        private void boton_FB18_Click(object sender, EventArgs e)
        {
            buscar("FB18");
            mostrar_info();
        }

        private void boton_FB14_Click(object sender, EventArgs e)
        {
            buscar("FB14");
            mostrar_info();
        }

        private void boton_FI2_Click(object sender, EventArgs e)
        {
            buscar("FI2");
            mostrar_info();
        }

        private void boton_FB11_Click(object sender, EventArgs e)
        {
            buscar("FB11");
            mostrar_info();
        }

        private void boton_A2_Click(object sender, EventArgs e)
        {
            buscar("A2");
            mostrar_info();
        }

        private void boton_FB20_Click(object sender, EventArgs e)
        {
            buscar("FB20");
            mostrar_info();
        }

        private void boton_A5_Click(object sender, EventArgs e)
        {
            buscar("A5");
            mostrar_info();
        }

        private void boton_A6_Click(object sender, EventArgs e)
        {
            buscar("A6");
            mostrar_info();
        }

        private void boton_A4_Click(object sender, EventArgs e)
        {
            buscar("A4");
            mostrar_info();
        }

        private void boton_A3_Click(object sender, EventArgs e)
        {
            buscar("A3");
            mostrar_info();
        }

        private void boton_FB12_Click(object sender, EventArgs e)
        {
            buscar("FB12");
            mostrar_info();
        }

        private void boton_A9_Click(object sender, EventArgs e)
        {
            buscar("A9");
            mostrar_info();
        }

        private void boton_A10_Click(object sender, EventArgs e)
        {
            buscar("A10");
            mostrar_info();
        }

        private void boton_A7_Click(object sender, EventArgs e)
        {
            buscar("A7");
            mostrar_info();
        }

        private void boton_A8_Click(object sender, EventArgs e)
        {
            buscar("A8");
            mostrar_info();
        }

        private void boton_A11_Click(object sender, EventArgs e)
        {
            buscar("A11");
            mostrar_info();
        }

        private void boton_A16_Click(object sender, EventArgs e)
        {
            buscar("A16");
            mostrar_info();
        }

        private void boton_A15_Click(object sender, EventArgs e)
        {
            buscar("A15");
            mostrar_info();
        }

        private void boton_A14_Click(object sender, EventArgs e)
        {
            buscar("A14");
            mostrar_info();
        }

        private void boton_A13_Click(object sender, EventArgs e)
        {
            buscar("A13");
            mostrar_info();
        }

        private void boton_A12_Click(object sender, EventArgs e)
        {
            buscar("A12");
            mostrar_info();
        }

        private void boton_A18_Click(object sender, EventArgs e)
        {
            buscar("A18");
            mostrar_info();
        }

        private void boton_OP1_Click(object sender, EventArgs e)
        {
            buscar("OP1");
            mostrar_info();
        }

        private void boton_A17_Click(object sender, EventArgs e)
        {
            buscar("A17");
            mostrar_info();
        }

        private void boton_A19_Click(object sender, EventArgs e)
        {
            buscar("A19");
            mostrar_info();
        }

        private void boton_ECE1_Click(object sender, EventArgs e)
        {
            buscar("ECE1");
            mostrar_info();
        }

        private void boton_OP2_Click(object sender, EventArgs e)
        {
            buscar("OP2");
            mostrar_info();
        }

        private void boton_FI5_Click(object sender, EventArgs e)
        {
            buscar("FI5");
            mostrar_info();
        }

        private void boton_FI7_Click(object sender, EventArgs e)
        {
            buscar("FI7");
            mostrar_info();
        }

        private void boton_A20_Click(object sender, EventArgs e)
        {
            buscar("A20");
            mostrar_info();
        }

        private void boton_A21_Click(object sender, EventArgs e)
        {
            buscar("A21");
            mostrar_info();
        }

        private void boton_FI8_Click(object sender, EventArgs e)
        {
            buscar("FI8");
            mostrar_info();
        }

        private void boton_FI6_Click(object sender, EventArgs e)
        {
            buscar("FI6");
            mostrar_info();
        }

        private void boton_A22_Click(object sender, EventArgs e)
        {
            buscar("A22");
            mostrar_info();
        }

        private void boton_ECE2_Click(object sender, EventArgs e)
        {
            buscar("ECE2");
            mostrar_info();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1_Load( sender,  e);
        }
    }
}
