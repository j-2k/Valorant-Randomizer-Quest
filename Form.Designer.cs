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
            this.SuspendLayout();
            // 
            // agentBtn
            // 
            this.agentBtn.AccessibleName = "";
            this.agentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.agentBtn.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentBtn.ForeColor = System.Drawing.Color.White;
            this.agentBtn.Location = new System.Drawing.Point(12, 11);
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
            this.loadoutBtn.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadoutBtn.ForeColor = System.Drawing.Color.White;
            this.loadoutBtn.Location = new System.Drawing.Point(12, 73);
            this.loadoutBtn.Name = "loadoutBtn";
            this.loadoutBtn.Size = new System.Drawing.Size(120, 56);
            this.loadoutBtn.TabIndex = 1;
            this.loadoutBtn.Text = "Loadout Randomizer";
            this.loadoutBtn.UseVisualStyleBackColor = false;
            this.loadoutBtn.Click += new System.EventHandler(this.loadoutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 455);
            this.Controls.Add(this.agentBtn);
            this.Controls.Add(this.loadoutBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Valorant Quest by Juma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button agentBtn;
        private System.Windows.Forms.Button loadoutBtn;
    }
}

