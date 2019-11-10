using System;
using System.Collections.Generic;
using System.Linq;
using WindowsDisplayAPI;
using DisplaySettingCCDSave.Interfaces;

namespace DisplaySettingCCDSave.Classes
{
    public class DisplaySettingManager : IDisplaySettingManager
    {

        public delegate void MessageHandler(string message);
        public event MessageHandler Notify;

        SafekeepingManager sm; 
        public DisplaySettingManager()
        {
            sm = new SafekeepingManager();
        }
        public List<Display> GetCureentSettings()
        {
            return Display.GetDisplays().ToList();
        }
        public List<Tuple<string, List<Display>>> GetSavedSettingList()
        {
            sm.Load();
            return sm.Settings;
        }

        public List<Display> GetSevedSetting(string name)
        {
            sm.Load();
            return sm.Settings.Where(s => s.Item1 == name).First().Item2;
        }

        public bool LoadSetting(string name)
        {
            sm.Load();
            List<Display> settings = sm.Settings.Where(s => s.Item1 == name).First().Item2;




            Notify?.Invoke("Settings loaded");
            return true;
        }

        public bool SeveCurrentSettings(string name)
        {
            if (name.Length == 0)
            {
                Notify?.Invoke("Error: Set name for save");
                return false;
            }
            if (sm.Settings.Where(s => s.Item1 == name).Count() > 0)
            {
                Notify?.Invoke("Error: Name busy");
                return false;
            }
            sm.Load();
            var saved_setting = sm.Settings;
            saved_setting.Add(new Tuple<string, List<Display>>(name, GetCureentSettings()));
            sm.Settings = saved_setting;
            if (sm.Save())
            {
                Notify?.Invoke("Settings saved");
                return true;
            }
            else
            {
                Notify?.Invoke("Error save settings");
                return false;
            }
        }
    }
}
