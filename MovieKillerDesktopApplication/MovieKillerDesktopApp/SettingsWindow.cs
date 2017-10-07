using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MovieKillerDesktopApp.Models;

namespace MovieKillerDesktopApp
{
    public partial class SettingsWindow : Form
    {
        private AlarmClockManager alarmClockManager;
        private LayoutColorManager colorManager;

        private bool soundOfAlarmFromResources;
        public SettingsWindow(LayoutColorManager colorManager, AlarmClockManager alarmClockManager)
        {
            InitializeComponent();
            this.colorManager = colorManager;
            this.alarmClockManager = alarmClockManager;
            rb_setSound_App.Checked = true;
            soundOfAlarmFromResources = true;
            cb_collectionOfAvaibleSounds.SelectedIndex = 0;
            this.TopMost = true;
        }
        private void ColorChangeButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;

            if(button == null)
            {
                return;
            }

            var color = SetColorToAssign();
            SetLayoutColor(button, color);

            var principalForm = Application.OpenForms.OfType<MainWindow>().Single();
            principalForm.SetLayoutColor();
        }
        private Color SetColorToAssign()
        {
            var color = new Color();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
            return color;
        }
        private void SetLayoutColor(Button button, Color color)
        {
            switch(button.Name)
            {
                case "btn_changeColorOfWindowBackground":
                    button.BackColor = color;
                    colorManager.WindowBackgroundColor = color;
                    break;
                case "btn_changeColorOfPanelOptionsBackgroundColor":
                    button.BackColor = color;
                    colorManager.PanelOptionsBackgroundColor = color;
                    break;
                case "btn_changeColorOfPanelClockBackground":
                    button.BackColor = color;
                    colorManager.PanelClockBackgroundColor = color;
                    break;
                case "btn_changeColorOfLabelOptionsBackgroundColor":
                    button.BackColor = color;
                    colorManager.LabelOptionsBackgroundColor = color;
                    break;
                case "btn_changeColorOfLabelClockBackgroundColor":
                    button.BackColor = color;
                    colorManager.LabelClockBackgroundColor = color;
                    break;
                case "btn_changeColorOfLabelOptionsForegroundColor":
                    button.BackColor = color;
                    colorManager.LabelOptionsForegroundColor = color;
                    break;
                case "btn_changeColorOfLabelClockForegroundColor":
                    button.BackColor = color;
                    colorManager.LabelClockForegroundColor = color;
                    break;
            }
        }
        private void cb_setTemplateOfColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var template = new LayoutColorManager.KindOfLayoutTemplate();
            var styleOftemplate = cb_setTemplateOfColor.SelectedItem.ToString();
            switch(styleOftemplate)
            {
                case "Szablon1":
                    template = LayoutColorManager.KindOfLayoutTemplate.Template1;
                    break;
                case "Szablon2":
                    template = LayoutColorManager.KindOfLayoutTemplate.Template2;
                    break;
                case "Szablon3":
                    template = LayoutColorManager.KindOfLayoutTemplate.Template3;
                    break;
                case "Szablon4":
                    template = LayoutColorManager.KindOfLayoutTemplate.Template4;
                    break;
                case "Szablon5":
                    template = LayoutColorManager.KindOfLayoutTemplate.Template5;
                    break;
                case "Ustawienia domyślne":
                    template = LayoutColorManager.KindOfLayoutTemplate.Template6;
                    break;
            }
            colorManager.SetColorFromTemplate(template);

            var principalForm = Application.OpenForms.OfType<MainWindow>().Single();
            principalForm.SetLayoutColor();
        }
        private void btn_testSound_Click(object sender, EventArgs e)
        {
            if(soundOfAlarmFromResources)
            {
                switch(cb_collectionOfAvaibleSounds.SelectedItem.ToString())
                {
                    case "Alarm 1":
                        alarmClockManager.ChooseAlarmSound(AlarmClockManager.KindOfAlarmSound.Alarm1);
                        break;
                    case "Alarm 2":
                        alarmClockManager.ChooseAlarmSound(AlarmClockManager.KindOfAlarmSound.Alarm2);
                        break;
                    case "Alarm 3":
                        alarmClockManager.ChooseAlarmSound(AlarmClockManager.KindOfAlarmSound.Alarm3);
                        break;
                    case "Alarm 4":
                        alarmClockManager.ChooseAlarmSound(AlarmClockManager.KindOfAlarmSound.Alarm4);
                        break;
                    case "Alarm 5":
                        alarmClockManager.ChooseAlarmSound(AlarmClockManager.KindOfAlarmSound.Alarm5);
                        break;
                }
            }
            alarmClockManager.TestAlarmSound();
        }
        private void SetKindOfPathToAlarmSound(bool fromResources)
        {
            if(fromResources)
            {
                soundOfAlarmFromResources = true;
                cb_collectionOfAvaibleSounds.Enabled = true;
            }
            else
            {
                soundOfAlarmFromResources = false;
                cb_collectionOfAvaibleSounds.Enabled = false;
                SetPathToAlarmSound();
            }
        }
        private void SetPathToAlarmSound()
        {
            openFileDialog.FileName = "";
            openFileDialog.ShowReadOnly = true;
            openFileDialog.Filter = "wav files| *.wav| All files (*.*)|*.*";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                alarmClockManager.ChooseAlarmSound(openFileDialog.FileName);
            }
        }
        private void btn_stopTestingSound_Click(object sender, EventArgs e)
        {
            alarmClockManager.KillAlarmClock();
        }
        private void ManageRadioButtons(object sender, EventArgs e)
        {
            if(rb_setSound_App.Checked)
            {
                SetKindOfPathToAlarmSound(true);
            }
            if(rb_setSound_Custom.Checked)
            {
                SetKindOfPathToAlarmSound(false);
            }
        }
        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            new ChangePasswordWindow().Show();
        }

        private void cb_passwordInspection_CheckedChanged(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<MainWindow>().Single();
            var checkPassword = cb_passwordInspection.Checked;
            if(checkPassword)
            {
                principalForm.CheckingPasswordToConnect = true;
            }
            else
            {
                principalForm.CheckingPasswordToConnect = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {

        }
        private void btn_settingsToDefault(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<MainWindow>().Single();
            var password = PermissionControl("Proszę podać hasło: ");

            if(principalForm.PasswordToConnection == password)
            {
                colorManager.SetDefaultColor();
                principalForm.SetLayoutColor();
                alarmClockManager.ChooseAlarmSound(AlarmClockManager.KindOfAlarmSound.Alarm1);
                principalForm.CheckingPasswordToConnect = true;
                Close();
            }
            else if(password != "CANCEL")
            {
                MessageBox.Show("Podano nieprawidłowe hasło");
            }

        }
        private static string PermissionControl(string message)
        {
            var prompt = new Form
            {
                Width = 200,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                StartPosition = FormStartPosition.CenterScreen
            };
            var textLabel = new Label { Left = 20, Top = 20, Text = message };
            var textBox = new TextBox { Left = 20, Top = 50, Width = 150 };
            var confirm = new Button
            {
                Text = "Zatwierdź",
                Left = 20,
                Width = 70,
                Top = 80,
                DialogResult = DialogResult.OK
            };
            confirm.Click += (sender, e) =>
            {
                prompt.Close();
            };
            var cancel = new Button
            {
                Text = "Anuluj",
                Left = 90,
                Width = 70,
                Top = 80,
                DialogResult = DialogResult.Cancel
            };
            cancel.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirm);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirm;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "CANCEL";
        }


        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cb_collectionOfAvaibleSounds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
