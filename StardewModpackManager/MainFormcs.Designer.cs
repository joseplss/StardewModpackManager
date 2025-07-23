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
            mainFormLabel = new Label();
            maximizeRestoreBtn = new Button();
            minimizeBtn = new Button();
            closeBtn = new Button();
            wizardPanel_pg1 = new Panel();
            wizardPanel_btn1_pg1 = new Button();
            wizardPanel_label_pg1 = new Label();
            setupWizardImg = new PictureBox();
            wizardPanel_pg2 = new Panel();
            wizardPanel_btn1_pg2 = new Button();
            wizardPanel_label_pg2 = new Label();
            panelTitleBar.SuspendLayout();
            wizardPanel_pg1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setupWizardImg).BeginInit();
            wizardPanel_pg2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(mainFormLabel);
            panelTitleBar.Controls.Add(maximizeRestoreBtn);
            panelTitleBar.Controls.Add(minimizeBtn);
            panelTitleBar.Controls.Add(closeBtn);
            panelTitleBar.Location = new Point(-7, -30);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1325, 61);
            panelTitleBar.TabIndex = 0;
            // 
            // mainFormLabel
            // 
            mainFormLabel.AutoSize = true;
            mainFormLabel.ForeColor = Color.White;
            mainFormLabel.Location = new Point(596, 36);
            mainFormLabel.Name = "mainFormLabel";
            mainFormLabel.Size = new Size(153, 15);
            mainFormLabel.TabIndex = 4;
            mainFormLabel.Text = "StardewModpackManager";
            // 
            // maximizeRestoreBtn
            // 
            maximizeRestoreBtn.BackgroundImage = Properties.Resources.icons8_expand_collapse;
            maximizeRestoreBtn.BackgroundImageLayout = ImageLayout.Stretch;
            maximizeRestoreBtn.FlatAppearance.BorderSize = 0;
            maximizeRestoreBtn.FlatStyle = FlatStyle.Flat;
            maximizeRestoreBtn.Location = new Point(1174, 37);
            maximizeRestoreBtn.Name = "maximizeRestoreBtn";
            maximizeRestoreBtn.Size = new Size(24, 24);
            maximizeRestoreBtn.TabIndex = 3;
            maximizeRestoreBtn.UseVisualStyleBackColor = true;
            maximizeRestoreBtn.Click += btnMaximizeRestore_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackgroundImage = Properties.Resources.icons8_minimize;
            minimizeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Location = new Point(1090, 37);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(24, 24);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = Properties.Resources.icons8_close;
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(1257, 37);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(24, 24);
            closeBtn.TabIndex = 1;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // wizardPanel_pg1
            // 
            wizardPanel_pg1.Controls.Add(wizardPanel_btn1_pg1);
            wizardPanel_pg1.Controls.Add(wizardPanel_label_pg1);
            wizardPanel_pg1.Location = new Point(25, 413);
            wizardPanel_pg1.Name = "wizardPanel_pg1";
            wizardPanel_pg1.Size = new Size(1249, 202);
            wizardPanel_pg1.TabIndex = 1;
            // 
            // wizardPanel_btn1_pg1
            // 
            wizardPanel_btn1_pg1.BackColor = Color.FromArgb(64, 192, 87);
            wizardPanel_btn1_pg1.FlatAppearance.BorderSize = 0;
            wizardPanel_btn1_pg1.FlatStyle = FlatStyle.Flat;
            wizardPanel_btn1_pg1.Font = new Font("Segoe UI Semibold", 10.8301888F, FontStyle.Regular, GraphicsUnit.Point);
            wizardPanel_btn1_pg1.ForeColor = Color.White;
            wizardPanel_btn1_pg1.Location = new Point(564, 138);
            wizardPanel_btn1_pg1.Name = "wizardPanel_btn1_pg1";
            wizardPanel_btn1_pg1.Size = new Size(100, 50);
            wizardPanel_btn1_pg1.TabIndex = 2;
            wizardPanel_btn1_pg1.Text = "Start!";
            wizardPanel_btn1_pg1.UseVisualStyleBackColor = false;
            wizardPanel_btn1_pg1.Click += wizardPanel_btn1_pg1_Click;
            // 
            // wizardPanel_label_pg1
            // 
            wizardPanel_label_pg1.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point);
            wizardPanel_label_pg1.ForeColor = Color.White;
            wizardPanel_label_pg1.Location = new Point(423, 21);
            wizardPanel_label_pg1.MaximumSize = new Size(400, 200);
            wizardPanel_label_pg1.Name = "wizardPanel_label_pg1";
            wizardPanel_label_pg1.Size = new Size(400, 100);
            wizardPanel_label_pg1.TabIndex = 1;
            wizardPanel_label_pg1.Text = "It looks like the wizard has not set up yet! \nSet up with the wizard in order to use Stardew Modpack Manager.";
            // 
            // setupWizardImg
            // 
            setupWizardImg.Image = Properties.Resources.programWizard;
            setupWizardImg.Location = new Point(564, 138);
            setupWizardImg.Name = "setupWizardImg";
            setupWizardImg.Size = new Size(256, 256);
            setupWizardImg.SizeMode = PictureBoxSizeMode.Zoom;
            setupWizardImg.TabIndex = 0;
            setupWizardImg.TabStop = false;
            setupWizardImg.WaitOnLoad = true;
            // 
            // wizardPanel_pg2
            // 
            wizardPanel_pg2.Controls.Add(wizardPanel_btn1_pg2);
            wizardPanel_pg2.Controls.Add(wizardPanel_label_pg2);
            wizardPanel_pg2.Location = new Point(25, 413);
            wizardPanel_pg2.Name = "wizardPanel_pg2";
            wizardPanel_pg2.Size = new Size(1249, 202);
            wizardPanel_pg2.TabIndex = 2;
            wizardPanel_pg2.Visible = false;
            // 
            // wizardPanel_btn1_pg2
            // 
            wizardPanel_btn1_pg2.BackColor = Color.FromArgb(64, 192, 87);
            wizardPanel_btn1_pg2.FlatAppearance.BorderSize = 0;
            wizardPanel_btn1_pg2.FlatStyle = FlatStyle.Flat;
            wizardPanel_btn1_pg2.Font = new Font("Segoe UI Semibold", 10.8301888F, FontStyle.Regular, GraphicsUnit.Point);
            wizardPanel_btn1_pg2.ForeColor = Color.White;
            wizardPanel_btn1_pg2.Location = new Point(564, 138);
            wizardPanel_btn1_pg2.Name = "wizardPanel_btn1_pg2";
            wizardPanel_btn1_pg2.Size = new Size(100, 50);
            wizardPanel_btn1_pg2.TabIndex = 2;
            wizardPanel_btn1_pg2.Text = "Start!";
            wizardPanel_btn1_pg2.UseVisualStyleBackColor = false;
            // 
            // wizardPanel_label_pg2
            // 
            wizardPanel_label_pg2.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point);
            wizardPanel_label_pg2.ForeColor = Color.White;
            wizardPanel_label_pg2.Location = new Point(423, 21);
            wizardPanel_label_pg2.MaximumSize = new Size(400, 200);
            wizardPanel_label_pg2.Name = "wizardPanel_label_pg2";
            wizardPanel_label_pg2.Size = new Size(400, 100);
            wizardPanel_label_pg2.TabIndex = 3;
            wizardPanel_label_pg2.Text = "We need to look for the mods folder within the Stardew Valley Directory.\nPlease check readme or github for guidance.";
            // 
            // MainFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1310, 672);
            Controls.Add(wizardPanel_pg2);
            Controls.Add(panelTitleBar);
            Controls.Add(setupWizardImg);
            Controls.Add(wizardPanel_pg1);
            Font = new Font("Microsoft Sans Serif", 8.830189F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainFormcs";
            Text = "MainFormcs";
            Load += MainFormcs_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            wizardPanel_pg1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)setupWizardImg).EndInit();
            wizardPanel_pg2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTitleBar;
        private Button maximizeRestoreBtn;
        private Button minimizeBtn;
        private Button closeBtn;
        private Label mainFormLabel;
        private Panel wizardPanel_pg1;
        private PictureBox setupWizardImg;
        private Label wizardPanel_label_pg1;
        private Button wizardPanel_btn1_pg1;
        private Panel wizardPanel_pg2;
        private Label wizardPanel_label_pg2;
        private Button wizardPanel_btn1_pg2;
    }
}