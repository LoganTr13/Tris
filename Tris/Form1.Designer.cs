namespace Tris
{
    partial class Tris
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tris));
            this.cpbCPU = new CircularProgressBar.CircularProgressBar();
            this.cpbRAM = new CircularProgressBar.CircularProgressBar();
            this.cpbDISK = new CircularProgressBar.CircularProgressBar();
            this.pnApps = new System.Windows.Forms.Panel();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.btnCima = new System.Windows.Forms.Button();
            this.btnTimers = new System.Windows.Forms.Button();
            this.btnMusics = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblDisk = new System.Windows.Forms.Label();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.ForSecond_Performance = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pboxModeDark = new System.Windows.Forms.PictureBox();
            this.pnFunctions = new System.Windows.Forms.Panel();
            this.pDisk = new System.Diagnostics.PerformanceCounter();
            this.pnApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxModeDark)).BeginInit();
            this.pnFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).BeginInit();
            this.SuspendLayout();
            // 
            // cpbCPU
            // 
            this.cpbCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCPU.AnimationSpeed = 500;
            this.cpbCPU.BackColor = System.Drawing.Color.Transparent;
            this.cpbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cpbCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(185)))), ((int)(((byte)(250)))));
            this.cpbCPU.InnerColor = System.Drawing.Color.Transparent;
            this.cpbCPU.InnerMargin = 2;
            this.cpbCPU.InnerWidth = -1;
            this.cpbCPU.Location = new System.Drawing.Point(43, 54);
            this.cpbCPU.MarqueeAnimationSpeed = 1000;
            this.cpbCPU.Name = "cpbCPU";
            this.cpbCPU.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.cpbCPU.OuterMargin = -25;
            this.cpbCPU.OuterWidth = 26;
            this.cpbCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.cpbCPU.ProgressWidth = 25;
            this.cpbCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.cpbCPU.Size = new System.Drawing.Size(138, 138);
            this.cpbCPU.StartAngle = 270;
            this.cpbCPU.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbCPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbCPU.SubscriptText = "";
            this.cpbCPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbCPU.SuperscriptText = "";
            this.cpbCPU.TabIndex = 0;
            this.cpbCPU.Text = "00 %";
            this.cpbCPU.TextMargin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.cpbCPU.Value = 50;
            // 
            // cpbRAM
            // 
            this.cpbRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbRAM.AnimationSpeed = 500;
            this.cpbRAM.BackColor = System.Drawing.Color.Transparent;
            this.cpbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cpbRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(185)))), ((int)(((byte)(250)))));
            this.cpbRAM.InnerColor = System.Drawing.Color.Transparent;
            this.cpbRAM.InnerMargin = 2;
            this.cpbRAM.InnerWidth = -1;
            this.cpbRAM.Location = new System.Drawing.Point(219, 54);
            this.cpbRAM.MarqueeAnimationSpeed = 2000;
            this.cpbRAM.Name = "cpbRAM";
            this.cpbRAM.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.cpbRAM.OuterMargin = -25;
            this.cpbRAM.OuterWidth = 26;
            this.cpbRAM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.cpbRAM.ProgressWidth = 25;
            this.cpbRAM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.cpbRAM.Size = new System.Drawing.Size(138, 138);
            this.cpbRAM.StartAngle = 270;
            this.cpbRAM.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbRAM.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbRAM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbRAM.SubscriptText = "";
            this.cpbRAM.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbRAM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbRAM.SuperscriptText = "";
            this.cpbRAM.TabIndex = 1;
            this.cpbRAM.Text = "00 %";
            this.cpbRAM.TextMargin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.cpbRAM.Value = 68;
            // 
            // cpbDISK
            // 
            this.cpbDISK.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbDISK.AnimationSpeed = 500;
            this.cpbDISK.BackColor = System.Drawing.Color.Transparent;
            this.cpbDISK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cpbDISK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(185)))), ((int)(((byte)(250)))));
            this.cpbDISK.InnerColor = System.Drawing.Color.Transparent;
            this.cpbDISK.InnerMargin = 2;
            this.cpbDISK.InnerWidth = -1;
            this.cpbDISK.Location = new System.Drawing.Point(396, 54);
            this.cpbDISK.MarqueeAnimationSpeed = 2000;
            this.cpbDISK.Name = "cpbDISK";
            this.cpbDISK.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.cpbDISK.OuterMargin = -25;
            this.cpbDISK.OuterWidth = 26;
            this.cpbDISK.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.cpbDISK.ProgressWidth = 25;
            this.cpbDISK.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.cpbDISK.Size = new System.Drawing.Size(138, 138);
            this.cpbDISK.StartAngle = 270;
            this.cpbDISK.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbDISK.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbDISK.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbDISK.SubscriptText = "";
            this.cpbDISK.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbDISK.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbDISK.SuperscriptText = "";
            this.cpbDISK.TabIndex = 2;
            this.cpbDISK.Text = "00 GB";
            this.cpbDISK.TextMargin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.cpbDISK.Value = 68;
            // 
            // pnApps
            // 
            this.pnApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pnApps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnApps.Controls.Add(this.btnBaixo);
            this.pnApps.Controls.Add(this.btnCima);
            this.pnApps.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pnApps.Location = new System.Drawing.Point(587, -1);
            this.pnApps.Name = "pnApps";
            this.pnApps.Size = new System.Drawing.Size(99, 375);
            this.pnApps.TabIndex = 3;
            // 
            // btnBaixo
            // 
            this.btnBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBaixo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixo.Font = new System.Drawing.Font("Lucida Bright", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBaixo.Location = new System.Drawing.Point(0, 351);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(99, 24);
            this.btnBaixo.TabIndex = 10;
            this.btnBaixo.Text = "˅";
            this.btnBaixo.UseVisualStyleBackColor = false;
            // 
            // btnCima
            // 
            this.btnCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCima.Font = new System.Drawing.Font("Lucida Bright", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCima.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCima.Location = new System.Drawing.Point(0, 0);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(99, 24);
            this.btnCima.TabIndex = 9;
            this.btnCima.Text = "˄";
            this.btnCima.UseVisualStyleBackColor = false;
            // 
            // btnTimers
            // 
            this.btnTimers.BackColor = System.Drawing.Color.Transparent;
            this.btnTimers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimers.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimers.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimers.Location = new System.Drawing.Point(43, 295);
            this.btnTimers.Name = "btnTimers";
            this.btnTimers.Size = new System.Drawing.Size(138, 39);
            this.btnTimers.TabIndex = 4;
            this.btnTimers.Text = "Timers";
            this.btnTimers.UseVisualStyleBackColor = false;
            // 
            // btnMusics
            // 
            this.btnMusics.BackColor = System.Drawing.Color.Transparent;
            this.btnMusics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusics.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusics.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnMusics.Location = new System.Drawing.Point(219, 295);
            this.btnMusics.Name = "btnMusics";
            this.btnMusics.Size = new System.Drawing.Size(138, 39);
            this.btnMusics.TabIndex = 5;
            this.btnMusics.Text = "Musics";
            this.btnMusics.UseVisualStyleBackColor = false;
            // 
            // btnNotas
            // 
            this.btnNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNotas.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnNotas.Location = new System.Drawing.Point(396, 295);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(138, 39);
            this.btnNotas.TabIndex = 6;
            this.btnNotas.Text = "Notas";
            this.btnNotas.UseVisualStyleBackColor = false;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Fugaz One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblCPU.Location = new System.Drawing.Point(76, 206);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(70, 39);
            this.lblCPU.TabIndex = 7;
            this.lblCPU.Text = "CPU";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Fugaz One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblRAM.Location = new System.Drawing.Point(254, 206);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(75, 39);
            this.lblRAM.TabIndex = 8;
            this.lblRAM.Text = "RAM";
            // 
            // lblDisk
            // 
            this.lblDisk.AutoSize = true;
            this.lblDisk.Font = new System.Drawing.Font("Fugaz One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblDisk.Location = new System.Drawing.Point(425, 206);
            this.lblDisk.Name = "lblDisk";
            this.lblDisk.Size = new System.Drawing.Size(79, 39);
            this.lblDisk.TabIndex = 9;
            this.lblDisk.Text = "DISK";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // ForSecond_Performance
            // 
            this.ForSecond_Performance.Enabled = true;
            this.ForSecond_Performance.Interval = 1000;
            this.ForSecond_Performance.Tick += new System.EventHandler(this.ForSecond_Performance_Tick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClose.Location = new System.Drawing.Point(563, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 22);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // pboxModeDark
            // 
            this.pboxModeDark.BackColor = System.Drawing.Color.Transparent;
            this.pboxModeDark.Image = ((System.Drawing.Image)(resources.GetObject("pboxModeDark.Image")));
            this.pboxModeDark.Location = new System.Drawing.Point(538, -1);
            this.pboxModeDark.Name = "pboxModeDark";
            this.pboxModeDark.Size = new System.Drawing.Size(26, 22);
            this.pboxModeDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxModeDark.TabIndex = 11;
            this.pboxModeDark.TabStop = false;
            this.pboxModeDark.Click += new System.EventHandler(this.ModoNoturno_Click);
            // 
            // pnFunctions
            // 
            this.pnFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.pnFunctions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnFunctions.Controls.Add(this.pboxModeDark);
            this.pnFunctions.Controls.Add(this.btnClose);
            this.pnFunctions.Location = new System.Drawing.Point(-2, 0);
            this.pnFunctions.Name = "pnFunctions";
            this.pnFunctions.Size = new System.Drawing.Size(589, 22);
            this.pnFunctions.TabIndex = 12;
            // 
            // pDisk
            // 
            this.pDisk.CategoryName = "LogicalDisk";
            this.pDisk.CounterName = "% Free Space";
            this.pDisk.InstanceName = "_Total";
            // 
            // Tris
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(686, 374);
            this.Controls.Add(this.pnFunctions);
            this.Controls.Add(this.lblDisk);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.btnMusics);
            this.Controls.Add(this.btnTimers);
            this.Controls.Add(this.pnApps);
            this.Controls.Add(this.cpbDISK);
            this.Controls.Add(this.cpbRAM);
            this.Controls.Add(this.cpbCPU);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tris";
            this.ShowIcon = false;
            this.Text = "Tris";
            this.pnApps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxModeDark)).EndInit();
            this.pnFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpbCPU;
        private CircularProgressBar.CircularProgressBar cpbRAM;
        private CircularProgressBar.CircularProgressBar cpbDISK;
        private System.Windows.Forms.Panel pnApps;
        private System.Windows.Forms.Button btnTimers;
        private System.Windows.Forms.Button btnMusics;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblDisk;
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnBaixo;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.Timer ForSecond_Performance;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pboxModeDark;
        private System.Windows.Forms.Panel pnFunctions;
        private System.Diagnostics.PerformanceCounter pDisk;
    }
}

