namespace StardewModpackManager
{
    partial class MainFormcs
    {
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// Required method for Designer support - do not modify
        private void InitializeComponent()
        {
            panelTitleBar = new Panel();
            label1 = new Label();
            maximizeRestoreBtn = new Button();
            minimizeBtn = new Button();
            closeBtn = new Button();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Controls.Add(maximizeRestoreBtn);
            panelTitleBar.Controls.Add(minimizeBtn);
            panelTitleBar.Controls.Add(closeBtn);
            panelTitleBar.Location = new Point(-7, -30);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1325, 61);
            panelTitleBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(596, 36);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 4;
            label1.Text = "StardewModpackManager";
            // 
            // maximizeRestoreBtn
            // 
            maximizeRestoreBtn.Location = new Point(1174, 32);
            maximizeRestoreBtn.Name = "maximizeRestoreBtn";
            maximizeRestoreBtn.Size = new Size(57, 26);
            maximizeRestoreBtn.TabIndex = 3;
            maximizeRestoreBtn.Text = "button1";
            maximizeRestoreBtn.UseVisualStyleBackColor = true;
            maximizeRestoreBtn.Click += btnMaximizeRestore_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Location = new Point(1090, 32);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(57, 26);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.Text = "button1";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(1257, 32);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(57, 26);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "button1";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // MainFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1310, 600);
            Controls.Add(panelTitleBar);
            Font = new Font("Arial Rounded MT Bold", 8.830189F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainFormcs";
            Text = "MainFormcs";
            Load += MainFormcs_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Button maximizeRestoreBtn;
        private Button minimizeBtn;
        private Button closeBtn;
        private Label label1;
    }
}