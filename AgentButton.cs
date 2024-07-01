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

        public AgentButton(int sizeX, int sizeY, int posX, int posY)
        {
            this.Text = "";
            this.Size = new System.Drawing.Size(sizeX, sizeY);
            this.Location = new System.Drawing.Point(posX, posY);

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 2;
            this.FlatAppearance.BorderColor = Color.Black; 
        }

        public void Toggler(object sender, EventArgs e)
        {
            isActive = !isActive;
            this.FlatAppearance.BorderColor = isActive ? Color.SkyBlue : Color.Black;
        }
    }
}
