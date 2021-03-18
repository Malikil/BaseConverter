namespace BaseConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceNumber = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toBase = new System.Windows.Forms.NumericUpDown();
            this.fromBase = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromBase)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceNumber
            // 
            this.sourceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceNumber.Location = new System.Drawing.Point(3, 23);
            this.sourceNumber.Name = "sourceNumber";
            this.sourceNumber.Size = new System.Drawing.Size(160, 22);
            this.sourceNumber.TabIndex = 0;
            this.sourceNumber.TextChanged += new System.EventHandler(this.CalculateResult);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Location = new System.Drawing.Point(169, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(160, 68);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toBase, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sourceNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fromBase, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 153);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // toBase
            // 
            this.toBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toBase.Location = new System.Drawing.Point(169, 108);
            this.toBase.Maximum = new decimal(new int[] {
            62,
            0,
            0,
            0});
            this.toBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.toBase.Name = "toBase";
            this.toBase.Size = new System.Drawing.Size(160, 22);
            this.toBase.TabIndex = 3;
            this.toBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.toBase.ValueChanged += new System.EventHandler(this.CalculateResult);
            // 
            // fromBase
            // 
            this.fromBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fromBase.Location = new System.Drawing.Point(3, 108);
            this.fromBase.Maximum = new decimal(new int[] {
            62,
            0,
            0,
            0});
            this.fromBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fromBase.Name = "fromBase";
            this.fromBase.Size = new System.Drawing.Size(160, 22);
            this.fromBase.TabIndex = 2;
            this.fromBase.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fromBase.ValueChanged += new System.EventHandler(this.CalculateResult);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From base:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(169, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "To base:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 153);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sourceNumber;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown toBase;
        private System.Windows.Forms.NumericUpDown fromBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}