namespace Arduino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputText = new System.Windows.Forms.TextBox();
            this.InputTextLabel = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.PortListLabel = new System.Windows.Forms.Label();
            this.PortSelected = new System.Windows.Forms.Label();
            this.ChangeFontBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DirectionList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(12, 40);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(100, 23);
            this.InputText.TabIndex = 0;
            // 
            // InputTextLabel
            // 
            this.InputTextLabel.AutoSize = true;
            this.InputTextLabel.Location = new System.Drawing.Point(12, 22);
            this.InputTextLabel.Name = "InputTextLabel";
            this.InputTextLabel.Size = new System.Drawing.Size(35, 15);
            this.InputTextLabel.TabIndex = 1;
            this.InputTextLabel.Text = "Input";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(118, 40);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 2;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // PortList
            // 
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(12, 98);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(100, 23);
            this.PortList.TabIndex = 3;
            this.PortList.SelectedIndexChanged += new System.EventHandler(this.PortList_SelectedIndexChanged);
            // 
            // PortListLabel
            // 
            this.PortListLabel.AutoSize = true;
            this.PortListLabel.Location = new System.Drawing.Point(12, 80);
            this.PortListLabel.Name = "PortListLabel";
            this.PortListLabel.Size = new System.Drawing.Size(32, 15);
            this.PortListLabel.TabIndex = 4;
            this.PortListLabel.Text = "Port:";
            // 
            // PortSelected
            // 
            this.PortSelected.AutoSize = true;
            this.PortSelected.Location = new System.Drawing.Point(52, 80);
            this.PortSelected.Name = "PortSelected";
            this.PortSelected.Size = new System.Drawing.Size(35, 15);
            this.PortSelected.TabIndex = 5;
            this.PortSelected.Text = "COM";
            // 
            // ChangeFontBtn
            // 
            this.ChangeFontBtn.Location = new System.Drawing.Point(12, 127);
            this.ChangeFontBtn.Name = "ChangeFontBtn";
            this.ChangeFontBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeFontBtn.TabIndex = 7;
            this.ChangeFontBtn.Text = "Font";
            this.ChangeFontBtn.UseVisualStyleBackColor = true;
            this.ChangeFontBtn.Click += new System.EventHandler(this.ChangeFontBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(12, 156);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DirectionList
            // 
            this.DirectionList.FormattingEnabled = true;
            this.DirectionList.Location = new System.Drawing.Point(118, 98);
            this.DirectionList.Name = "DirectionList";
            this.DirectionList.Size = new System.Drawing.Size(75, 23);
            this.DirectionList.TabIndex = 9;
            this.DirectionList.SelectedIndexChanged += new System.EventHandler(this.DirectionList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 198);
            this.Controls.Add(this.DirectionList);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ChangeFontBtn);
            this.Controls.Add(this.PortSelected);
            this.Controls.Add(this.PortListLabel);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.InputTextLabel);
            this.Controls.Add(this.InputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputText;
        private Label InputTextLabel;
        private Button SubmitBtn;
        private ComboBox PortList;
        private Label PortListLabel;
        private Label PortSelected;
        private Button ChangeFontBtn;
        private Button ResetBtn;
        private ComboBox DirectionList;
    }
}