using Ej1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
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
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        private void bVer_Click(object sender, EventArgs e)
        {
            lisbo.Items.Clear();
            for (int idx = 0; idx < banco.CantidadCuentas; idx++)
            {
                Cuenta c = banco[idx];

                string linea = $"{c.Numero}";

                lisbo.Items.Add(linea);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\Users\\Alumno\\Desktop\\tup_prog_2_2024_actividad8\\Ficheros";
            open.Filter = "Archivos CSV (*.csv)|*.csv";
            if (open.ShowDialog()==DialogResult.OK)
           {
                fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                sr.ReadLine();
                while( !sr.EndOfStream )
                {
                    string a = sr.ReadLine();
                    a = a.Trim().Replace(" ","") ;
                    lisbo.Items.Add( a );
                    string[] b = a.Split(';');
                    Cuenta c = banco.AgregarCuenta(Convert.ToInt32(b[2]), Convert.ToInt32(b[0]), b[1]);
                    c.Saldo = Convert.ToDouble(b[3]);
                    lisbo.Items.Add(c);
                }
                fs.Close();
                sr.Close();
            }
            bVer.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivos CSV (*.csv)|*.csv";
            save.InitialDirectory = "C:\\Users\\Alumno\\Desktop\\tup_prog_2_2024_actividad8\\Ficheros";
            if (save.ShowDialog()==DialogResult.OK)
            {
                fs = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                for (int i = 0; i < lisbo.Items.Count; i++)
                {
                    string item = (string)lisbo.Items[i];
                    sw.WriteLine(item);
                }
            }
        }
    }
}
