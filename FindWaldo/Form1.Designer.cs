    namespace FindWaldo
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
            this.components = new System.ComponentModel.Container();
            this.gpo_Info = new System.Windows.Forms.GroupBox();
            this.txt_Mode = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.pct_Image = new System.Windows.Forms.PictureBox();
            this.gpo_Info.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // gpo_Info
            // 
            this.gpo_Info.Controls.Add(this.txt_Mode);
            this.gpo_Info.Controls.Add(this.btn_Start);
            this.gpo_Info.Controls.Add(this.txt_Time);
            this.gpo_Info.Controls.Add(this.txt_Name);
            this.gpo_Info.Controls.Add(this.lbl_Time);
            this.gpo_Info.Controls.Add(this.lbl_Mode);
            this.gpo_Info.Controls.Add(this.lbl_Name);
            this.gpo_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpo_Info.Location = new System.Drawing.Point(786, 27);
            this.gpo_Info.Name = "gpo_Info";
            this.gpo_Info.Size = new System.Drawing.Size(200, 180);
            this.gpo_Info.TabIndex = 2;
            this.gpo_Info.TabStop = false;
            this.gpo_Info.Text = "Player Info";
            // 
            // txt_Mode
            // 
            this.txt_Mode.Enabled = false;
            this.txt_Mode.Location = new System.Drawing.Point(70, 77);
            this.txt_Mode.Name = "txt_Mode";
            this.txt_Mode.Size = new System.Drawing.Size(121, 26);
            this.txt_Mode.TabIndex = 6;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(10, 148);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(182, 26);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txt_Time
            // 
            this.txt_Time.Enabled = false;
            this.txt_Time.Location = new System.Drawing.Point(71, 118);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(121, 26);
            this.txt_Time.TabIndex = 5;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(71, 37);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(121, 26);
            this.txt_Name.TabIndex = 4;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(6, 118);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(52, 20);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "Time:";
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.AutoSize = true;
            this.lbl_Mode.Location = new System.Drawing.Point(6, 77);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(58, 20);
            this.lbl_Mode.TabIndex = 1;
            this.lbl_Mode.Text = "Mode:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(6, 37);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(65, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.juegoToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // gameTime
            // 
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // pct_Image
            // 
            this.pct_Image.Enabled = false;
            this.pct_Image.Image = global::FindWaldo.Properties.Resources._0;
            this.pct_Image.Location = new System.Drawing.Point(12, 27);
            this.pct_Image.Name = "pct_Image";
            this.pct_Image.Size = new System.Drawing.Size(768, 495);
            this.pct_Image.TabIndex = 1;
            this.pct_Image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 526);
            this.Controls.Add(this.gpo_Info);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pct_Image);
            this.Name = "Form1";
            this.Text = "Find Waldo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.gpo_Info.ResumeLayout(false);
            this.gpo_Info.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_Image;
        private System.Windows.Forms.GroupBox gpo_Info;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.TextBox txt_Mode;
    }
}

