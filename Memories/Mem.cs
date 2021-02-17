﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memories
{

  class data
  {
    // public string word { get; set; }
    // public string sentence { get; set; }
    // public string translate { get; set; }
    // public bool select { get; set; }

    string word;
    string sentence;
    string translate;
    bool select;

    public data(string _word, string _sen, string _tran, bool _sele)
    {
      word = _word;
      sentence = _sen;
      translate = _tran;
      select = _sele;
    }
  }
  static class Mem
  {
    static int i = 0;
    //static DataTable table = new DataTable("Verbs");

    #region 4 Basics Fun
    public static void readTable(DataTable t)
    {
      if (File.Exists(Application.StartupPath + "\\table_schema") && File.Exists(Application.StartupPath + "\\table_verbs"))
      {
        t.ReadXmlSchema(Application.StartupPath + "\\table_schema");
        t.ReadXml(Application.StartupPath + "\\table_verbs");
      }
    }
    public static void createTable(DataTable t)
    {
      t.Columns.Add("Word", typeof(string));
      t.Columns.Add("Sentance", typeof(string));
      t.Columns.Add("Translation", typeof(string));
      t.Columns["Word"].ReadOnly = true;
      t.Columns["Sentance"].ReadOnly = true;
      t.Columns["Translation"].ReadOnly = true;
      //t.Columns.Add("Select", typeof(bool));
      //t.Columns.Add(new DataColumn("Select", typeof(bool)));
    }
    public static void addCheckboxCol(DataGridView dgv)
    {
      DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
      dgv.Columns.Add(checkBoxColumn);
    }
    public static DataTable copyDGVtoDT(DataGridView dgv)
    {
      // DataTable dt = new DataTable();
      // foreach (DataGridViewColumn col in dgv.Columns)
      // {
      //   //dt.Columns.Add(col.Name);
      //   dt.Columns.Add(col.HeaderText, col.ValueType);
      // }

      // foreach (DataGridViewRow row in dgv.Rows)
      // {
      //   DataRow dRow = dt.NewRow();
      //   foreach (DataGridViewCell cell in row.Cells)
      //   {
      //     dRow[cell.ColumnIndex] = cell.Value;
      //   }
      //   dt.Rows.Add(dRow);
      // }

      //Creating DataTable.
      DataTable dt = new DataTable("Words");

      //Adding the Columns.
      foreach (DataGridViewColumn column in dgv.Columns)
      {
        dt.Columns.Add(column.Name);
      }

      // //Adding the Rows.
      // foreach (DataGridViewRow row in dgv.Rows)
      // {
      //   dt.Rows.Add();
      //   foreach (DataGridViewCell cell in row.Cells)
      //   {
      //     dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
      //   }
      // }

      return dt;
    }
    public static void fillData(DataGridView dgv)
    {
      // Source
      //dgv.DataSource = table;

      // Apperance
      //dataGridView1.Columns["Translation"].Visible = false;
      //dataGridView1.Columns["Sentance"].Visible = false;
      //dataGridView1.Columns["Verbs"].Width = 285;
    }
    public static void writeTable(DataTable t)
    {
      // table schema
      t.WriteXmlSchema(Application.StartupPath + "\\table_schema");
      t.WriteXml(Application.StartupPath + "\\table_verbs");
    }
    #endregion

    public static bool isExist(TextBox w, TextBox s, TextBox t, DataTable dt)
    {
      bool result = false;

      for (int i = 0; i < dt.Rows.Count; i++)
      {
        //if (w.Text == dgv.Rows[i].Cells[0].ToString() && s.Text == dgv.Rows[i].Cells[1].ToString() && t.Text == dgv.Rows[i].Cells[2].ToString())
        if (w.Text == dt.Rows[i][0].ToString() && s.Text == dt.Rows[i][1].ToString() && t.Text == dt.Rows[i][2].ToString())
        {
          result = true;
          break;
        }
        else
        {
          result = false;
        }

      }

      //   foreach (DataRow dr in dt.Rows)
      // {
      //     if (dr["Name"].ToString() == txtName.Text.Trim())
      //     {
      //         ifExist = true;
      //     }
      // }

      return result;

    }

    public static bool isExist2(string w, string s, string t, DataTable dt, out int id)
    {
      bool result = false;
      id = 0;
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        //if (w.Text == dgv.Rows[i].Cells[0].ToString() && s.Text == dgv.Rows[i].Cells[1].ToString() && t.Text == dgv.Rows[i].Cells[2].ToString())
        if (w == dt.Rows[i][0].ToString() && s == dt.Rows[i][1].ToString() && t == dt.Rows[i][2].ToString())
        {
          result = true;
          id = i;

          break;
        }
        else
        {
          result = false;
        }

      }

      //   foreach (DataRow dr in dt.Rows)
      // {
      //     if (dr["Name"].ToString() == txtName.Text.Trim())
      //     {
      //         ifExist = true;
      //     }
      // }

      return result;

    }

    public static void addWord(TextBox w, TextBox s, TextBox t, DataTable dt)
    {
      if (w.Text.Trim() != "" && s.Text.Trim() != "" && t.Text.Trim() != "")
      {
        if (!isExist(w, s, t, dt))
        {
          // List<data> dObj = new List<data>();
          // dObj.Add(new data(w.Text, s.Text, t.Text, false));

          object[] arr = { w.Text, s.Text, t.Text, false };
          DataRow dr = dt.NewRow();
          dr.ItemArray = arr;
          dt.Rows.InsertAt(dr, 0);

        }

      }

    }

    public static void rowColor(DataGridView dgv, int index)
    {
      for (int i = 0; i < dgv.Rows.Count; i++)
      {
        bool status = (bool)dgv.Rows[i].Cells[3].Value;
        if (status)
        {
          dgv.Rows[i].DefaultCellStyle.BackColor = Color.Green;
        }
      }
    }
    public static void removeWord(DataGridView dgv)
    {
      //reference
      //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/selected-cells-rows-and-columns-datagridview?view=netframeworkdesktop-4.8

      //Method 1 (Using selected rows)
      /*
      Int32 selectedRowCount = dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
      //must select row to remove
      if (selectedRowCount > 0)
      {
        List<int> index = new List<int>();
        for (int i = 0; i < selectedRowCount; i++)
        {
          index.Add((dgv.SelectedRows[i].Index));
          //MessageBox.Show(dgv.SelectedRows[i].Index.ToString());
          //if (dgv.SelectedRows[i].Selected)
          //    dgv.Rows.RemoveAt(dgv.SelectedRows[i].Index);
        }
        if (dgv.Rows.Count > 0)
        {
          //dgv.FirstDisplayedScrollingRowIndex = 0;
        }

        foreach (int item in index)
        {
          dgv.Rows.RemoveAt(item);
        }
      }
      */
      // Method 2 (Using checked rows)
      List<int> index = new List<int>();
      for (int i = dgv.Rows.Count - 1; i >= 0; i--)
      {
        bool delete = (bool)dgv.Rows[i].Cells[3].Value;
        if (delete)
        {
          DataGridViewRow rowRemove = dgv.Rows[i];
          //dgv.Rows.Remove(rowRemove);
          index.Add(rowRemove.Index);
        }
      }

      foreach (int item in index)
      {
        //dgv.Rows.RemoveAt(item);
        dgv.Rows.RemoveAt(item);
      }

    }

    public static int countSelectedValue(DataGridView dgv)
    {
      int n = 0;
      for (int i = 0; i < dgv.Rows.Count; i++)
      {
        bool selected = (bool)dgv.Rows[i].Cells[3].Value;
        if (selected)
        {
          n++;
        }
      }
      return n;
    }
    public static void selectedValuesTable(DataGridView dgv, DataTable dt)
    {
      int id;
      if (countSelectedValue(dgv) == 0 && dgv.Rows.Count >= 5)
      {
        for (int i = 0; i < 5; i++)
        {
          if (!isExist2(dgv.Rows[i].Cells[0].Value.ToString(), dgv.Rows[i].Cells[1].Value.ToString(), dgv.Rows[i].Cells[2].Value.ToString(), dt, out id))
          {
            dt.Rows.Add(dgv.Rows[i].Cells[0].Value, dgv.Rows[i].Cells[1].Value, dgv.Rows[i].Cells[2].Value);
          }
        }

      }
      else if (countSelectedValue(dgv) >= 5)
      {

        for (int i = 0; i < dgv.Rows.Count; i++)
        {
          bool status = (bool)dgv.Rows[i].Cells[3].Value;

          if (status)
          {

            if (!isExist2(dgv.Rows[i].Cells[0].Value.ToString(), dgv.Rows[i].Cells[1].Value.ToString(), dgv.Rows[i].Cells[2].Value.ToString(), dt, out id))
            {
              dt.Rows.Add(dgv.Rows[i].Cells[0].Value, dgv.Rows[i].Cells[1].Value, dgv.Rows[i].Cells[2].Value);
            }
          }
          else
          {
            for (int j = 0; j < dt.Rows.Count; j++)
            {

              if (isExist2(dgv.Rows[i].Cells[0].Value.ToString(), dgv.Rows[i].Cells[1].Value.ToString(), dgv.Rows[i].Cells[2].Value.ToString(), dt, out id))
              {
                dt.Rows.RemoveAt(id);
                //dt.Rows.Remove(dt.Rows[j]);
              }
            }
          }
        }
      }

    }
    public static bool checkInt(string input)
    {
      int number = 0;
      return int.TryParse(input, out number);
    }
    public static bool formIsExist(Form frmOpen)
    {
      FormCollection fc = Application.OpenForms;
      //MessageBox.Show(frmOpen.Text);

      if (frmOpen != null)
      {
        foreach (Form frm in fc)
        {
          if (frm.Name == frmOpen.Name)
          {
            return true;
          }
        }
      }
      return false;

    }
    public static bool formIsExist2(string frmOpen)
    {
      FormCollection fc = Application.OpenForms;
      //MessageBox.Show(frmOpen.Text);
      foreach (Form frm in fc)
      {
        if (frm.Name == frmOpen)
        {
          return true;
        }
      }

      return false;
    }

    //private void startMemory()
    //{

    //    //RowsCount = table.Rows.Count;
    //    //int i =  dataGridView1.SelectedRows =1
    //    R = new string[table.Rows.Count, 3];
    //    // First 3 Row
    //    if ((table.Rows.Count >= 1 && table.Rows.Count <= 3 && (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedCells.Count == 0)) || (table.Rows.Count > 3 && (dataGridView1.SelectedCells.Count == 1 || dataGridView1.SelectedCells.Count == 0)))
    //    {
    //        //R1 = dataGridView1.Rows[0];
    //        //R2 = dataGridView1.Rows[1];
    //        //R3 = dataGridView1.Rows[2];
    //        //// R1
    //        //R[0, 0] = Form1.R1.Cells[0].Value.ToString();
    //        //R[0, 1] = Form1.R1.Cells[1].Value.ToString();
    //        //R[0, 2] = Form1.R1.Cells[2].Value.ToString();

    //        for (int i = 0; i < table.Rows.Count; i++)
    //        {
    //            for (int j = 0; j < 3; j++)
    //            {
    //                //R[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
    //            }
    //        }
    //        // Goto Form 2
    //        //this.Hide();
    //        Form2 frm2 = new Form2();
    //        frm2.Show();
    //    }
    //    // Multi Selected
    //    //else if (table.Rows.Count >= 3 && dataGridView1.SelectedCells.Count > 1)
    //    //{
    //    //    for (int i = 0; i < table.Rows.Count; i++)
    //    //    {
    //    //        for (int j = 0; j < 3; j++)
    //    //        {
    //    //            //R[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
    //    //        }
    //    //    }
    //    ////}
    //}
  }
}
