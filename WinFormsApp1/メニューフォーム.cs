using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            //string[] lines = System.IO.File.ReadAllLines("aaa.csv");
        }

        private void saveForm_Click(object sender, EventArgs e)
        {
            User User = new User();
            User.ShowDialog();
        }

        private void ListForm_Click(object sender, EventArgs e)
        {
           二つ目のフォーム f = new 二つ目のフォーム();
            f.ShowDialog();
        }
    }
}
