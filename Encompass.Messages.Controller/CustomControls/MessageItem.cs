using EllieMae.Encompass.Automation;
using Encompass.Messages.MessageDetailObjects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Encompass.Messages.Controller.CustomControls
{
    public partial class MessageItem : UserControl
    {
        public event EventHandler CloseClick;
        public event EventHandler LinkClick;

        private const int BODY_TEXT_OFFSET = 16;

        public IMessageDetail MessageDetails { get; private set; }

        public MessageItem()
        {
            InitializeComponent();
        }

        public void SetMessageDetails(IMessageDetail details)
        {
            MessageDetails = details;

            // set titlebar details
            titlebar.SetMessageDetails(details);
            // setup title bar event
            titlebar.CloseClick += Titlebar_CloseClick;

            // if no id was supplied, ensure the message item has a unique name
            this.Name = (string.IsNullOrEmpty(details.Id) ? Guid.NewGuid().ToString() : details.Id);
            // set properties
            this.BackColor = details.BackgroundColor;
            labelBodyText.ForeColor = details.TextColor;
            // set the message text
            labelBodyText.AutoSize = true;
            labelBodyText.Text = details.Text;
            if (!string.IsNullOrEmpty(details.Link))
            {
                labelBodyText.Text += Environment.NewLine + Environment.NewLine;
                labelBodyText.Text += "(click to open linked form)";
                labelBodyText.Cursor = Cursors.Hand;
                // setup link click event
                labelBodyText.Click += LabelBodyText_Click;
            }
            SetControlSize();

            // setup events
            this.Resize += MessageItem_Resize;
            this.Paint += MessageItem_Paint;
        }

        private void LabelBodyText_Click(object sender, EventArgs e)
            => LinkClick?.Invoke(this, new EventArgs());
        private void Titlebar_CloseClick(object sender, EventArgs e)
            => CloseClick?.Invoke(this, new EventArgs());
        private void MessageItem_Resize(object sender, EventArgs e)
        {
            SetControlSize();
        }
        private void MessageItem_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, MessageDetails.TitleBarColor, ButtonBorderStyle.Solid);
        }

        private void SetControlSize()
        {
            labelBodyText.MaximumSize = new Size(this.Width - BODY_TEXT_OFFSET, 0);
            this.Height = titlebar.Height + labelBodyText.Height + BODY_TEXT_OFFSET + 1;
            this.Invalidate();
        }
    }
}
