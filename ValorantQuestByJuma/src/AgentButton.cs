using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumasValorantRandomizer
{
    internal class AgentButton : Button
    {
        public bool isActive = false;
        public int agentIndex = 0;


        List<int> agentListReference;

        public AgentButton(int sizeX, int sizeY, int posX, int posY, int agentIndex, ref List<int> activeAgentList)
        {
            this.Text = "";
            this.Size = new System.Drawing.Size(sizeX, sizeY);
            this.Location = new System.Drawing.Point(posX, posY);

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 2;
            this.FlatAppearance.BorderColor = Color.Black;

            this.agentIndex = agentIndex;
            this.agentListReference = activeAgentList;
        }

        public void Toggler(object sender, EventArgs e)
        {
            isActive = !isActive;
            if(isActive) {
                this.agentListReference.Add(agentIndex);
            }
            else{
                this.agentListReference.Remove(agentIndex);
            }
            this.FlatAppearance.BorderColor = isActive ? Color.SkyBlue : Color.Black;
        }
    }
}
