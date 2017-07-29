namespace Aqualite
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.Start = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.DISCLAIMER = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(258, 336);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(222, 96);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start Trojan";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.startClick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(186, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(362, 58);
            this.Title.TabIndex = 1;
            this.Title.Text = "Aqualite Trojan";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // DISCLAIMER
            // 
            this.DISCLAIMER.AutoSize = true;
            this.DISCLAIMER.ForeColor = System.Drawing.Color.Blue;
            this.DISCLAIMER.Location = new System.Drawing.Point(12, 471);
            this.DISCLAIMER.Name = "DISCLAIMER";
            this.DISCLAIMER.Size = new System.Drawing.Size(206, 17);
            this.DISCLAIMER.TabIndex = 2;
            this.DISCLAIMER.Text = "CLICK HERE FOR DISCLAIMER";
            this.DISCLAIMER.Click += new System.EventHandler(this.DISCLAIMER_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 497);
            this.Controls.Add(this.DISCLAIMER);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Aqualite Trojan";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label DISCLAIMER;
    }
}

