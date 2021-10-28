using System.Windows.Forms;

namespace Encompass.Messages.Controller.FormObjects
{
    abstract class HookedForm
    {
        protected Form _form = null;

        public HookedForm(Form form)
            => _form = form;
    }
}
