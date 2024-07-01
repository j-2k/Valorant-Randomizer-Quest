namespace JumasValorantRandomizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.agentBtn = new System.Windows.Forms.Button();
            this.loadoutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // agentBtn
            // 
            this.agentBtn.AccessibleName = "";
            this.agentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.agentBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.agentBtn.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentBtn.ForeColor = System.Drawing.Color.White;
            this.agentBtn.Location = new System.Drawing.Point(9, 14);
            this.agentBtn.Name = "agentBtn";
            this.agentBtn.Size = new System.Drawing.Size(120, 56);
            this.agentBtn.TabIndex = 0;
            this.agentBtn.Text = "Agent Randomizer";
            this.agentBtn.UseVisualStyleBackColor = false;
            this.agentBtn.Click += new System.EventHandler(this.agentBtn_Click);
            // 
            // loadoutBtn
            // 
            this.loadoutBtn.AccessibleName = "";
            this.loadoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.loadoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadoutBtn.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadoutBtn.ForeColor = System.Drawing.Color.White;
            this.loadoutBtn.Location = new System.Drawing.Point(9, 76);
            this.loadoutBtn.Name = "loadoutBtn";
            this.loadoutBtn.Size = new System.Drawing.Size(120, 56);
            this.loadoutBtn.TabIndex = 1;
            this.loadoutBtn.Text = "Loadout Randomizer";
            this.loadoutBtn.UseVisualStyleBackColor = false;
            this.loadoutBtn.Click += new System.EventHandler(this.loadoutBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(138, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 561);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.agentBtn);
            this.Controls.Add(this.loadoutBtn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Valorant Quest by Juma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button agentBtn;
        private System.Windows.Forms.Button loadoutBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

