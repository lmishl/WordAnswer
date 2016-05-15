using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OracleClient;
using Word = Microsoft.Office.Interop.Word;


namespace wordAnswer
{
    public partial class MainForm : Form
    {
        OracleConnection ocon;
        OracleCommand cmd;
        OracleDataReader dr;

        Object wMissing = System.Reflection.Missing.Value;
        //обьекты true  и  false
        Object wTrue = true;
        Object wFalse = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            ocon = new OracleConnection(Properties.Settings.Default.ConnectionString);
            cmd = new OracleCommand("", ocon);
            ocon.Open();

            cmd.CommandText = prepareRequest();     //тут составляется запрос

            dr = cmd.ExecuteReader();
            OracleDataReader r = cmd.ExecuteReader();

            prepareDataGrid();

            int kol = 0;
            while (r.Read())
            {
                int q = dataGridView1.Rows.Add();
                outputInDataGrid(q, r);
                kol++;
                if (kol > 100)
                    break;
            }
            if (kol > 100)
                MessageBox.Show("Невозможно отобразить все правонарушения", "Уточните параметры поиска и повторите", MessageBoxButtons.OK);

            if (dataGridView1.Rows.Count == 0)
            {
                DialogResult dres = MessageBox.Show("Распечатать ответ?", "Административная практика отсутствует", MessageBoxButtons.YesNo);
                if (dres == DialogResult.Yes)
                    buttonToWord_Click(sender, e);
                    //printManPractNo();
            }
            else
            {
                buttonToWord.Enabled = true;
            }
        }

        private string prepareRequest()
        {
            string sqlString = "";
            if (panelMan.Enabled)
            {
                sqlString = "select * from LISHENTSY t, REF_VIOLATIONTYPES r where t.VIOLATION_TYPE = r.CODE and LAST_NAME = '" + textBoxFam.Text.ToUpper() + "' and FIRST_NAME = '" + textBoxName.Text.ToUpper() + "'";     //запрос по фамилии и имени

                if (textBoxOtch.Text != "")     //если заполнено отчество
                    sqlString += " and MIDDLE_NAME = '" + textBoxOtch.Text.ToUpper() + "'";

                if (dateTimePicker1.Value.ToShortDateString() != DateTime.Now.ToShortDateString())     //если заполнена Дата рождения
                    sqlString += " and birthday = TO_DATE('" + dateTimePicker1.Value.ToShortDateString() + "','DD.MM.YYYY')";


            }
            else
                if (panelCar.Enabled)
                {
                    sqlString = "select * from LISHENTSY t, REF_VIOLATIONTYPES r where t.VIOLATION_TYPE = r.CODE";
                    if (textBoxMarka.Text != "")
                        sqlString += " and CAR_TYPE = '" + textBoxMarka.Text.ToUpper() + "' ";
                    if (textBoxNomer.Text != "")
                        sqlString += " and CAR_NUMBER = '" + textBoxNomer.Text.ToUpper() + "' ";
                }


            if (dateTimePicker2.Value.ToShortDateString() != DateTime.Now.ToShortDateString())     //если заполнено начало периода поиска
                sqlString += " and VIOLATION_DATE >= TO_DATE('" + dateTimePicker2.Value.ToShortDateString() + "','DD.MM.YYYY')";

            if (dateTimePicker3.Value.ToShortDateString() != DateTime.Now.ToShortDateString())     //если заполнен конец периода поиска
                sqlString += " and VIOLATION_DATE <= TO_DATE('" + dateTimePicker3.Value.ToShortDateString() + "','DD.MM.YYYY')";

            return sqlString;
        }

        private void printManPractNo()
        {
            Word.Application wordApp = fillStandart(Application.StartupPath + @"/ManPractNo.dot");
            wordSearchReplace("@@FIO", textBoxFam.Text.ToUpper() + " " + textBoxName.Text.ToUpper() + " " + textBoxOtch.Text.ToUpper(), ref wordApp, 1);
            if (dateTimePicker1.Value.ToShortDateString() != DateTime.Now.ToShortDateString())
                wordSearchReplace("@@dateOfBirth", ", " + dateTimePicker1.Value.ToShortDateString() + "г.р.", ref wordApp, 1);
            else
                wordSearchReplace("@@dateOfBirth", "", ref wordApp, 1);
            //делаем приложение ворд видимым
            wordApp.Visible = true;
        }

