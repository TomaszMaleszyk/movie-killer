using System.Drawing;

namespace MovieKillerDesktopApp.Models
{
    public class LayoutColorManager
    {
        public Color WindowBackgroundColor { get; set; }
        public Color PanelClockBackgroundColor { get; set; }
        public Color PanelOptionsBackgroundColor { get; set; }
        public Color LabelClockBackgroundColor { get; set; }
        public Color LabelClockForegroundColor { get; set; }
        public Color LabelOptionsBackgroundColor { get; set; }
        public Color LabelOptionsForegroundColor { get; set; }
        public enum KindOfLayoutTemplate
        {
            Template1,
            Template2,
            Template3,
            Template4,
            Template5,
            Template6
        }

        public LayoutColorManager()
        {
            SetDefaultColor();
        }
        public void SetDefaultColor()
        {
            SetColorOfWindowBackground(Color.PaleTurquoise);
            SetColorOfPanelBackground(Color.MediumBlue, Color.MediumPurple);
            SetColorOfLabelBackground(Color.DeepSkyBlue, Color.DarkMagenta);
            SetColorOfLabelForeground(Color.Black, Color.Thistle);
        }

        private void SetColorOfWindowBackground(Color color)
        {
            WindowBackgroundColor = color;
        }
        private void SetColorOfPanelBackground(Color colorClock, Color colorOptions)
        {
            PanelClockBackgroundColor = colorClock;
            PanelOptionsBackgroundColor = colorOptions;
        }
        private void SetColorOfLabelBackground(Color colorClock, Color colorOptions)
        {
            LabelClockBackgroundColor = colorClock;
            LabelOptionsBackgroundColor = colorOptions;
        }
        private void SetColorOfLabelForeground(Color colorClock, Color colorOptions)
        {
            LabelClockForegroundColor = colorClock;
            LabelOptionsForegroundColor = colorOptions;
        }

        public void SetColorFromTemplate(KindOfLayoutTemplate kindOfLayoutTemplate)
        {
            switch(kindOfLayoutTemplate)
            {
                case KindOfLayoutTemplate.Template1:
                    SetColorOfWindowBackground(Color.DodgerBlue);
                    SetColorOfPanelBackground(Color.FromArgb(110, 71, 127), Color.FromArgb(34, 112, 158));
                    SetColorOfLabelBackground(Color.DodgerBlue, Color.FromArgb(56, 133, 153));
                    SetColorOfLabelForeground(Color.Goldenrod, Color.AliceBlue);
                    break;
                case KindOfLayoutTemplate.Template2:
                    SetColorOfWindowBackground(Color.Goldenrod);
                    SetColorOfPanelBackground(Color.Bisque, Color.Beige);
                    SetColorOfLabelBackground(Color.Khaki, Color.Beige);
                    SetColorOfLabelForeground(Color.Black, Color.DimGray);
                    break;
                case KindOfLayoutTemplate.Template3:
                    SetColorOfWindowBackground(Color.FromArgb(133, 213, 229));
                    SetColorOfPanelBackground(Color.White, Color.Beige);
                    SetColorOfLabelBackground(Color.FromArgb(209, 250, 255), Color.FromArgb(133, 166, 173));
                    SetColorOfLabelForeground(Color.FromArgb(90, 108, 112), Color.FromArgb(70, 77, 79));
                    break;
                case KindOfLayoutTemplate.Template4:
                    SetColorOfWindowBackground(Color.FromArgb(7, 153, 99));
                    SetColorOfPanelBackground(Color.FromArgb(10, 132, 65), Color.FromArgb(84, 40, 28));
                    SetColorOfLabelBackground(Color.FromArgb(20, 110, 50), Color.FromArgb(137, 66, 46));
                    SetColorOfLabelForeground(Color.Black, Color.FromArgb(84, 40, 28));
                    break;
                case KindOfLayoutTemplate.Template5:
                    SetColorOfWindowBackground(Color.FromArgb(35, 35, 34));
                    SetColorOfPanelBackground(Color.FromArgb(234, 91, 9), Color.FromArgb(234, 91, 9));
                    SetColorOfLabelBackground(Color.DarkRed, Color.DarkRed);
                    SetColorOfLabelForeground(Color.Yellow, Color.Yellow);
                    break;
                case KindOfLayoutTemplate.Template6:
                    SetDefaultColor();
                    break;
            }
        }


    }
}
