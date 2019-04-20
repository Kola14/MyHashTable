namespace MyHashTable
{
    partial class MainForm
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
            this.pnlResult = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbFoundSubsciber = new System.Windows.Forms.TextBox();
            this.nudPhoneNumber = new System.Windows.Forms.NumericUpDown();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbHashFunction = new System.Windows.Forms.GroupBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.rbParametersHash = new System.Windows.Forms.RadioButton();
            this.rbSimpleHash = new System.Windows.Forms.RadioButton();
            this.lblC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhoneNumber)).BeginInit();
            this.gbHashFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlResult
            // 
            this.pnlResult.BackColor = System.Drawing.Color.White;
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlResult.Location = new System.Drawing.Point(0, 0);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(1140, 704);
            this.pnlResult.TabIndex = 0;
            this.pnlResult.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResult_Paint);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1170, 308);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbFoundSubsciber
            // 
            this.tbFoundSubsciber.BackColor = System.Drawing.SystemColors.Window;
            this.tbFoundSubsciber.Location = new System.Drawing.Point(1170, 337);
            this.tbFoundSubsciber.Multiline = true;
            this.tbFoundSubsciber.Name = "tbFoundSubsciber";
            this.tbFoundSubsciber.ReadOnly = true;
            this.tbFoundSubsciber.Size = new System.Drawing.Size(282, 118);
            this.tbFoundSubsciber.TabIndex = 4;
            // 
            // nudPhoneNumber
            // 
            this.nudPhoneNumber.Location = new System.Drawing.Point(1251, 308);
            this.nudPhoneNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPhoneNumber.Name = "nudPhoneNumber";
            this.nudPhoneNumber.Size = new System.Drawing.Size(120, 20);
            this.nudPhoneNumber.TabIndex = 5;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1170, 175);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gbHashFunction
            // 
            this.gbHashFunction.Controls.Add(this.lblC);
            this.gbHashFunction.Controls.Add(this.lblB);
            this.gbHashFunction.Controls.Add(this.lblA);
            this.gbHashFunction.Controls.Add(this.nudC);
            this.gbHashFunction.Controls.Add(this.nudB);
            this.gbHashFunction.Controls.Add(this.nudA);
            this.gbHashFunction.Controls.Add(this.rbParametersHash);
            this.gbHashFunction.Controls.Add(this.rbSimpleHash);
            this.gbHashFunction.Location = new System.Drawing.Point(1170, 40);
            this.gbHashFunction.Name = "gbHashFunction";
            this.gbHashFunction.Size = new System.Drawing.Size(261, 129);
            this.gbHashFunction.TabIndex = 7;
            this.gbHashFunction.TabStop = false;
            this.gbHashFunction.Text = "Hash function";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(115, 77);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 12;
            this.lblB.Text = "B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(21, 77);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 11;
            this.lblA.Text = "A";
            // 
            // nudC
            // 
            this.nudC.Location = new System.Drawing.Point(182, 93);
            this.nudC.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(54, 20);
            this.nudC.TabIndex = 10;
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(99, 93);
            this.nudB.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(54, 20);
            this.nudB.TabIndex = 9;
            // 
            // nudA
            // 
            this.nudA.Location = new System.Drawing.Point(6, 93);
            this.nudA.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(54, 20);
            this.nudA.TabIndex = 8;
            // 
            // rbParametersHash
            // 
            this.rbParametersHash.AutoSize = true;
            this.rbParametersHash.Location = new System.Drawing.Point(57, 53);
            this.rbParametersHash.Name = "rbParametersHash";
            this.rbParametersHash.Size = new System.Drawing.Size(125, 17);
            this.rbParametersHash.TabIndex = 1;
            this.rbParametersHash.TabStop = true;
            this.rbParametersHash.Text = "hash with parameters";
            this.rbParametersHash.UseVisualStyleBackColor = true;
            // 
            // rbSimpleHash
            // 
            this.rbSimpleHash.AutoSize = true;
            this.rbSimpleHash.Location = new System.Drawing.Point(57, 30);
            this.rbSimpleHash.Name = "rbSimpleHash";
            this.rbSimpleHash.Size = new System.Drawing.Size(138, 17);
            this.rbSimpleHash.TabIndex = 0;
            this.rbSimpleHash.TabStop = true;
            this.rbSimpleHash.Text = "simple hash (key % 256)";
            this.rbSimpleHash.UseVisualStyleBackColor = true;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(199, 77);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 13;
            this.lblC.Text = "C";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 704);
            this.Controls.Add(this.gbHashFunction);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.nudPhoneNumber);
            this.Controls.Add(this.tbFoundSubsciber);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.pnlResult);
            this.Name = "MainForm";
            this.Text = "Hash table";
            ((System.ComponentModel.ISupportInitialize)(this.nudPhoneNumber)).EndInit();
            this.gbHashFunction.ResumeLayout(false);
            this.gbHashFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbFoundSubsciber;
        private System.Windows.Forms.NumericUpDown nudPhoneNumber;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox gbHashFunction;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.RadioButton rbParametersHash;
        private System.Windows.Forms.RadioButton rbSimpleHash;
        private System.Windows.Forms.Label lblC;
    }
}

