using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MovieKillerDesktopApp.Models
{
    public class OperationManager
    {
        [DllImport("user32")]
        private static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        [DllImport("user32")]
        private static extern void LockWorkStation();
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        private AlarmClockManager alarmClockManager;
        public enum ChooseKindOfOperation
        {
            Shutdown,
            LogOut,
            Restart,
            Lock,
            Sleep,
            Alarm,
            StopAlarmClock,
            StopTimerFromDevice,
            SetLevelOfSpeed
        }
        public OperationManager(AlarmClockManager alarmClock)
        {
            alarmClockManager = alarmClock;
        }
        public void StartOperation(ChooseKindOfOperation kindOfOperation)
        {
            MainWindow principalForm;
            switch(kindOfOperation)
            {
                case ChooseKindOfOperation.Shutdown:
                    Process.Start("shutdown", "/s");
                    break;
                case ChooseKindOfOperation.Restart:
                    Process.Start("shutdown", "/r");
                    break;
                case ChooseKindOfOperation.LogOut:
                    ExitWindowsEx(0, 0);
                    break;
                case ChooseKindOfOperation.Lock:
                    LockWorkStation();
                    break;
                case ChooseKindOfOperation.Sleep:
                    SetSuspendState(false, true, true);
                    break;
                case ChooseKindOfOperation.Alarm:
                    alarmClockManager.StartToMakeNoise();
                    break;
                case ChooseKindOfOperation.StopAlarmClock:
                    alarmClockManager.KillAlarmClock();
                    break;
                case ChooseKindOfOperation.StopTimerFromDevice:
                    principalForm = Application.OpenForms.OfType<MainWindow>().Single();
                    principalForm.StopTimerFromDevice = true;
                    break;
//                case ChooseKindOfOperation.SetLevelOfSpeed:
//                    principalForm = Application.OpenForms.OfType<MainWindow>().Single();
//                    principalForm.levelOfSpeed 
//                    break;
            }
        }


    }
}
