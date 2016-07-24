namespace CustomerRegist
{
    partial class AdminDelete
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
            this.adminUserNameBox = new System.Windows.Forms.TextBox();
            this.adminUserNameConti = new System.Windows.Forms.TextBox();
            this.adminDeleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminDeleteInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminPassBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adminUserNameBox
            // 
            this.adminUserNameBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.adminUserNameBox.Location = new System.Drawing.Point(251, 53);
            this.adminUserNameBox.Name = "adminUserNameBox";
            this.adminUserNameBox.Size = new System.Drawing.Size(250, 34);
            this.adminUserNameBox.TabIndex = 0;
            // 
            // adminUserNameConti
            // 
            this.adminUserNameConti.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.adminUserNameConti.Location = new System.Drawing.Point(251, 122);
            this.adminUserNameConti.Name = "adminUserNameConti";
            this.adminUserNameConti.Size = new System.Drawing.Size(250, 34);
            this.adminUserNameConti.TabIndex = 1;
            // 
            // adminDeleteButton
            // 
            this.adminDeleteButton.BackColor = System.Drawing.Color.Yellow;
            this.adminDeleteButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.adminDeleteButton.Location = new System.Drawing.Point(340, 274);
            this.adminDeleteButton.Name = "adminDeleteButton";
            this.adminDeleteButton.Size = new System.Drawing.Size(200, 40);
            this.adminDeleteButton.TabIndex = 4;
            this.adminDeleteButton.Text = "ユーザー削除";
            this.adminDeleteButton.UseVisualStyleBackColor = false;
            this.adminDeleteButton.Click += new System.EventHandler(this.adminDeleteButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.button1.Location = new System.Drawing.Point(134, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "キャンセル";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "ユーザー名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "ユーザー名（確認）";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminDeleteInfo
            // 
            this.adminDeleteInfo.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.adminDeleteInfo.Location = new System.Drawing.Point(40, 231);
            this.adminDeleteInfo.Name = "adminDeleteInfo";
            this.adminDeleteInfo.Size = new System.Drawing.Size(500, 40);
            this.adminDeleteInfo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label3.Location = new System.Drawing.Point(30, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "パスワード";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminPassBox
            // 
            this.adminPassBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.adminPassBox.Location = new System.Drawing.Point(251, 183);
            this.adminPassBox.Name = "adminPassBox";
            this.adminPassBox.PasswordChar = '●';
            this.adminPassBox.Size = new System.Drawing.Size(250, 34);
            this.adminPassBox.TabIndex = 2;
            // 
            // AdminDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.adminPassBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminDeleteInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminDeleteButton);
            this.Controls.Add(this.adminUserNameConti);
            this.Controls.Add(this.adminUserNameBox);
            this.Name = "AdminDelete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理ユーザー削除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminUserNameBox;
        private System.Windows.Forms.TextBox adminUserNameConti;
        private System.Windows.Forms.Button adminDeleteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adminDeleteInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminPassBox;
    }
}