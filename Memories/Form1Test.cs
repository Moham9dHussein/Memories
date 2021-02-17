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
    DataTable tableSelected = new DataTable();
    bool selected = false;

    public DataTable TableSelected
    {
      get { return tableSelected; }
    }
    int indexRow;
    public TextBox Txt_time
    {
      get { return txt_time; }
    }
    Form2 f2;
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
      //////////////
      if (tableSelected.Columns.Count < 1)
      {
        tableSelected.Columns.Add("Word", typeof(string));
        tableSelected.Columns.Add("Sentance", typeof(string));
        tableSelected.Columns.Add("Translation", typeof(string));
      }
      //////////////

      dataGridView1.DataSource = table;

      if (!selected)
      {
        for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
        {
          dataGridView1.Rows[i].Cells[3].Value = false;
          dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
        }
      }

      //txt_translation.Select(0, 0); //Deselect text in a textbox
      this.ActiveControl = lblWord; //Unfocus on textbox


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

      if (Mem.countSelectedValue(dataGridView1) > 0)
      {
        selected = true;
      }

      if ((Mem.countSelectedValue(dataGridView1) == 0 && dataGridView1.Rows.Count >= 5) || Mem.countSelectedValue(dataGridView1) >= 5)
      {
        Mem.selectedValuesTable(dataGridView1, tableSelected);

        if (Mem.formIsExist(f2))
        {
          f2.Focus();
        }
        else
        {
          if (txt_time.Text == "" || Mem.checkInt(txt_time.Text))
          {
            f2 = new Form2(this);
            Hide();
            f2.ShowDialog();
            Show();
          }
          else
          {
            MessageBox.Show("Time must be an integer!");
          }
        }

      }
      else
      {
        MessageBox.Show("By default at least selected 5 words");
      }

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
      if (indexRow >= 0)
      {


        DataGridViewRow row = dataGridView1.Rows[indexRow];

        txt_word.Text = row.Cells[0].Value.ToString();
        txt_sentence.Text = row.Cells[1].Value.ToString();
        txt_translation.Text = row.Cells[2].Value.ToString();

        // dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
        // dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
      }
    }

    private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
    {
      bool status = cbSelectAll.Checked;
      if (status)
      {
        for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
        {
          dataGridView1.Rows[i].Cells[3].Value = true;
          dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
        }
      }
      else
      {
        for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
        {
          dataGridView1.Rows[i].Cells[3].Value = false;
          dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
        }
      }
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (dataGridView1.Columns[e.ColumnIndex].Name == "Select")
      {
        if (indexRow >= 0)
        {

          bool flag = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
          if (flag)
          {
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;

          }
          else
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }
      }
    }

    private void textbox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        Mem.addWord(txt_word, txt_sentence, txt_translation, table);
        dataGridView1.DataSource = table;
        dataGridView1.ClearSelection();
        dataGridView1.Rows[0].Selected = true;
        dataGridView1.FirstDisplayedScrollingRowIndex = 0;

        Mem.writeTable(table);
      }
      if (e.KeyCode == Keys.Tab)
      {
        MessageBox.Show("Pressed tab");
      }
    }


  }
}
