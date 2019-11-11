using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDisplayAPI;

namespace DisplaySettingCCDSave.Interfaces
{
    interface IDisplaySettingManager
    {
        List<Tuple<Display, WindowsDisplayAPI.DisplaySetting>> GetCureentSettings();
        bool SeveCurrentSettings(string name);
        bool LoadSetting(string name);
        List<Tuple<string, List<Tuple<Display, DisplaySetting>>>> GetSavedSettingList();
        List<Tuple<Display, DisplaySetting>> GetSevedSetting(string name);

    }
}
