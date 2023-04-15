namespace LazyBrowser
{
    partial class Main
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
            this.CefPanel = new System.Windows.Forms.Panel();
            this.forwardButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.addressBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.exButton = new System.Windows.Forms.Button();
            this.baseWinPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addressBarPanel.SuspendLayout();
            this.baseWinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CefPanel
            // 
            this.CefPanel.Location = new System.Drawing.Point(4, 41);
            this.CefPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CefPanel.Name = "CefPanel";
            this.CefPanel.Size = new System.Drawing.Size(1059, 498);
            this.CefPanel.TabIndex = 0;
            // 
            // forwardButton
            // 
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Location = new System.Drawing.Point(41, 4);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(4);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(29, 28);
            this.forwardButton.TabIndex = 0;
            this.forwardButton.Text = "▶";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.Location = new System.Drawing.Point(78, 4);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(4);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(29, 28);
            this.reloadButton.TabIndex = 1;
            this.reloadButton.Text = "r";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(4, 4);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(29, 28);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "◀";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addressBar
            // 
            this.addressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBar.Location = new System.Drawing.Point(115, 4);
            this.addressBar.Margin = new System.Windows.Forms.Padding(4);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(906, 22);
            this.addressBar.TabIndex = 3;
            this.addressBar.Click += new System.EventHandler(this.addressBar_Click);
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // addressBarPanel
            // 
            this.addressBarPanel.ColumnCount = 5;
            this.addressBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.addressBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.addressBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.addressBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addressBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.addressBarPanel.Controls.Add(this.backButton, 0, 0);
            this.addressBarPanel.Controls.Add(this.forwardButton, 1, 0);
            this.addressBarPanel.Controls.Add(this.reloadButton, 2, 0);
            this.addressBarPanel.Controls.Add(this.addressBar, 3, 0);
            this.addressBarPanel.Controls.Add(this.exButton, 4, 0);
            this.addressBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressBarPanel.Location = new System.Drawing.Point(0, 0);
            this.addressBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.addressBarPanel.Name = "addressBarPanel";
            this.addressBarPanel.RowCount = 1;
            this.addressBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addressBarPanel.Size = new System.Drawing.Size(1067, 37);
            this.addressBarPanel.TabIndex = 0;
            // 
            // exButton
            // 
            this.exButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exButton.Location = new System.Drawing.Point(1029, 4);
            this.exButton.Margin = new System.Windows.Forms.Padding(4);
            this.exButton.Name = "exButton";
            this.exButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exButton.Size = new System.Drawing.Size(34, 29);
            this.exButton.TabIndex = 4;
            this.exButton.Text = "...";
            this.exButton.UseVisualStyleBackColor = true;
            this.exButton.Click += new System.EventHandler(this.exButton_Click);
            // 
            // baseWinPanel
            // 
            this.baseWinPanel.ColumnCount = 1;
            this.baseWinPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseWinPanel.Controls.Add(this.addressBarPanel, 0, 0);
            this.baseWinPanel.Controls.Add(this.CefPanel, 0, 1);
            this.baseWinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseWinPanel.Location = new System.Drawing.Point(0, 0);
            this.baseWinPanel.Margin = new System.Windows.Forms.Padding(0);
            this.baseWinPanel.Name = "baseWinPanel";
            this.baseWinPanel.RowCount = 2;
            this.baseWinPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.baseWinPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.baseWinPanel.Size = new System.Drawing.Size(1067, 554);
            this.baseWinPanel.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.baseWinPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form1";
            this.addressBarPanel.ResumeLayout(false);
            this.addressBarPanel.PerformLayout();
            this.baseWinPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CefPanel;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.TableLayoutPanel addressBarPanel;
        private System.Windows.Forms.TableLayoutPanel baseWinPanel;
        private System.Windows.Forms.Button exButton;
    }
}

