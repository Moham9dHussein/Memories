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
    
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2():this(null)
        {
            
        }

        public Form2(Form1 _f1)
        {
            InitializeComponent();
            f1 = _f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            //f1.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
