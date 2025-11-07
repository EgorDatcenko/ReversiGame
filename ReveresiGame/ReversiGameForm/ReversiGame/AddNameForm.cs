using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddNameForm : Form
    {
        public AddNameForm()
        {
            InitializeComponent();
        }
        private String GetName1;
        private String GetName2;
        public void ButtonAccess_Click(object sender, EventArgs e)
        {
            GetName1 = textBox1.Text;
            GetName2 = textBox2.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public string getName1()
        {
            return GetName1;
        }
        public string getName2()
        {
            return GetName2;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
