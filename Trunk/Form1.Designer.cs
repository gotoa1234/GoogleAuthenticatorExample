namespace GoogleAuthenticatorExample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_CurrentCode = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Generator = new System.Windows.Forms.Button();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_QRCode = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_KeyCode = new System.Windows.Forms.DataGridView();
            this.GeneratorDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecretKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_GeneratorCode = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_ValidateMessage = new System.Windows.Forms.TextBox();
            this.textBox_ValidateCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Validate = new System.Windows.Forms.Button();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SecretKey = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView_ManualKeyCode = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Manual_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GeneratorDateTimeManual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountManual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecretKeyManual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCodeManual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_CurrentCode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KeyCode)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManualKeyCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_CurrentCode
            // 
            this.tabControl_CurrentCode.Controls.Add(this.tabPage1);
            this.tabControl_CurrentCode.Controls.Add(this.tabPage2);
            this.tabControl_CurrentCode.Controls.Add(this.tabPage3);
            this.tabControl_CurrentCode.Controls.Add(this.tabPage4);
            this.tabControl_CurrentCode.Location = new System.Drawing.Point(18, 40);
            this.tabControl_CurrentCode.Name = "tabControl_CurrentCode";
            this.tabControl_CurrentCode.SelectedIndex = 0;
            this.tabControl_CurrentCode.Size = new System.Drawing.Size(776, 367);
            this.tabControl_CurrentCode.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Generator);
            this.tabPage1.Controls.Add(this.textBox_Message);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "產生QRCode與SecretKey";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Generator
            // 
            this.button_Generator.Location = new System.Drawing.Point(6, 6);
            this.button_Generator.Name = "button_Generator";
            this.button_Generator.Size = new System.Drawing.Size(195, 23);
            this.button_Generator.TabIndex = 2;
            this.button_Generator.Text = "執行產生QRCode與資訊";
            this.button_Generator.UseVisualStyleBackColor = true;
            this.button_Generator.Click += new System.EventHandler(this.button_Generator_Click);
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(210, 49);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(542, 273);
            this.textBox_Message.TabIndex = 1;
            this.textBox_Message.Text = "產生的相關資訊";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_QRCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "產生的QR Code";
            // 
            // pictureBox_QRCode
            // 
            this.pictureBox_QRCode.Location = new System.Drawing.Point(16, 21);
            this.pictureBox_QRCode.Name = "pictureBox_QRCode";
            this.pictureBox_QRCode.Size = new System.Drawing.Size(160, 160);
            this.pictureBox_QRCode.TabIndex = 0;
            this.pictureBox_QRCode.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_KeyCode);
            this.tabPage2.Controls.Add(this.button_GeneratorCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "當前SecretKey的密碼";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_KeyCode
            // 
            this.dataGridView_KeyCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KeyCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GeneratorDateTime,
            this.Account,
            this.SecretKey,
            this.CurrentCode});
            this.dataGridView_KeyCode.Location = new System.Drawing.Point(6, 35);
            this.dataGridView_KeyCode.Name = "dataGridView_KeyCode";
            this.dataGridView_KeyCode.RowTemplate.Height = 24;
            this.dataGridView_KeyCode.Size = new System.Drawing.Size(756, 300);
            this.dataGridView_KeyCode.TabIndex = 1;
            // 
            // GeneratorDateTime
            // 
            this.GeneratorDateTime.HeaderText = "產生時間";
            this.GeneratorDateTime.Name = "GeneratorDateTime";
            this.GeneratorDateTime.ReadOnly = true;
            this.GeneratorDateTime.Width = 150;
            // 
            // Account
            // 
            this.Account.HeaderText = "手產字串";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 150;
            // 
            // SecretKey
            // 
            this.SecretKey.HeaderText = "手產金鑰";
            this.SecretKey.Name = "SecretKey";
            this.SecretKey.ReadOnly = true;
            this.SecretKey.Width = 150;
            // 
            // CurrentCode
            // 
            this.CurrentCode.HeaderText = "當前驗證金鑰";
            this.CurrentCode.Name = "CurrentCode";
            this.CurrentCode.ReadOnly = true;
            this.CurrentCode.Width = 150;
            // 
            // button_GeneratorCode
            // 
            this.button_GeneratorCode.Location = new System.Drawing.Point(6, 6);
            this.button_GeneratorCode.Name = "button_GeneratorCode";
            this.button_GeneratorCode.Size = new System.Drawing.Size(215, 23);
            this.button_GeneratorCode.TabIndex = 0;
            this.button_GeneratorCode.Text = "取得當前SecretKey的密碼";
            this.button_GeneratorCode.UseVisualStyleBackColor = true;
            this.button_GeneratorCode.Click += new System.EventHandler(this.button_GeneratorCode_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_ValidateMessage);
            this.tabPage3.Controls.Add(this.textBox_ValidateCode);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button_Validate);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "驗證當前密碼是否正確";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_ValidateMessage
            // 
            this.textBox_ValidateMessage.Location = new System.Drawing.Point(17, 79);
            this.textBox_ValidateMessage.Multiline = true;
            this.textBox_ValidateMessage.Name = "textBox_ValidateMessage";
            this.textBox_ValidateMessage.Size = new System.Drawing.Size(745, 256);
            this.textBox_ValidateMessage.TabIndex = 4;
            this.textBox_ValidateMessage.Text = "驗證結果";
            // 
            // textBox_ValidateCode
            // 
            this.textBox_ValidateCode.Location = new System.Drawing.Point(98, 14);
            this.textBox_ValidateCode.Name = "textBox_ValidateCode";
            this.textBox_ValidateCode.Size = new System.Drawing.Size(100, 22);
            this.textBox_ValidateCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "輸入驗證碼：";
            // 
            // button_Validate
            // 
            this.button_Validate.Location = new System.Drawing.Point(17, 42);
            this.button_Validate.Name = "button_Validate";
            this.button_Validate.Size = new System.Drawing.Size(181, 31);
            this.button_Validate.TabIndex = 0;
            this.button_Validate.Text = "驗證";
            this.button_Validate.UseVisualStyleBackColor = true;
            this.button_Validate.Click += new System.EventHandler(this.button_Validate_Click);
            // 
            // textBox_account
            // 
            this.textBox_account.Location = new System.Drawing.Point(81, 12);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(100, 22);
            this.textBox_account.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secret Key ：";
            // 
            // textBox_SecretKey
            // 
            this.textBox_SecretKey.Location = new System.Drawing.Point(283, 12);
            this.textBox_SecretKey.Name = "textBox_SecretKey";
            this.textBox_SecretKey.Size = new System.Drawing.Size(100, 22);
            this.textBox_SecretKey.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Manual_textBox);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dataGridView_ManualKeyCode);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 341);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "當前手動金鑰密碼";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ManualKeyCode
            // 
            this.dataGridView_ManualKeyCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ManualKeyCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GeneratorDateTimeManual,
            this.AccountManual,
            this.SecretKeyManual,
            this.CurrentCodeManual});
            this.dataGridView_ManualKeyCode.Location = new System.Drawing.Point(6, 35);
            this.dataGridView_ManualKeyCode.Name = "dataGridView_ManualKeyCode";
            this.dataGridView_ManualKeyCode.RowTemplate.Height = 24;
            this.dataGridView_ManualKeyCode.Size = new System.Drawing.Size(756, 300);
            this.dataGridView_ManualKeyCode.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "取得當前手動金鑰的密碼";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manual_textBox
            // 
            this.Manual_textBox.Location = new System.Drawing.Point(324, 7);
            this.Manual_textBox.Name = "Manual_textBox";
            this.Manual_textBox.Size = new System.Drawing.Size(290, 22);
            this.Manual_textBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "手動輸入金鑰：";
            // 
            // GeneratorDateTimeManual
            // 
            this.GeneratorDateTimeManual.HeaderText = "產生時間";
            this.GeneratorDateTimeManual.Name = "GeneratorDateTimeManual";
            this.GeneratorDateTimeManual.ReadOnly = true;
            this.GeneratorDateTimeManual.Width = 150;
            // 
            // AccountManual
            // 
            this.AccountManual.HeaderText = "手產字串";
            this.AccountManual.Name = "AccountManual";
            this.AccountManual.ReadOnly = true;
            this.AccountManual.Width = 150;
            // 
            // SecretKeyManual
            // 
            this.SecretKeyManual.HeaderText = "手產金鑰";
            this.SecretKeyManual.Name = "SecretKeyManual";
            this.SecretKeyManual.ReadOnly = true;
            this.SecretKeyManual.Width = 150;
            // 
            // CurrentCodeManual
            // 
            this.CurrentCodeManual.HeaderText = "當前驗證金鑰";
            this.CurrentCodeManual.Name = "CurrentCodeManual";
            this.CurrentCodeManual.ReadOnly = true;
            this.CurrentCodeManual.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.textBox_SecretKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.tabControl_CurrentCode);
            this.Name = "Form1";
            this.Text = "GoogleAuthenticator範例";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_CurrentCode.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KeyCode)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManualKeyCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_CurrentCode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SecretKey;
        private System.Windows.Forms.Button button_Generator;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_QRCode;
        private System.Windows.Forms.DataGridView dataGridView_KeyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneratorDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecretKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCode;
        private System.Windows.Forms.Button button_GeneratorCode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_ValidateMessage;
        private System.Windows.Forms.TextBox textBox_ValidateCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Validate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView_ManualKeyCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Manual_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneratorDateTimeManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecretKeyManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCodeManual;
    }
}

