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
using Tyuiu.KrutikovaVP.Sprint7.Project.V13.LIb;

namespace Tyuiu.KrutikovaVP.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogLibrary_KVP.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogLibrary_KVP.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }


        static int rows;
        static int columns;
        static string OpenFilePath;

        DataService ds = new DataService();

        public static object[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251));

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            object[,] arrayValues = new object[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            return arrayValues;
        }


        private void buttonOpenFile_KVP_Click(object sender, EventArgs e)
        {
            openFileDialogLibrary_KVP.ShowDialog();
            OpenFilePath = openFileDialogLibrary_KVP.FileName;

            object[,] arrayValues = new object[rows, columns];

            arrayValues = LoadFromFileData(OpenFilePath);

            dataGridViewInPutData_KVP.ColumnCount = columns;
            dataGridViewInPutData_KVP.RowCount = rows;

            dataGridViewOutPutData_KVP.ColumnCount = columns;
            dataGridViewOutPutData_KVP.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_KVP.Columns[i].Width = 100;
                dataGridViewOutPutData_KVP.Columns[i].Width = 100;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_KVP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
        }

        private void buttonSortSquare_KVP_Click(object sender, EventArgs e)
        {
            try
            {
                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.SquareSort(LoadFromFileData(filePath: OpenFilePath));


                this.chartStatistic_KVP.ChartAreas[0].AxisX.Title = "Страна";
                this.chartStatistic_KVP.ChartAreas[0].AxisY.Title = "Площадь";

                chartStatistic_KVP.Series[0].Points.Clear();

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutPutData_KVP.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }

                    chartStatistic_KVP.Series[0].Points.AddXY(r, arrayValues[r, 3]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSortPopulation_KVP_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartStatistic_KVP.ChartAreas[0].AxisX.Title = "Год";
                this.chartStatistic_KVP.ChartAreas[0].AxisY.Title = "Книги";

                chartStatistic_KVP.Series[0].Points.Clear();

                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.PopulationSort(LoadFromFileData(filePath: OpenFilePath));

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutPutData_KVP.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                    chartStatistic_KVP.Series[0].Points.AddXY(r, arrayValues[r, 2]);

                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchInfo_KVP_Click(object sender, EventArgs e)
        {
            try
            {
                string targetElement = Convert.ToString(textBoxSearch_KVP.Text);

                string[] arrayValues = new string[columns];
                arrayValues = ds.Search(LoadFromFileData(filePath: OpenFilePath), targetElement);

                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutData_KVP.Rows[0].Cells[c].Value = arrayValues[c];
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStatistic_KVP_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = Convert.ToString(textBoxOperation_KVP.Text);
                int columnIndex = Convert.ToInt32(textBoxNumOfColumn_KVP.Text) - 1;

                object[,] dataBase = new object[rows, columns];
                dataBase = LoadFromFileData(filePath: OpenFilePath);

                textBoxResStatistic_KVP.Text = Convert.ToString(ds.DataStatistics(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_KVP_Click(object sender, EventArgs e)
        {
            saveFileDialogLibrary_KVP.FileName = "OutPutFileProjectV4.csv";
            saveFileDialogLibrary_KVP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogLibrary_KVP.ShowDialog();

            string path = saveFileDialogLibrary_KVP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutData_KVP.RowCount;
            int columns = dataGridViewOutPutData_KVP.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPutData_KVP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPutData_KVP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_KVP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        
        private void buttonTask_KVP_Click(object sender, EventArgs e)
        {
            FormTask formTask = new FormTask();
            formTask.ShowDialog();

        }

      
    }
}
