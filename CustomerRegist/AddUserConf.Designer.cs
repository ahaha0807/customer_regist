namespace CustomerRegist
{
    partial class AddUserConf
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
            this.addUserConfLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUserConfLabel
            // 
            this.addUserConfLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.addUserConfLabel.Location = new System.Drawing.Point(41, 75);
            this.addUserConfLabel.Name = "addUserConfLabel";
            this.addUserConfLabel.Size = new System.Drawing.Size(400, 50);
            this.addUserConfLabel.TabIndex = 0;
            this.addUserConfLabel.Text = "登録完了しました";
            this.addUserConfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.button1.Location = new System.Drawing.Point(137, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "メニューに戻る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUserConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addUserConfLabel);
            this.Name = "AddUserConf";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserConf";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addUserConfLabel;
        private System.Windows.Forms.Button button1;
    }
}