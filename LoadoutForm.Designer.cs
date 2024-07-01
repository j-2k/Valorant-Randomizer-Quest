namespace JumasValorantRandomizer
{
    partial class LoadoutForm
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
            this.loadoutGenBtn = new System.Windows.Forms.Button();
            this.loadoutTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadoutGenBtn
            // 
            this.loadoutGenBtn.Location = new System.Drawing.Point(519, 512);
            this.loadoutGenBtn.Name = "loadoutGenBtn";
            this.loadoutGenBtn.Size = new System.Drawing.Size(115, 37);
            this.loadoutGenBtn.TabIndex = 0;
            this.loadoutGenBtn.Text = "Generate Loadout";
            this.loadoutGenBtn.UseVisualStyleBackColor = true;
            this.loadoutGenBtn.Click += new System.EventHandler(this.loadoutGenBtn_Click);
            // 
            // loadoutTitle
            // 
            this.loadoutTitle.AutoSize = true;
            this.loadoutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadoutTitle.ForeColor = System.Drawing.Color.White;
            this.loadoutTitle.Location = new System.Drawing.Point(170, 9);
            this.loadoutTitle.Name = "loadoutTitle";
            this.loadoutTitle.Size = new System.Drawing.Size(315, 37);
            this.loadoutTitle.TabIndex = 1;
            this.loadoutTitle.Text = "Loadout Randomizer";
            // 
            // LoadoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(646, 561);
            this.Controls.Add(this.loadoutTitle);
            this.Controls.Add(this.loadoutGenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadoutForm";
            this.Text = "LoadoutForm";
            this.Load += new System.EventHandler(this.LoadoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadoutGenBtn;
        private System.Windows.Forms.Label loadoutTitle;
    }
}