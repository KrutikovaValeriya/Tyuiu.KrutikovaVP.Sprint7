using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KrutikovaVP.Sprint7.Project.V13.LIb
{
    public class DataService
    {
        public object[,] SquareSort(object[,] data)
        {
            int rows = data.GetLength(0);
            int columns = data.GetLength(1);

            object[,] sortedArray = (object[,])data.Clone();

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (Convert.ToInt32(sortedArray[j, 3]) > Convert.ToInt32(sortedArray[j + 1, 3]))
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            object temp = sortedArray[j, k];
                            sortedArray[j, k] = sortedArray[j + 1, k];
                            sortedArray[j + 1, k] = temp;
                        }
                    }
                }
            }
            return sortedArray;
        }

        public object[,] PopulationSort(object[,] data)
        {
            int rows = data.GetLength(0);
            int columns = data.GetLength(1);

            object[,] sortedArray = (object[,])data.Clone();

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (Convert.ToInt32(sortedArray[j, 2]) > Convert.ToInt32(sortedArray[j + 1, 2]))
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            object temp = sortedArray[j, k];
                            sortedArray[j, k] = sortedArray[j + 1, k];
                            sortedArray[j + 1, k] = temp;
                        }
                    }
                }
            }
            return sortedArray;
        }

        public string[] Search(object[,] data, string targetElement)
        {
            bool isElementFound = false;
            int rows = data.GetLength(0);
            int columns = data.GetLength(1);
            int targetRow = -1;
            int targetColumn = -1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (data[i, j].Equals(targetElement))
                    {
                        isElementFound = true;
                        targetRow = i;
                        targetColumn = j;
                        break;
                    }
                }
                if (isElementFound)
                {
                    break;
                }
            }

            string[] result = new string[columns];
            if (isElementFound)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[j] = data[targetRow, j].ToString();
                }
            }
            else
            {
                for (int j = 0; j < columns; j++)
                {
                    result[j] = string.Empty;
                }
            }

            return result;
        }

        public double DataStatistics(object[,] data, string commandStat, int column)
        {
            int numRows = data.GetLength(0);
            int numColumns = data.GetLength(1);

            double result = 0;
            if (commandStat == "sum")
            {
                for (int i = 0; i < numRows; i++)
                {
                    result += Convert.ToInt32(data[i, column]);
                }

            }

            List<int> termsList = new List<int>();
            if (commandStat == "min")
            {
                for (int i = 0; i < numRows; i++)
                {
                    termsList.Add(Convert.ToInt32(data[i, column]));
                }

                int[] statElements = new int[numRows];
                statElements = termsList.ToArray();

                result = Convert.ToDouble(statElements.Min());
            }

            if (commandStat == "max")
            {
                for (int i = 0; i < numRows; i++)
                {
                    termsList.Add(Convert.ToInt32(data[i, column]));
                }

                int[] statElements = new int[numRows];
                statElements = termsList.ToArray();

                result = Convert.ToDouble(statElements.Max());
            }

            if (commandStat == "avarage")
            {
                double resSum = 0;
                for (int i = 0; i < numRows; i++)
                {
                    resSum += Convert.ToDouble(data[i, column]);
                }
                result = resSum / numRows;
                result = Math.Round(result, 2);
            }

            return result;
        }
    }
}
