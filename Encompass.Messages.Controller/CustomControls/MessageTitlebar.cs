using Encompass.Messages.MessageDetailObjects;
using System;
using System.Windows.Forms;

namespace Encompass.Messages.CustomControls
{
    public partial class MessageTitlebar : UserControl
    {
        public event EventHandler CloseClick;

        private const int CLOSE_NOHOVER_INDEX = 4;
        private const int CLOSE_HOVER_INDEX = 5;

        public MessageTitlebar()
        {
            InitializeComponent();
        }

        public void SetMessageDetails(IMessageDetail details)
        {
            // set titlebar properties
            this.BackColor = details.TitleBarColor;
            labelTitleText.ForeColor = details.TitleBarTextColor;
            labelTitleText.Text = details.Title;
            icon.Image = iconList.Images[(int)details.Display];

            // check to see if we need to hide the close button
            // if the can dismiss is false a message id must be suplied
            // so the message can be dismissed programatically.
            if (!details.CanDismiss && !string.IsNullOrEmpty(details.Id))
                buttonClose.Visible = false;
            else
            {
                // set the default close button image
                buttonClose.Image = iconList.Images[CLOSE_NOHOVER_INDEX];
                // create titebar events
                buttonClose.MouseEnter += ButtonClose_MouseEnter;
                buttonClose.MouseLeave += ButtonClose_MouseLeave;
                buttonClose.Click += ButtonClose_Click;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
            => CloseClick?.Invoke(this, new EventArgs());
        private void ButtonClose_MouseLeave(object sender, EventArgs e)
            => buttonClose.Image = iconList.Images[CLOSE_NOHOVER_INDEX];
        private void ButtonClose_MouseEnter(object sender, EventArgs e)
            => buttonClose.Image = iconList.Images[CLOSE_HOVER_INDEX];
    }
}