        void printManPractYes()
        {
            Word.Application wordApp = fillStandart(Application.StartupPath + @"/ManPractYes.dot");
            Word.Document wordDoc = wordApp.ActiveDocument;

            int y = dataGridView1.Columns.Count;
            int x = dataGridView1.Rows.Count;

            fillTable(wordDoc, x, y, dataGridView1);

            int pagesCount = 0;
            Word.WdStatistic pagesStatType = Word.WdStatistic.wdStatisticPages;
            pagesCount = wordDoc.ComputeStatistics(pagesStatType, ref wMissing);
            pagesCount -= 2;    //так как 1ответ и 1 оборот

            wordSearchReplace("@@kollist", pagesCount.ToString(), ref wordApp, 1);

            wordSearchReplace("@@FIO", textBoxFam.Text.ToUpper() + " " + textBoxName.Text.ToUpper() + " " + textBoxOtch.Text.ToUpper(), ref wordApp, 1);
            if (dateTimePicker1.Value.ToShortDateString() != DateTime.Now.ToShortDateString())
                wordSearchReplace("@@dateOfBirth", ", " + dateTimePicker1.Value.ToShortDateString() + "г.р.", ref wordApp, 1);
            else
                wordSearchReplace("@@dateOfBirth", "", ref wordApp, 1);

            //делаем приложение ворд видимым
            wordApp.Visible = true;

        }

        private void fillTable(Word.Document wordDoc, int x, int y, DataGridView data)
        {
            Word.Range myRange;
            object textToFind = "@@table";

            object replaceWith = "";
            object replaceType = Word.WdReplace.wdReplaceOne;

            myRange = wordDoc.Range();
            myRange.Find.Execute(ref textToFind, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref replaceWith, ref replaceType, ref wMissing, ref wMissing, ref wMissing, ref wMissing);

            Object behavior = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;
            Word.Table wordTab = wordDoc.Tables.Add(myRange, x + 1, y, ref behavior, ref autoFitBehiavor);

            for (int j = 0; j < y; j++)
                wordTab.Cell(1, j + 1).Range.Text = data.Columns[j].HeaderText;
            for (int i = 1; i < x + 1; i++)
                for (int j = 0; j < y; j++)
                    wordTab.Cell(i + 1, j + 1).Range.Text = data[j, i - 1].Value.ToString();
            wordTab.Range.Font.Size = 7;
        }

