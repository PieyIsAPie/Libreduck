namespace LazyBrowser.Config
{
    partial class ConfigWindow
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
            this.clearCookiesForSiteButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.siteToClearCookies = new System.Windows.Forms.TextBox();
            this.cookieLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.updateTab = new System.Windows.Forms.TabPage();
            this.clearAllCookiesButton = new System.Windows.Forms.Button();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.dataTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearCookiesForSiteButton
            // 
            this.clearCookiesForSiteButton.Location = new System.Drawing.Point(146, 335);
            this.clearCookiesForSiteButton.Name = "clearCookiesForSiteButton";
            this.clearCookiesForSiteButton.Size = new System.Drawing.Size(134, 23);
            this.clearCookiesForSiteButton.TabIndex = 0;
            this.clearCookiesForSiteButton.Text = "Clear Cookies for Site";
            this.clearCookiesForSiteButton.UseVisualStyleBackColor = true;
            this.clearCookiesForSiteButton.Click += new System.EventHandler(this.clearCookiesForSiteButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // siteToClearCookies
            // 
            this.siteToClearCookies.Location = new System.Drawing.Point(6, 309);
            this.siteToClearCookies.Name = "siteToClearCookies";
            this.siteToClearCookies.Size = new System.Drawing.Size(274, 20);
            this.siteToClearCookies.TabIndex = 3;
            // 
            // cookieLabel
            // 
            this.cookieLabel.AutoSize = true;
            this.cookieLabel.Location = new System.Drawing.Point(6, 293);
            this.cookieLabel.Name = "cookieLabel";
            this.cookieLabel.Size = new System.Drawing.Size(111, 13);
            this.cookieLabel.TabIndex = 4;
            this.cookieLabel.Text = "Cookie Machine 3000";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dataTab);
            this.tabControl1.Controls.Add(this.updateTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // updateTab
            // 
            this.updateTab.Location = new System.Drawing.Point(4, 22);
            this.updateTab.Name = "updateTab";
            this.updateTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateTab.Size = new System.Drawing.Size(286, 364);
            this.updateTab.TabIndex = 1;
            this.updateTab.Text = "Updates";
            this.updateTab.UseVisualStyleBackColor = true;
            // 
            // clearAllCookiesButton
            // 
            this.clearAllCookiesButton.Location = new System.Drawing.Point(76, 335);
            this.clearAllCookiesButton.Name = "clearAllCookiesButton";
            this.clearAllCookiesButton.Size = new System.Drawing.Size(64, 23);
            this.clearAllCookiesButton.TabIndex = 1;
            this.clearAllCookiesButton.Text = "Clear";
            this.clearAllCookiesButton.UseVisualStyleBackColor = true;
            this.clearAllCookiesButton.Click += new System.EventHandler(this.clearAllCookiesButton_Click);
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.richTextBox1);
            this.dataTab.Controls.Add(this.cookieLabel);
            this.dataTab.Controls.Add(this.siteToClearCookies);
            this.dataTab.Controls.Add(this.button3);
            this.dataTab.Controls.Add(this.clearAllCookiesButton);
            this.dataTab.Controls.Add(this.clearCookiesForSiteButton);
            this.dataTab.Location = new System.Drawing.Point(4, 22);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(286, 364);
            this.dataTab.TabIndex = 0;
            this.dataTab.Text = "Data";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 216);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 55);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConfigWindow";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.dataTab.ResumeLayout(false);
            this.dataTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearCookiesForSiteButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox siteToClearCookies;
        private System.Windows.Forms.Label cookieLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button clearAllCookiesButton;
        private System.Windows.Forms.TabPage updateTab;
    }
}