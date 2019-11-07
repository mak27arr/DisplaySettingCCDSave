using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDisplayAPI.DisplayConfig;
using WindowsDisplayAPI.Native;
using WindowsDisplayAPI.Native.DeviceContext;

namespace DisplaySettingCCDSave
{
    class DisplaySettingManager
    {

        public List<object> GetMonitorList()
        {
            var device = Native.DeviceContext.Structures.DisplayDevice.Initialize();
            var deviceIds = new List<string>();
            for (uint i = 0; DeviceContextApi.EnumDisplayDevices(null, i, ref device, 0); i++)
            {
                if (!deviceIds.Contains(device.DeviceId))
                {
                    deviceIds.Add(device.DeviceId);
                    yield return new DisplayAdapter(device.DeviceId, device.DeviceString, device.DeviceKey);
                }
                device = Native.DeviceContext.Structures.DisplayDevice.Initialize();
            }
            return null;
        }

    }
}
