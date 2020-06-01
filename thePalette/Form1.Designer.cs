namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.greenLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.curRed = new System.Windows.Forms.Label();
            this.curGreen = new System.Windows.Forms.Label();
            this.curBlue = new System.Windows.Forms.Label();
            this.minRed = new System.Windows.Forms.Label();
            this.maxRed = new System.Windows.Forms.Label();
            this.minGreen = new System.Windows.Forms.Label();
            this.minBlue = new System.Windows.Forms.Label();
            this.maxGreen = new System.Windows.Forms.Label();
            this.maxBlue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.redBar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.canvas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.blueLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.greenBar, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.greenLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.redLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.blueBar, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.curRed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.curGreen, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.curBlue, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.minRed, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.maxRed, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.minGreen, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.minBlue, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.maxGreen, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.maxBlue, 3, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.43128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.43128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.43128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.951028F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 361);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // redBar
            // 
            this.redBar.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.redBar, 2);
            this.redBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redBar.Location = new System.Drawing.Point(229, 38);
            this.redBar.Maximum = 255;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(221, 42);
            this.redBar.TabIndex = 0;
            this.redBar.Tag = "";
            this.redBar.TickFrequency = 15;
            this.redBar.Value = 125;
            this.redBar.Scroll += new System.EventHandler(this.RedBar_Scroll);
            // 
            // canvas
            // 
            this.canvas.Cursor = System.Windows.Forms.Cursors.Default;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(3, 3);
            this.canvas.Name = "canvas";
            this.tableLayoutPanel1.SetRowSpan(this.canvas, 9);
            this.canvas.Size = new System.Drawing.Size(175, 355);
            this.canvas.TabIndex = 4;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.PictureBox1_Click);
            this.canvas.MouseHover += new System.EventHandler(this.Canvas_MouseHover);
            // 
            // blueLabel
            // 
            this.blueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(189, 288);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(28, 13);
            this.blueLabel.TabIndex = 8;
            this.blueLabel.Text = "Blue";
            // 
            // greenBar
            // 
            this.greenBar.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.greenBar, 2);
            this.greenBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenBar.Location = new System.Drawing.Point(229, 156);
            this.greenBar.Maximum = 255;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(221, 42);
            this.greenBar.TabIndex = 2;
            this.greenBar.Tag = "";
            this.greenBar.TickFrequency = 15;
            this.greenBar.Value = 125;
            this.greenBar.Scroll += new System.EventHandler(this.GreenBar_Scroll);
            // 
            // greenLabel
            // 
            this.greenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(185, 170);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(36, 13);
            this.greenLabel.TabIndex = 7;
            this.greenLabel.Text = "Green";
            // 
            // redLabel
            // 
            this.redLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(190, 52);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(27, 13);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "Red";
            // 
            // blueBar
            // 
            this.blueBar.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.blueBar, 2);
            this.blueBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueBar.Location = new System.Drawing.Point(229, 274);
            this.blueBar.Maximum = 255;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(221, 42);
            this.blueBar.TabIndex = 3;
            this.blueBar.Tag = "";
            this.blueBar.TickFrequency = 15;
            this.blueBar.Value = 125;
            this.blueBar.Scroll += new System.EventHandler(this.BlueBar_Scroll);
            // 
            // curRed
            // 
            this.curRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.curRed.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.curRed, 2);
            this.curRed.Location = new System.Drawing.Point(327, 11);
            this.curRed.Name = "curRed";
            this.curRed.Size = new System.Drawing.Size(25, 13);
            this.curRed.TabIndex = 9;
            this.curRed.Text = "125";
            // 
            // curGreen
            // 
            this.curGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.curGreen.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.curGreen, 2);
            this.curGreen.Location = new System.Drawing.Point(327, 129);
            this.curGreen.Name = "curGreen";
            this.curGreen.Size = new System.Drawing.Size(25, 13);
            this.curGreen.TabIndex = 10;
            this.curGreen.Text = "125";
            // 
            // curBlue
            // 
            this.curBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.curBlue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.curBlue, 2);
            this.curBlue.Location = new System.Drawing.Point(327, 247);
            this.curBlue.Name = "curBlue";
            this.curBlue.Size = new System.Drawing.Size(25, 13);
            this.curBlue.TabIndex = 11;
            this.curBlue.Text = "125";
            // 
            // minRed
            // 
            this.minRed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minRed.AutoSize = true;
            this.minRed.Location = new System.Drawing.Point(229, 94);
            this.minRed.Name = "minRed";
            this.minRed.Size = new System.Drawing.Size(13, 13);
            this.minRed.TabIndex = 12;
            this.minRed.Text = "0";
            // 
            // maxRed
            // 
            this.maxRed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maxRed.AutoSize = true;
            this.maxRed.Location = new System.Drawing.Point(425, 94);
            this.maxRed.Name = "maxRed";
            this.maxRed.Size = new System.Drawing.Size(25, 13);
            this.maxRed.TabIndex = 13;
            this.maxRed.Text = "255";
            this.maxRed.Click += new System.EventHandler(this.Label_RedMaxValue_Click);
            // 
            // minGreen
            // 
            this.minGreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minGreen.AutoSize = true;
            this.minGreen.Location = new System.Drawing.Point(229, 212);
            this.minGreen.Name = "minGreen";
            this.minGreen.Size = new System.Drawing.Size(13, 13);
            this.minGreen.TabIndex = 14;
            this.minGreen.Text = "0";
            // 
            // minBlue
            // 
            this.minBlue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minBlue.AutoSize = true;
            this.minBlue.Location = new System.Drawing.Point(229, 333);
            this.minBlue.Name = "minBlue";
            this.minBlue.Size = new System.Drawing.Size(13, 13);
            this.minBlue.TabIndex = 15;
            this.minBlue.Text = "0";
            // 
            // maxGreen
            // 
            this.maxGreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maxGreen.AutoSize = true;
            this.maxGreen.Location = new System.Drawing.Point(425, 212);
            this.maxGreen.Name = "maxGreen";
            this.maxGreen.Size = new System.Drawing.Size(25, 13);
            this.maxGreen.TabIndex = 16;
            this.maxGreen.Text = "255";
            // 
            // maxBlue
            // 
            this.maxBlue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maxBlue.AutoSize = true;
            this.maxBlue.Location = new System.Drawing.Point(425, 333);
            this.maxBlue.Name = "maxBlue";
            this.maxBlue.Size = new System.Drawing.Size(25, 13);
            this.maxBlue.TabIndex = 17;
            this.maxBlue.Text = "255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.Label curRed;
        private System.Windows.Forms.Label curGreen;
        private System.Windows.Forms.Label curBlue;
        private System.Windows.Forms.Label minRed;
        private System.Windows.Forms.Label maxRed;
        private System.Windows.Forms.Label minGreen;
        private System.Windows.Forms.Label minBlue;
        private System.Windows.Forms.Label maxGreen;
        private System.Windows.Forms.Label maxBlue;
    }
}

