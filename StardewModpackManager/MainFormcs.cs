using StardewModpackManager.common;
using StardewModpackManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewModpackManager
{
    public partial class MainFormcs : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastFormLocation;
        private Point minimizedCloseBtnLocation;
        private Point minimizedMinimizeBtnLocation;
        private Point minimizedMaximizeRestoreBtnLocation;
        public MainFormcs()
        {
            InitializeComponent();
        }

        private void MainFormcs_Load(object sender, EventArgs e)
        {
            Console.WriteLine("MainFormcs loaded successfully.");
            Form form = FindForm();
            Panel panel = panelTitleBar;
            CommonUtils.DefaultForm(form, panel);

            // Save old button locations
            minimizedCloseBtnLocation = closeBtn.Location;
            minimizedMinimizeBtnLocation = minimizeBtn.Location;
            minimizedMaximizeRestoreBtnLocation = btnMaximizeRestore.Location;

            // Attach mouse events to the title bar panel  
            panelTitleBar.MouseUp += panelTitleBar_MouseUp!;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown!;
            panelTitleBar.MouseMove += panelTitleBar_MouseMove!;

            // Set initial colors for a dark theme  
            this.BackColor = Color.FromArgb(30, 30, 30); // Dark background for the main form  
            panelTitleBar.BackColor = Color.FromArgb(20, 20, 20); // Slightly darker for title bar  
                                                                  // Set button forecolors to white or light gray  
                                                                  // Set button flat style and remove border for a modern look  
        }

        #region experimental  
        private void panelTitleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastFormLocation = this.Location;
            }
        }

        private void panelTitleBar_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int dx = Cursor.Position.X - lastCursor.X;
                int dy = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastFormLocation.X + dx, lastFormLocation.Y + dy);
            }
        }

        private void panelTitleBar_MouseUp(object? sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        // Event handlers for control buttons  
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void btnMaximizeRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                panelTitleBar.Width = GetFormSize(FormSize.Width);
                panelTitleBar.Height = 61; // Set a fixed height for the title bar
                // move buttons from panel to move closer to the right
                closeBtn.Location = new Point(panelTitleBar.Width - 100, 32); // Adjust the X position as needed
                btnMaximizeRestore.Location = new Point(panelTitleBar.Width - 160, 32); // Adjust the X position as needed
                minimizeBtn.Location = new Point(panelTitleBar.Width - 220, 32); // Adjust the X position as needed

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                closeBtn.Location = minimizedCloseBtnLocation;
                minimizeBtn.Location = minimizedMinimizeBtnLocation;
                btnMaximizeRestore.Location = minimizedMaximizeRestoreBtnLocation;
            }
        }

        private int GetFormSize(FormSize formSize)
        {
            // Get the current size of the form  
            Size size = this.Size;
            return formSize == FormSize.Width ? size.Width : size.Height;
        }

    }
}
