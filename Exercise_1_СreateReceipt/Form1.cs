using Exercise_1_СreateReceipt.ObjectsForCheck;
using Exercise_1_СreateReceipt.ObjectsToRoundOf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Exercise_1_СreateReceipt
{
    public partial class Form1 : Form
    {
        private Generator generator = new Generator();
        private Dictionary<string, Rounds> RoundArray = new Dictionary<string, Rounds>();
        private XmlSerializer formatter = new XmlSerializer(typeof(СheckTape));

        public Form1()
        {
            InitializeComponent();

            //Словарь из вариантов окрушления
            RoundArray.Add("type1", new Round1());
            RoundArray.Add("type2", new Round2());
            RoundArray.Add("type3", new Round3());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generator.Gemerate();
            WriteChectTape("type1");
        }

        private void WriteChectTape(string type)
        {
            if (!RoundArray.ContainsKey(type))
            {
                MessageBox.Show("Указанного варианта не существует");
                return;
            }
            Rounds rounds = RoundArray[type];
            richTextBox1.Clear();

            for (int i = 0; i < generator.tape.Checks.Count; i++)
            {
                var Checks = generator.tape.Checks;
                richTextBox1.SelectedText = "Номер чека - " + Checks[i].Number.ToString() + " || ";
                richTextBox1.SelectedText = "Дата создания - " + Checks[i].Date.ToShortDateString().ToString() + " || ";
                richTextBox1.SelectedText = "Сумма чека - " + rounds.DoRound(Checks[i].SumPriceLines).ToString(rounds.tostring) + "\n";
                for (int j = 0; j < Checks[i].LineInChecks.Count; j++)
                {
                    var LineInChecks = Checks[i].LineInChecks;
                    richTextBox1.SelectedText = " - №- " + LineInChecks[j].Number.ToString() + " - К-во- " + LineInChecks[j].Count.ToString() + " - Цена- " + LineInChecks[j].Price.ToString() + " - Общая цена- " + rounds.DoRound(LineInChecks[j].SumPrice).ToString(rounds.tostring) + " - \n";
                }
            }
            richTextBox1.SelectedText = "Итого: Всего чеков -" + generator.tape.CountChecks.ToString() + " Общая сумма -" + rounds.DoRound(generator.tape.SumAllChecks).ToString(rounds.tostring);
        }

        private void radioRound1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRound1.Checked)
            {
                WriteChectTape("type1");
            }
        }

        private void radioRound2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRound2.Checked)
            {
                WriteChectTape("type2");
            }
        }

        private void radioRound3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRound3.Checked)
            {
                WriteChectTape("type3");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.xml)|*.xml|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog.FileName;

            //Сохранение
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, generator.tape);
                MessageBox.Show("Данные сохранены");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.xml)|*.xml|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog.FileName;
            //Загрузка
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                generator.tape = (СheckTape)formatter.Deserialize(fs);
                MessageBox.Show("Данные загружены");
                WriteChectTape("type1");
            }
        }
    }
}