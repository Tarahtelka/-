using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocenka_mer_svyzei
{
    public static class DateRegression
    {
        public static double[] CoefRef;
        public static double[] ValOY;
        public static double[,] ValOx;


        public static string Study_Name;
        public static DateTime Date;
        public static string Comment;

        public static int NumberOfScale;
        public static string NumberOfVariable;
        public static string NumberOfUqVariable;
        public static string TypeOfScale;
        public static string DistType;
        public static string AGV;
        public static string StandardDeviation;
        //Пикообразность
        public static string Slope;
        //Скошенность
        public static string Mechanics;
        public static string TypeMethod;

        public static string GetString()
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(Study_Name))
            {              
                sb.Append("Название исследования: ");
                sb.Append(Study_Name);
                sb.Append("\r\n");
                sb.Append("Комментарий к исследованию: ");
                sb.Append(Comment);
                sb.Append("\r\n");
                sb.Append("Дата: ");
                sb.Append(Date.ToString());
                sb.Append("\r\n");
            }
            sb.Append("Количество шкал: ");
            sb.Append(NumberOfScale.ToString());
            sb.Append("\r\n");
            sb.Append("Количество значений: ");
            sb.Append("\r\n");
            string[] temp = NumberOfVariable.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append("  Зависимая переменная: ");
            sb.Append(temp[0]);
            sb.Append("\r\n");
            for (int i = 1; i < temp.Length; i++)
            {
                sb.Append("  Независимая переменная№");
                sb.Append(i.ToString());
                sb.Append(": ");
                sb.Append(temp[i]);
                sb.Append("\r\n");
            }

            sb.Append("Количество уникальных значений: ");
            sb.Append("\r\n");
            temp = NumberOfUqVariable.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append("  Зависимая переменная: ");
            sb.Append(temp[0]);
            sb.Append("\r\n");
            for (int i = 1; i < temp.Length; i++)
            {
                sb.Append("  Независимая переменная№");
                sb.Append(i.ToString());
                sb.Append(": ");
                sb.Append(temp[i]);
                sb.Append("\r\n");
            }

            sb.Append("Типы шкал: ");
            sb.Append("\r\n");
            temp = TypeOfScale.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append("  Зависимая переменная: ");
            sb.Append(temp[0]);
            sb.Append("\r\n");
            for (int i = 1; i < temp.Length; i++)
            {
                sb.Append("  Независимая переменная№");
                sb.Append(i.ToString());
                sb.Append(": ");
                sb.Append(temp[i]);
                sb.Append("\r\n");
            }

            sb.Append("Тип распределения данных: ");
            sb.Append("\r\n");
            temp = DistType.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append("  Зависимая переменная: ");
            if (temp[0] == "Нет")
            {
                sb.Append("Невозможно определить");
            }
            else
            {
                sb.Append(temp[0]);
            }
            sb.Append("\r\n");
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] == "Нет")
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append("Невозможно определить");
                    sb.Append("\r\n");
                }
                else
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append(temp[i]);
                    sb.Append("\r\n");
                }
            }

            sb.Append("Среднее значение: ");
            sb.Append("\r\n");
            temp = AGV.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append("  Зависимая переменная: ");
            if (temp[0] == "Нет")
            {
                sb.Append("Невозможно определить");
            }
            else
            {
                sb.Append(temp[0]);
            }
            sb.Append("\r\n");
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] == "Нет")
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append("Невозможно определить");
                    sb.Append("\r\n");
                }
                else
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append(temp[i]);
                    sb.Append("\r\n");
                }
            }

            sb.Append("Стандартное отклонение: ");
            sb.Append("\r\n");
            temp = StandardDeviation.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append("  Зависимая переменная: ");
            if (temp[0] == "Нет")
            {
                sb.Append("Невозможно определить");
            }
            else
            {
                sb.Append(temp[0]);
            }
            sb.Append("\r\n");
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] == "Нет")
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append("Невозможно определить");
                    sb.Append("\r\n");
                }
                else
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append(temp[i]);
                    sb.Append("\r\n");
                }
            }

            sb.Append("Пикообразность: ");
            sb.Append("\r\n");
            temp = Slope.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append("  Зависимая переменная: ");
            if (temp[0] == "Нет")
            {
                sb.Append("Невозможно определить");
            }
            else
            {
                sb.Append(temp[0]);
            }
            sb.Append("\r\n");
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] == "Нет")
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append("Невозможно определить");
                    sb.Append("\r\n");
                }
                else
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append(temp[i]);
                    sb.Append("\r\n");
                }
            }

            sb.Append("Скошенность: ");
            sb.Append("\r\n");
            temp = Mechanics.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append("  Зависимая переменная: ");
            if (temp[0] == "Нет")
            {
                sb.Append("Невозможно определить");
            }
            else
            {
                sb.Append(temp[0]);
            }
            sb.Append("\r\n");
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] == "Нет")
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append("Невозможно определить");
                    sb.Append("\r\n");
                }
                else
                {
                    sb.Append("  Независимая переменная№");
                    sb.Append(i.ToString());
                    sb.Append(": ");
                    sb.Append(temp[i]);
                    sb.Append("\r\n");
                }
            }

            sb.Append("Методы исследования: ");
            sb.Append("\r\n");
            sb.Append(TypeMethod);

            return sb.ToString();
        }
    }
}
