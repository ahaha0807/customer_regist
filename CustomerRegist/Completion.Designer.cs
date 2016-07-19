namespace CustomerRegist
{
    partial class Completion
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
            this.regiBack = new System.Windows.Forms.Button();
            this.menuBack = new System.Windows.Forms.Button();
            this.cmpInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regiBack
            // 
            this.regiBack.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.regiBack.Location = new System.Drawing.Point(103, 150);
            this.regiBack.Name = "regiBack";
            this.regiBack.Size = new System.Drawing.Size(200, 50);
            this.regiBack.TabIndex = 0;
            this.regiBack.Text = "登録画面に戻る";
            this.regiBack.UseVisualStyleBackColor = true;
            this.regiBack.Click += new System.EventHandler(this.regiBack_Click);
            // 
            // menuBack
            // 
            this.menuBack.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.menuBack.Location = new System.Drawing.Point(309, 150);
            this.menuBack.Name = "menuBack";
            this.menuBack.Size = new System.Drawing.Size(200, 50);
            this.menuBack.TabIndex = 1;
            this.menuBack.Text = "メニューに戻る";
            this.menuBack.UseVisualStyleBackColor = true;
            this.menuBack.Click += new System.EventHandler(this.menuBack_Click);
            // 
            // cmpInfo
            // 
            this.cmpInfo.Font = new System.Drawing.Font("MS UI Gothic", 28F);
            this.cmpInfo.Location = new System.Drawing.Point(96, 44);
            this.cmpInfo.Name = "cmpInfo";
            this.cmpInfo.Size = new System.Drawing.Size(400, 50);
            this.cmpInfo.TabIndex = 2;
            this.cmpInfo.Text = "登録完了しました";
            this.cmpInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Completion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 212);
            this.Controls.Add(this.cmpInfo);
            this.Controls.Add(this.menuBack);
            this.Controls.Add(this.regiBack);
            this.Name = "Completion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登録完了";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regiBack;
        private System.Windows.Forms.Button menuBack;
        private System.Windows.Forms.Label cmpInfo;
    }
}