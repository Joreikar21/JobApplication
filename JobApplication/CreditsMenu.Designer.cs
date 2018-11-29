namespace JobApplication
{
    partial class CreditsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsMenu));
            this.InBtn = new System.Windows.Forms.Button();
            this.OutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InBtn
            // 
            this.InBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InBtn.Location = new System.Drawing.Point(12, 12);
            this.InBtn.Name = "InBtn";
            this.InBtn.Size = new System.Drawing.Size(111, 32);
            this.InBtn.TabIndex = 0;
            this.InBtn.Text = "Входящие";
            this.InBtn.UseVisualStyleBackColor = true;
            this.InBtn.Click += new System.EventHandler(this.InBtn_Click);
            // 
            // OutBtn
            // 
            this.OutBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutBtn.Location = new System.Drawing.Point(12, 50);
            this.OutBtn.Name = "OutBtn";
            this.OutBtn.Size = new System.Drawing.Size(111, 32);
            this.OutBtn.TabIndex = 1;
            this.OutBtn.Text = "Исходящие";
            this.OutBtn.UseVisualStyleBackColor = true;
            this.OutBtn.Click += new System.EventHandler(this.OutBtn_Click);
            // 
            // CreditsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 95);
            this.Controls.Add(this.OutBtn);
            this.Controls.Add(this.InBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(149, 134);
            this.MinimumSize = new System.Drawing.Size(149, 134);
            this.Name = "CreditsMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InBtn;
        private System.Windows.Forms.Button OutBtn;
    }
}