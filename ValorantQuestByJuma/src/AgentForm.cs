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

        Random rng = new Random();

        // I couldve just referenced the cur active agents via static but I wanted to challenge my self to do it with either delegates or another roundabout way,
        // but either way the delegate felt messy / difficult for me to do & this current reference method im doing is i feel like kinda still trashy.
        //public static List<int> currActiveAgents = new List<int>();

        List<int> currActiveAgents = new List<int>();

        public AgentForm()
        {
            InitializeComponent();
        }

        private void agentGenBtn_Click(object sender, EventArgs e)
        {
            if(currActiveAgents.Count() < 1) { generatedAgentBtn.Text = "Add agents!"; return; }

            int randomNum = currActiveAgents[rng.Next(currActiveAgents.Count())];

            //generatedAgentBtn.ForeColor = Color.BlueViolet; //disabled buttons will not reflect their color being changed to show they are "disabled"
            generatedAgentBtn.Text = randomNum.ToString();

        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            agentButtons = new AgentButton[numberOfAgents];

            for (int i = 0; i < numberOfAgents; i++)
            {
                agentButtons[i] = new AgentButton(100, 100, (i % 6) * (100 + 5) + 10, (i/6) * (100 + 5) + 10, i, ref currActiveAgents);
                agentButtons[i].Click += new EventHandler(agentButtons[i].Toggler);

                //Testing Colors & Debug
                agentButtons[i].Text = i.ToString();
                agentButtons[i].ForeColor = Color.YellowGreen;
                int colCalc = (int)(   (1f - ((float)i / (float)numberOfAgents))   * 255f);
                agentButtons[i].BackColor = Color.FromArgb(255, colCalc, colCalc, colCalc);

                this.Controls.Add(agentButtons[i]);
            }
        }

        private void generatedAgentBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
