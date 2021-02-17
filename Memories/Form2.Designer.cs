
namespace Memories
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnTranslate = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblSentence = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowAndHide = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.lblNumOfWords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWordsCount = new System.Windows.Forms.Label();
            this.lblTimerSec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.cbAutoTranslate = new System.Windows.Forms.CheckBox();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTranslate.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnTranslate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnTranslate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnTranslate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.Location = new System.Drawing.Point(159, 348);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(165, 60);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // lblWord
            // 
            this.lblWord.BackColor = System.Drawing.Color.LightGray;
            this.lblWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWord.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(159, 72);
            this.lblWord.Name = "lblWord";
            this.lblWord.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWord.Size = new System.Drawing.Size(520, 53);
            this.lblWord.TabIndex = 1;
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSentence
            // 
            this.lblSentence.BackColor = System.Drawing.Color.LightGray;
            this.lblSentence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSentence.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentence.Location = new System.Drawing.Point(159, 149);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblSentence.Size = new System.Drawing.Size(520, 53);
            this.lblSentence.TabIndex = 1;
            this.lblSentence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTranslation
            // 
            this.lblTranslation.BackColor = System.Drawing.Color.LightGray;
            this.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTranslation.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslation.Location = new System.Drawing.Point(159, 226);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTranslation.Size = new System.Drawing.Size(520, 53);
            this.lblTranslation.TabIndex = 1;
            this.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(337, 348);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(165, 60);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(736, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Number of words";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(735, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "Time: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowAndHide
            // 
            this.btnShowAndHide.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAndHide.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnShowAndHide.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnShowAndHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAndHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowAndHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAndHide.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAndHide.Location = new System.Drawing.Point(758, 348);
            this.btnShowAndHide.Name = "btnShowAndHide";
            this.btnShowAndHide.Size = new System.Drawing.Size(144, 60);
            this.btnShowAndHide.TabIndex = 3;
            this.btnShowAndHide.Text = "Show";
            this.btnShowAndHide.UseVisualStyleBackColor = false;
            this.btnShowAndHide.Click += new System.EventHandler(this.btnShowAndHide_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bad Script", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(732, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "for each word";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(876, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 92);
            this.label2.TabIndex = 5;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerCount.Font = new System.Drawing.Font("Open Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCount.Location = new System.Drawing.Point(914, 252);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(28, 33);
            this.lblTimerCount.TabIndex = 6;
            this.lblTimerCount.Text = "1";
            this.lblTimerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfWords
            // 
            this.lblNumOfWords.AutoSize = true;
            this.lblNumOfWords.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfWords.Font = new System.Drawing.Font("Open Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfWords.ForeColor = System.Drawing.Color.Orange;
            this.lblNumOfWords.Location = new System.Drawing.Point(768, 115);
            this.lblNumOfWords.Name = "lblNumOfWords";
            this.lblNumOfWords.Size = new System.Drawing.Size(28, 33);
            this.lblNumOfWords.TabIndex = 7;
            this.lblNumOfWords.Text = "6";
            this.lblNumOfWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Open Sans", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label5.Location = new System.Drawing.Point(804, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 55);
            this.label5.TabIndex = 8;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWordsCount
            // 
            this.lblWordsCount.AutoSize = true;
            this.lblWordsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblWordsCount.Font = new System.Drawing.Font("Open Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsCount.Location = new System.Drawing.Point(846, 118);
            this.lblWordsCount.Name = "lblWordsCount";
            this.lblWordsCount.Size = new System.Drawing.Size(28, 33);
            this.lblWordsCount.TabIndex = 9;
            this.lblWordsCount.Text = "1";
            this.lblWordsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimerSec
            // 
            this.lblTimerSec.AutoSize = true;
            this.lblTimerSec.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerSec.Font = new System.Drawing.Font("Open Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerSec.ForeColor = System.Drawing.Color.Orange;
            this.lblTimerSec.Location = new System.Drawing.Point(800, 252);
            this.lblTimerSec.Name = "lblTimerSec";
            this.lblTimerSec.Size = new System.Drawing.Size(41, 33);
            this.lblTimerSec.TabIndex = 10;
            this.lblTimerSec.Text = "10";
            this.lblTimerSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(829, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sec";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.Info;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btnPause.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(514, 348);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(165, 60);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // cbAutoTranslate
            // 
            this.cbAutoTranslate.AutoSize = true;
            this.cbAutoTranslate.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoTranslate.Location = new System.Drawing.Point(6, 368);
            this.cbAutoTranslate.Name = "cbAutoTranslate";
            this.cbAutoTranslate.Size = new System.Drawing.Size(147, 26);
            this.cbAutoTranslate.TabIndex = 12;
            this.cbAutoTranslate.Text = "Auto Translate";
            this.cbAutoTranslate.UseVisualStyleBackColor = true;
            this.cbAutoTranslate.CheckedChanged += new System.EventHandler(this.cbAutoTranslate_CheckedChanged);
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbRandom.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cbRandom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbRandom.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRandom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbRandom.Location = new System.Drawing.Point(6, 313);
            this.cbRandom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(173, 27);
            this.cbRandom.TabIndex = 20;
            this.cbRandom.Text = "Change Random";
            this.cbRandom.UseVisualStyleBackColor = false;
            this.cbRandom.CheckedChanged += new System.EventHandler(this.cbRandom_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 452);
            this.Controls.Add(this.cbRandom);
            this.Controls.Add(this.cbAutoTranslate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTimerSec);
            this.Controls.Add(this.lblWordsCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumOfWords);
            this.Controls.Add(this.lblTimerCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAndHide);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblSentence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTranslate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Memories";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblSentence;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowAndHide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.Label lblNumOfWords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWordsCount;
        private System.Windows.Forms.Label lblTimerSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.CheckBox cbAutoTranslate;
        private System.Windows.Forms.CheckBox cbRandom;
    }
}