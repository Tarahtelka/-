using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocenka_mer_svyzei
{
    class CorrelationUtils
    {
        private static SignificantDBDataSetTableAdapters.PearsonsSignTableAdapter pears = new SignificantDBDataSetTableAdapters.PearsonsSignTableAdapter();
        private static SignificantDBDataSetTableAdapters.SpearmansSignTableAdapter spear = new SignificantDBDataSetTableAdapters.SpearmansSignTableAdapter();

        public static double getPearsonCriticalValue(int freedomDegree, float signV)
        {
            if (freedomDegree > 120)
            {
                freedomDegree = 9999;
            }
            else if (freedomDegree > 60 && freedomDegree < 120)
            {
                freedomDegree = 60;
            }
            else if (freedomDegree > 40 && freedomDegree < 60)
            {
                freedomDegree = 40;
            }
            else if (freedomDegree > 30 && freedomDegree < 40)
            {
                freedomDegree = 30;
            }

            SignificantDBDataSet.PearsonsSignDataTable pearsDT = pears.GetDataByDegreeAndSign(freedomDegree, signV);

            return Convert.ToDouble(pearsDT.Rows[0].ItemArray[3].ToString());

        }

        private static bool isPearsonSignificant(int freedomDegree, double corrVal)
        {
            Double critVal = getPearsonCriticalValue(freedomDegree, float.Parse("0,05"));

            if (corrVal > critVal)
            {
                return true;
            }
            return false;
        }

        public static string getPearsonSignificant(int freedomDegree, double corrVal)
        {
            if (isPearsonSignificant(freedomDegree, corrVal))
            {
                return "Связь статистически значима";
            }
            return "Корреляционная зависимость отсутствует";
        }

        public static Double getSpearmanCriticalValue(int freedomDegree, float signV)
        {
            SignificantDBDataSet.SpearmansSignDataTable spearmDT = spear.GetDataByDegreeAndSign(freedomDegree, signV);

            return Convert.ToDouble(spearmDT.Rows[0].ItemArray[3].ToString());

        }

        private static bool isSpearmanSignificant(int freedomDegree, double corrVal)
        {
            Double critVal = getSpearmanCriticalValue(freedomDegree, float.Parse("0,05"));

            if (corrVal > critVal)
            {
                return true;
            }
            return false;
        }

        public static string getSpearmanSignificant(int freedomDegree, double corrVal)
        {
            if (freedomDegree < 5 || freedomDegree > 30)
            {
                return "Невозможно определить значимость";
            }
                if (isSpearmanSignificant(freedomDegree, corrVal))
            {
                return "Связь статистически значима";
            }
            return "Корреляционная зависимость отсутствует";
        }

    }
}