        private void outputInDataGrid(int q, OracleDataReader r)
        {
            try
            {

                if (dataGridView1.Columns.Contains("FIO"))
                {
                    dataGridView1["FIO", q].Value = r["LAST_NAME"].ToString() + " " + r["FIRST_NAME"].ToString() + " " + r["MIDDLE_NAME"].ToString();
                }
                if (dataGridView1.Columns.Contains("BIRTHDAY"))
                {
                    string s = r["BIRTHDAY"].ToString();
                    if (s.Length >= 10)
                        dataGridView1["BIRTHDAY", q].Value = s.Substring(0, 10);
                }
                if (dataGridView1.Columns.Contains("CAR_TYPE"))
                {
                    dataGridView1["CAR_TYPE", q].Value = r["CAR_TYPE"].ToString();
                }
                if (dataGridView1.Columns.Contains("CAR_NUMBER"))
                {
                    dataGridView1["CAR_NUMBER", q].Value = r["CAR_NUMBER"].ToString();
                }
                if (dataGridView1.Columns.Contains("VIOLATION_DATE"))
                {
                    dataGridView1["VIOLATION_DATE", q].Value = r["VIOLATION_DATE"].ToString();
                }
                if (dataGridView1.Columns.Contains("VIOLATION"))
                {
                    dataGridView1["VIOLATION", q].Value = r["NAME"].ToString();
                }
                if (dataGridView1.Columns.Contains("WORK"))
                {
                    dataGridView1["WORK", q].Value = r["RCHAR"].ToString();
                }
                if (dataGridView1.Columns.Contains("ADDRESS"))
                {
                    dataGridView1["ADDRESS", q].Value = r["ADDRESS"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ошибочные данные в базе, проверьте таблицу");

            }
        }

        private void prepareDataGrid()
        {
            if (checkedListBox1.GetItemChecked(0))
            {
                dataGridView1.Columns.Add("FIO", "ФИО");
                dataGridView1.Columns["FIO"].Width = 150;
            }
            if (checkedListBox1.GetItemChecked(1))
            {
                dataGridView1.Columns.Add("BIRTHDAY", "Дата рождения");
                dataGridView1.Columns["BIRTHDAY"].Width = 75;
            }
            if (checkedListBox1.GetItemChecked(2))
            {
                dataGridView1.Columns.Add("CAR_TYPE", "Автомобиль");
                dataGridView1.Columns["CAR_TYPE"].Width = 100;
            }
            if (checkedListBox1.GetItemChecked(3))
            {
                dataGridView1.Columns.Add("CAR_NUMBER", "Номер");
                dataGridView1.Columns["CAR_NUMBER"].Width = 70;
            }
            if (checkedListBox1.GetItemChecked(4))
            {
                dataGridView1.Columns.Add("VIOLATION_DATE", "ДАТА");
                dataGridView1.Columns["VIOLATION_DATE"].Width = 75;
            }
            if (checkedListBox1.GetItemChecked(5))
            {
                dataGridView1.Columns.Add("VIOLATION", "Нарушение");
                dataGridView1.Columns["VIOLATION"].Width = 250;
            }
            if (checkedListBox1.GetItemChecked(6))
            {
                dataGridView1.Columns.Add("ADDRESS", "Адрес");
                dataGridView1.Columns["ADDRESS"].Width = 150;
            }
            if (checkedListBox1.GetItemChecked(7))
            {
                dataGridView1.Columns.Add("WORK", "Место работы");
                dataGridView1.Columns["WORK"].Width = 150;
            }
        }

        private void buttonToWord_Click(object sender, EventArgs e)
        {
            string s;
            SelectRecipient sr = new SelectRecipient();
            sr.ShowDialog();

            //костыль. Если была нажата отмена, то в CommonClass.forRecipient пусто
            if (CommonClass.forRecipient == "")
                return;


            if (panelMan.Enabled)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    printManPractNo();
                }
                else
                {
                    printManPractYes();
                }
            }
            else
                if (panelCar.Enabled)
                {
                    if (dataGridView1.Rows.Count == 0)
                    {
                        printCarPractNo();
                    }
                    else
                    {
                        printCarPractYes();
                    }

                }


        }

        private void printCarPractNo()
        {
            Word.Application wordApp = fillStandart(Application.StartupPath + @"/CarPractNo.dot");
            wordSearchReplace("@@Auto", textBoxMarka.Text.ToUpper(), ref wordApp, 1);
            wordSearchReplace("@@GRZ", textBoxNomer.Text.ToUpper(), ref wordApp, 1);
            
            //делаем приложение ворд видимым
            wordApp.Visible = true;
        }

        private void printCarPractYes()
        {
            Word.Application wordApp = fillStandart(Application.StartupPath + @"/CarPractYes.dot");
            Word.Document wordDoc = wordApp.ActiveDocument;
            wordSearchReplace("@@Auto", textBoxMarka.Text.ToUpper(), ref wordApp, 1);
            wordSearchReplace("@@GRZ", textBoxNomer.Text.ToUpper(), ref wordApp, 1);



            int y = dataGridView1.Columns.Count;
            int x = dataGridView1.Rows.Count;

            fillTable(wordDoc, x, y, dataGridView1);

            int pagesCount = 0;
            Word.WdStatistic pagesStatType = Word.WdStatistic.wdStatisticPages;
            pagesCount = wordDoc.ComputeStatistics(pagesStatType, ref wMissing);
            pagesCount -= 2;    //так как 1ответ и 1 оборот

            wordSearchReplace("@@kollist", pagesCount.ToString(), ref wordApp, 1);

            //делаем приложение ворд видимым
            wordApp.Visible = true;
        }

