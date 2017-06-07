namespace MainForm
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leagueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabPlayer = new System.Windows.Forms.TabPage();
            this.tabLeague = new System.Windows.Forms.TabPage();
            this.initLeagueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelLeagueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.tabMainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.playersMenuItem,
            this.leagueMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1282, 27);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(65, 23);
            this.fileMenuItem.Text = "Fichero";
            // 
            // playersMenuItem
            // 
            this.playersMenuItem.Name = "playersMenuItem";
            this.playersMenuItem.Size = new System.Drawing.Size(83, 23);
            this.playersMenuItem.Text = "Jugadores";
            // 
            // leagueMenuItem
            // 
            this.leagueMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initLeagueMenuItem,
            this.cancelLeagueMenuItem});
            this.leagueMenuItem.Name = "leagueMenuItem";
            this.leagueMenuItem.Size = new System.Drawing.Size(46, 23);
            this.leagueMenuItem.Text = "Liga";
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabPlayer);
            this.tabMainControl.Controls.Add(this.tabLeague);
            this.tabMainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainControl.Enabled = false;
            this.tabMainControl.Location = new System.Drawing.Point(0, 27);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(1282, 726);
            this.tabMainControl.TabIndex = 1;
            // 
            // tabPlayer
            // 
            this.tabPlayer.Location = new System.Drawing.Point(4, 25);
            this.tabPlayer.Name = "tabPlayer";
            this.tabPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayer.Size = new System.Drawing.Size(1274, 697);
            this.tabPlayer.TabIndex = 0;
            this.tabPlayer.Text = "Jugadores";
            this.tabPlayer.UseVisualStyleBackColor = true;
            // 
            // tabLeague
            // 
            this.tabLeague.Location = new System.Drawing.Point(4, 25);
            this.tabLeague.Name = "tabLeague";
            this.tabLeague.Padding = new System.Windows.Forms.Padding(3);
            this.tabLeague.Size = new System.Drawing.Size(1274, 697);
            this.tabLeague.TabIndex = 1;
            this.tabLeague.Text = "Liga";
            this.tabLeague.UseVisualStyleBackColor = true;
            // 
            // initLeagueMenuItem
            // 
            this.initLeagueMenuItem.Name = "initLeagueMenuItem";
            this.initLeagueMenuItem.Size = new System.Drawing.Size(181, 26);
            this.initLeagueMenuItem.Text = "Iniciar liga";
            // 
            // cancelLeagueMenuItem
            // 
            this.cancelLeagueMenuItem.Name = "cancelLeagueMenuItem";
            this.cancelLeagueMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cancelLeagueMenuItem.Text = "Cancelar liga";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.tabMainControl);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "mainForm";
            this.Text = "Ping Pong";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabMainControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leagueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initLeagueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelLeagueMenuItem;
        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabPlayer;
        private System.Windows.Forms.TabPage tabLeague;
    }
}

