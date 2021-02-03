namespace Memories
{
    partial class Form1
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
            this.add = new System.Windows.Forms.Button();
            this.txt_translation = new System.Windows.Forms.TextBox();
            this.lb_word = new System.Windows.Forms.Label();
            this.lb_sentence = new System.Windows.Forms.Label();
            this.lb_translation = new System.Windows.Forms.Label();
            this.txt_sentence = new System.Windows.Forms.TextBox();
            this.txt_word = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.get = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_time = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(350, 414);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(150, 55);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // txt_translation
            // 
            this.txt_translation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_translation.ForeColor = System.Drawing.Color.Green;
            this.txt_translation.Location = new System.Drawing.Point(162, 298);
            this.txt_translation.Name = "txt_translation";
            this.txt_translation.Size = new System.Drawing.Size(568, 30);
            this.txt_translation.TabIndex = 1;
            this.txt_translation.Text = "لكن أنا أريدك - أن تعدّل سلوكك يا سيد";
            this.txt_translation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_word
            // 
            this.lb_word.AutoSize = true;
            this.lb_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_word.Location = new System.Drawing.Point(51, 100);
            this.lb_word.Name = "lb_word";
            this.lb_word.Size = new System.Drawing.Size(47, 20);
            this.lb_word.TabIndex = 6;
            this.lb_word.Text = "Word";
            // 
            // lb_sentence
            // 
            this.lb_sentence.AutoSize = true;
            this.lb_sentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sentence.Location = new System.Drawing.Point(51, 200);
            this.lb_sentence.Name = "lb_sentence";
            this.lb_sentence.Size = new System.Drawing.Size(78, 20);
            this.lb_sentence.TabIndex = 7;
            this.lb_sentence.Text = "Sentence";
            // 
            // lb_translation
            // 
            this.lb_translation.AutoSize = true;
            this.lb_translation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_translation.Location = new System.Drawing.Point(51, 303);
            this.lb_translation.Name = "lb_translation";
            this.lb_translation.Size = new System.Drawing.Size(87, 20);
            this.lb_translation.TabIndex = 8;
            this.lb_translation.Text = "Translation";
            // 
            // txt_sentence
            // 
            this.txt_sentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sentence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_sentence.Location = new System.Drawing.Point(162, 195);
            this.txt_sentence.Name = "txt_sentence";
            this.txt_sentence.Size = new System.Drawing.Size(568, 30);
            this.txt_sentence.TabIndex = 9;
            this.txt_sentence.Text = "I want you to adjust your attitude, mister.";
            this.txt_sentence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_word
            // 
            this.txt_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_word.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_word.Location = new System.Drawing.Point(162, 93);
            this.txt_word.Name = "txt_word";
            this.txt_word.Size = new System.Drawing.Size(568, 32);
            this.txt_word.TabIndex = 10;
            this.txt_word.Text = "adjust";
            this.txt_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(1117, 401);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(105, 55);
            this.remove.TabIndex = 11;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(794, 402);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(126, 54);
            this.start.TabIndex = 12;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            // 
            // get
            // 
            this.get.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get.Location = new System.Drawing.Point(953, 402);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(126, 54);
            this.get.TabIndex = 14;
            this.get.Text = "Get";
            this.get.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(794, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(428, 240);
            this.dataGridView1.TabIndex = 15;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(51, 435);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(65, 20);
            this.lb_time.TabIndex = 17;
            this.lb_time.Text = "Time(s):";
            // 
            // txt_time
            // 
            this.txt_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.ForeColor = System.Drawing.Color.Olive;
            this.txt_time.Location = new System.Drawing.Point(122, 430);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(89, 30);
            this.txt_time.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 526);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.get);
            this.Controls.Add(this.start);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.txt_word);
            this.Controls.Add(this.txt_sentence);
            this.Controls.Add(this.lb_translation);
            this.Controls.Add(this.lb_sentence);
            this.Controls.Add(this.lb_word);
            this.Controls.Add(this.txt_translation);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memories";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox txt_translation;
        private System.Windows.Forms.Label lb_word;
        private System.Windows.Forms.Label lb_sentence;
        private System.Windows.Forms.Label lb_translation;
        private System.Windows.Forms.TextBox txt_sentence;
        private System.Windows.Forms.TextBox txt_word;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.TextBox txt_time;
    }
}

