namespace SmileBase.Students
{
    partial class NewStudentForm
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStudentForm));
            this.contactControl1 = new SmileBase.Contacts.ContactControl();
            this.AddStudentButton = new SmileBase.DerivedControls.Button();
            this.AbortButton = new SmileBase.DerivedControls.Button();
            this.SuspendLayout();
            // 
            // contactControl1
            // 
            this.contactControl1.Location = new System.Drawing.Point(23, 24);
            this.contactControl1.Name = "contactControl1";
            this.contactControl1.Size = new System.Drawing.Size(327, 145);
            this.contactControl1.TabIndex = 0;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.Image = global::SmileBase.Properties.Resources.ok_32;
            appearance2.ImageHAlign = Infragistics.Win.HAlign.Right;
            this.AddStudentButton.Appearance = appearance2;
            this.AddStudentButton.ImageSize = new System.Drawing.Size(32, 32);
            this.AddStudentButton.Location = new System.Drawing.Point(366, 221);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(110, 41);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.Image = global::SmileBase.Properties.Resources.stop_32;
            appearance1.ImageHAlign = Infragistics.Win.HAlign.Right;
            this.AbortButton.Appearance = appearance1;
            this.AbortButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AbortButton.ImageSize = new System.Drawing.Size(32, 32);
            this.AbortButton.Location = new System.Drawing.Point(250, 221);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(110, 41);
            this.AbortButton.TabIndex = 2;
            this.AbortButton.Text = "Abort";
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // NewStudentForm
            // 
            this.AcceptButton = this.AddStudentButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AbortButton;
            this.ClientSize = new System.Drawing.Size(485, 269);
            this.ControlBox = false;
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.contactControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewStudentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewStudentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Contacts.ContactControl contactControl1;
        private SmileBase.DerivedControls.Button AddStudentButton;
        private DerivedControls.Button AbortButton;
    }
}