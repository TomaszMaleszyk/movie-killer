using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MovieKillerDesktopApp.Interfaces;

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
        private readonly IAlarmManager alarmManager;
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
        public OperationManager(IAlarmManager alarm)
        {
            alarmManager = alarm;
        }
        public void StartOperation(ChooseKindOfOperation kindOfOperation)
        {
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
                    alarmManager.StartToMakeNoise();
                    break;
                case ChooseKindOfOperation.StopAlarmClock:
                    alarmManager.KillAlarmClock();
                    break;
                case ChooseKindOfOperation.StopTimerFromDevice:
                    var principalForm = Application.OpenForms.OfType<MainWindow>().Single();
                    principalForm.IsTimerStoppedByDevice = true;
                    break;
                    //                case ChooseKindOfOperation.SetLevelOfSpeed:
                    //                    principalForm = Application.OpenForms.OfType<MainWindow>().Single();
                    //                    principalForm.levelOfSpeed 
                    //                    break;
            }
        }


    }
}
