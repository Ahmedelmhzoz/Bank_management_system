namespace BankSystem {
    partial class FrmClientProcess {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fdChooseImg = new System.Windows.Forms.OpenFileDialog();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(1156, 197);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(349, 38);
            this.txtPinCode.TabIndex = 22;
            this.txtPinCode.Tag = "PinCode";
            this.txtPinCode.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBoxes);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Teal;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhone.Location = new System.Drawing.Point(963, 317);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(161, 47);
            this.lblPhone.TabIndex = 21;
            this.lblPhone.Text = "Phone: ";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(1156, 317);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(349, 38);
            this.txtPhoneNum.TabIndex = 20;
            this.txtPhoneNum.Tag = "Phone";
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtPhoneNum_TextChanged);
            this.txtPhoneNum.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBoxes);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(932, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 47);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pin code:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(406, 316);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 38);
            this.txtName.TabIndex = 18;
            this.txtName.Tag = "Client name";
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBoxes);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(114, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 47);
            this.label4.TabIndex = 17;
            this.label4.Text = "Client name:";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold);
            this.lblProcess.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblProcess.Location = new System.Drawing.Point(642, 25);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(372, 88);
            this.lblProcess.TabIndex = 16;
            this.lblProcess.Text = "Add new client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(35, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Account number:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fdChooseImg
            // 
            this.fdChooseImg.FileName = "openFileDialog1";
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(406, 189);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(349, 38);
            this.txtAccNumber.TabIndex = 1;
            this.txtAccNumber.Tag = "Account number";
            this.txtAccNumber.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBoxes);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.ForeColor = System.Drawing.Color.Cyan;
            this.btnSave.Image = global::BankSystem.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(685, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(255, 122);
            this.btnSave.TabIndex = 24;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.ForeColor = System.Drawing.Color.Cyan;
            this.btnClose.Image = global::BankSystem.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1312, 615);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(256, 67);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmClientProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1602, 710);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmClientProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddClient";
            this.Load += new System.EventHandler(this.FrmAddClient_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.validatingTextBoxes);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog fdChooseImg;
    }
}