namespace iTunesTest
{
    partial class iTunesForm
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
            this.currentTxt = new System.Windows.Forms.TextBox();
            this.nowBtn = new System.Windows.Forms.Button();
            this.lyricTxt = new System.Windows.Forms.TextBox();
            this.syncBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentTxt
            // 
            this.currentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTxt.Location = new System.Drawing.Point(13, 81);
            this.currentTxt.Multiline = true;
            this.currentTxt.Name = "currentTxt";
            this.currentTxt.ReadOnly = true;
            this.currentTxt.Size = new System.Drawing.Size(592, 34);
            this.currentTxt.TabIndex = 0;
            // 
            // nowBtn
            // 
            this.nowBtn.Location = new System.Drawing.Point(506, 12);
            this.nowBtn.Name = "nowBtn";
            this.nowBtn.Size = new System.Drawing.Size(99, 47);
            this.nowBtn.TabIndex = 1;
            this.nowBtn.Text = "Now";
            this.nowBtn.UseVisualStyleBackColor = true;
            this.nowBtn.Click += new System.EventHandler(this.nowBtn_Click);
            // 
            // lyricTxt
            // 
            this.lyricTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lyricTxt.Location = new System.Drawing.Point(13, 121);
            this.lyricTxt.Multiline = true;
            this.lyricTxt.Name = "lyricTxt";
            this.lyricTxt.ReadOnly = true;
            this.lyricTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lyricTxt.Size = new System.Drawing.Size(592, 484);
            this.lyricTxt.TabIndex = 2;
            this.lyricTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // syncBtn
            // 
            this.syncBtn.Location = new System.Drawing.Point(13, 12);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(99, 47);
            this.syncBtn.TabIndex = 3;
            this.syncBtn.Text = "Sync";
            this.syncBtn.UseVisualStyleBackColor = true;
            this.syncBtn.Click += new System.EventHandler(this.syncBtn_Click);
            // 
            // iTunesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 617);
            this.Controls.Add(this.syncBtn);
            this.Controls.Add(this.lyricTxt);
            this.Controls.Add(this.nowBtn);
            this.Controls.Add(this.currentTxt);
            this.Name = "iTunesForm";
            this.Text = "iTunes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentTxt;
        private System.Windows.Forms.Button nowBtn;
        private System.Windows.Forms.TextBox lyricTxt;
        private System.Windows.Forms.Button syncBtn;
    }
}

