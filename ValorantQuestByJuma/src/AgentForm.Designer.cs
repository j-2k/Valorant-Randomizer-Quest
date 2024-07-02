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
            this.generatedAgentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agentGenBtn
            // 
            this.agentGenBtn.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentGenBtn.Location = new System.Drawing.Point(535, 430);
            this.agentGenBtn.Name = "agentGenBtn";
            this.agentGenBtn.Size = new System.Drawing.Size(100, 100);
            this.agentGenBtn.TabIndex = 1;
            this.agentGenBtn.Text = "Generate Agent";
            this.agentGenBtn.UseVisualStyleBackColor = true;
            this.agentGenBtn.Click += new System.EventHandler(this.agentGenBtn_Click);
            // 
            // generatedAgentBtn
            // 
            this.generatedAgentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.generatedAgentBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generatedAgentBtn.BackgroundImage")));
            this.generatedAgentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generatedAgentBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.generatedAgentBtn.Enabled = false;
            this.generatedAgentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.generatedAgentBtn.FlatAppearance.BorderSize = 2;
            this.generatedAgentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatedAgentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedAgentBtn.ForeColor = System.Drawing.Color.Yellow;
            this.generatedAgentBtn.Location = new System.Drawing.Point(430, 430);
            this.generatedAgentBtn.Name = "generatedAgentBtn";
            this.generatedAgentBtn.Size = new System.Drawing.Size(100, 100);
            this.generatedAgentBtn.TabIndex = 3;
            this.generatedAgentBtn.Text = "Test";
            this.generatedAgentBtn.UseVisualStyleBackColor = false;
            this.generatedAgentBtn.Click += new System.EventHandler(this.generatedAgentBtn_Click);
            // 
            // AgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(646, 561);
            this.Controls.Add(this.generatedAgentBtn);
            this.Controls.Add(this.agentGenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgentForm";
            this.Text = "AgentForm";
            this.Load += new System.EventHandler(this.AgentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agentGenBtn;
        private System.Windows.Forms.Button generatedAgentBtn;
    }
}