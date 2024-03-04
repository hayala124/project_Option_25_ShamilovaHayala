using System;
using System.Windows.Forms;

namespace samostRab_Option_25_ShamilovaHayala
{
    public partial class Form1 : Form
    {
        static int question, wrongAnswer, correctAnswer, level;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            GenerateBinaryNumberForLevel_1();
            GenerateBinaryNumberForLevel_2();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void beginningTest()
        {
            question++;
            ExitButton.Visible = true;
            OctalNumberTextBox.Enabled = true;
            HexNumberTextBox.Enabled = true;
            NumberLabel.Visible = true;
            BinaryNumberLabel.Visible = true;
            OctalNumberLabel.Visible = true;
            HexNumberLabel.Visible = true;
            OctalNumberTextBox.Visible = true;
            HexNumberTextBox.Visible = true;
        }
        private void OctalNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void HexNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CountingCorrectAndWrongAnswers(string octalRepresentation, string hexRepresentation)
        {
            if (octalRepresentation.ToLower() == OctalNumberTextBox.Text.ToLower() && hexRepresentation.ToLower() == HexNumberTextBox.Text.ToLower())
            {
                correctAnswer += 2;
            }
            else if (octalRepresentation.ToLower() == OctalNumberTextBox.Text.ToLower() || hexRepresentation.ToLower() == HexNumberTextBox.Text.ToLower())
            {
                correctAnswer++;
                wrongAnswer++;
            }
            else
            {
                wrongAnswer += 2;
            }
        }
        private void GenerateBinaryNumberForLevel_1()
        {
            int decimalNumber = random.Next(0, 1024);
            string binaryNumber = Convert.ToString(decimalNumber, 2);
            BinaryNumberLabel.Text = binaryNumber;
        }
        private void GenerateBinaryNumberForLevel_2()
        {
            int decimalNumber = random.Next();
            string binaryNumber = Convert.ToString(decimalNumber, 2);
            BinaryNumberLabel.Text = binaryNumber;
        }
        private void ActionBeforeShowResults()
        {
            CheckButton.Visible = true;
            OctalNumberTextBox.Enabled = false;
            HexNumberTextBox.Enabled = false;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            level = 1;
            LevelNumberAndTaskLabel.Text = "ЗАДАНИЕ: ПЕРЕВЕДИТЕ ЧИСЛО ИЗ 2-ОЙ СИСТЕМЫ\nСЧИСЛЕНИЯ В 8-УЮ И 16-УЮ\nУровень " + level;
            StartButton.Text = "Дальше";
            beginningTest();
            string binaryRepresentation = BinaryNumberLabel.Text;
            string octalRepresentation = Convert.ToString(Convert.ToInt32(binaryRepresentation, 2), 8);
            string hexRepresentation = Convert.ToString(Convert.ToInt32(binaryRepresentation, 2), 16);

            CountingCorrectAndWrongAnswers(octalRepresentation, hexRepresentation);
            GenerateBinaryNumberForLevel_1();
            OctalNumberTextBox.Clear();
            HexNumberTextBox.Clear();

            if (question == 11)
            {
                StartButton.Visible = false;
                ActionBeforeShowResults();
            }
        }
        private void NextLevelButton_Click(object sender, EventArgs e)
        {
            level = 2;
            LevelNumberAndTaskLabel.Text = "ЗАДАНИЕ: ПЕРЕВЕДИТЕ ЧИСЛО ИЗ 2-ОЙ СИСТЕМЫ\nСЧИСЛЕНИЯ В 8-УЮ И 16-УЮ\nУровень " + level;
            NextLevelButton.Text = "Дальше";
            beginningTest();
            string binaryRepresentation = BinaryNumberLabel.Text;
            string octalRepresentation = Convert.ToString(Convert.ToInt32(binaryRepresentation, 2), 8);
            string hexRepresentation = Convert.ToString(Convert.ToInt32(binaryRepresentation, 2), 16);

            CountingCorrectAndWrongAnswers(octalRepresentation, hexRepresentation);
            GenerateBinaryNumberForLevel_2();
            OctalNumberTextBox.Clear();
            HexNumberTextBox.Clear();

            if (question == 11)
            {
                ActionBeforeShowResults();
                NextLevelButton.Visible = false;
            }
        }
        private void ConditionsForEachLevel()
        {
            if (level == 1)
                NextLevelButton.Visible = true;
            else
                NextLevelButton.Visible = false;
        }
        private void ActionsForShowResults()
        {
            question -= 1;
            wrongAnswer -= 2;
            CheckButton.Visible = false;
            OctalNumberTextBox.Enabled = false;
            HexNumberTextBox.Enabled = false;
            StartButton.Text = "Начать";
        }
        private void CheckingAndOutputResult()
        {
            if (correctAnswer == 20)
            {
                MessageBox.Show($"Поздравляем, вы отлично владеете данным материалом!\nПравильных переводов - {correctAnswer}\nНеправильных переводов нет!", "Результат");
                ConditionsForEachLevel();
            }
            else if (correctAnswer > wrongAnswer)
            {
                MessageBox.Show($"Поздравляем, ваш уровень знаний выше среднего!\nПравильных переводов - {correctAnswer}\nНеправильных переводов - {wrongAnswer}", "Результат");
                ConditionsForEachLevel();
            }
            else
            {
                MessageBox.Show($"К сожалению, Вам стоит еще немного потренироваться и пройти тест снова!\n" +
                    $"Правильных переводов - {correctAnswer}\nНеправильных переводов - {wrongAnswer}", "Результат");
                StartButton.Visible = true;
                wrongAnswer = 0;
                correctAnswer = 0;
            }
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            ActionsForShowResults();
            CheckingAndOutputResult();
            question = 0;
            correctAnswer = 0;
            wrongAnswer = 0;
        }
    }
}