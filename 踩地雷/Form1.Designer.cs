namespace 踩地雷
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.選項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.難度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.簡單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中等ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.困難ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 94;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(321, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選項ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 選項ToolStripMenuItem
            // 
            this.選項ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.難度ToolStripMenuItem,
            this.排名ToolStripMenuItem,
            this.作者ToolStripMenuItem});
            this.選項ToolStripMenuItem.Name = "選項ToolStripMenuItem";
            this.選項ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.選項ToolStripMenuItem.Text = "遊戲";
            // 
            // 難度ToolStripMenuItem
            // 
            this.難度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.簡單ToolStripMenuItem,
            this.中等ToolStripMenuItem,
            this.困難ToolStripMenuItem});
            this.難度ToolStripMenuItem.Name = "難度ToolStripMenuItem";
            this.難度ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.難度ToolStripMenuItem.Text = "難度";
            // 
            // 簡單ToolStripMenuItem
            // 
            this.簡單ToolStripMenuItem.Name = "簡單ToolStripMenuItem";
            this.簡單ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.簡單ToolStripMenuItem.Text = "簡單";
            this.簡單ToolStripMenuItem.Click += new System.EventHandler(this.簡單ToolStripMenuItem_Click);
            // 
            // 中等ToolStripMenuItem
            // 
            this.中等ToolStripMenuItem.Name = "中等ToolStripMenuItem";
            this.中等ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.中等ToolStripMenuItem.Text = "中等";
            this.中等ToolStripMenuItem.Click += new System.EventHandler(this.中等ToolStripMenuItem_Click);
            // 
            // 困難ToolStripMenuItem
            // 
            this.困難ToolStripMenuItem.Name = "困難ToolStripMenuItem";
            this.困難ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.困難ToolStripMenuItem.Text = "困難";
            this.困難ToolStripMenuItem.Click += new System.EventHandler(this.困難ToolStripMenuItem_Click);
            // 
            // 排名ToolStripMenuItem
            // 
            this.排名ToolStripMenuItem.Name = "排名ToolStripMenuItem";
            this.排名ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.排名ToolStripMenuItem.Text = "排名";
            this.排名ToolStripMenuItem.Click += new System.EventHandler(this.排名ToolStripMenuItem_Click);
            // 
            // 作者ToolStripMenuItem
            // 
            this.作者ToolStripMenuItem.Name = "作者ToolStripMenuItem";
            this.作者ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.作者ToolStripMenuItem.Text = "作者";
            this.作者ToolStripMenuItem.Click += new System.EventHandler(this.作者ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.TabIndex = 6;
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.Color.Transparent;
            this.res.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.res.ForeColor = System.Drawing.Color.Transparent;
            this.res.Location = new System.Drawing.Point(242, 36);
            this.res.Margin = new System.Windows.Forms.Padding(0);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(45, 45);
            this.res.TabIndex = 1;
            this.res.UseVisualStyleBackColor = false;
            this.res.Click += new System.EventHandler(this.Res_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(529, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "踩地雷";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 選項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 難度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 簡單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中等ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 困難ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排名ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 作者ToolStripMenuItem;
    }
}

