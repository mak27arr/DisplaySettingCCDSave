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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SettingslistBox1 = new System.Windows.Forms.ListBox();
            this.SaveCurentSettings = new System.Windows.Forms.Button();
            this.LoadSelectedSettings = new System.Windows.Forms.Button();
            this.SettingsName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SettingslistBox1
            // 
            this.SettingslistBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingslistBox1.FormattingEnabled = true;
            this.SettingslistBox1.Location = new System.Drawing.Point(9, 6);
            this.SettingslistBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingslistBox1.Name = "SettingslistBox1";
            this.SettingslistBox1.Size = new System.Drawing.Size(193, 173);
            this.SettingslistBox1.TabIndex = 0;
            this.SettingslistBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SaveCurentSettings
            // 
            this.SaveCurentSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCurentSettings.Location = new System.Drawing.Point(9, 243);
            this.SaveCurentSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveCurentSettings.Name = "SaveCurentSettings";
            this.SaveCurentSettings.Size = new System.Drawing.Size(192, 32);
            this.SaveCurentSettings.TabIndex = 1;
            this.SaveCurentSettings.Text = "Save curent settings";
            this.SaveCurentSettings.UseVisualStyleBackColor = true;
            this.SaveCurentSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadSelectedSettings
            // 
            this.LoadSelectedSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadSelectedSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadSelectedSettings.Location = new System.Drawing.Point(9, 183);
            this.LoadSelectedSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadSelectedSettings.Name = "LoadSelectedSettings";
            this.LoadSelectedSettings.Size = new System.Drawing.Size(192, 32);
            this.LoadSelectedSettings.TabIndex = 2;
            this.LoadSelectedSettings.Text = "Load selected settings";
            this.LoadSelectedSettings.UseVisualStyleBackColor = true;
            this.LoadSelectedSettings.Click += new System.EventHandler(this.LoadSelectedSettings_Click);
            // 
            // SettingsName
            // 
            this.SettingsName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsName.Location = new System.Drawing.Point(87, 219);
            this.SettingsName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SettingsName.Name = "SettingsName";
            this.SettingsName.Size = new System.Drawing.Size(114, 20);
            this.SettingsName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Save name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingsName);
            this.Controls.Add(this.LoadSelectedSettings);
            this.Controls.Add(this.SaveCurentSettings);
            this.Controls.Add(this.SettingslistBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
    }
}

