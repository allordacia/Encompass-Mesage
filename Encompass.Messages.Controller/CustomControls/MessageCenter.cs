using EllieMae.Encompass.Automation;
using Encompass.Messages.ConfigurationObjects;
using Encompass.Messages.MessageDetailObjects;
using Encompass.Messages.Parsers;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Encompass.Messages.Controller.CustomControls
{
    public partial class MessageCenter : UserControl
    {
        private const int SCROLL_OFFSET = 25;
        private static UserSettings _userSettings = null;
        private bool soundPlayed = false;

        public List<ColorDetails> Colors
        {
            set => XmlMessageParser.SetColorDetails(value);
        }

        public MessageCenter()
        {
            InitializeComponent();

            // set resize event
            this.Resize += MessageCenter_Resize;
            // message center default is visible = false
            // if there are no messages to be displayed on open
            // it is already hidden.
            this.Visible = false;
        }

        // clear the list box when a new loan is opened
        // so only that loans messages are shown.
        public void ClearList()
        {
            listBox.Controls.Clear();
            this.Visible = false;
        }
        // convert the passed in xml string into a 
        // message item that is added/removed 
        public void ProcessMessages(string xmlMessages)
        {
            soundPlayed = false;

            var messages = XmlMessageParser.GetObjectFromXml(xmlMessages);
            foreach (var message in messages)
                ParseMessageItem(message);
        }
        // convert the open messages to an XML string 
        // to be stored in the loans CDO
        public string GetMessageList()
        {
            string messagesXml = "<messages>" + Environment.NewLine;

            foreach (Control control in listBox.Controls)
            {
                if (control.GetType() == typeof(MessageItem))
                    messagesXml += XmlMessageParser.GetXmlFromObject(((MessageItem)control).MessageDetails) + Environment.NewLine;
            }

            messagesXml += "</messages>";

            return messagesXml;
        }

        private void ParseMessageItem(IMessageDetail message)
        {
            if (message.Action == ActionType.Add)
                AddMessageItem(message);
            else
                RemoveMessageItem((MessageItem)listBox.Controls[message.Id]);
        }
        private void AddMessageItem(IMessageDetail message)
        {
            if (!listBox.Controls.ContainsKey(message.Id))
            {
                if (!this.Visible)
                    this.Visible = true;

                MessageItem item = new MessageItem();
                item.Name = message.Id;
                item.CloseClick += Item_CloseClick;
                item.LinkClick += Item_LinkClick;
                listBox.Controls.Add(item);
                // adds new message item to the top of the list
                listBox.Controls.SetChildIndex(item, 0);
                item.Width = listBox.Width - SCROLL_OFFSET;
                item.SetMessageDetails(message);
                item.Show();

                PlaySound();
            }
        }
        private void RemoveMessageItem(MessageItem item)
        {
            if (item != null)
                listBox.Controls.Remove(item);

            // if there are no messages to be displayed, hide the message center
            this.Visible = listBox.Controls.Count > 0;
        }

        private void MessageCenter_Resize(object sender, EventArgs e)
        {
            // set the user setting
            if (_userSettings != null)
                _userSettings.MessageCenterWidth = this.Width;

            // resize all of the message items to the new width.
            foreach (Control control in listBox.Controls)
            {
                if (control.GetType() == typeof(MessageItem))
                    control.Width = listBox.Width - SCROLL_OFFSET;
            }
        }
        private void Item_LinkClick(object sender, EventArgs e)
        {
            var item = (MessageItem)sender;
            if (!string.IsNullOrEmpty(item.MessageDetails.Link))
                Macro.GoToForm(item.MessageDetails.Link);
        }
        private void Item_CloseClick(object sender, EventArgs e)
            => RemoveMessageItem((MessageItem)sender);
        private void PlaySound()
        {
            if(!soundPlayed)
                SystemSounds.Beep.Play();

            soundPlayed = true;
        }
        public static MessageCenter CreateMessageCenter(ApplicationSettings applicationSettings, UserSettings userSettings)
        {
            _userSettings = userSettings;

            MessageCenter messageCenter = new MessageCenter();
            messageCenter.Width = _userSettings.MessageCenterWidth;
            messageCenter.labelTitle.Text = applicationSettings.HeaderTitle;
            messageCenter.Colors = applicationSettings.MessageColors;

            return messageCenter;
        }
    }
}
