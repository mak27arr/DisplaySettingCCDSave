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
        List<Display> GetCureentSettings();
        bool SeveCurrentSettings(string name);
        bool LoadSetting(string name);
        List<Tuple<string, List<Display>>> GetSavedSettingList();
        List<Display> GetSevedSetting(string name);

    }
}
