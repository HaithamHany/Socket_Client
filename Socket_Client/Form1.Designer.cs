namespace Socket_Client
{
    partial class Form1
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
            this.inputMessege = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this._statusLabel = new System.Windows.Forms.Label();
            this._statusValue = new System.Windows.Forms.Label();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._buttonConnect = new System.Windows.Forms.Button();
            _lblStatusConnect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputMessege
            // 
            this.inputMessege.Location = new System.Drawing.Point(45, 310);
            this.inputMessege.Multiline = true;
            this.inputMessege.Name = "inputMessege";
            this.inputMessege.Size = new System.Drawing.Size(628, 68);
            this.inputMessege.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(679, 310);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(76, 68);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // _statusLabel
            // 
            this._statusLabel.AutoSize = true;
            this._statusLabel.Location = new System.Drawing.Point(45, 32);
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(40, 13);
            this._statusLabel.TabIndex = 2;
            this._statusLabel.Text = "Status:";
            // 
            // _statusValue
            // 
            this._statusValue.AutoSize = true;
            this._statusValue.Location = new System.Drawing.Point(43, 56);
            this._statusValue.Name = "_statusValue";
            this._statusValue.Size = new System.Drawing.Size(0, 13);
            this._statusValue.TabIndex = 3;
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(39, 396);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(93, 20);
            this._nameTextBox.TabIndex = 4;
            // 
            // _buttonConnect
            // 
            this._buttonConnect.Location = new System.Drawing.Point(680, 396);
            this._buttonConnect.Name = "_buttonConnect";
            this._buttonConnect.Size = new System.Drawing.Size(75, 23);
            this._buttonConnect.TabIndex = 5;
            this._buttonConnect.Text = "Connect";
            this._buttonConnect.UseVisualStyleBackColor = true;
            // 
            // _lblStatusConnect
            // 
            _lblStatusConnect.AutoSize = true;
            _lblStatusConnect.Location = new System.Drawing.Point(91, 32);
            _lblStatusConnect.Name = "_lblStatusConnect";
            _lblStatusConnect.Size = new System.Drawing.Size(0, 13);
            _lblStatusConnect.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(_lblStatusConnect);
            this.Controls.Add(this._buttonConnect);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this._statusValue);
            this.Controls.Add(this._statusLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.inputMessege);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputMessege;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label _statusLabel;
        private System.Windows.Forms.Label _statusValue;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Button _buttonConnect;
        public static System.Windows.Forms.Label _lblStatusConnect;
    }
}

