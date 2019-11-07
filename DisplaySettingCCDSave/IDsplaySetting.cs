using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplaySettingCCDSave
{
    interface IDsplaySetting
    {
        string Name { get; set; }
        int ScreenNumber { get; set; }
        int Screenlayout { get; set; }
        ScreenMode ScreenMode { get; set; }
        int RefreshRates { get; set; }
        int ColorDepths { get; set; }
        Tuple<int, int> Resolutions { get; set; }
        int Rotation { get; set; }
        int Scaling { get; set; }
    }

    enum ScreenMode
    {
        Mirrored,
        Extended
    }
}
