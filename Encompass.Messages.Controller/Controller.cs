using EllieMae.Encompass.Automation;
using EllieMae.Encompass.ComponentModel;
using Encompass.Messages.ConfigurationObjects;
using Encompass.Messages.Controller.CustomControls;
using Encompass.Messages.Controller.FormObjects;
using System;

namespace Encompass.Messages.Controller
{
    [Plugin]
    public class Controller : IDisposable
    {
        ApplicationSettings _applicationSettings = null;
        UserSettings _userSettings = null;
        LoanPage _form = null;
        MessageCenter _messageCenter = null;

        const string LOAN_PAGE_FORM_NAME = "LoanPage";
        const string XML_MESSAGE_LIST = "Messages.xml";
        const string USER_SETTINGS_NAME = "UserSettings.json";
        const string APPLICATION_SETTINGS_NAME = "MessageConfig.json";

        public Controller()
        {
            // create the form opened event
            FormHook.FormOpened += FormHook_FormOpened;
            // add form to the form watch list
            FormHook.CaptureFormList.Add(LOAN_PAGE_FORM_NAME);

            // load the configuration settings
            LoadSettings();

            // create the message Center
            _messageCenter = MessageCenter.CreateMessageCenter(_applicationSettings, _userSettings);

            // create entry encompass events
            EncompassApplication.LoanOpened += EncompassApplication_LoanOpened;
            EncompassApplication.LoanClosing += EncompassApplication_LoanClosing;
            EncompassApplication.Logout += EncompassApplication_Logout;
        }
        public void Dispose()
        {
            _form = null;
            _messageCenter = null;
            _applicationSettings = null;
            _userSettings = null;
        }

        private void EncompassApplication_Logout(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void EncompassApplication_LoanOpened(object sender, EventArgs e)
        {
            // capture field change events to look for our message field being updated
            EncompassApplication.CurrentLoan.FieldChange += CurrentLoan_FieldChange;

            // load stored messages
            LoadMessages();
        }
        private void EncompassApplication_LoanClosing(object sender, EventArgs e)
        {
            // store open messages
            CustomDataObjectsAccess.PutStringData(XML_MESSAGE_LIST, EncompassApplication.CurrentLoan, _messageCenter.GetMessageList());
            _messageCenter.ClearList();

            // store the user settings back to the user cdo
            CustomDataObjectsAccess.PutJsonData<UserSettings>(USER_SETTINGS_NAME, EncompassApplication.CurrentUser, _userSettings);

            // unsubscribe from the field change event.
            EncompassApplication.CurrentLoan.FieldChange -= CurrentLoan_FieldChange;
        }
        private void CurrentLoan_FieldChange(object source, EllieMae.Encompass.BusinessObjects.Loans.FieldChangeEventArgs e)
        {
            if(e.FieldID == _applicationSettings.TriggerField.ToUpper())
            {
                // apply the new message
                _messageCenter.ProcessMessages(EncompassApplication.CurrentLoan.Fields[e.FieldID].ToString());
            }
        }

        private void FormHook_FormOpened(object sender, FormOpenedEventArgs e)
        {
            if (e.OpenedForm != null)
            {
                if (e.OpenedForm.Name == LOAN_PAGE_FORM_NAME)
                {
                    _form = new LoanPage(e.OpenedForm);
                    _form.AddControls(_messageCenter);
                }
            }
        }

        private void LoadSettings()
        {
            try
            {
                _applicationSettings = CustomDataObjectsAccess.GetJsonData<ApplicationSettings>(APPLICATION_SETTINGS_NAME, EncompassApplication.Session.DataExchange);
            }
            catch(Exception)
            {
                _applicationSettings = ApplicationSettings.CreateWithDefaults();
                CustomDataObjectsAccess.PutJsonData<ApplicationSettings>(APPLICATION_SETTINGS_NAME, EncompassApplication.Session.DataExchange, _applicationSettings);
            }

            try
            {
                _userSettings = CustomDataObjectsAccess.GetJsonData<UserSettings>(USER_SETTINGS_NAME, EncompassApplication.CurrentUser);
            }
            catch(Exception)
            {
                _userSettings = new UserSettings();
                CustomDataObjectsAccess.PutJsonData<UserSettings>(USER_SETTINGS_NAME, EncompassApplication.CurrentUser, _userSettings);
            }
        }
        private void LoadMessages()
        {
            try
            {
                _messageCenter.ProcessMessages(CustomDataObjectsAccess.GetStringData(XML_MESSAGE_LIST, EncompassApplication.CurrentLoan));
            }
            catch (Exception)
            { }
        }
    }
}
