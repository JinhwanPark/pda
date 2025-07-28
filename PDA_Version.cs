using System;
using System.Collections.Generic;
using System.Text;

namespace DYPI_WMS_PDA
{
    class PDA_Version
    {
        static string strVersion = "2025.0714";

        public static string strPDAVersion
        {
            get { return strVersion; }
            set
            {
                strVersion = value;
            }
        }
    }
}