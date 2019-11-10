using System;
using System.Collections.Generic;
using System.Linq;
using WindowsDisplayAPI;
using Newtonsoft.Json.Linq;
using DisplaySettingCCDSave.Interfaces;

namespace DisplaySettingCCDSave
{
    class DisplaySettingManager : IDisplaySettingManager
    {
        public List<Display> GetCureentSettings()
        {
            return Display.GetDisplays().ToList();
        }

        public List<Tuple<string, List<Display>>> GetSavedSettingList()
        {
            throw new NotImplementedException();
        }

        public List<Display> GetSevedSetting(string name)
        {
            throw new NotImplementedException();
        }

        public bool LoadSetting(string name)
        {
            throw new NotImplementedException();
        }

        public bool SaveCurentSetting()
        {
            //JObject.Parse(new Object());
            return false;
        }

        public bool SeveCurrentSettings(string name)
        {
            throw new NotImplementedException();
        }
    }
}
