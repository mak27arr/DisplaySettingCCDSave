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
            this.savedSettingList = new System.Windows.Forms.ListBox();
            this.saveCurentSettingsButton = new System.Windows.Forms.Button();
            this.loadSelectedSettingsButton = new System.Windows.Forms.Button();
            this.settingsNameTextBox = new System.Windows.Forms.TextBox();
            this.saveNameLable = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // savedSettingList
            // 
            this.savedSettingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savedSettingList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.savedSettingList.FormattingEnabled = true;
            this.savedSettingList.Location = new System.Drawing.Point(9, 6);
            this.savedSettingList.Margin = new System.Windows.Forms.Padding(2);
            this.savedSettingList.Name = "savedSettingList";
            this.savedSettingList.Size = new System.Drawing.Size(193, 186);
            this.savedSettingList.TabIndex = 0;
            // 
            // saveCurentSettingsButton
            // 
            this.saveCurentSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveCurentSettingsButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveCurentSettingsButton.Location = new System.Drawing.Point(9, 260);
            this.saveCurentSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveCurentSettingsButton.Name = "saveCurentSettingsButton";
            this.saveCurentSettingsButton.Size = new System.Drawing.Size(192, 32);
            this.saveCurentSettingsButton.TabIndex = 1;
            this.saveCurentSettingsButton.Text = "Save curent settings";
            this.saveCurentSettingsButton.UseVisualStyleBackColor = false;
            this.saveCurentSettingsButton.Click += new System.EventHandler(this.saveCurentSettingsButton_Click);
            // 
            // loadSelectedSettingsButton
            // 
            this.loadSelectedSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadSelectedSettingsButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loadSelectedSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadSelectedSettingsButton.Location = new System.Drawing.Point(9, 200);
            this.loadSelectedSettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadSelectedSettingsButton.Name = "loadSelectedSettingsButton";
            this.loadSelectedSettingsButton.Size = new System.Drawing.Size(192, 32);
            this.loadSelectedSettingsButton.TabIndex = 2;
            this.loadSelectedSettingsButton.Text = "Load selected settings";
            this.loadSelectedSettingsButton.UseVisualStyleBackColor = false;
            this.loadSelectedSettingsButton.Click += new System.EventHandler(this.loadSelectedSettingsButton_Click);
            // 
            // settingsNameTextBox
            // 
            this.settingsNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsNameTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.settingsNameTextBox.Location = new System.Drawing.Point(77, 236);
            this.settingsNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.settingsNameTextBox.Name = "settingsNameTextBox";
            this.settingsNameTextBox.Size = new System.Drawing.Size(124, 20);
            this.settingsNameTextBox.TabIndex = 3;
            // 
            // saveNameLable
            // 
            this.saveNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveNameLable.AutoSize = true;
            this.saveNameLable.Location = new System.Drawing.Point(11, 239);
            this.saveNameLable.Name = "saveNameLable";
            this.saveNameLable.Size = new System.Drawing.Size(61, 13);
            this.saveNameLable.TabIndex = 4;
            this.saveNameLable.Text = "Save name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(211, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(211, 317);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.saveNameLable);
            this.Controls.Add(this.settingsNameTextBox);
            this.Controls.Add(this.loadSelectedSettingsButton);
            this.Controls.Add(this.saveCurentSettingsButton);
            this.Controls.Add(this.savedSettingList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DisplaySettingCCDSave";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox savedSettingList;
        private System.Windows.Forms.Button saveCurentSettingsButton;
        private System.Windows.Forms.Button loadSelectedSettingsButton;
        private System.Windows.Forms.TextBox settingsNameTextBox;
        private System.Windows.Forms.Label saveNameLable;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

