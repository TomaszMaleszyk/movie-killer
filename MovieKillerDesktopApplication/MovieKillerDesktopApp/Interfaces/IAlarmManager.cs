namespace MovieKillerDesktopApp.Interfaces
{
    public interface IAlarmManager
    {
        void StartToMakeNoise();
        void TestAlarmSound();
        void KillAlarmClock();
        void ChooseAlarmSound(string alarmSound);
        void ChooseAlarmSound(KindOfAlarmSound alarmSound);
    }
    public enum KindOfAlarmSound
    {
        Alarm1,
        Alarm2,
        Alarm3,
        Alarm4,
        Alarm5
    }
}
