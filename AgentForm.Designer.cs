namespace JumasValorantRandomizer
{
    partial class AgentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentForm));
            this.agentGenBtn = new System.Windows.Forms.Button();
            this.loadoutTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agentGenBtn
            // 
            this.agentGenBtn.Location = new System.Drawing.Point(417, 499);
            this.agentGenBtn.Name = "agentGenBtn";
            this.agentGenBtn.Size = new System.Drawing.Size(115, 37);
            this.agentGenBtn.TabIndex = 1;
            this.agentGenBtn.Text = "Generate Agent";
            this.agentGenBtn.UseVisualStyleBackColor = true;
            this.agentGenBtn.Click += new System.EventHandler(this.agentGenBtn_Click);
            // 
            // loadoutTitle
            // 
            this.loadoutTitle.AutoSize = true;
            this.loadoutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadoutTitle.ForeColor = System.Drawing.Color.White;
            this.loadoutTitle.Location = new System.Drawing.Point(170, 9);
            this.loadoutTitle.Name = "loadoutTitle";
            this.loadoutTitle.Size = new System.Drawing.Size(282, 37);
            this.loadoutTitle.TabIndex = 2;
            this.loadoutTitle.Text = "Agent Randomizer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(534, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(646, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadoutTitle);
            this.Controls.Add(this.agentGenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgentForm";
            this.Text = "AgentForm";
            this.Load += new System.EventHandler(this.AgentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agentGenBtn;
        private System.Windows.Forms.Label loadoutTitle;
        private System.Windows.Forms.Button button1;
    }
}