
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FontAwesome;

namespace Reproductor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limipiarColaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Playlist = new System.Windows.Forms.Label();
            this.Lista_Reproduccion = new System.Windows.Forms.ListBox();
            this.PpButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(5, 34);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(393, 285);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carpetaToolStripMenuItem,
            this.seleccionarToolStripMenuItem,
            this.limipiarColaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.abrirToolStripMenuItem.Text = "Archivos";
            // 
            // carpetaToolStripMenuItem
            // 
            this.carpetaToolStripMenuItem.Name = "carpetaToolStripMenuItem";
            this.carpetaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.carpetaToolStripMenuItem.Text = "Abrir carpeta";
            this.carpetaToolStripMenuItem.Click += new System.EventHandler(this.carpetaToolStripMenuItem_Click);
            // 
            // seleccionarToolStripMenuItem
            // 
            this.seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            this.seleccionarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.seleccionarToolStripMenuItem.Text = "Seleccionar archivos";
            this.seleccionarToolStripMenuItem.Click += new System.EventHandler(this.seleccionarToolStripMenuItem_Click);
            // 
            // limipiarColaToolStripMenuItem
            // 
            this.limipiarColaToolStripMenuItem.Name = "limipiarColaToolStripMenuItem";
            this.limipiarColaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.limipiarColaToolStripMenuItem.Text = "Limipiar Cola";
            this.limipiarColaToolStripMenuItem.Click += new System.EventHandler(this.limipiarColaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Playlist
            // 
            this.Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Playlist.AutoSize = true;
            this.Playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Playlist.Location = new System.Drawing.Point(405, 34);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(63, 16);
            this.Playlist.TabIndex = 6;
            this.Playlist.Text = " Playlist";
            // 
            // Lista_Reproduccion
            // 
            this.Lista_Reproduccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lista_Reproduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lista_Reproduccion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_Reproduccion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Lista_Reproduccion.FormattingEnabled = true;
            this.Lista_Reproduccion.ItemHeight = 15;
            this.Lista_Reproduccion.Location = new System.Drawing.Point(405, 50);
            this.Lista_Reproduccion.Name = "Lista_Reproduccion";
            this.Lista_Reproduccion.Size = new System.Drawing.Size(260, 274);
            this.Lista_Reproduccion.TabIndex = 7;
            this.Lista_Reproduccion.SelectedIndexChanged += new System.EventHandler(this.Lista_Reproduccion_SelectedIndexChanged);
            // 
            // PpButton
            // 
            this.PpButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PpButton.Location = new System.Drawing.Point(52, 325);
            this.PpButton.Name = "PpButton";
            this.PpButton.Size = new System.Drawing.Size(70, 20);
            this.PpButton.TabIndex = 8;
            this.PpButton.Text = "Play/Pause";
            this.PpButton.UseVisualStyleBackColor = true;
            this.PpButton.Click += new System.EventHandler(this.PpButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StopButton.Location = new System.Drawing.Point(128, 325);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(61, 21);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = " Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextButton.Location = new System.Drawing.Point(265, 325);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(64, 21);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = " Siguiente";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PrevButton.Location = new System.Drawing.Point(195, 325);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(64, 21);
            this.PrevButton.TabIndex = 11;
            this.PrevButton.Text = " Anterior";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 355);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PpButton);
            this.Controls.Add(this.Lista_Reproduccion);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limipiarColaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label Playlist;
        private System.Windows.Forms.ListBox Lista_Reproduccion;
        private System.Windows.Forms.Button PpButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
    }
}

