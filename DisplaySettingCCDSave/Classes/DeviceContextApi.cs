using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DisplaySettingCCDSave.Classes
{
    class DeviceContextApi
    {
        [DllImport("user32")]
        public static extern ChangeDisplaySettingsExResults ChangeDisplaySettingsEx(
            string deviceName,
            ref DeviceMode devMode,
            IntPtr handler,
            ChangeDisplaySettingsFlags flags,
            IntPtr param);

        [DllImport("user32")]
        public static extern ChangeDisplaySettingsExResults ChangeDisplaySettingsEx(
            string deviceName,
            IntPtr devModePointer,
            IntPtr handler,
            ChangeDisplaySettingsFlags flags,
            IntPtr param);

        [DllImport("user32")]
        public static extern bool EnumDisplaySettings(
            string deviceName,
            DisplaySettingsMode mode,
            ref DeviceMode devMode);

        [DllImport("user32", CharSet = CharSet.Ansi)]
        internal static extern bool EnumDisplayDevices(string deviceName, uint deviceNumber,
            ref DeviceContext.Structures.DisplayDevice displayDevice,
            uint flags);
        [DllImport("user32")]
        public static extern Win32Status DisplayConfigGetDeviceInfo(
            ref DisplayConfigSupportVirtualResolution targetSupportVirtualResolution);

        [DllImport("user32")]
        public static extern Win32Status DisplayConfigGetDeviceInfo(ref DisplayConfigTargetDeviceName deviceName);

        [DllImport("user32")]
        public static extern Win32Status DisplayConfigGetDeviceInfo(ref DisplayConfigAdapterName deviceName);

        [DllImport("user32")]
        public static extern Win32Status DisplayConfigGetDeviceInfo(ref DisplayConfigSourceDeviceName deviceName);

        [DllImport("user32")]
        public static extern Win32Status DisplayConfigGetDeviceInfo(
            ref DisplayConfigTargetPreferredMode targetPreferredMode);

        [DllImport("user32")]
        public static extern Win32Status DisplayConfigGetDeviceInfo(ref DisplayConfigTargetBaseType targetBaseType);

        [DllImport("user32")]
        public static extern Win32Status DisplayConfigSetDeviceInfo(DisplayConfigSetTargetPersistence targetPersistence);

        [DllImport("user32")]
        public static extern Win32Status DisplayConfigSetDeviceInfo(
            DisplayConfigSupportVirtualResolution targetSupportVirtualResolution);

        [DllImport("user32")]
        public static extern Win32Status GetDisplayConfigBufferSizes(QueryDeviceConfigFlags flags,
            out uint pathArrayElements, out uint modeInfoArrayElements);

        [DllImport("user32")]
        public static extern Win32Status QueryDisplayConfig(QueryDeviceConfigFlags flags, ref uint pathArrayElements,
            [Out] DisplayConfigPathInfo[] pathInfoArray, ref uint modeInfoArrayElements,
            [Out] DisplayConfigModeInfo[] modeInfoArray, IntPtr currentTopologyId);

        [DllImport("user32")]
        public static extern Win32Status QueryDisplayConfig(QueryDeviceConfigFlags flags, ref uint pathArrayElements,
            [Out] DisplayConfigPathInfo[] pathInfoArray, ref uint modeInfoArrayElements,
            [Out] DisplayConfigModeInfo[] modeInfoArray, [Out] out DisplayConfigTopologyId currentTopologyId);

        [DllImport("user32")]
        public static extern Win32Status SetDisplayConfig([In] uint pathArrayElements,
            [In] DisplayConfigPathInfo[] pathInfoArray, [In] uint modeInfoArrayElements,
            [In] DisplayConfigModeInfo[] modeInfoArray, [In] SetDisplayConfigFlags flags);
    }

    internal enum Win32Status
    {
        Success = 0x0,
        ErrorInsufficientBuffer = 0x7A
    }

    [Flags]
    internal enum DisplayConfigPathInfoFlags : uint
    {
        None = 0,
        Active = 1,
        SupportVirtualMode = 8
    }

    //https://github.com/falahati/WindowsDisplayAPI/blob/master/WindowsDisplayAPI/DisplayDevice.cs
}
