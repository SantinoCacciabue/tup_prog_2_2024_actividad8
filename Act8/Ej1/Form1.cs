using Ej1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Banco banco = new Banco();

       
        private void bVer_Click(object sender, EventArgs e)
        {
            lisbo.Items.Clear();
            for (int idx = 0; idx < banco.CantidadCuentas; idx++)
            {
                Cuenta c = banco[idx];

                lisbo.Items.Add(c);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = "C:\\Users\\Alumno\\Desktop\\Nueva Carpet\\tup_prog_2_2024_actividad8\\Ficheros";
                open.Filter = "Archivos CSV (*.csv)|*.csv";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string a = sr.ReadLine();
                        a = a.Trim().Replace(" ", "");
                        lisbo.Items.Add(a);
                        string[] b = a.Split(';');
                        Cuenta c = banco.AgregarCuenta(Convert.ToInt32(b[2]), Convert.ToInt32(b[0]), b[1]);//si ya tiene saldo, lo actualiza.
                        c.Saldo = Convert.ToDouble(b[3]);
                        
                    }
                }
                bVer.PerformClick();
            }
            catch(Exception)
            {
                MessageBox.Show("Hay algun error(no sé cual jaja)");
            }
            finally
            {
                if(fs != null) fs.Close();
                if(sr != null) sr.Close();
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Archivos CSV (*.csv)|*.csv";
                save.InitialDirectory = "C:\\Users\\Alumno\\Desktop\\tup_prog_2_2024_actividad8\\Ficheros";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    for (int i = 0; i < lisbo.Items.Count; i++)
                    {
                        Cuenta c = banco[i];
                        if (c.Saldo > 10000)
                        {
                            sw.WriteLine($"{c.Titular.DNI};{c.Titular.Nombre};{c.Numero};{c.Saldo}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hay algun error(no sé cual jaja)");
            }
            finally
            {
                if (fs != null) fs.Close();
                if (sw != null) sw.Close();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            FileStream fs = null;
            try
            {
                fs = new FileStream("ejercicio1.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, banco);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                if (File.Exists("ejercicio1.dat"))
                {
                    fs = new FileStream("ejercicio1.dat", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    banco = bf.Deserialize(fs) as Banco;
                }
               
            }
            finally
            {
                if (fs != null) fs.Close();
            }


            if (banco == null)
            {
                banco=new Banco();
            }


            lisbo.Items.Clear();
            for (int idx = 0; idx < banco.CantidadCuentas; idx++)
            {
                Cuenta c = banco[idx];

                lisbo.Items.Add(c);
            }
        }
    }
}
