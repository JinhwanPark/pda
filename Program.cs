using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace DYPI_WMS_PDA
{
      static class Program
      {
          //multilanguage 
            public static MultLanguage multlanguage = new MultLanguage(MultLanguage.ContryType.USA);


            [DllImport("coredll.dll", EntryPoint = "CreateMutex", SetLastError = true)]
            public static extern IntPtr CreateMutex(IntPtr IpMutexAttributes, bool InitialOwner, string MutexName);

            [DllImport("coredll.dll", EntryPoint = "ReleaseMutex", SetLastError = true)]
            public static extern bool ReleaseMutex(IntPtr hMutex);

            public const Int32 NATIVE_ERROR_ALREADY_EXISTS = 183;

            public static bool IsInstanceRunning()
            {
                  IntPtr hMutex = CreateMutex(IntPtr.Zero, true, "DYPI_WMS_PDA");
                  if (hMutex == IntPtr.Zero)
                        throw new ApplicationException("Failure creating mutex: " + Marshal.GetLastWin32Error().ToString("X"));

                  if (Marshal.GetLastWin32Error() == NATIVE_ERROR_ALREADY_EXISTS)
                        return true;
                  else
                        return false;
            }
      

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다. 
        /// </summary>
        [MTAThread]
            static void Main()
            {
                  if (IsInstanceRunning())
                  {
                        //MessageBox.Show("프로그램이 이미 실행중입니다.");
                        Program.multlanguage.GetLanguage(Program.multlanguage.GetLanguage("Program is running."));
                        return;
                  }

                  try
                  {
                        Application.Run(new W_PD1S00());
                  }
                  catch(Exception ex)
                  {
                      //MessageBox.Show("프로그램이 이미 실행중입니다.");
                      MessageBox.Show(ex.ToString());
                      Program.multlanguage.GetLanguage(Program.multlanguage.GetLanguage("Program is running."));
                  }
            }
    }
}