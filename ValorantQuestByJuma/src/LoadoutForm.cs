using System;
using System.Collections;
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
    public partial class LoadoutForm : Form
    {
        public class LoadoutButton : Button
        {
            //Array now is sorted 0 - 4 sidearms,
            //5 - 17 is reserved for weapons in correct order,
            //18 - 20 is reserved for shields in correct order, 21 is the length thus there is no 21st element!
            public int index = 0;
            public int price = 0;
            public bool isToggled = false;

            public void ToggleButton(object sender, EventArgs e)
            {
                isToggled = !isToggled;
                
                //add this to the list of active items
                if (isToggled)
                {
                    //activeLoadoutItems.Add(index);
                    InsertToCorrectList();
                }
                else
                {
                    RemoveFromCorrectList();
                    //activeLoadoutItems.Remove(index);
                }

                this.FlatAppearance.BorderColor = isToggled ? Color.SkyBlue : Color.Black;
            }

            //ref to the comment on line 49, im doing this the shitty way since im running out of time
            void InsertToCorrectList()
            {
                if(index >= 18)
                {
                    activeShieldItems.Add(index);
                }
                else if(index >= 5)
                {
                    activePrimaryItems.Add(index);
                }
                else if (index >= 0)
                {
                    activeSecondaryItems.Add(index);
                }
            }

            void RemoveFromCorrectList()
            {
                if (index >= 18)
                {
                    activeShieldItems.Remove(index);
                }
                else if (index >= 5)
                {
                    activePrimaryItems.Remove(index);
                }
                else if (index >= 0)
                {
                    activeSecondaryItems.Remove(index);
                }
            }
        }

        public LoadoutForm()
        {
            InitializeComponent();
        }

        const int maxLoadoutBtns = 21;
        //Holds all weapons & shield buttons!
        LoadoutButton[] loadoutBtns = new LoadoutButton[maxLoadoutBtns];
        //static List<int> activeLoadoutItems = new List<int>();// couldve handled it all in 1 list but im going to do it the dumb way for this part since im running out of time
        static List<int> activePrimaryItems = new List<int>();
        static List<int> activeSecondaryItems = new List<int>();
        static List<int> activeShieldItems = new List<int>();

        Random rng = new Random();

        private void LoadoutForm_Load(object sender, EventArgs e)
        {
            //activeLoadoutItems.Clear();
            secondaryBox.Visible = checkSecondaryBox.Checked;
            shieldBox.Visible = checkShieldBox.Checked;
            primaryBox.BackgroundImage = null;
            //int loadoutIndex = 0;
            int arrayOffset = 0;
            
            foreach(Control c in this.Controls)
            {
                if (c is LoadoutButton btn && (btn.Name.StartsWith("W") || btn.Name.StartsWith("S")))
                {
                    //Test & Debug
                    //loadoutBtns[loadoutIndex] = btn;
                    //loadoutIndex++;

                    //its a good idea probably to make sure loadoutIndex dosn't exceed maxLoadoutBtns value to avoid buffer overflow
                    //just stating this incase it has to be done below but im not going to do this for now

                    //====
                    //int n = btn.Name.IndexOf('_');

                    //im so inconsistent I start weapons with 1 but shields with 0 lmao (0 for shield because i assume no
                    //shield but the same can be said about the classic smooth brain moment) its a quick fix tho!

                    //casting to a derived class issue!
                    //if (c is Button btn &&...
                    //LoadoutButton lb = (LoadoutButton) btn //will not work! so i use changed the whole button class at the initalize component stage

                    arrayOffset = btn.Name[0] == 'S' ? 19 : 0;
                    string[] btnInfo = btn.Name.Split('_');
                    int i = Int32.Parse(btnInfo[0].Substring(1)) - 1 + arrayOffset;
                    int cost = Int32.Parse(btnInfo[1]);

                    loadoutBtns[i] = btn;
                    loadoutBtns[i].price = cost;
                    loadoutBtns[i].index = i;
                    loadoutBtns[i].Click += new EventHandler(loadoutBtns[i].ToggleButton);
                    loadoutBtns[i].PerformClick();
                    
                    //Array now is sorted 0 - 4 sidearms, 5 - 17 is reserved for weapons in correct order, 18 - 20 is reserved for shields in correct order, 21 is the length thus there is no 21st element!
                }
            }
            Console.WriteLine(loadoutBtns);
        }

        List<int> combinedActiveList = new List<int>();

        private void loadoutGenBtn_Click(object sender, EventArgs e)
        {
            //Check for money first then base the selection on the amount of money
            // additional problem: how should money be spent in what prio order? shield > prim > sec? or prim > sec > shield? can something be neglected??? etc..
            //I think im going to do something general because this would take some time to handle all these cases.
            //RNG box names = primaryBox, secondaryBox, shieldBox

            //Money Check is the last function to be implemented, I will try finish everything else before handling this

            //this is disgusting, and i have not even yet added money checks & money management
            if (checkSecondaryBox.Checked && activeSecondaryItems.Count > 0)
            {
                if(activePrimaryItems.Count > 0) {
                    //primaryBox.Visible = true;
                    int rngPrimaryIndex = activePrimaryItems[rng.Next(activePrimaryItems.Count)];
                    //primaryBox.BackgroundImage = loadoutBtns[rng.Next(6, 18)].BackgroundImage;
                    primaryBox.BackgroundImage = loadoutBtns[rngPrimaryIndex].BackgroundImage;

                    secondaryBox.Visible = true;
                    int rngSecondaryIndex = activeSecondaryItems[rng.Next(activeSecondaryItems.Count)];
                    //secondaryBox.BackgroundImage = loadoutBtns[rng.Next(0, 6)].BackgroundImage;
                    secondaryBox.BackgroundImage = loadoutBtns[rngSecondaryIndex].BackgroundImage;
                }
                else
                {
                    return;
                }
            }
            else
            {
                checkSecondaryBox.Checked = false;
                secondaryBox.Visible = false;

                //everything here is bad!
                combinedActiveList.Clear();
                foreach(int p in activePrimaryItems)
                {
                    combinedActiveList.Add(p);
                }
                foreach (int s in activeSecondaryItems)
                {
                    combinedActiveList.Add(s);
                }

                //Array.Sort(combinedActiveList.ToArray());

                foreach (int i in combinedActiveList.ToArray())
                {
                    if (loadoutBtns[i].price > currentMoney)
                    {
                        combinedActiveList.Remove(i);
                    }
                }

                if(combinedActiveList.Count > 0)
                {
                    primaryBox.Visible = true;
                    int rngCombinedIndex = combinedActiveList[rng.Next(combinedActiveList.Count)];
                    primaryBox.BackgroundImage = loadoutBtns[rngCombinedIndex].BackgroundImage;
                }
                else
                {
                    primaryBox.Visible = false;
                }

                /*
                if(currentMoney >= 850)
                {
                    int rngPorS = rng.Next(2);
                    if (rngPorS == 0)
                    {
                        int rngPriIndex = activePrimaryItems[rng.Next(activePrimaryItems.Count)];
                        primaryBox.BackgroundImage = loadoutBtns[rngPriIndex].BackgroundImage;
                    }
                    else
                    {
                        int rngSecIndex = activeSecondaryItems[rng.Next(activeSecondaryItems.Count)];
                        primaryBox.BackgroundImage = loadoutBtns[rngSecIndex].BackgroundImage;
                    }
                }
                else
                {
                    int rngSecIndex = activeSecondaryItems[rng.Next(activeSecondaryItems.Count)];
                    primaryBox.BackgroundImage = loadoutBtns[rngSecIndex].BackgroundImage;
                }



                int rngMixIndex = activePrimaryItems[rng.Next(activePrimaryItems.Count)];
                //primaryBox.BackgroundImage = loadoutBtns[rng.Next(0, 18)].BackgroundImage;
                primaryBox.BackgroundImage = loadoutBtns[rngMixIndex].BackgroundImage;
                */
            }

            if (checkShieldBox.Checked && activeShieldItems.Count > 0)
            {
                shieldBox.Visible = true;
                int rngShieldIndex = activeShieldItems[rng.Next(activeShieldItems.Count)];
                //shieldBox.BackgroundImage = loadoutBtns[rng.Next(18, 21)].BackgroundImage;
                shieldBox.BackgroundImage = loadoutBtns[rngShieldIndex].BackgroundImage;
            }

            //activeLoadoutItems.Capacity
        }

        int currentMoney = 0;
        int prevMoney = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Set money here
            /*
            sender.GetType();
            char lastChar;
            if (textBox1.TextLength - 1 > 0)
            {
                lastChar = textBox1.Text[textBox1.TextLength - 1];
            }
            else
            {
                return;
            }

            if (!char.IsNumber(lastChar))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            */

            //New implementation below works like a charm, my first implementation above showcasing a big bug I didn't think about... (prev implementation only checks end!)
            //Now it actively removes it which looks slightly ugly but idk if there is a easy way to check for incoming key pressed because that would be the best method ig, instead of checking what has been put inside already.
            bool isNumberOnly = int.TryParse(textBox1.Text, out currentMoney);

            if (!isNumberOnly && textBox1.TextLength > 0)
            {
                textBox1.Text = prevMoney.ToString();
            }
            else
            {
                prevMoney = currentMoney;
            }
            
        }

        private void checkShieldBox_CheckedChanged(object sender, EventArgs e)
        {
            //shieldBox.Visible = checkShieldBox.Checked;
            if(!checkShieldBox.Checked)
            {
                shieldBox.Visible = false;
            }
        }

        private void checkSecondaryBox_CheckedChanged(object sender, EventArgs e)
        {
            //secondaryBox.Visible = checkSecondaryBox.Checked;
            if (!checkSecondaryBox.Checked)
            {
                secondaryBox.Visible = false;
            }
        }

        private void lastBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
