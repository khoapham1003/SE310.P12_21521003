using Bai1_ADO.NET.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_ADO.NET.Presentation
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            Form form = new MainForm((int)nud_cowAmount.Value, (int)nud_sheepAmount.Value, (int)nud_goatAmount.Value);
            form.Show();
            this.Hide();

        }
    }
}
