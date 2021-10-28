using Encompass.Messages.ConfigurationObjects;
using Encompass.Messages.Parsers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Encompass.Messages.Config
{
    public enum DisplayType
    {
        Information,
        Success,
        Warning,
        Failure
    }

    public partial class formConfig : Form
    {
        ApplicationSettings _configObject = new ApplicationSettings();
        string _configFilePath = string.Empty;

        public formConfig()
        {
            InitializeComponent();

            comboDisplay.SelectedIndexChanged += ComboDisplay_SelectedIndexChanged;
        }

        private void ComboDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            icon.Image = iconList.Images[comboDisplay.SelectedIndex];
            SetColorSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set to defaults
            comboDisplay.SelectedIndex = 0;
            comboMessageType.SelectedIndex = 0;
            comboDismiss.SelectedIndex = 1;
            XmlBuilder();
        }

        private void buttonBackbround_Click(object sender, EventArgs e)
        {
            OpenColorDialog(backgroundValue);
            panelBody.BackColor = GetColor(backgroundValue);
            UpdateColorSelection();
        }
        private void buttonText_Click(object sender, EventArgs e)
        {
            OpenColorDialog(textValue);
            panelBody.ForeColor = GetColor(textValue);
            UpdateColorSelection();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open json config file";
            dialog.Filter = "*.json | *.json";

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                _configFilePath = dialog.FileName;

                try
                {
                    string json = File.ReadAllText(_configFilePath);
                    _configObject = JsonParser.GetObjectFromJson<ApplicationSettings>(json);
                    SetConfigControls();
                }
                catch (Exception)
                {
                    string message = " An error was encountered trying to read the Json config file." + Environment.NewLine +
                        "Make sure you selected the MessageConfig.json file from the dialog window.";

                    MessageBox.Show(message, "Error Loading Json File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textTitle.Text.Length > 0 && textTriggerField.Text.Length > 0)
            {
                _configObject.HeaderTitle = textTitle.Text;
                _configObject.TriggerField = textTriggerField.Text;

                try
                {
                    string json = JsonParser.GetJsonFromObject(_configObject);
                    File.WriteAllText(_configFilePath, json);
                }
                catch(Exception)
                {
                    string message = " An error was encountered trying to write to the Json config file." + Environment.NewLine +
                        "Make sure the file is not open in another application.";

                    MessageBox.Show(message, "Error Writing Json File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("The title and trigger fields are required.", "Unable to save configuration changes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OpenColorDialog(TextBox textbox)
        {
            ColorDialog dialog = new ColorDialog() { FullOpen = true };

            dialog.Color = GetColor(textbox);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                textbox.Text = dialog.Color.ToArgb().ToString();
            }
        }

        private void SetConfigControls()
        {
            textTitle.Text = _configObject.HeaderTitle;
            textTitle.Enabled = true;

            comboDisplay.Enabled = true;

            buttonBackbround.Enabled = true;
            buttonText.Enabled = true;

            textTriggerField.Text = _configObject.TriggerField;
            textTriggerField.Enabled = true;

            SetColorSelection();
        }

        private void SetColorSelection()
        {
            if (_configObject.MessageColors != null)
            {
                ColorDetails colors = _configObject.MessageColors.Find(f => f.Key == comboDisplay.SelectedIndex);

                if (colors != null)
                {
                    panelBackground.BackColor = Color.FromArgb(colors.TitleColor);
                    labelTitle.ForeColor = Color.FromArgb(colors.TitleTextColor);
                    panelBody.BackColor = Color.FromArgb(colors.BackColor);
                    panelBody.ForeColor = Color.FromArgb(colors.TextColor);

                    backgroundValue.Text = colors.BackColor.ToString();
                    textValue.Text = colors.TextColor.ToString();
                }
            }
        }
        private void UpdateColorSelection()
        {
            if (_configObject.MessageColors != null)
            {
                ColorDetails colors = _configObject.MessageColors.Find(f => f.Key == comboDisplay.SelectedIndex);

                if (colors != null)
                {
                    colors.BackColor = panelBody.BackColor.ToArgb();
                    colors.TextColor = panelBody.ForeColor.ToArgb();
                    colors.TitleColor = panelBackground.BackColor.ToArgb();
                    colors.TitleTextColor = labelTitle.ForeColor.ToArgb();
                }
            }
        }
        private Color GetColor(TextBox textbox)
        {
            int colorInt = 0;
            if (textbox.Text.Length > 0)
                colorInt = Convert.ToInt32(textbox.Text);

            return Color.FromArgb(colorInt);
        }

        private void MessageComboChanged(object sender, EventArgs e)
        {
            XmlBuilder();
        }
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            XmlBuilder();
        }
        private void XmlBuilder()
        {
            string xml = "<message";

            xml += $" id='{textMessageId.Text}' action='1' dismiss='{comboDismiss.SelectedIndex}' display='{comboMessageType.SelectedIndex}'";
            xml += $" title='{textTitleText.Text}' link='{textLink.Text}'>";
            xml += textMessageText.Text;
            xml += "</message>";

            textXmlOutput.Text = xml;
        }
    }
}
