namespace DisplaySettingCCDSave
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
            this.SettingslistBox1 = new System.Windows.Forms.ListBox();
            this.SaveCurentSettings = new System.Windows.Forms.Button();
            this.LoadSelectedSettings = new System.Windows.Forms.Button();
            this.SettingsName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SettingslistBox1
            // 
            this.SettingslistBox1.FormattingEnabled = true;
            this.SettingslistBox1.ItemHeight = 16;
            this.SettingslistBox1.Location = new System.Drawing.Point(12, 49);
            this.SettingslistBox1.Name = "SettingslistBox1";
            this.SettingslistBox1.Size = new System.Drawing.Size(256, 308);
            this.SettingslistBox1.TabIndex = 0;
            this.SettingslistBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SaveCurentSettings
            // 
            this.SaveCurentSettings.Location = new System.Drawing.Point(12, 364);
            this.SaveCurentSettings.Name = "SaveCurentSettings";
            this.SaveCurentSettings.Size = new System.Drawing.Size(256, 23);
            this.SaveCurentSettings.TabIndex = 1;
            this.SaveCurentSettings.Text = "SaveCurentSettings";
            this.SaveCurentSettings.UseVisualStyleBackColor = true;
            this.SaveCurentSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadSelectedSettings
            // 
            this.LoadSelectedSettings.Location = new System.Drawing.Point(12, 393);
            this.LoadSelectedSettings.Name = "LoadSelectedSettings";
            this.LoadSelectedSettings.Size = new System.Drawing.Size(256, 23);
            this.LoadSelectedSettings.TabIndex = 2;
            this.LoadSelectedSettings.Text = "LoadSelectedSettings";
            this.LoadSelectedSettings.UseVisualStyleBackColor = true;
            // 
            // SettingsName
            // 
            this.SettingsName.Location = new System.Drawing.Point(12, 12);
            this.SettingsName.Name = "SettingsName";
            this.SettingsName.Size = new System.Drawing.Size(256, 22);
            this.SettingsName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 422);
            this.Controls.Add(this.SettingsName);
            this.Controls.Add(this.LoadSelectedSettings);
            this.Controls.Add(this.SaveCurentSettings);
            this.Controls.Add(this.SettingslistBox1);
            this.Name = "Form1";
            this.Text = "DisplaySettingCCDSave";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SettingslistBox1;
        private System.Windows.Forms.Button SaveCurentSettings;
        private System.Windows.Forms.Button LoadSelectedSettings;
        private System.Windows.Forms.TextBox SettingsName;
    }
}

