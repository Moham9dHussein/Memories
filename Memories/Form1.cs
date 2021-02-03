using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memories
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("Verbs");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            readTable();
            if (table.Columns.Count < 1) createTable();
            fillData();
        }


        private void readTable()
        {
            if (File.Exists(Application.StartupPath + "\\table_schema") && File.Exists(Application.StartupPath + "\\table_verbs"))
            {
                table.ReadXmlSchema(Application.StartupPath + "\\table_schema");
                table.ReadXml(Application.StartupPath + "\\table_verbs");
            }
        }
        private void createTable()
        {
            table.Columns.Add("Verbs", typeof(String));
            table.Columns.Add("Sentance", typeof(String));
            table.Columns.Add("Translation", typeof(String));
        }
        private void fillData()
        {
            // Source
            dataGridView1.DataSource = table;

            // Apperance
            //dataGridView1.Columns["Translation"].Visible = false;
            //dataGridView1.Columns["Sentance"].Visible = false;
            //dataGridView1.Columns["Verbs"].Width = 285;
        }
        private void writeTable()
        {
            // table schema
            table.WriteXmlSchema(Application.StartupPath + "\\table_schema");
            table.WriteXml(Application.StartupPath + "\\table_verbs");
        }

        

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.ShowDialog();
            Show();
        }
    
      
    }
}
      