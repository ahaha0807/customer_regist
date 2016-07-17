namespace CustomerRegist
{
    partial class menuList
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
            this.customerRegi = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.loginUserRegi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerRegi
            // 
            this.customerRegi.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.customerRegi.Location = new System.Drawing.Point(70, 70);
            this.customerRegi.Name = "customerRegi";
            this.customerRegi.Size = new System.Drawing.Size(200, 50);
            this.customerRegi.TabIndex = 0;
            this.customerRegi.Text = "顧客情報登録";
            this.customerRegi.UseVisualStyleBackColor = true;
            this.customerRegi.Click += new System.EventHandler(this.customerRegi_Click);
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.logOut.Location = new System.Drawing.Point(450, 400);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(200, 40);
            this.logOut.TabIndex = 2;
            this.logOut.Text = "ログアウト";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // loginUserRegi
            // 
            this.loginUserRegi.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.loginUserRegi.Location = new System.Drawing.Point(401, 70);
            this.loginUserRegi.Name = "loginUserRegi";
            this.loginUserRegi.Size = new System.Drawing.Size(200, 50);
            this.loginUserRegi.TabIndex = 1;
            this.loginUserRegi.Text = "管理ユーザー登録";
            this.loginUserRegi.UseVisualStyleBackColor = true;
            this.loginUserRegi.Click += new System.EventHandler(this.loginUserRegi_Click);
            // 
            // menuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.loginUserRegi);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.customerRegi);
            this.Name = "menuList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerRegi;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button loginUserRegi;
    }
}