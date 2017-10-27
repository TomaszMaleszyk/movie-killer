using System.Drawing;
using System.Windows.Forms;

namespace MovieKillerDesktopApp
{
    public partial class UserControlClockDisplayer : UserControl
    {
        public string ExpectedTimeOfEndOperation
        {
            get
            {
                return lb_endOfOperation.Text;
            }
            set
            {
                lb_endOfOperation.Text = value;
            }
        }
        public string TimeToEndOperation
        {
            get
            {
                return lb_timer.Text;
            }
            set
            {
                lb_timer.Text = value;
            }
        }
        public Color SetPanelClockBackColor { set { panel_clock.BackColor = value; } }
        public Color SetLbTimerBackColor { set { lb_timer.BackColor = value; } }
        public Color SetEndOfOperationBackColor { set { lb_endOfOperation.BackColor = value; } }
        public Color SetLbTimerForeColor { set { lb_timer.ForeColor = value; } }
        public Color SetEndOfOperationForeColor { set { lb_endOfOperation.ForeColor = value; } }

        public UserControlClockDisplayer()
        {
            InitializeComponent();
        }
    }
}
