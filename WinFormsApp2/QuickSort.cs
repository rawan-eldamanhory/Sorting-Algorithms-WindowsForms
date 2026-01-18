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
    public partial class QuickSort : Form
    {
        public QuickSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        

        private void explain_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void code_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void example_btn_Click(object sender, EventArgs e)
        {
            
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
            UC1_quicksort uc1 = new UC1_quicksort();
            addUserControl(uc1);
        }

        private void code_btn_Click_1(object sender, EventArgs e)
        {
            movesidepanel(code_btn);
            UC2_quicksort uc2 = new UC2_quicksort();
            addUserControl(uc2);
        }

        private void example_btn_Click_1(object sender, EventArgs e)
        {
            movesidepanel(example_btn);
            UC3_quicksort uc3 = new UC3_quicksort();
            addUserControl(uc3);
        }
    }
}
