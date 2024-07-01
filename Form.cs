using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumasValorantRandomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadForm(Form form)
        {
            if(this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            Form f = form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;

            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void agentBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new AgentForm());
        }

        private void loadoutBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new LoadoutForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
