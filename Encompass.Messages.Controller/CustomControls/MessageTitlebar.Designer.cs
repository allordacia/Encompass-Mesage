namespace Encompass.Messages.CustomControls
{
    partial class MessageTitlebar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageTitlebar));
            this.icon = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.labelTitleText = new System.Windows.Forms.Label();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(20, 24);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Location = new System.Drawing.Point(130, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 24);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            // 
            // labelTitleText
            // 
            this.labelTitleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleText.Location = new System.Drawing.Point(20, 0);
            this.labelTitleText.Name = "labelTitleText";
            this.labelTitleText.Size = new System.Drawing.Size(110, 24);
            this.labelTitleText.TabIndex = 2;
            this.labelTitleText.Text = "label1";
            this.labelTitleText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "information.png");
            this.iconList.Images.SetKeyName(1, "accept.png");
            this.iconList.Images.SetKeyName(2, "error.png");
            this.iconList.Images.SetKeyName(3, "exclamation.png");
            this.iconList.Images.SetKeyName(4, "Close_NoHover.png");
            this.iconList.Images.SetKeyName(5, "Close_Hover.png");
            // 
            // MessageTitlebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTitleText);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.icon);
            this.Name = "MessageTitlebar";
            this.Size = new System.Drawing.Size(150, 24);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox buttonClose;
        private System.Windows.Forms.Label labelTitleText;
        private System.Windows.Forms.ImageList iconList;
    }
}
