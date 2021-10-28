namespace Encompass.Messages.Config
{
    partial class formConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTriggerField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonBackbround = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboDisplay = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textValue = new System.Windows.Forms.TextBox();
            this.backgroundValue = new System.Windows.Forms.TextBox();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDismiss = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboMessageType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textMessageId = new System.Windows.Forms.TextBox();
            this.textTitleText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textLink = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textMessageText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textXmlOutput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textTriggerField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonText);
            this.groupBox1.Controls.Add(this.buttonBackbround);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.textTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.comboDisplay);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.textValue);
            this.groupBox1.Controls.Add(this.backgroundValue);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messages Config File";
            // 
            // textTriggerField
            // 
            this.textTriggerField.Enabled = false;
            this.textTriggerField.Location = new System.Drawing.Point(12, 124);
            this.textTriggerField.Name = "textTriggerField";
            this.textTriggerField.Size = new System.Drawing.Size(216, 20);
            this.textTriggerField.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Trigger Field Name:";
            // 
            // buttonText
            // 
            this.buttonText.Enabled = false;
            this.buttonText.Location = new System.Drawing.Point(12, 348);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(104, 23);
            this.buttonText.TabIndex = 9;
            this.buttonText.Text = "Text Color:";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonBackbround
            // 
            this.buttonBackbround.Enabled = false;
            this.buttonBackbround.Location = new System.Drawing.Point(12, 320);
            this.buttonBackbround.Name = "buttonBackbround";
            this.buttonBackbround.Size = new System.Drawing.Size(104, 23);
            this.buttonBackbround.TabIndex = 8;
            this.buttonBackbround.Text = "Background Color:";
            this.buttonBackbround.UseVisualStyleBackColor = true;
            this.buttonBackbround.Click += new System.EventHandler(this.buttonBackbround_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 24);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(144, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load Config File";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textTitle
            // 
            this.textTitle.Enabled = false;
            this.textTitle.Location = new System.Drawing.Point(12, 76);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(216, 20);
            this.textTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Message Center Title:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(84, 380);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(144, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update Config File";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboDisplay
            // 
            this.comboDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDisplay.Enabled = false;
            this.comboDisplay.FormattingEnabled = true;
            this.comboDisplay.Items.AddRange(new object[] {
            "Information",
            "Success / Pass",
            "Warning",
            "Failure / Error"});
            this.comboDisplay.Location = new System.Drawing.Point(12, 176);
            this.comboDisplay.Name = "comboDisplay";
            this.comboDisplay.Size = new System.Drawing.Size(152, 21);
            this.comboDisplay.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Message Type:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panelBackground);
            this.panel1.Location = new System.Drawing.Point(12, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 104);
            this.panel1.TabIndex = 31;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.panelBackground.Controls.Add(this.panelBody);
            this.panelBackground.Controls.Add(this.panelTitlebar);
            this.panelBackground.Location = new System.Drawing.Point(8, 8);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(200, 88);
            this.panelBackground.TabIndex = 31;
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelBody.Controls.Add(this.labelText);
            this.panelBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.panelBody.Location = new System.Drawing.Point(1, 24);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(198, 63);
            this.panelBody.TabIndex = 1;
            // 
            // labelText
            // 
            this.labelText.Location = new System.Drawing.Point(4, 4);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(188, 56);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "This is a sample message to check your color selections so you can see what it wo" +
    "uld look like in the Notification Center,";
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.Controls.Add(this.labelTitle);
            this.panelTitlebar.Controls.Add(this.pictureBox2);
            this.panelTitlebar.Controls.Add(this.icon);
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(200, 24);
            this.panelTitlebar.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(156, 24);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Sample Title Text";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(116, 348);
            this.textValue.Name = "textValue";
            this.textValue.ReadOnly = true;
            this.textValue.Size = new System.Drawing.Size(112, 20);
            this.textValue.TabIndex = 28;
            this.textValue.TabStop = false;
            // 
            // backgroundValue
            // 
            this.backgroundValue.Location = new System.Drawing.Point(116, 320);
            this.backgroundValue.Name = "backgroundValue";
            this.backgroundValue.ReadOnly = true;
            this.backgroundValue.Size = new System.Drawing.Size(112, 20);
            this.backgroundValue.TabIndex = 18;
            this.backgroundValue.TabStop = false;
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "information.png");
            this.iconList.Images.SetKeyName(1, "accept.png");
            this.iconList.Images.SetKeyName(2, "error.png");
            this.iconList.Images.SetKeyName(3, "exclamation.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textXmlOutput);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textMessageText);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textLink);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textTitleText);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textMessageId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboDismiss);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboMessageType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(260, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 416);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xml Message Builder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "be dismissed.";
            // 
            // comboDismiss
            // 
            this.comboDismiss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDismiss.FormattingEnabled = true;
            this.comboDismiss.Items.AddRange(new object[] {
            "cannot",
            "can"});
            this.comboDismiss.Location = new System.Drawing.Point(68, 56);
            this.comboDismiss.Name = "comboDismiss";
            this.comboDismiss.Size = new System.Drawing.Size(56, 21);
            this.comboDismiss.TabIndex = 10;
            this.comboDismiss.SelectedIndexChanged += new System.EventHandler(this.MessageComboChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Message";
            // 
            // comboMessageType
            // 
            this.comboMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMessageType.FormattingEnabled = true;
            this.comboMessageType.Items.AddRange(new object[] {
            "Information",
            "Success / Pass",
            "Warning",
            "Failure / Error"});
            this.comboMessageType.Location = new System.Drawing.Point(96, 24);
            this.comboMessageType.Name = "comboMessageType";
            this.comboMessageType.Size = new System.Drawing.Size(152, 21);
            this.comboMessageType.TabIndex = 9;
            this.comboMessageType.SelectedIndexChanged += new System.EventHandler(this.MessageComboChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Message Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Messge ID:";
            // 
            // textMessageId
            // 
            this.textMessageId.Location = new System.Drawing.Point(324, 24);
            this.textMessageId.Name = "textMessageId";
            this.textMessageId.Size = new System.Drawing.Size(172, 20);
            this.textMessageId.TabIndex = 40;
            this.textMessageId.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // textTitleText
            // 
            this.textTitleText.Location = new System.Drawing.Point(324, 52);
            this.textTitleText.Name = "textTitleText";
            this.textTitleText.Size = new System.Drawing.Size(172, 20);
            this.textTitleText.TabIndex = 42;
            this.textTitleText.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Title Text:";
            // 
            // textLink
            // 
            this.textLink.Location = new System.Drawing.Point(324, 80);
            this.textLink.Name = "textLink";
            this.textLink.Size = new System.Drawing.Size(172, 20);
            this.textLink.TabIndex = 44;
            this.textLink.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Form Link:";
            // 
            // textMessageText
            // 
            this.textMessageText.Location = new System.Drawing.Point(12, 124);
            this.textMessageText.Multiline = true;
            this.textMessageText.Name = "textMessageText";
            this.textMessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMessageText.Size = new System.Drawing.Size(484, 124);
            this.textMessageText.TabIndex = 46;
            this.textMessageText.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Messge Text:";
            // 
            // textXmlOutput
            // 
            this.textXmlOutput.Location = new System.Drawing.Point(12, 276);
            this.textXmlOutput.Multiline = true;
            this.textXmlOutput.Name = "textXmlOutput";
            this.textXmlOutput.ReadOnly = true;
            this.textXmlOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textXmlOutput.Size = new System.Drawing.Size(484, 124);
            this.textXmlOutput.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Xml Message:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Encompass.Messages.Config.Properties.Resources.Close_NoHover;
            this.pictureBox2.Location = new System.Drawing.Point(180, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(20, 24);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // formConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formConfig";
            this.Text = "Encompass Messages Config Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelTitlebar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboDisplay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.TextBox backgroundValue;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonBackbround;
        private System.Windows.Forms.TextBox textTriggerField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDismiss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboMessageType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMessageId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMessageText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTitleText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textXmlOutput;
        private System.Windows.Forms.Label label10;
    }
}

