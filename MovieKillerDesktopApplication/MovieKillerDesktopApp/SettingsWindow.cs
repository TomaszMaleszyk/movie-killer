using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MovieKillerDesktopApp.Interfaces;
using MovieKillerDesktopApp.Models;

namespace MovieKillerDesktopApp
{
    public partial class SettingsWindow : Form
    {
        private readonly IAlarmManager alarmManager;
        private readonly LayoutColorManager colorManager;

        private bool soundOfAlarmFromResources;
        public SettingsWindow(LayoutColorManager colorManager, IAlarmManager alarmManager)
        {
            InitializeComponent();
            this.colorManager = colorManager;
            this.alarmManager = alarmManager;
            rb_setSound_App.Checked = true;
            soundOfAlarmFromResources = true;
            cb_collectionOfAvaibleSounds.SelectedIndex = 0;
            TopMost = true;
        }
        private void ColorChangeButtonClick(object sender, EventArgs e)
        {
            var colorChangeButton = sender as Button;

            if(colorChangeButton == null)
            {
                return;
            }

            var colorToAssign = SetColorToAssign();
            SetLayoutColor(colorChangeButton, colorToAssign);

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
        private void SetLayoutColor(Button button, Color elementOfLayoutColor)
        {
            switch(button.Name)
            {
                case "btn_changeColorOfWindowBackground":
                    button.BackColor = elementOfLayoutColor;
                    colorManager.WindowBackgroundColor = elementOfLayoutColor;
                    break;
                case "btn_changeColorOfPanelOptionsBackgroundColor":
                    button.BackColor = elementOfLayoutColor;
                    colorManager.PanelOptionsBackgroundColor = elementOfLayoutColor;
                    break;
                case "btn_changeColorOfPanelClockBackground":
                    button.BackColor = elementOfLayoutColor;
                    colorManager.PanelClockBackgroundColor = elementOfLayoutColor;
                    break;
                case "btn_changeColorOfLabelOptionsBackgroundColor":
                    button.BackColor = elementOfLayoutColor;
                    colorManager.LabelOptionsBackgroundColor = elementOfLayoutColor;
                    break;
                case "btn_changeColorOfLabelClockBackgroundColor":
                    button.BackColor = elementOfLayoutColor;
                    colorManager.LabelClockBackgroundColor = elementOfLayoutColor;
                    break;
                case "btn_changeColorOfLabelOptionsForegroundColor":
                    button.BackColor = elementOfLayoutColor;
                    colorManager.LabelOptionsForegroundColor = elementOfLayoutColor;
                    break;
                case "btn_changeColorOfLabelClockForegroundColor":
                    button.BackColor = elementOfLayoutColor;
                    colorManager.LabelClockForegroundColor = elementOfLayoutColor;
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
                        alarmManager.ChooseAlarmSound(KindOfAlarmSound.Alarm1);
                        break;
                    case "Alarm 2":
                        alarmManager.ChooseAlarmSound(KindOfAlarmSound.Alarm2);
                        break;
                    case "Alarm 3":
                        alarmManager.ChooseAlarmSound(KindOfAlarmSound.Alarm3);
                        break;
                    case "Alarm 4":
                        alarmManager.ChooseAlarmSound(KindOfAlarmSound.Alarm4);
                        break;
                    case "Alarm 5":
                        alarmManager.ChooseAlarmSound(KindOfAlarmSound.Alarm5);
                        break;
                }
            }
            alarmManager.TestAlarmSound();
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
            openFileDialog.Filter = @"wav files| *.wav| All files (*.*)|*.*";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                alarmManager.ChooseAlarmSound(openFileDialog.FileName);
            }
        }
        private void btn_stopTestingSound_Click(object sender, EventArgs e)
        {
            alarmManager.KillAlarmClock();
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
                principalForm.IsCheckingPasswordAvaible = true;
            }
            else
            {
                principalForm.IsCheckingPasswordAvaible = false;
            }
        }
        private void btn_settingsToDefault(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<MainWindow>().Single();
            var password = PermissionControlForm("Proszę podać hasło: ");

            if(principalForm.PasswordToOpenConnection == password)
            {
                colorManager.SetDefaultColor();
                principalForm.SetLayoutColor();
                alarmManager.ChooseAlarmSound(KindOfAlarmSound.Alarm1);
                principalForm.IsCheckingPasswordAvaible = true;
                Close();
            }
            else if(password != "CANCEL")
            {
                MessageBox.Show(@"Podano nieprawidłowe hasło");
            }
        }
        private static string PermissionControlForm(string message)
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
                Text = @"Zatwierdź",
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
                Text = @"Anuluj",
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
    }
}
