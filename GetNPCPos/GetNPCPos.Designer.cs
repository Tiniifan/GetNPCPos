
namespace GetNPCPos
{
    partial class GetNPCPos
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.minimapPictureBox = new System.Windows.Forms.PictureBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMapPositionX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMapPositionY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownNPCPositionY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownNPCPositionX = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonDeleteCurrentPoint = new System.Windows.Forms.Button();
            this.buttonDeleteAllPoint = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.minimapPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCPositionX)).BeginInit();
            this.SuspendLayout();
            // 
            // minimapPictureBox
            // 
            this.minimapPictureBox.Location = new System.Drawing.Point(12, 54);
            this.minimapPictureBox.Name = "minimapPictureBox";
            this.minimapPictureBox.Size = new System.Drawing.Size(512, 512);
            this.minimapPictureBox.TabIndex = 1;
            this.minimapPictureBox.TabStop = false;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(229, 32);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(35, 13);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // numericUpDownMapPositionX
            // 
            this.numericUpDownMapPositionX.DecimalPlaces = 2;
            this.numericUpDownMapPositionX.Enabled = false;
            this.numericUpDownMapPositionX.Location = new System.Drawing.Point(592, 88);
            this.numericUpDownMapPositionX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownMapPositionX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDownMapPositionX.Name = "numericUpDownMapPositionX";
            this.numericUpDownMapPositionX.ReadOnly = true;
            this.numericUpDownMapPositionX.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownMapPositionX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Map Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y";
            this.label4.Visible = false;
            // 
            // numericUpDownMapPositionY
            // 
            this.numericUpDownMapPositionY.DecimalPlaces = 2;
            this.numericUpDownMapPositionY.Enabled = false;
            this.numericUpDownMapPositionY.Location = new System.Drawing.Point(592, 114);
            this.numericUpDownMapPositionY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownMapPositionY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDownMapPositionY.Name = "numericUpDownMapPositionY";
            this.numericUpDownMapPositionY.ReadOnly = true;
            this.numericUpDownMapPositionY.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownMapPositionY.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y";
            this.label5.Visible = false;
            // 
            // numericUpDownNPCPositionY
            // 
            this.numericUpDownNPCPositionY.DecimalPlaces = 2;
            this.numericUpDownNPCPositionY.Enabled = false;
            this.numericUpDownNPCPositionY.Location = new System.Drawing.Point(592, 228);
            this.numericUpDownNPCPositionY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownNPCPositionY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDownNPCPositionY.Name = "numericUpDownNPCPositionY";
            this.numericUpDownNPCPositionY.ReadOnly = true;
            this.numericUpDownNPCPositionY.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownNPCPositionY.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "NPC Position";
            // 
            // numericUpDownNPCPositionX
            // 
            this.numericUpDownNPCPositionX.DecimalPlaces = 2;
            this.numericUpDownNPCPositionX.Enabled = false;
            this.numericUpDownNPCPositionX.Location = new System.Drawing.Point(592, 202);
            this.numericUpDownNPCPositionX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownNPCPositionX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDownNPCPositionX.Name = "numericUpDownNPCPositionX";
            this.numericUpDownNPCPositionX.ReadOnly = true;
            this.numericUpDownNPCPositionX.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownNPCPositionX.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(541, 266);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(161, 236);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // buttonDeleteCurrentPoint
            // 
            this.buttonDeleteCurrentPoint.Location = new System.Drawing.Point(541, 512);
            this.buttonDeleteCurrentPoint.Name = "buttonDeleteCurrentPoint";
            this.buttonDeleteCurrentPoint.Size = new System.Drawing.Size(161, 23);
            this.buttonDeleteCurrentPoint.TabIndex = 14;
            this.buttonDeleteCurrentPoint.Text = "Delete Current Point";
            this.buttonDeleteCurrentPoint.UseVisualStyleBackColor = true;
            this.buttonDeleteCurrentPoint.Click += new System.EventHandler(this.ButtonDeleteCurrentPoint_Click);
            // 
            // buttonDeleteAllPoint
            // 
            this.buttonDeleteAllPoint.Location = new System.Drawing.Point(541, 541);
            this.buttonDeleteAllPoint.Name = "buttonDeleteAllPoint";
            this.buttonDeleteAllPoint.Size = new System.Drawing.Size(161, 23);
            this.buttonDeleteAllPoint.TabIndex = 15;
            this.buttonDeleteAllPoint.Text = "Delete All points";
            this.buttonDeleteAllPoint.UseVisualStyleBackColor = true;
            this.buttonDeleteAllPoint.Click += new System.EventHandler(this.ButtonDeleteAllPoint_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Point";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Position";
            this.columnHeader2.Width = 100;
            // 
            // GetNPCPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 577);
            this.Controls.Add(this.buttonDeleteAllPoint);
            this.Controls.Add(this.buttonDeleteCurrentPoint);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownNPCPositionY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownNPCPositionX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownMapPositionY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownMapPositionX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GetNPCPos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minimapPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCPositionX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox minimapPictureBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMapPositionX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMapPositionY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownNPCPositionY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownNPCPositionX;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonDeleteCurrentPoint;
        private System.Windows.Forms.Button buttonDeleteAllPoint;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

