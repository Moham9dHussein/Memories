namespace Memories
{
  partial class Form1Test
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Test));
            this.lblWord = new System.Windows.Forms.Label();
            this.lblSentence = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.txt_sentence = new System.Windows.Forms.TextBox();
            this.txt_word = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txt_translation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            resources.ApplyResources(this.lblWord, "lblWord");
            this.lblWord.Name = "lblWord";
            // 
            // lblSentence
            // 
            resources.ApplyResources(this.lblSentence, "lblSentence");
            this.lblSentence.Name = "lblSentence";
            // 
            // lblTranslation
            // 
            resources.ApplyResources(this.lblTranslation, "lblTranslation");
            this.lblTranslation.Name = "lblTranslation";
            // 
            // txt_sentence
            // 
            this.txt_sentence.BackColor = System.Drawing.Color.LightGray;
            this.txt_sentence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_sentence, "txt_sentence");
            this.txt_sentence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_sentence.Name = "txt_sentence";
            this.txt_sentence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            // 
            // txt_word
            // 
            this.txt_word.BackColor = System.Drawing.Color.LightGray;
            this.txt_word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_word, "txt_word");
            this.txt_word.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_word.Name = "txt_word";
            this.txt_word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            // 
            // txt_time
            // 
            this.txt_time.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txt_time, "txt_time");
            this.txt_time.ForeColor = System.Drawing.Color.Olive;
            this.txt_time.Name = "txt_time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbSelectAll
            // 
            resources.ApplyResources(this.cbSelectAll, "cbSelectAll");
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbSelectAll_CheckedChanged);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.CadetBlue;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txt_translation
            // 
            this.txt_translation.BackColor = System.Drawing.Color.LightGray;
            this.txt_translation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_translation, "txt_translation");
            this.txt_translation.ForeColor = System.Drawing.Color.Green;
            this.txt_translation.Name = "txt_translation";
            this.txt_translation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            // 
            // Form1Test
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_word);
            this.Controls.Add(this.txt_sentence);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblSentence);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txt_translation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lblWord;
    private System.Windows.Forms.Label lblSentence;
    private System.Windows.Forms.Label lblTranslation;
    private System.Windows.Forms.TextBox txt_sentence;
    private System.Windows.Forms.TextBox txt_word;
    private System.Windows.Forms.TextBox txt_time;
    private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txt_translation;
    }
}

