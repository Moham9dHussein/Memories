using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memories
{

  // Verbs with sentance and translation
  //string[,] R = Form1.R;
  //int totalSeconds = Form1.timer;

  public partial class Form2 : Form
  {
    Form1Test f1;
    DataTable dataTable;
    int time;
    bool random;
    public Form2() : this(null) { }
    public Form2(Form1Test _f1)
    {
      InitializeComponent();
      f1 = _f1;
    }
    private void Form2_Load(object sender, EventArgs e)
    {
      //time = int.Parse(f1.Txt_time.Text);
      //random = f1.CbRandom.Checked;
      dataTable = f1.TableSelected;
      dataGridView1.DataSource = dataTable;
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      //Application.OpenForms[0].Show();
      Close();
    }


  }
}
