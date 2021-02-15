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



  public partial class Form1Test : Form
  {
    DataTable table = new DataTable("Words");

    int indexRow;
    public TextBox Txt_time
    {
      get { return txt_time; }
    }
    public CheckBox CbRandom
    {
      get
      {
        return cbRandom;
      }
    }
    public Form1Test()
    {
      InitializeComponent();

    }
    private void Form1_Load(object sender, EventArgs e)
    {

      //table = Mem.copyDGVtoDT(dataGridView1);
      Mem.readTable(table);
      if (table.Columns.Count < 1)
      {
        Mem.createTable(table);
        table.Columns.Add("Select", typeof(bool));
      }
      //fillData();

      dataGridView1.DataSource = table;
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
      Mem.addWord(txt_word, txt_sentence, txt_translation, table);
      dataGridView1.DataSource = table;
      dataGridView1.ClearSelection();
      dataGridView1.Rows[0].Selected = true;
      dataGridView1.FirstDisplayedScrollingRowIndex = 0;

      Mem.writeTable(table);
    }
    private void btnRemove_Click(object sender, EventArgs e)
    {
      Mem.removeWord(dataGridView1);
      Mem.writeTable(table);
    }
    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        Mem.removeWord(dataGridView1);
        Mem.writeTable(table);
      }
    }
    private void btnStart_Click(object sender, EventArgs e)
    {
      Form2 f2 = new Form2(this);
      Hide();
      f2.ShowDialog();
      Show();


    }

    private void button1_Click(object sender, EventArgs e)
    {
      //Mem.addSentenceCol(txt_word,txt_sentence,txt_translation, table);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
      newDataRow.Cells[0].Value = txt_word.Text;
      newDataRow.Cells[1].Value = txt_sentence.Text;
      newDataRow.Cells[2].Value = txt_translation.Text;
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      indexRow = e.RowIndex;
      DataGridViewRow row = dataGridView1.Rows[indexRow];

      txt_word.Text = row.Cells[0].Value.ToString();
      txt_sentence.Text = row.Cells[1].Value.ToString();
      txt_translation.Text = row.Cells[2].Value.ToString();
    }

    private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
    {
      bool status = cbSelectAll.Checked;
      if (status)
      {
        for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
        {
          dataGridView1.Rows[i].Cells[3].Value = true;
        }
      }
      else
      {
        for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
        {
          dataGridView1.Rows[i].Cells[3].Value = false;
        }
      }
    }
  }
}
