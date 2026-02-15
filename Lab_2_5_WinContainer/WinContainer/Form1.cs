using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) but.Text = "First";
            else if (radioButton2.Checked) but.Text = "Second";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SetFlowBreak(button6, true);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button aButton = new Button();
            aButton.Text = "New";
            // Добавляем новую кнопку программно в ячейку (столбец 1, строка 1)
            tableLayoutPanel1.Controls.Add(aButton, 1, 1);
        }
    }
}
