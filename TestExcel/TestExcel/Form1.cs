using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExcel
{
    public partial class Form1 : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.8.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR={1}'";

        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsubir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string archivo = openFileDialog1.FileName;
                string extension = Path.GetExtension(archivo);
                string cabecera = rbHeaderYes.Checked ? "YES" : "NO";
                string conStr, sheetName;
                DataTable dt = new DataTable();
                conStr = string.Empty;
                switch (extension)
                {

                    case ".xls": //Excel 97-03
                        conStr = string.Format(Excel03ConString, archivo, cabecera);
                        break;

                    case ".xlsx": //Excel 07
                        conStr = string.Format(Excel07ConString, archivo, cabecera);
                        break;
                }

                //Obteniendo el nombre de la primer fila.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }
                lblnombre.Text = sheetName;
                lblextension.Text = extension;

                //Leyedo la información de la primer pestaña.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {


                          
                                cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            

                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();


                            dataGridView1.DataSource = dt;
                           
                            lblestatus.Text = "Archivo agregado con éxito";

                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
              
                lblestatus.Text = "Error, " + ex.ToString();
            }
            
        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Suma", "Sumatoria");
            int sum = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
                this.dataGridView1[3, i].Value = sum;
                sum = 0;
            }
            
        }

        private void Btndivicion_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Division", "División");

            double valor1 = 0, valor2 = 0, resultado=0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                valor1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                valor2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

                resultado = valor1 / valor2;

                this.dataGridView1[4, i].Value = resultado;
            }
        }
    }
}
