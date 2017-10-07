using System.Media;

namespace MovieKillerDesktopApp.Models
{
    public class AlarmClockManager
    {
        private SoundPlayer soundPlayer;
        public enum KindOfAlarmSound
        {
            Alarm1,
            Alarm2,
            Alarm3,
            Alarm4,
            Alarm5
        }
        public AlarmClockManager()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.Alarm1);
        }
        public void StartToMakeNoise()
        {
            soundPlayer.PlayLooping();
        }
        public void TestAlarmSound()
        {
            soundPlayer.Play();
        }
        public void KillAlarmClock()
        {
            soundPlayer.Stop();
            var resourceFolderPath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources");
            soundPlayer.SoundLocation = resourceFolderPath + "//Silence.wav";
        }
        public void ChooseAlarmSound(string alarmSound)
        {
            soundPlayer.SoundLocation = alarmSound;
        }
        public void ChooseAlarmSound(KindOfAlarmSound alarmSound)
        {
            var resourceFolderPath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources");

            switch(alarmSound)
            {
                case KindOfAlarmSound.Alarm1:
                    soundPlayer.SoundLocation = resourceFolderPath + "//Alarm1.wav";
                    break;
                case KindOfAlarmSound.Alarm2:
                    soundPlayer.SoundLocation = resourceFolderPath + "//Alarm2.wav";
                    break;
                case KindOfAlarmSound.Alarm3:
                    soundPlayer.SoundLocation = resourceFolderPath + "//Alarm3.wav";
                    break;
                case KindOfAlarmSound.Alarm4:
                    soundPlayer.SoundLocation = resourceFolderPath + "//Alarm4.wav";
                    break;
                case KindOfAlarmSound.Alarm5:
                    soundPlayer.SoundLocation = resourceFolderPath + "//Alarm5.wav";
                    break;
            }
        }
    }
}
