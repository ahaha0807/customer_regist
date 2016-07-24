namespace CustomerRegist
{
    partial class AdminAddition
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
            this.addUserName = new System.Windows.Forms.TextBox();
            this.addUserPass = new System.Windows.Forms.TextBox();
            this.addUserPassConti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.addUserInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addUserName
            // 
            this.addUserName.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.addUserName.Location = new System.Drawing.Point(247, 45);
            this.addUserName.Name = "addUserName";
            this.addUserName.Size = new System.Drawing.Size(250, 41);
            this.addUserName.TabIndex = 0;
            // 
            // addUserPass
            // 
            this.addUserPass.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.addUserPass.Location = new System.Drawing.Point(247, 117);
            this.addUserPass.Name = "addUserPass";
            this.addUserPass.PasswordChar = '●';
            this.addUserPass.Size = new System.Drawing.Size(250, 41);
            this.addUserPass.TabIndex = 1;
            // 
            // addUserPassConti
            // 
            this.addUserPassConti.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.addUserPassConti.Location = new System.Drawing.Point(247, 191);
            this.addUserPassConti.Name = "addUserPassConti";
            this.addUserPassConti.PasswordChar = '●';
            this.addUserPassConti.Size = new System.Drawing.Size(250, 41);
            this.addUserPassConti.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "ユーザー名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(29, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "パスワード";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(29, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "パスワード確認";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.submit.Location = new System.Drawing.Point(191, 310);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(150, 40);
            this.submit.TabIndex = 6;
            this.submit.Text = "登録";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.cancel.Location = new System.Drawing.Point(347, 310);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(150, 40);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // addUserInfo
            // 
            this.addUserInfo.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.addUserInfo.ForeColor = System.Drawing.Color.Coral;
            this.addUserInfo.Location = new System.Drawing.Point(29, 235);
            this.addUserInfo.Name = "addUserInfo";
            this.addUserInfo.Size = new System.Drawing.Size(468, 72);
            this.addUserInfo.TabIndex = 8;
            this.addUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.Controls.Add(this.addUserInfo);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUserPassConti);
            this.Controls.Add(this.addUserPass);
            this.Controls.Add(this.addUserName);
            this.Name = "AdminAddition";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAddition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addUserName;
        private System.Windows.Forms.TextBox addUserPass;
        private System.Windows.Forms.TextBox addUserPassConti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label addUserInfo;
    }
}