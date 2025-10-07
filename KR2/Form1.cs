using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class MainForm : Form
    {
        private Matrix matrixA;
        private Matrix matrixB;
        private TextBox[,] matrixAInputs;
        private TextBox[,] matrixBInputs;

        public MainForm()
        {
            InitializeComponent();
            SetupMatrixInputsStyle();
        }

        private void SetupMatrixInputsStyle()
        {
            // Этот метод будет вызываться при создании текстовых полей для матриц
        }

        private void btnCreateMatrices_Click(object sender, EventArgs e)
        {
            CreateMatrices();
        }

        private void CreateMatrices()
        {
            try
            {
                int rows = int.Parse(txtRows.Text);
                int cols = int.Parse(txtCols.Text);

                if (rows <= 0 || cols <= 0)
                {
                    MessageBox.Show("Размеры матрицы должны быть положительными числами.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (rows > 8 || cols > 8)
                {
                    MessageBox.Show("Для лучшего отображения рекомендуется использовать матрицы не более 8x8.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                matrixA = new Matrix(rows, cols);
                matrixB = new Matrix(rows, cols);

                CreateMatrixInputs(panelMatrixA, rows, cols, 'A');
                CreateMatrixInputs(panelMatrixB, rows, cols, 'B');

                txtResult.Text = $"Созданы матрицы A и B размером {rows}x{cols}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения для размеров матрицы.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateMatrixInputs(Panel panel, int rows, int cols, char matrixName)
        {
            panel.Controls.Clear();
            TextBox[,] inputs = new TextBox[rows, cols];

            // Автоматический расчет размера ячеек в зависимости от размера матрицы
            int cellWidth = Math.Max(35, 300 / cols);
            int cellHeight = 25;
            int spacing = 5;

            // Центрирование матрицы в панели
            int startX = (panel.Width - (cols * (cellWidth + spacing))) / 2;
            int startY = (panel.Height - (rows * (cellHeight + spacing))) / 2;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    TextBox txt = new TextBox
                    {
                        Location = new Point(startX + j * (cellWidth + spacing), startY + i * (cellHeight + spacing)),
                        Size = new Size(cellWidth, cellHeight),
                        Text = "0",
                        TextAlign = HorizontalAlignment.Center,
                        BackColor = Color.FromArgb(63, 63, 70),
                        ForeColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = (i, j)
                    };

                    txt.TextChanged += (s, ev) => UpdateMatrixFromInputs(matrixName);
                    txt.Enter += (s, ev) => { txt.BackColor = Color.FromArgb(85, 85, 92); };
                    txt.Leave += (s, ev) => { txt.BackColor = Color.FromArgb(63, 63, 70); };

                    inputs[i, j] = txt;
                    panel.Controls.Add(txt);
                }
            }

            if (matrixName == 'A')
                matrixAInputs = inputs;
            else
                matrixBInputs = inputs;
        }

        private void UpdateMatrixFromInputs(char matrixName)
        {
            TextBox[,] inputs = matrixName == 'A' ? matrixAInputs : matrixBInputs;
            Matrix matrix = matrixName == 'A' ? matrixA : matrixB;

            if (inputs == null || matrix == null) return;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (double.TryParse(inputs[i, j].Text, out double value))
                    {
                        matrix.Data[i, j] = value;
                    }
                }
            }
        }

        private void btnRandomA_Click(object sender, EventArgs e)
        {
            FillRandomMatrix('A');
        }

        private void btnRandomB_Click(object sender, EventArgs e)
        {
            FillRandomMatrix('B');
        }

        private void FillRandomMatrix(char matrixName)
        {
            try
            {
                int min = int.Parse(txtMin.Text);
                int max = int.Parse(txtMax.Text);

                Matrix matrix = matrixName == 'A' ? matrixA : matrixB;
                TextBox[,] inputs = matrixName == 'A' ? matrixAInputs : matrixBInputs;

                if (matrix == null || inputs == null)
                {
                    MessageBox.Show("Сначала создайте матрицы.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Random rand = new Random();
                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix.Cols; j++)
                    {
                        double value = rand.Next(min, max + 1);
                        matrix.Data[i, j] = value;
                        inputs[i, j].Text = value.ToString();
                    }
                }

                txtResult.Text = $"Матрица {matrixName} заполнена случайными значениями от {min} до {max}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения для диапазона.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Пункт 4: Сложение матриц
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMatrices();
        }

        private void AddMatrices()
        {
            try
            {
                if (matrixA == null || matrixB == null)
                {
                    txtResult.Text = "Ошибка: Матрицы не созданы.";
                    return;
                }

                Matrix result = MatrixCalculator.Add(matrixA, matrixB);
                txtResult.Text = $"✅ РЕЗУЛЬТАТ СЛОЖЕНИЯ МАТРИЦ A И B:\r\n{result}";
            }
            catch (ArgumentException ex)
            {
                txtResult.Text = $"❌ ОШИБКА СЛОЖЕНИЯ: {ex.Message}";
            }
        }

        // Пункт 5: Умножение матриц
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            MultiplyMatrices();
        }

        private void MultiplyMatrices()
        {
            try
            {
                if (matrixA == null || matrixB == null)
                {
                    txtResult.Text = "Ошибка: Матрицы не созданы.";
                    return;
                }

                Matrix result = MatrixCalculator.Multiply(matrixA, matrixB);
                txtResult.Text = $"✅ РЕЗУЛЬТАТ УМНОЖЕНИЯ МАТРИЦ A И B:\r\n{result}";
            }
            catch (ArgumentException ex)
            {
                txtResult.Text = $"❌ ОШИБКА УМНОЖЕНИЯ: {ex.Message}";
            }
        }

        // Пункт 6: Детерминант матрицы
        private void btnDeterminantA_Click(object sender, EventArgs e)
        {
            CalculateDeterminant('A');
        }

        private void btnDeterminantB_Click(object sender, EventArgs e)
        {
            CalculateDeterminant('B');
        }

        private void CalculateDeterminant(char matrixName)
        {
            try
            {
                Matrix matrix = matrixName == 'A' ? matrixA : matrixB;
                if (matrix == null)
                {
                    txtResult.Text = "Ошибка: Матрица не создана.";
                    return;
                }

                double determinant = MatrixCalculator.Determinant(matrix);
                string matrixStr = matrixName == 'A' ?
                    $"Матрица A:\r\n{matrix}" :
                    $"Матрица B:\r\n{matrix}";

                txtResult.Text = $"🔢 ДЕТЕРМИНАНТ МАТРИЦЫ {matrixName}:\r\n" +
                               $"{matrixStr}\r\n" +
                               $"📊 Результат: {determinant:F4}";
            }
            catch (ArgumentException ex)
            {
                txtResult.Text = $"❌ ОШИБКА ВЫЧИСЛЕНИЯ ДЕТЕРМИНАНТА: {ex.Message}";
            }
        }

        // Пункт 7: Обратная матрица
        private void btnInverseA_Click(object sender, EventArgs e)
        {
            CalculateInverse('A');
        }

        private void btnInverseB_Click(object sender, EventArgs e)
        {
            CalculateInverse('B');
        }

        private void CalculateInverse(char matrixName)
        {
            try
            {
                Matrix matrix = matrixName == 'A' ? matrixA : matrixB;
                if (matrix == null)
                {
                    txtResult.Text = "Ошибка: Матрица не создана.";
                    return;
                }

                Matrix inverse = MatrixCalculator.Inverse(matrix);
                string originalMatrix = matrixName == 'A' ?
                    $"Исходная матрица A:\r\n{matrix}" :
                    $"Исходная матрица B:\r\n{matrix}";

                txtResult.Text = $"🔄 ОБРАТНАЯ МАТРИЦА {matrixName}:\r\n" +
                               $"{originalMatrix}\r\n" +
                               $"📈 Результат:\r\n{inverse}";
            }
            catch (ArgumentException ex)
            {
                txtResult.Text = $"❌ ОШИБКА ВЫЧИСЛЕНИЯ ОБРАТНОЙ МАТРИЦЫ: {ex.Message}";
            }
        }

        private void btnTransposeA_Click(object sender, EventArgs e)
        {
            TransposeMatrix('A');
        }

        private void btnTransposeB_Click(object sender, EventArgs e)
        {
            TransposeMatrix('B');
        }

        private void TransposeMatrix(char matrixName)
        {
            try
            {
                Matrix matrix = matrixName == 'A' ? matrixA : matrixB;
                if (matrix == null)
                {
                    txtResult.Text = "Ошибка: Матрица не создана.";
                    return;
                }

                Matrix transposed = MatrixCalculator.Transpose(matrix);
                string originalMatrix = matrixName == 'A' ?
                    $"Исходная матрица A:\r\n{matrix}" :
                    $"Исходная матрица B:\r\n{matrix}";

                txtResult.Text = $"🔄 ТРАНСПОНИРОВАННАЯ МАТРИЦА {matrixName}:\r\n" +
                               $"{originalMatrix}\r\n" +
                               $"📐 Результат:\r\n{transposed}";
            }
            catch (Exception ex)
            {
                txtResult.Text = $"❌ ОШИБКА ТРАНСПОНИРОВАНИЯ: {ex.Message}";
            }
        }

        private void btnTestAll_Click(object sender, EventArgs e)
        {
            RunAllTests();
        }

        // Тестирование всех сценариев
        private void RunAllTests()
        {
            txtResult.Clear();
            txtResult.AppendText("🧪 === ТЕСТИРОВАНИЕ ВСЕХ СЦЕНАРИЕВ ===\r\n\r\n");

            TestPositiveScenarios();
            txtResult.AppendText("\r\n");
            TestNegativeScenarios();

            txtResult.AppendText("\r\n✅ ТЕСТИРОВАНИЕ ЗАВЕРШЕНО!\r\n");
        }

        private void TestPositiveScenarios()
        {
            txtResult.AppendText("✅ ПОЛОЖИТЕЛЬНЫЕ СЦЕНАРИИ:\r\n");

            // Тест 1: Успешное сложение
            Matrix testA1 = new Matrix(2, 2);
            testA1.Data[0, 0] = 1; testA1.Data[0, 1] = 2;
            testA1.Data[1, 0] = 3; testA1.Data[1, 1] = 4;

            Matrix testB1 = new Matrix(2, 2);
            testB1.Data[0, 0] = 5; testB1.Data[0, 1] = 6;
            testB1.Data[1, 0] = 7; testB1.Data[1, 1] = 8;

            try
            {
                Matrix result = MatrixCalculator.Add(testA1, testB1);
                txtResult.AppendText("✓ Сложение матриц 2x2: УСПЕХ\r\n");
            }
            catch (Exception ex)
            {
                txtResult.AppendText($"✗ Сложение матриц 2x2: ОШИБКА - {ex.Message}\r\n");
            }

            // Тест 2: Успешное умножение
            Matrix testA2 = new Matrix(2, 3);
            testA2.Data[0, 0] = 1; testA2.Data[0, 1] = 2; testA2.Data[0, 2] = 3;
            testA2.Data[1, 0] = 4; testA2.Data[1, 1] = 5; testA2.Data[1, 2] = 6;

            Matrix testB2 = new Matrix(3, 2);
            testB2.Data[0, 0] = 7; testB2.Data[0, 1] = 8;
            testB2.Data[1, 0] = 9; testB2.Data[1, 1] = 10;
            testB2.Data[2, 0] = 11; testB2.Data[2, 1] = 12;

            try
            {
                Matrix result = MatrixCalculator.Multiply(testA2, testB2);
                txtResult.AppendText("✓ Умножение матриц 2x3 и 3x2: УСПЕХ\r\n");
            }
            catch (Exception ex)
            {
                txtResult.AppendText($"✗ Умножение матриц: ОШИБКА - {ex.Message}\r\n");
            }

            // Тест 3: Детерминант квадратной матрицы
            Matrix testA3 = new Matrix(3, 3);
            testA3.Data[0, 0] = 1; testA3.Data[0, 1] = 2; testA3.Data[0, 2] = 3;
            testA3.Data[1, 0] = 0; testA3.Data[1, 1] = 4; testA3.Data[1, 2] = 5;
            testA3.Data[2, 0] = 1; testA3.Data[2, 1] = 0; testA3.Data[2, 2] = 6;

            try
            {
                double det = MatrixCalculator.Determinant(testA3);
                txtResult.AppendText($"✓ Детерминант 3x3: УСПЕХ ({det:F2})\r\n");
            }
            catch (Exception ex)
            {
                txtResult.AppendText($"✗ Детерминант 3x3: ОШИБКА - {ex.Message}\r\n");
            }

            // Тест 4: Обратная матрица
            Matrix testA4 = new Matrix(2, 2);
            testA4.Data[0, 0] = 4; testA4.Data[0, 1] = 7;
            testA4.Data[1, 0] = 2; testA4.Data[1, 1] = 6;

            try
            {
                Matrix inverse = MatrixCalculator.Inverse(testA4);
                txtResult.AppendText("✓ Обратная матрица 2x2: УСПЕХ\r\n");
            }
            catch (Exception ex)
            {
                txtResult.AppendText($"✗ Обратная матрица: ОШИБКА - {ex.Message}\r\n");
            }
        }

        private void TestNegativeScenarios()
        {
            txtResult.AppendText("❌ НЕГАТИВНЫЕ СЦЕНАРИИ:\r\n");

            // Тест 1: Невозможность сложения
            Matrix testA1 = new Matrix(2, 2);
            Matrix testB1 = new Matrix(3, 3);

            try
            {
                Matrix result = MatrixCalculator.Add(testA1, testB1);
                txtResult.AppendText("✗ Сложение разных размеров: ОШИБКА ПРОВЕРКИ\r\n");
            }
            catch (ArgumentException)
            {
                txtResult.AppendText("✓ Сложение разных размеров: корректная ошибка\r\n");
            }

            // Тест 2: Невозможность умножения
            Matrix testA2 = new Matrix(2, 3);
            Matrix testB2 = new Matrix(2, 3);

            try
            {
                Matrix result = MatrixCalculator.Multiply(testA2, testB2);
                txtResult.AppendText("✗ Умножение несовместимых матриц: ОШИБКА ПРОВЕРКИ\r\n");
            }
            catch (ArgumentException)
            {
                txtResult.AppendText("✓ Умножение несовместимых матриц: корректная ошибка\r\n");
            }

            // Тест 3: Детерминант не квадратной матрицы
            Matrix testA3 = new Matrix(2, 3);

            try
            {
                double det = MatrixCalculator.Determinant(testA3);
                txtResult.AppendText("✗ Детерминант не квадратной матрицы: ОШИБКА ПРОВЕРКИ\r\n");
            }
            catch (ArgumentException)
            {
                txtResult.AppendText("✓ Детерминант не квадратной матрицы: корректная ошибка\r\n");
            }

            // Тест 4: Обратная матрица с нулевым детерминантом
            Matrix testA4 = new Matrix(2, 2);
            testA4.Data[0, 0] = 1; testA4.Data[0, 1] = 2;
            testA4.Data[1, 0] = 2; testA4.Data[1, 1] = 4; // det = 0

            try
            {
                Matrix inverse = MatrixCalculator.Inverse(testA4);
                txtResult.AppendText("✗ Обратная матрица с det=0: ОШИБКА ПРОВЕРКИ\r\n");
            }
            catch (ArgumentException)
            {
                txtResult.AppendText("✓ Обратная матрица с det=0: корректная ошибка\r\n");
            }

            // Тест 5: Обратная матрица для не квадратной матрицы
            Matrix testA5 = new Matrix(2, 3);

            try
            {
                Matrix inverse = MatrixCalculator.Inverse(testA5);
                txtResult.AppendText("✗ Обратная матрица для не квадратной: ОШИБКА ПРОВЕРКИ\r\n");
            }
            catch (ArgumentException)
            {
                txtResult.AppendText("✓ Обратная матрица для не квадратной: корректная ошибка\r\n");
            }
        }
    }
}