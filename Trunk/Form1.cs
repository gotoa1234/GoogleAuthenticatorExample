using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GoogleAuthenticatorExample
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 影響QR_Code 產生的圖片
        /// </summary>
        private string _account = "louis";
        /// <summary>
        /// 金鑰，相同的金鑰會產生相同的驗證碼
        /// </summary>
        private string _secretKey = "1234567890";

        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_account.Text = _account;
            textBox_SecretKey.Text = _secretKey;
        }

        #region Button Event
        
        private void button_Generator_Click(object sender, EventArgs e)
        {
            CreateSecretKeyAndQrCode();
        }


        /// <summary>
        /// 驗證
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Validate_Click(object sender, EventArgs e)
        {
            textBox_ValidateMessage.Text = 
                "Search Key :" + textBox_SecretKey.Text + Environment.NewLine +
                "驗證結果 : " + ValidateGoogleAuthCode() + Environment.NewLine ;
        }

        private static string _lastCurrentCode = "";

        /// <summary>
        /// 產生驗證碼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_GeneratorCode_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView_KeyCode.RowTemplate.Clone();
            var currentCodeList = GeneratorCurrentCode().Take(1);
            var takeSingle = currentCodeList.Take(1).First();//取一筆做為比較
            if (_lastCurrentCode != takeSingle)
            {
                _lastCurrentCode = takeSingle;
                var currentDateTimeNow = DateTime.Now;
                foreach (var code in currentCodeList)
                {
                    dataGridView_KeyCode.Rows.Add(
                        currentDateTimeNow.ToString("yyyy/MM/d HH:mm:ss"),
                        textBox_account.Text,
                        textBox_SecretKey.Text,
                        code);
                }
                //排序
                dataGridView_KeyCode.Sort(dataGridView_KeyCode.Columns["GeneratorDateTime"], System.ComponentModel.ListSortDirection.Descending);
            }
        }

        #endregion

        #region Private Method

        /// <summary>
        /// 產生QR Code 與 加密金鑰
        /// </summary>
        public void CreateSecretKeyAndQrCode()
        {
            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator();
            var setupCode = tfA.GenerateSetupCode(textBox_account.Text, textBox_account.Text, textBox_SecretKey.Text, false, 3);

            //1. QRCode圖片從記憶體轉到畫面上
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(setupCode.QrCodeSetupImageUrl.Replace("data:image/png;base64,", ""))))
                pictureBox_QRCode.Image = Image.FromStream(ms);

            //2. 產生的金鑰與資訊
            this.textBox_Message.Text =
               "結合密鑰的文字 Account: " + textBox_account.Text + System.Environment.NewLine +
               "自已加密的密鑰 Secret Key: " + textBox_SecretKey.Text + System.Environment.NewLine +
               "手動輸入的密鑰 Encoded Key: " + setupCode.ManualEntryKey;
        }

        /// <summary>
        /// 產生Secret當前的驗證碼
        /// </summary>
        public List<string> GeneratorCurrentCode()
        {
            var resultArray = new TwoFactorAuthenticator().GetCurrentPINs(textBox_SecretKey.Text);
            var resultList = new List<string>(resultArray);
            return resultList;
        }

        /// <summary>
        /// 驗證碼是否正確
        /// </summary>
        /// <returns></returns>
        public string ValidateGoogleAuthCode()
        {
            var isRight = false;
            TwoFactorAuthenticator tfA = new TwoFactorAuthenticator();
            isRight = tfA.ValidateTwoFactorPIN(textBox_SecretKey.Text, textBox_ValidateCode.Text);
            return isRight ? "驗證正確" : "錯誤";
        }

        #endregion


    }
}
