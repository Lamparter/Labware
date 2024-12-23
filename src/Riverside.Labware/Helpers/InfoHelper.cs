using System;
using Windows.System.Profile;

namespace Riverside.Labware.Helpers
{
    public static class InfoHelper
    {
        public static Version SystemVersion { get; }

        static InfoHelper()
        {
            string systemVersion = AnalyticsInfo.VersionInfo.DeviceFamilyVersion;
            ulong version = ulong.Parse(systemVersion);
            SystemVersion = new Version((int)((version & 0xFFFF000000000000L) >> 48), (int)((version & 0x0000FFFF00000000L) >> 32), (int)((version & 0x00000000FFFF0000L) >> 16), (int)(version & 0x000000000000FFFFL));
        }
    }
}