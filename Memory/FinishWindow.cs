using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace displayingCard
{
    public partial class FinishWindow : Form
    {
        public FinishWindow()
        {
            InitializeComponent();
        }

        private void finishNGBtn_Click(object sender, EventArgs e)
        {
            StartWindow sw = new StartWindow();
            this.Hide();
            sw.ShowDialog();
            this.Close();
        }
    }
}
