﻿using System;

namespace PerMonitorDpi.Helper
{
    /// <summary>
    /// OS version information
    /// </summary>
    internal static class OsVersion
    {
        private static readonly Version ver = Environment.OSVersion.Version;

        /// <summary>
        /// Whether OS is Windows Vista or newer
        /// </summary>
        /// <remarks>Windows Vista = version 6.0</remarks>
        public static bool IsVistaOrNewer
        {
            get { return (6 <= ver.Major); }
        }

        /// <summary>
        /// Whether OS is Windows 8 or newer
        /// </summary>
        /// <remarks>Windows 8 = version 6.2</remarks>
        public static bool IsEightOrNewer
        {
            get { return ((6 == ver.Major) && (2 <= ver.Minor)) || (7 <= ver.Major); }
        }

        /// <summary>
        /// Whether OS is Windows 8.1 or newer
        /// </summary>
        /// <remarks>Windows 8.1 = version 6.3</remarks>
        public static bool IsEightOneOrNewer
        {
            get { return ((6 == ver.Major) && (3 <= ver.Minor)) || (7 <= ver.Major); }
        }
    }
}