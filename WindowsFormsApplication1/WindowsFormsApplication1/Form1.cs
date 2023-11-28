using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessloginLayer;

namespace WindowsFormsApplication1
{
    public partial class Frm_Patient : Form
    {
        public Frm_Patient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bll_patient obj = new bll_patient();
            obj.getting_values(txtID.Text, txtname.Text, txtaddress.Text);

            //Testing For Github


        }
    }
}
