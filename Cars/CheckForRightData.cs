using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class CheckForRightData
    {
        public bool CheckInputValues(string v1, string v2, string v3, string v4, string v5)
        {
            bool flag = false;
            double result;
            double res = 0;
            if (double.TryParse(v1, out res) && v1.Length != 0)
            {
                flag = true;
            }
            else
            {
                if (v1.Length == 0)
                {
                    flag = false;
                   // MessageBox.Show("Введите BrandCode");
                    return flag;
                }
                else
                {
                    flag = false;
                   // MessageBox.Show("BrandCode должен быть числом");
                    return flag;
                }
            }
            if (double.TryParse(v2, out res) && v2.Length != 0)
            {
                flag = true;
            }
            else
            {
                if (v2.Length == 0)
                {
                    flag = false;
                   // MessageBox.Show("Введите Power");
                    return flag;
                }
                else
                {
                    flag = false;
                    //MessageBox.Show("Power должен быть числом");
                    return flag;
                }
            }
            if (double.TryParse(v3, out res) && v3.Length != 0)
            {
                flag = true;
            }
            else
            {
                if (v3.Length == 0)
                {
                    flag = false;
                   // MessageBox.Show("Введите BenzineMaxVolume");
                    return flag;
                }
                else
                {
                    flag = false;
                   // MessageBox.Show("BenzineMaxVolume должен быть числом");
                    return flag;
                }
            }
            if (double.TryParse(v4, out res) && v4.Length != 0)
            {
                flag = true;
            }
            else
            {
                if (v4.Length == 0)
                {
                    flag = false;
                   // MessageBox.Show("Введите ResidueBenzine");
                    return flag;
                }
                else
                {
                    flag = false;
                   // MessageBox.Show("ResidueBenzine должен быть числом");
                    return flag;
                }
            }
            if (double.TryParse(v5, out res) && v5.Length != 0)
            {
                flag = true;
            }
            else
            {
                if (v5.Length == 0)
                {
                    flag = false;
                    //MessageBox.Show("Введите OilVolume");
                    return flag;
                }
                else
                {
                    flag = false;
                   // MessageBox.Show("OilVolume должен быть числом");
                    return flag;
                }
            }
            return flag;
        }

        public bool CheckInputValues2(string v1, string v2, string v3)
        {
            bool flag = false;
            double result;
            double res = 0;
            if ((v1.Any(c => char.IsLetter(c))) && v1.Length != 0)
            {
                flag = true;
            }
            else
            {
                if (v1.Length == 0)
                {
                    flag = false;
                    // MessageBox.Show("Введите LastName");
                    return flag;
                }
                else
                {
                    flag = false;
                    // MessageBox.Show("LastName содержит недопустимые символы");
                    return flag;
                }
            }
            if (v2.Length == 0)
            {
                flag = false;
                // MessageBox.Show("Введите BrandName");
                return flag;
            }
            if (v3.Length == 0)
            {
                flag = false;
                //MessageBox.Show("Введите Benzine");
                return flag;
            }
            return flag;
        }

        public bool CheckInputValues3(string v1, string v2)
        {
            if (Convert.ToDouble(v1) >= Convert.ToDouble(v2))
            {
                return true;
            }
            else
            {
                //MessageBox.Show("Остаток бензина не может быть больше максимального объема бака");
                return false;
            }
        }
    }

    

}
