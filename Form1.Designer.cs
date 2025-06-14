namespace Triangle
{
    partial class form
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.La = new System.Windows.Forms.Label();
            this.Lb = new System.Windows.Forms.Label();
            this.Lc = new System.Windows.Forms.Label();
            this.perimetr = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triangleToolStripMenuItem,
            this.operationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.triangleToolStripMenuItem.Text = "Triangle";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.Generate);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(409, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Triangle";
            // 
            // a
            // 
            this.a.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a.Location = new System.Drawing.Point(85, 18);
            this.a.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(68, 33);
            this.a.TabIndex = 2;
            this.a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(36, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Generate);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.c);
            this.panel1.Controls.Add(this.b);
            this.panel1.Controls.Add(this.a);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 243);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(30, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "C =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(30, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "B =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "A =";
            // 
            // c
            // 
            this.c.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c.Location = new System.Drawing.Point(85, 96);
            this.c.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(68, 33);
            this.c.TabIndex = 2;
            this.c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b.Location = new System.Drawing.Point(85, 57);
            this.b.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(68, 33);
            this.b.TabIndex = 2;
            this.b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // La
            // 
            this.La.AutoSize = true;
            this.La.Font = new System.Drawing.Font("Roboto Cn", 20.25F);
            this.La.Location = new System.Drawing.Point(353, 227);
            this.La.Name = "La";
            this.La.Size = new System.Drawing.Size(29, 33);
            this.La.TabIndex = 5;
            this.La.Text = "0";
            // 
            // Lb
            // 
            this.Lb.AutoSize = true;
            this.Lb.Font = new System.Drawing.Font("Roboto Cn", 20.25F);
            this.Lb.Location = new System.Drawing.Point(563, 227);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(29, 33);
            this.Lb.TabIndex = 5;
            this.Lb.Text = "0";
            // 
            // Lc
            // 
            this.Lc.AutoSize = true;
            this.Lc.Font = new System.Drawing.Font("Roboto Cn", 20.25F);
            this.Lc.Location = new System.Drawing.Point(456, 418);
            this.Lc.Name = "Lc";
            this.Lc.Size = new System.Drawing.Size(29, 33);
            this.Lc.TabIndex = 5;
            this.Lc.Text = "0";
            // 
            // perimetr
            // 
            this.perimetr.AutoSize = true;
            this.perimetr.Font = new System.Drawing.Font("Roboto Cn", 20.25F);
            this.perimetr.Location = new System.Drawing.Point(739, 143);
            this.perimetr.Name = "perimetr";
            this.perimetr.Size = new System.Drawing.Size(69, 33);
            this.perimetr.TabIndex = 6;
            this.perimetr.Text = "P = 0";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Font = new System.Drawing.Font("Roboto Cn", 20.25F);
            this.area.Location = new System.Drawing.Point(739, 182);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(69, 33);
            this.area.TabIndex = 6;
            this.area.Text = "A = 0";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Roboto Cn", 20.25F);
            this.type.Location = new System.Drawing.Point(672, 227);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(225, 33);
            this.type.TabIndex = 7;
            this.type.Text = "Type";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.type);
            this.Controls.Add(this.area);
            this.Controls.Add(this.perimetr);
            this.Controls.Add(this.Lb);
            this.Controls.Add(this.Lc);
            this.Controls.Add(this.La);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown a;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown c;
        private System.Windows.Forms.NumericUpDown b;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label La;
        private System.Windows.Forms.Label Lb;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.Label Lc;
        private System.Windows.Forms.Label perimetr;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label type;
    }
}

