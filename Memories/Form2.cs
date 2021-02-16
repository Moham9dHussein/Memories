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
    int i = 0;
    int count = 0;
    public Form2() : this(null) { }
    public Form2(Form1Test _f1)
    {
      InitializeComponent();
      f1 = _f1;
    }
    private void Form2_Load(object sender, EventArgs e)
    {
      if (f1.Txt_time.Text == "")
      {
        time = 5;
      }
      else
      {
        time = int.Parse(f1.Txt_time.Text);
      }
      //lblTimer.Text = time.ToString();
      dataTable = f1.TableSelected;
      lblCounter.Text = string.Format("{0} / {1}", 1, dataTable.Rows.Count);
      random = f1.CbRandom.Checked;
      //dataGridView1.DataSource = dataTable;
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      //Application.OpenForms[0].Show();
      Close();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      i++;

      /////////////////
      lblWord.Text = dataTable.Rows[count][0].ToString();
      lblSentence.Text = dataTable.Rows[count][1].ToString();
      lblTranslation.Text = dataTable.Rows[count][2].ToString();
      /////////////////
      if (i > time)
      {
        i = 1;
        if (count >= dataTable.Rows.Count - 1)
        {
          //reach to end
          count = 1;
          //dataGridView1.Rows[count - 1].Selected = true;

          /////////////////
          lblWord.Text = dataTable.Rows[count - 1][0].ToString();
          lblSentence.Text = dataTable.Rows[count - 1][1].ToString();
          lblTranslation.Text = dataTable.Rows[count - 1][2].ToString();
          /////////////////

          lblCounter.Text = string.Format("{0} / {1}", count, dataTable.Rows.Count);
        }
        else
        {
          //start count
          //dataGridView1.Rows[count].Selected = true;
          count++;
          /////////////////
          lblWord.Text = dataTable.Rows[count][0].ToString();
          lblSentence.Text = dataTable.Rows[count][1].ToString();
          lblTranslation.Text = dataTable.Rows[count][2].ToString();
          /////////////////
          lblCounter.Text = string.Format("{0} / {1}", count + 1, dataTable.Rows.Count);

        }
      }
      lblTimer.Text = i.ToString();
    }
  }
}
