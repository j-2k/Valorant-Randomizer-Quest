using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumasValorantRandomizer
{
    public partial class AgentForm : Form
    {
        private const int numberOfAgents = 24;
        private AgentButton[] agentButtons;

        public AgentForm()
        {
            InitializeComponent();
        }

        private void agentGenBtn_Click(object sender, EventArgs e)
        {

        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            agentButtons = new AgentButton[numberOfAgents];

            for (int i = 0; i < numberOfAgents; i++)
            {
                agentButtons[i] = new AgentButton(100, 100, (i % 6) * (100 + 5) + 10, (i/6) * (100 + 5) + 10);
                agentButtons[i].Click += new EventHandler(agentButtons[i].Toggler);

                //Testing Colors & Debug
                int colCalc = (int)(   (1f - ((float)i / (float)numberOfAgents))   * 255f);
                agentButtons[i].BackColor = Color.FromArgb(255, colCalc, colCalc, colCalc);

                this.Controls.Add(agentButtons[i]);
            }
        }
    }
}
