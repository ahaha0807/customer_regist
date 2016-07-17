namespace CustomerRegist
{
    partial class Login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.userPassBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loginInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameBox
            // 
            this.userNameBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userNameBox.Location = new System.Drawing.Point(33, 102);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(300, 31);
            this.userNameBox.TabIndex = 0;
            // 
            // userPassBox
            // 
            this.userPassBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userPassBox.Location = new System.Drawing.Point(33, 245);
            this.userPassBox.Name = "userPassBox";
            this.userPassBox.PasswordChar = '●';
            this.userPassBox.Size = new System.Drawing.Size(300, 31);
            this.userPassBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userNameLabel.Location = new System.Drawing.Point(28, 69);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(250, 30);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "ユーザー名";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(28, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "パスワード";
            // 
            // loginSubmit
            // 
            this.loginSubmit.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginSubmit.Location = new System.Drawing.Point(12, 348);
            this.loginSubmit.Name = "loginSubmit";
            this.loginSubmit.Size = new System.Drawing.Size(171, 40);
            this.loginSubmit.TabIndex = 4;
            this.loginSubmit.Text = "ログイン";
            this.loginSubmit.UseVisualStyleBackColor = true;
            this.loginSubmit.Click += new System.EventHandler(this.loginSubmit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(202, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "終了";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginInfo
            // 
            this.loginInfo.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.loginInfo.ForeColor = System.Drawing.Color.IndianRed;
            this.loginInfo.Location = new System.Drawing.Point(12, 297);
            this.loginInfo.Name = "loginInfo";
            this.loginInfo.Size = new System.Drawing.Size(360, 30);
            this.loginInfo.TabIndex = 6;
            this.loginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.loginInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userPassBox);
            this.Controls.Add(this.userNameBox);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログイン画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox userPassBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginSubmit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loginInfo;
    }
}

