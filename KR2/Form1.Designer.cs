namespace MatrixCalculator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblRows = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblCols = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.btnCreateMatrices = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnRandomA = new System.Windows.Forms.Button();
            this.btnRandomB = new System.Windows.Forms.Button();
            this.panelMatrixA = new System.Windows.Forms.Panel();
            this.panelMatrixB = new System.Windows.Forms.Panel();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDeterminantA = new System.Windows.Forms.Button();
            this.btnDeterminantB = new System.Windows.Forms.Button();
            this.btnInverseA = new System.Windows.Forms.Button();
            this.btnTransposeA = new System.Windows.Forms.Button();
            this.btnTransposeB = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTestAll = new System.Windows.Forms.Button();
            this.btnInverseB = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.grpMatrices = new System.Windows.Forms.GroupBox();
            this.grpTesting = new System.Windows.Forms.GroupBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.panelControls.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.grpMatrices.SuspendLayout();
            this.grpTesting.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.ForeColor = System.Drawing.Color.White;
            this.lblRows.Location = new System.Drawing.Point(15, 26);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(72, 13);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Строки (n):";
            // 
            // txtRows
            // 
            this.txtRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtRows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRows.ForeColor = System.Drawing.Color.White;
            this.txtRows.Location = new System.Drawing.Point(93, 23);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(50, 20);
            this.txtRows.TabIndex = 1;
            this.txtRows.Text = "3";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.ForeColor = System.Drawing.Color.White;
            this.lblCols.Location = new System.Drawing.Point(149, 26);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(83, 13);
            this.lblCols.TabIndex = 2;
            this.lblCols.Text = "Столбцы (m):";
            // 
            // txtCols
            // 
            this.txtCols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtCols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCols.ForeColor = System.Drawing.Color.White;
            this.txtCols.Location = new System.Drawing.Point(238, 23);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(50, 20);
            this.txtCols.TabIndex = 3;
            this.txtCols.Text = "3";
            // 
            // btnCreateMatrices
            // 
            this.btnCreateMatrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCreateMatrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMatrices.ForeColor = System.Drawing.Color.White;
            this.btnCreateMatrices.Location = new System.Drawing.Point(294, 21);
            this.btnCreateMatrices.Name = "btnCreateMatrices";
            this.btnCreateMatrices.Size = new System.Drawing.Size(100, 23);
            this.btnCreateMatrices.TabIndex = 4;
            this.btnCreateMatrices.Text = "Создать матрицы";
            this.btnCreateMatrices.UseVisualStyleBackColor = false;
            this.btnCreateMatrices.Click += new System.EventHandler(this.btnCreateMatrices_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(400, 26);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(30, 13);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Min:";
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMin.ForeColor = System.Drawing.Color.White;
            this.txtMin.Location = new System.Drawing.Point(436, 23);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(50, 20);
            this.txtMin.TabIndex = 6;
            this.txtMin.Text = "0";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(492, 26);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(33, 13);
            this.lblMax.TabIndex = 7;
            this.lblMax.Text = "Max:";
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMax.ForeColor = System.Drawing.Color.White;
            this.txtMax.Location = new System.Drawing.Point(531, 23);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(50, 20);
            this.txtMax.TabIndex = 8;
            this.txtMax.Text = "10";
            // 
            // btnRandomA
            // 
            this.btnRandomA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRandomA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomA.ForeColor = System.Drawing.Color.White;
            this.btnRandomA.Location = new System.Drawing.Point(587, 21);
            this.btnRandomA.Name = "btnRandomA";
            this.btnRandomA.Size = new System.Drawing.Size(80, 23);
            this.btnRandomA.TabIndex = 9;
            this.btnRandomA.Text = "Случайно A";
            this.btnRandomA.UseVisualStyleBackColor = false;
            this.btnRandomA.Click += new System.EventHandler(this.btnRandomA_Click);
            // 
            // btnRandomB
            // 
            this.btnRandomB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRandomB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomB.ForeColor = System.Drawing.Color.White;
            this.btnRandomB.Location = new System.Drawing.Point(673, 21);
            this.btnRandomB.Name = "btnRandomB";
            this.btnRandomB.Size = new System.Drawing.Size(80, 23);
            this.btnRandomB.TabIndex = 10;
            this.btnRandomB.Text = "Случайно B";
            this.btnRandomB.UseVisualStyleBackColor = false;
            this.btnRandomB.Click += new System.EventHandler(this.btnRandomB_Click);
            // 
            // panelMatrixA
            // 
            this.panelMatrixA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelMatrixA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatrixA.Location = new System.Drawing.Point(18, 42);
            this.panelMatrixA.Name = "panelMatrixA";
            this.panelMatrixA.Size = new System.Drawing.Size(350, 200);
            this.panelMatrixA.TabIndex = 11;
            // 
            // panelMatrixB
            // 
            this.panelMatrixB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelMatrixB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatrixB.Location = new System.Drawing.Point(384, 42);
            this.panelMatrixB.Name = "panelMatrixB";
            this.panelMatrixB.Size = new System.Drawing.Size(350, 200);
            this.panelMatrixB.TabIndex = 12;
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMatrixA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblMatrixA.Location = new System.Drawing.Point(15, 20);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(77, 15);
            this.lblMatrixA.TabIndex = 13;
            this.lblMatrixA.Text = "Матрица A";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMatrixB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblMatrixB.Location = new System.Drawing.Point(381, 20);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(77, 15);
            this.lblMatrixB.TabIndex = 14;
            this.lblMatrixB.Text = "Матрица B";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(18, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Сложение (A+B)";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(144, 25);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(120, 30);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "Умножение (A×B)";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDeterminantA
            // 
            this.btnDeterminantA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDeterminantA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeterminantA.ForeColor = System.Drawing.Color.White;
            this.btnDeterminantA.Location = new System.Drawing.Point(270, 25);
            this.btnDeterminantA.Name = "btnDeterminantA";
            this.btnDeterminantA.Size = new System.Drawing.Size(120, 30);
            this.btnDeterminantA.TabIndex = 17;
            this.btnDeterminantA.Text = "Детерминант A";
            this.btnDeterminantA.UseVisualStyleBackColor = false;
            this.btnDeterminantA.Click += new System.EventHandler(this.btnDeterminantA_Click);
            // 
            // btnDeterminantB
            // 
            this.btnDeterminantB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDeterminantB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeterminantB.ForeColor = System.Drawing.Color.White;
            this.btnDeterminantB.Location = new System.Drawing.Point(396, 25);
            this.btnDeterminantB.Name = "btnDeterminantB";
            this.btnDeterminantB.Size = new System.Drawing.Size(120, 30);
            this.btnDeterminantB.TabIndex = 18;
            this.btnDeterminantB.Text = "Детерминант B";
            this.btnDeterminantB.UseVisualStyleBackColor = false;
            this.btnDeterminantB.Click += new System.EventHandler(this.btnDeterminantB_Click);
            // 
            // btnInverseA
            // 
            this.btnInverseA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInverseA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverseA.ForeColor = System.Drawing.Color.White;
            this.btnInverseA.Location = new System.Drawing.Point(18, 61);
            this.btnInverseA.Name = "btnInverseA";
            this.btnInverseA.Size = new System.Drawing.Size(120, 30);
            this.btnInverseA.TabIndex = 19;
            this.btnInverseA.Text = "Обратная A";
            this.btnInverseA.UseVisualStyleBackColor = false;
            this.btnInverseA.Click += new System.EventHandler(this.btnInverseA_Click);
            // 
            // btnTransposeA
            // 
            this.btnTransposeA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTransposeA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransposeA.ForeColor = System.Drawing.Color.White;
            this.btnTransposeA.Location = new System.Drawing.Point(144, 61);
            this.btnTransposeA.Name = "btnTransposeA";
            this.btnTransposeA.Size = new System.Drawing.Size(120, 30);
            this.btnTransposeA.TabIndex = 20;
            this.btnTransposeA.Text = "Транспонировать A";
            this.btnTransposeA.UseVisualStyleBackColor = false;
            this.btnTransposeA.Click += new System.EventHandler(this.btnTransposeA_Click);
            // 
            // btnTransposeB
            // 
            this.btnTransposeB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTransposeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransposeB.ForeColor = System.Drawing.Color.White;
            this.btnTransposeB.Location = new System.Drawing.Point(270, 61);
            this.btnTransposeB.Name = "btnTransposeB";
            this.btnTransposeB.Size = new System.Drawing.Size(120, 30);
            this.btnTransposeB.TabIndex = 21;
            this.btnTransposeB.Text = "Транспонировать B";
            this.btnTransposeB.UseVisualStyleBackColor = false;
            this.btnTransposeB.Click += new System.EventHandler(this.btnTransposeB_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtResult.Location = new System.Drawing.Point(10, 23);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(740, 127);
            this.txtResult.TabIndex = 22;
            // 
            // btnTestAll
            // 
            this.btnTestAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.btnTestAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTestAll.ForeColor = System.Drawing.Color.White;
            this.btnTestAll.Location = new System.Drawing.Point(18, 25);
            this.btnTestAll.Name = "btnTestAll";
            this.btnTestAll.Size = new System.Drawing.Size(200, 35);
            this.btnTestAll.TabIndex = 23;
            this.btnTestAll.Text = "ТЕСТИРОВАНИЕ ВСЕХ СЦЕНАРИЕВ";
            this.btnTestAll.UseVisualStyleBackColor = false;
            this.btnTestAll.Click += new System.EventHandler(this.btnTestAll_Click);
            // 
            // btnInverseB
            // 
            this.btnInverseB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInverseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverseB.ForeColor = System.Drawing.Color.White;
            this.btnInverseB.Location = new System.Drawing.Point(396, 61);
            this.btnInverseB.Name = "btnInverseB";
            this.btnInverseB.Size = new System.Drawing.Size(120, 30);
            this.btnInverseB.TabIndex = 24;
            this.btnInverseB.Text = "Обратная B";
            this.btnInverseB.UseVisualStyleBackColor = false;
            this.btnInverseB.Click += new System.EventHandler(this.btnInverseB_Click);
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelControls.Controls.Add(this.lblRows);
            this.panelControls.Controls.Add(this.txtRows);
            this.panelControls.Controls.Add(this.lblCols);
            this.panelControls.Controls.Add(this.txtCols);
            this.panelControls.Controls.Add(this.btnCreateMatrices);
            this.panelControls.Controls.Add(this.lblMin);
            this.panelControls.Controls.Add(this.txtMin);
            this.panelControls.Controls.Add(this.lblMax);
            this.panelControls.Controls.Add(this.txtMax);
            this.panelControls.Controls.Add(this.btnRandomA);
            this.panelControls.Controls.Add(this.btnRandomB);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(784, 60);
            this.panelControls.TabIndex = 25;
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.btnInverseB);
            this.grpOperations.Controls.Add(this.btnAdd);
            this.grpOperations.Controls.Add(this.btnMultiply);
            this.grpOperations.Controls.Add(this.btnDeterminantA);
            this.grpOperations.Controls.Add(this.btnDeterminantB);
            this.grpOperations.Controls.Add(this.btnTransposeB);
            this.grpOperations.Controls.Add(this.btnInverseA);
            this.grpOperations.Controls.Add(this.btnTransposeA);
            this.grpOperations.ForeColor = System.Drawing.Color.White;
            this.grpOperations.Location = new System.Drawing.Point(12, 310);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(760, 100);
            this.grpOperations.TabIndex = 26;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Операции с матрицами";
            // 
            // grpMatrices
            // 
            this.grpMatrices.Controls.Add(this.lblMatrixA);
            this.grpMatrices.Controls.Add(this.panelMatrixA);
            this.grpMatrices.Controls.Add(this.lblMatrixB);
            this.grpMatrices.Controls.Add(this.panelMatrixB);
            this.grpMatrices.ForeColor = System.Drawing.Color.White;
            this.grpMatrices.Location = new System.Drawing.Point(12, 66);
            this.grpMatrices.Name = "grpMatrices";
            this.grpMatrices.Size = new System.Drawing.Size(760, 250);
            this.grpMatrices.TabIndex = 27;
            this.grpMatrices.TabStop = false;
            this.grpMatrices.Text = "Матрицы";
            // 
            // grpTesting
            // 
            this.grpTesting.Controls.Add(this.btnTestAll);
            this.grpTesting.ForeColor = System.Drawing.Color.White;
            this.grpTesting.Location = new System.Drawing.Point(12, 510);
            this.grpTesting.Name = "grpTesting";
            this.grpTesting.Size = new System.Drawing.Size(760, 70);
            this.grpTesting.TabIndex = 28;
            this.grpTesting.TabStop = false;
            this.grpTesting.Text = "Тестирование";
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.txtResult);
            this.grpResults.ForeColor = System.Drawing.Color.White;
            this.grpResults.Location = new System.Drawing.Point(12, 416);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.grpResults.Size = new System.Drawing.Size(760, 160);
            this.grpResults.TabIndex = 29;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Результаты";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(784, 591);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpTesting);
            this.Controls.Add(this.grpMatrices);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.panelControls);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 630);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix Calculator Pro";
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.grpOperations.ResumeLayout(false);
            this.grpMatrices.ResumeLayout(false);
            this.grpMatrices.PerformLayout();
            this.grpTesting.ResumeLayout(false);
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Button btnCreateMatrices;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnRandomA;
        private System.Windows.Forms.Button btnRandomB;
        private System.Windows.Forms.Panel panelMatrixA;
        private System.Windows.Forms.Panel panelMatrixB;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDeterminantA;
        private System.Windows.Forms.Button btnDeterminantB;
        private System.Windows.Forms.Button btnInverseA;
        private System.Windows.Forms.Button btnTransposeA;
        private System.Windows.Forms.Button btnTransposeB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTestAll;
        private System.Windows.Forms.Button btnInverseB;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.GroupBox grpMatrices;
        private System.Windows.Forms.GroupBox grpTesting;
        private System.Windows.Forms.GroupBox grpResults;
    }
}