        /// <summary>
        /// Заполнение стандартных данных:  исполнитель, период, начальник ...
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        Word.Application fillStandart(object file)
        {
            Word.Application wordApp = new Word.Application();

            //создаем обьект документа word
            Word.Document wordDoc = wordApp.Documents.Add(ref file, ref wMissing, ref wMissing, ref wFalse);

            wordDoc.Activate();


            //заполняется на отдельной формеё
            wordSearchInShape("@@Recipient", CommonClass.forRecipient, ref wordApp);

            if (dateTimePicker2.Value.ToShortDateString() != DateTime.Now.ToShortDateString())     //если заполнено начало периода поиска
            {
                wordSearchReplace("@@period1", "в период с " + dateTimePicker2.Value.ToShortDateString(), ref wordApp, 1);
                if (dateTimePicker3.Value.ToShortDateString() != DateTime.Now.ToShortDateString())     //если заполнено конец периода поиска
                    wordSearchReplace("@@period2", " по " + dateTimePicker3.Value.ToShortDateString(), ref wordApp, 1);
                else
                    wordSearchReplace("@@period2", " по настоящее время", ref wordApp, 1);
            }
            else
                wordSearchReplace("@@period1@@period2", "", ref wordApp, 1);

            wordSearchReplace("@@CurDate", DateTime.Now.ToShortDateString(), ref wordApp, 1);
            wordSearchReplace("@@IspolFIO", Properties.Settings.Default.IspolFIO, ref wordApp, 1);
            wordSearchReplace("@@IspolPhone", Properties.Settings.Default.IspolPhone, ref wordApp, 1);
            wordSearchReplace("@@NachFIO", Properties.Settings.Default.NachFIO, ref wordApp, 1);
            wordSearchReplace("@@NachDolz", Properties.Settings.Default.NachDolz, ref wordApp, 1);


            return wordApp;
        }

        // функция поиска и замены строк в документе ворд по заранее вписанным в него шаблонам
        public void wordSearchReplace(string search, string replace, ref Word.Application wordApp, int how)
        {
            // обьект диапазона, собственно какая-то часть документа
            Word.Range myRange;
            // обьект пустого параметра
            object wMissing = Type.Missing;

            // строка вида @@adress, которую будем искать в документе ворд
            object textToFind = search;
            // чем будем заменять строку шаблона
            object replaceWith = replace;

            //типа поиска и замены
            object replaceType;
            if (how == 0)
                // заменять все найденные вхождения
                replaceType = Word.WdReplace.wdReplaceAll;
            else
                // заменять только первое найденное вхождение
                replaceType = Word.WdReplace.wdReplaceOne;

            // обходим все разделы документа
            for (int i = 1; i <= wordApp.ActiveDocument.Sections.Count; i++)
            {
                // берем всю секцию диапазоном
                myRange = wordApp.ActiveDocument.Sections[i].Range;

                // выполняем метод поискаи  замены обьекта диапазона ворд
                myRange.Find.Execute(ref textToFind, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref replaceWith, ref replaceType, ref wMissing, ref wMissing, ref wMissing, ref wMissing);
            }
        }


        public void wordSearchInShape(string search, string replace, ref Word.Application wordApp)
        {
            // обьект диапазона, собственно какая-то часть документа
            Word.Range myRange;

            // обходим все разделы документа
            for (int i = 1; i <= wordApp.ActiveDocument.Sections.Count; i++)
            {
                // берем всю секцию диапазоном
                myRange = wordApp.ActiveDocument.Sections[i].Range;
                // foreach (Word.Shape sh in myRange.ShapeRange)
                myRange.ShapeRange[2].TextFrame.TextRange.Text = myRange.ShapeRange[2].TextFrame.TextRange.Text.Replace(search, replace);

                // выполняем метод поискаи  замены обьекта диапазона ворд
                //  myRange.Find.Execute(ref textToFind, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref replaceWith, ref replaceType, ref wMissing, ref wMissing, ref wMissing, ref wMissing);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int kol = checkedListBox1.Items.Count;
            for (int i = 0; i < kol; i++)
                checkedListBox1.SetItemChecked(i, true);
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.ShowDialog();
        }

        private void textBoxFam_TextChanged(object sender, EventArgs e)
        {
            buttonToWord.Enabled = false;
        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            panelMan.Enabled = true;
            panelCar.Enabled = false;
            buttonFind.Enabled = true;
        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            panelMan.Enabled = false;
            panelCar.Enabled = true;
            buttonFind.Enabled = true;
        }
    }
}
