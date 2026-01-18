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
    public partial class InsertionSort : Form
    {
        public InsertionSort()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void explain_btn_Click(object sender, EventArgs e)
        {
            movesidepanel(explain_btn);
            UC1_insertionsort uc1 = new UC1_insertionsort();
            addUserControl(uc1);
        }

        private void code_btn_Click(object sender, EventArgs e)
        {
            movesidepanel(code_btn);
            UC2_insertionsort uc2 = new UC2_insertionsort();
            addUserControl(uc2);
        }

        private void example_btn_Click(object sender, EventArgs e)
        {
            movesidepanel(example_btn);
            UC3_insertionsort uc3 = new UC3_insertionsort();
            addUserControl(uc3);
        }

    }
}
