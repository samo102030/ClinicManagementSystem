using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sliding_menue.user_controls;

namespace sliding_menue.BLL
{
    class CLS_CheckTxt
    {
        //the func to check decimal number in txtbox :

        public bool isDecimal(char ch, string text)
        {
            bool res = true;
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            //check if it´s a decimal separator and if doesn´t already have one in the text string
            if (ch == decimalChar && text.IndexOf(decimalChar) != -1)
            {
                res = false;
                return res;
            }

            //check if it´s a digit, decimal separator and backspace
            if (!Char.IsDigit(ch) && ch != decimalChar && ch != (char)Keys.Back)
                res = false;

            return res;
        }




        //public bool isDecimal(char ch, string text)
        //{
        //    bool res = true;
        //    char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        //    //check if it´s a decimal separator and if doesn´t already have one in the text string
        //    if (ch == decimalChar && text.IndexOf(decimalChar) != -1)
        //    {
        //        res = false;
        //        return res;
        //    }

        //    //check if it´s a digit, decimal separator and backspace
        //    if (!Char.IsDigit(ch) && ch != decimalChar && ch != (char)Keys.Back)
        //        res = false;

        //    return res;
        //}

        // func to check intger only like mobile :

        public bool isNumber(char ch, string text)
        {
            bool res = true;

            //check if it´s a digit, decimal separator and backspace
            if (!Char.IsDigit(ch) && ch != (char)Keys.Back)
                res = false;

            return res;
        }


        public static string ConvertNumeralsToArabic(string input)

        {

            return input = input.Replace('0', '٠')

                        .Replace('1', '۱')

                        .Replace('2', '۲')

                        .Replace('3', '۳')

                        .Replace('4', '٤')

                        .Replace('5', '۵')

                        .Replace('6', '٦')

                        .Replace('7', '٧')

                        .Replace('8', '٨')

                        .Replace('9', '٩');

        }

    }
}
