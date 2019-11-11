using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisplaySettingCCDSave.Classes;

namespace DisplaySettingCCDSave
{
    public partial class Form1 : Form
    {
        DisplaySettingManager dsm;
        public Form1()
        { 
            InitializeComponent();
            dsm = new DisplaySettingManager();
            dsm.Notify += MessageNotification;
            InitData();
        }
        private void MessageNotification(string msg)
        {
            toolStripStatusLabel.Text = msg;
        }

        private void loadSelectedSettingsButton_Click(object sender, EventArgs e)
        {
            if (savedSettingList.SelectedIndex != null && savedSettingList.SelectedIndex != -1)
                dsm.LoadSetting(savedSettingList.SelectedItem?.ToString());
        }

        private void InitData()
        {
            var saved_setting = dsm.GetSavedSettingList();
            savedSettingList.DataSource = saved_setting;
        }

        private void saveCurentSettingsButton_Click(object sender, EventArgs e)
        {
            if (settingsNameTextBox.Text.Length > 0)
                dsm.SeveCurrentSettings(settingsNameTextBox.Text);
            else
                MessageNotification("Please enter a name");
        }
    }
}
