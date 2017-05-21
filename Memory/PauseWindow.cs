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
    public partial class PauseWindow : Form
    {
        public PauseWindow()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void unpauseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
