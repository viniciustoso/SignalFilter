namespace SignalFilter
{
    partial class Form1
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.lowPassFilterField = new System.Windows.Forms.NumericUpDown();
            this.lowPassFilterBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highPassFilterBar = new System.Windows.Forms.TrackBar();
            this.highPassFilterField = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.lowPassFilterField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowPassFilterBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highPassFilterBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highPassFilterField)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(218, 27);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(369, 572);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // lowPassFilterField
            // 
            this.lowPassFilterField.Location = new System.Drawing.Point(69, 111);
            this.lowPassFilterField.Name = "lowPassFilterField";
            this.lowPassFilterField.Size = new System.Drawing.Size(53, 20);
            this.lowPassFilterField.TabIndex = 1;
            this.lowPassFilterField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lowPassFilterField.ValueChanged += new System.EventHandler(this.FilterField_ValueChanged);
            // 
            // lowPassFilterBar
            // 
            this.lowPassFilterBar.Location = new System.Drawing.Point(12, 137);
            this.lowPassFilterBar.Maximum = 100;
            this.lowPassFilterBar.Name = "lowPassFilterBar";
            this.lowPassFilterBar.Size = new System.Drawing.Size(190, 45);
            this.lowPassFilterBar.TabIndex = 2;
            this.lowPassFilterBar.Scroll += new System.EventHandler(this.FilterBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Low pass filter cutoff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "High pass filter cutoff";
            // 
            // highPassFilterBar
            // 
            this.highPassFilterBar.Location = new System.Drawing.Point(12, 267);
            this.highPassFilterBar.Maximum = 100;
            this.highPassFilterBar.Name = "highPassFilterBar";
            this.highPassFilterBar.Size = new System.Drawing.Size(190, 45);
            this.highPassFilterBar.TabIndex = 6;
            this.highPassFilterBar.Scroll += new System.EventHandler(this.FilterBar_Scroll);
            // 
            // highPassFilterField
            // 
            this.highPassFilterField.Location = new System.Drawing.Point(69, 241);
            this.highPassFilterField.Name = "highPassFilterField";
            this.highPassFilterField.Size = new System.Drawing.Size(53, 20);
            this.highPassFilterField.TabIndex = 5;
            this.highPassFilterField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.highPassFilterField.ValueChanged += new System.EventHandler(this.FilterField_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Arquivo";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.openToolStripMenuItem.Text = "Abrir...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.saveAsToolStripMenuItem.Text = "Salvar Como...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "db.txt";
            this.openFileDialog1.Filter = "Documentos de texto|*.txt";
            this.openFileDialog1.InitialDirectory = "C:\\";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "db";
            this.saveFileDialog1.Filter = "Documentos de texto|*.txt";
            this.saveFileDialog1.InitialDirectory = "C:\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 611);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.highPassFilterBar);
            this.Controls.Add(this.highPassFilterField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lowPassFilterBar);
            this.Controls.Add(this.lowPassFilterField);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Filtragem de sinal";
            ((System.ComponentModel.ISupportInitialize)(this.lowPassFilterField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowPassFilterBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highPassFilterBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highPassFilterField)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.NumericUpDown lowPassFilterField;
        private System.Windows.Forms.TrackBar lowPassFilterBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar highPassFilterBar;
        private System.Windows.Forms.NumericUpDown highPassFilterField;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

