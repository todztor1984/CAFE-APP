using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeecafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" แล้วพบกันใหม่ที่ร้าน COFFEE SERVER HERE ขอบคุณครับ ", " COFFEE SERVER HERE ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
