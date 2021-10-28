namespace Encompass.Messages.Controller.CustomControls
{
    partial class MessageItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlebar = new Encompass.Messages.CustomControls.MessageTitlebar();
            this.labelBodyText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(148, 24);
            this.titlebar.TabIndex = 0;
            // 
            // labelBodyText
            // 
            this.labelBodyText.AutoSize = true;
            this.labelBodyText.Location = new System.Drawing.Point(8, 32);
            this.labelBodyText.Name = "labelBodyText";
            this.labelBodyText.Size = new System.Drawing.Size(35, 13);
            this.labelBodyText.TabIndex = 2;
            this.labelBodyText.Text = "label1";
            // 
            // MessageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelBodyText);
            this.Controls.Add(this.titlebar);
            this.Name = "MessageItem";
            this.Size = new System.Drawing.Size(148, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Messages.CustomControls.MessageTitlebar titlebar;
        private System.Windows.Forms.Label labelBodyText;
    }
}
