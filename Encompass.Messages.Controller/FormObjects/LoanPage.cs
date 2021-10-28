using Encompass.Messages.Controller.CustomControls;
using System.Linq;
using System.Windows.Forms;

namespace Encompass.Messages.Controller.FormObjects
{
    class LoanPage : HookedForm
    {
        const string PARENT_CONTROL_NAME = "RightPanel";

        public LoanPage(Form form) : base(form) { }

        public void AddControls(MessageCenter messageCenter)
        {
            Control[] controls = _form.Controls.Find(PARENT_CONTROL_NAME, true);
            if (controls != null && controls.Count() > 0)
            {
                // get the work panel
                Panel workPanel = (Panel)controls[0];

                // create the splitter
                Splitter splitter = new Splitter();
                workPanel.Controls.Add(splitter);
                splitter.Dock = DockStyle.Right;

                // add message center
                workPanel.Controls.Add(messageCenter);
                messageCenter.Dock = DockStyle.Right;
                messageCenter.Refresh();
            }
        }
    }
}
