using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Encompass.Messages.Controller.FormObjects
{
    public delegate void FormOpenedHandler(object sender, FormOpenedEventArgs e);
    public class FormOpenedEventArgs : EventArgs
    {
        private Form _form;

        public Form OpenedForm
        {
            get { return _form; }
            set { _form = value; }
        }
        public FormOpenedEventArgs(Form form)
        {
            _form = form;
        }
        public FormOpenedEventArgs() { }
    }

    public static class FormHook
    {
        public static event FormOpenedHandler FormOpened;

        static Dictionary<Form, IntPtr> _openFormList;
        static System.Timers.Timer _checkOpenFormsTimer = null;

        static List<string> _captureFormList = new List<string>();
        public static List<string> CaptureFormList
        {
            get { return _captureFormList; }
            set { _captureFormList = value; }
        }

        static FormHook()
        {
            // create our list of open forms object.
            // we compare this to the Application.OpenForms
            // to catch new forms being opened.
            _openFormList = new Dictionary<Form, IntPtr>();
            // wire up to the deactivate event of the main encompass form.
            // this will help capture new forms as they are opened.
            Application.OpenForms[0].Deactivate += FormHook_Deactivate;
            // set up the timer, this will check if any new forms were added to the OpenForms
            // object.
            _checkOpenFormsTimer = new System.Timers.Timer(300);
            _checkOpenFormsTimer.Elapsed += _checkOpenFormsTimer_Elapsed;
            _checkOpenFormsTimer.AutoReset = false;
            _checkOpenFormsTimer.SynchronizingObject = Application.OpenForms[0];
            _checkOpenFormsTimer.Enabled = true;
            // this is the main workhorse of the object, its job is to catch when 
            // new forms are opened and to raise the Form Opened Event.
            CheckForNewForms();
        }

        private static void FormHook_Deactivate(object sender, EventArgs e)
        {
            CheckForNewForms();
        }
        private static void _checkOpenFormsTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckForNewForms();
            CleanupOpenFormsList();
            _checkOpenFormsTimer.Enabled = true;
        }
        private static void CleanupOpenFormsList()
        {
            if (_openFormList != null)
            {
                List<KeyValuePair<Form, IntPtr>> openedForms = _openFormList.Where(w => w.Key == null || w.Key.IsDisposed).ToList();
                foreach (var formEntry in openedForms)
                    _openFormList.Remove(formEntry.Key);
            }
        }
        private static void CheckForNewForms()
        {
            // make sure the open forms and form list objects exist
            if (Application.OpenForms != null && _openFormList != null)
            {
                // loop through the open forms.
                foreach (Form form in Application.OpenForms)
                {
                    // if a new form is found add it to the open forms list
                    if (form != null && !form.IsDisposed)
                    {
                        // check to see if the form is in our to watch for list
                        if (_captureFormList.Contains(form.Name))
                        {
                            if (!_openFormList.Keys.Contains(form))
                            {
                                // subscribe to the closing event so we can remove closed loans
                                form.FormClosing += form_FormClosing;
                                _openFormList.Add(form, form.Handle);
                                // raise the event that one of the forms we are watching for has been opened.
                                FormOpenedEventArgs eventArgs = new FormOpenedEventArgs(form);
                                if (FormOpened != null)
                                    FormOpened.Invoke(null, eventArgs);
                            }
                        }
                    }
                }
            }
        }
        private static void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // one of our forms is closing we need to remove it from our
            // open form list
            if (sender != null)
            {
                Form form = (Form)sender;
                if (form != null && _openFormList.Keys.Contains(form))
                    _openFormList.Remove(form);
                // unsubscribe from the closing event.
                form.FormClosing -= form_FormClosing;
            }
        }
    }
}
