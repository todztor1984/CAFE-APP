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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str;
            str = "";
            if (mrck.Checked == true)
            {
                str = " นาย " + txtName.Text;
            }
            else
            {
                str = " นางสาว " + txtName.Text;
            }

            /////////////////////

            str += " \r\n\nวัน/เดือน/ปี : " + date2.SelectedItem.ToString() + " / " + mouth2.SelectedItem.ToString() + " / " + year2.Text;

            ////////////////////

            str += " \r\n\nที่อยู่ : " + txtaddress.Text;

            ////////////////////

            str += " \r\n\nอีเมลล์ : " + txtemail.Text;

            ////////////////////

            str += " \r\n\nเบอร์โทรศัพท์ : " + tel.Text;

            ////////////////////

            OutData.Text = str;

            String str1;
            double BE1, BE2, BE3, BE4, BE5, BE6, DE1, DE2, DE3, DE4, DE5, SUM;
            str1 = "";

            if (B1.Checked == true)
            {
                str1 += " \r\n\nEspresso  ราคา 40 บาท ";
                BE1 = 40;
            }
            else
            {
                BE1 = 0;
            }
            if (B2.Checked == true)
            {
                str1 += " \r\n\nAmericano  ราคา 50 บาท ";
                BE2 = 50;
            }
            else
            {
                BE2 = 0;
            }
            if (B3.Checked == true)
            {
                str1 += " \r\n\nCafe Breve  ราคา 55 บาท ";
                BE3 = 55;
            }
            else
            {
                BE3 = 0;
            }
            if (B4.Checked == true)
            {
                str1 += " \r\n\nFlat White  ราคา 50 บาท ";
                BE4 = 50;
            }
            else
            {
                BE4 = 0;
            }
            if (B5.Checked == true)
            {
                str1 += " \r\n\nCappuccino  ราคา 45 บาท ";
                BE5 = 45;
            }
            else
            {
                BE5 = 0;
            }
            if (B6.Checked == true)
            {
                str1 += " \r\n\nIce Coffee  ราคา 50 บาท ";
                BE6 = 50;
            }
            else
            {
                BE6 = 0;
            }
            if (D1.Checked == true)
            {
                str1 += " \r\n\nGelato Waffle  ราคา 120 บาท ";
                DE1 = 120;
            }
            else
            {
                DE1 = 0;
            }
            if (D2.Checked == true)
            {
                str1 += " \r\n\nBread Pudding  ราคา 89 บาท ";
                DE2 = 89;
            }
            else
            {
                DE2 = 0;
            }
            if (D3.Checked == true)
            {
                str1 += " \r\n\nFrench Toast Original  ราคา 129 บาท ";
                DE3 = 129;
            }
            else
            {
                DE3 = 0;
            }
            if (D4.Checked == true)
            {
                str1 += " \r\n\nFresh Fruit Pancake  ราคา 139 บาท ";
                DE4 = 139;
            }
            else
            {
                DE4 = 0;
            }
            if (D5.Checked == true)
            {
                str1 += " \r\n\npancake banana  ราคา 119 บาท ";
                DE5 = 119;
            }
            else
            {
                DE5 = 0;
            }

            Order.Text = str1;
            /////////////////////

            SUM = BE1 + BE2 + BE3 + BE4 + BE5 + BE6 + DE1 + DE2 + DE3 + DE4 + DE5;

            Sum.Text = (SUM + " บาท ");

            MessageBox.Show("บันทึกรายการสั่งสิ้นค้า" + Sum.Text, " COFFEE CAFE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            date2.ResetText();
            mouth2.ResetText();
            year2.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            tel.Clear();

            OutData.Clear();
            Order.Clear();
            Sum.Clear();

            /////////////////////

            B1.Checked = false;
            B2.Checked = false;
            B3.Checked = false;
            B4.Checked = false;
            B5.Checked = false;
            B6.Checked = false;

            /////////////////////

            D1.Checked = false;
            D2.Checked = false;
            D3.Checked = false;
            D4.Checked = false;
            D5.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("แล้วพบกันใหม่ในโอกาสหน้าที่ร้าน COFFEE SERVER HERE ขอบคุณครับ", "COFFEE SERVER HERE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void OutData_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
