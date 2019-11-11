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
        public List<Tuple<Display, WindowsDisplayAPI.DisplaySetting>> GetCureentSettings()
        {
            return Display.GetDisplays().Select(d=> { return new Tuple<Display, WindowsDisplayAPI.DisplaySetting>(d, d.SavedSetting); }).ToList();
        }
        public List<Tuple<string, List<Tuple<Display, WindowsDisplayAPI.DisplaySetting>>>> GetSavedSettingList()
        {
            sm.Load();
            return sm.Settings;
        }

        public List<Tuple<Display, WindowsDisplayAPI.DisplaySetting>> GetSevedSetting(string name)
        {
            sm.Load();
            return sm.Settings.Where(s => s.Item1 == name).First().Item2;
        }

        public bool LoadSetting(string name)
        {
            if(name==null || name.Length <= 0)
            {
                Notify?.Invoke("Please select a name");
                return false;
            }
            sm.Load();
            List<Tuple<Display, DisplaySetting>> settings = sm.Settings.Where(s => s.Item1 == name).First().Item2;
            //Numbers of screens attached +
            //layout of screens
            //mode of the screens (mirrored or extended)
            //refresh rates +
            //color depths +
            //resolutions + 
            //rotation 
            //scaling +
            Dictionary<WindowsDisplayAPI.DisplayDevice, WindowsDisplayAPI.DisplaySetting> new_value = new Dictionary<WindowsDisplayAPI.DisplayDevice, WindowsDisplayAPI.DisplaySetting>();
            foreach (var dis in settings)
            {
                new_value.Add(dis.Item1,dis.Item2);
            }

            WindowsDisplayAPI.DisplaySetting.SaveDisplaySettings(new_value,true);
            WindowsDisplayAPI.DisplaySetting.ApplySavedSettings();
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
            saved_setting.Add(new Tuple<string, List<Tuple<Display, DisplaySetting>>>(name, GetCureentSettings()));
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
