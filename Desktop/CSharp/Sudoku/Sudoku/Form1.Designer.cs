namespace Sudoku
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.NumericUpDown();
            this.n2 = new System.Windows.Forms.NumericUpDown();
            this.n3 = new System.Windows.Forms.NumericUpDown();
            this.n4 = new System.Windows.Forms.NumericUpDown();
            this.n5 = new System.Windows.Forms.NumericUpDown();
            this.n6 = new System.Windows.Forms.NumericUpDown();
            this.n7 = new System.Windows.Forms.NumericUpDown();
            this.n8 = new System.Windows.Forms.NumericUpDown();
            this.n9 = new System.Windows.Forms.NumericUpDown();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(325, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sudoku";
            // 
            // n1
            // 
            this.n1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.n1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.n1.Location = new System.Drawing.Point(112, 151);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(60, 20);
            this.n1.TabIndex = 1;
            this.n1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // n2
            // 
            this.n2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.n2.Location = new System.Drawing.Point(367, 151);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(60, 20);
            this.n2.TabIndex = 2;
            this.n2.Tag = "n2";
            this.n2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // n3
            // 
            this.n3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.n3.Location = new System.Drawing.Point(579, 151);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(60, 20);
            this.n3.TabIndex = 3;
            this.n3.Tag = "n3";
            this.n3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // n4
            // 
            this.n4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.n4.Location = new System.Drawing.Point(112, 219);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(60, 20);
            this.n4.TabIndex = 4;
            this.n4.Tag = "n4";
            this.n4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // n5
            // 
            this.n5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.n5.Location = new System.Drawing.Point(367, 219);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(60, 20);
            this.n5.TabIndex = 5;
            this.n5.Tag = "n5";
            this.n5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // n6
            // 
            this.n6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.n6.Location = new System.Drawing.Point(579, 219);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(60, 20);
            this.n6.TabIndex = 6;
            this.n6.Tag = "n6";
            this.n6.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // n7
            // 
            this.n7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.n7.Location = new System.Drawing.Point(112, 284);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(60, 20);
            this.n7.TabIndex = 7;
            this.n7.Tag = "n7";
            this.n7.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // n8
            // 
            this.n8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.n8.Location = new System.Drawing.Point(367, 300);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(60, 20);
            this.n8.TabIndex = 8;
            this.n8.Tag = "n8";
            this.n8.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // n9
            // 
            this.n9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.n9.Location = new System.Drawing.Point(579, 300);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(60, 20);
            this.n9.TabIndex = 9;
            this.n9.Tag = "n9";
            this.n9.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // Clear
            // 
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Clear.Location = new System.Drawing.Point(345, 355);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(104, 36);
            this.Clear.TabIndex = 11;
            this.Clear.Tag = "Clear";
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sudoku Game";
            ((System.ComponentModel.ISupportInitialize)(this.n1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown n1;
        private System.Windows.Forms.NumericUpDown n2;
        private System.Windows.Forms.NumericUpDown n3;
        private System.Windows.Forms.NumericUpDown n4;
        private System.Windows.Forms.NumericUpDown n5;
        private System.Windows.Forms.NumericUpDown n6;
        private System.Windows.Forms.NumericUpDown n7;
        private System.Windows.Forms.NumericUpDown n8;
        private System.Windows.Forms.NumericUpDown n9;
        private System.Windows.Forms.Button Clear;
    }
}

