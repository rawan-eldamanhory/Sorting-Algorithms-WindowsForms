using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class RadixSort : Form
    {
        public RadixSort()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void movesidepanel(Button btn)
        {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;
        }

        private void addUserControl(Control uc)
        {
            panelcenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(uc);
        }

        private void explain_btn_Click_1(object sender, EventArgs e)
        {
            movesidepanel(explain_btn);
            UC1_radixsort uc1 = new UC1_radixsort();
            addUserControl(uc1);
        }

        private void code_btn_Click_1(object sender, EventArgs e)
        {
            movesidepanel(code_btn);
            UC2_radixsort uc2 = new UC2_radixsort();
            addUserControl(uc2);
        }

        private void example_btn_Click_1(object sender, EventArgs e)
        {
            movesidepanel(example_btn);
            UC3_radixsort uc3 = new UC3_radixsort();
            addUserControl(uc3);
        }
    }
}