using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularEx
{
    public static class RegularExpressions
    {
        public static string[] IP(this string strText)//ip адрес
        {
            string pattern = @"(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])(\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])){3}";
            var arr = Regex.Matches(strText, pattern)
                .OfType<Match>().
                Select(m => m.Value).
                ToArray();
            //преобразовываем MathCollection в массив
            return arr;
        }

        public static string[] GUID(this string strText)// GUID
        {
            string pattern = @"([0-9a-fA-F]{8})([-]([0-9a-fA-F]{4})){3}([-]([0-9a-fA-F]{12}))";
            var arr = Regex.Matches(strText, pattern)
                .OfType<Match>().
                Select(m => m.Value).
                ToArray();
            //преобразовываем MathCollection в массив
            return arr;
        }

        public static string[] URL(this string strText)//url
        {
            string pattern = @"(http(s?):[/]{2})?(www[.])?([a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9][.])([a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])(:\d+)?([/]\w+([.]\w+)?)*(([/])?\?\w+=\w+(?:&\w+=\w+)*)?[/]?(#\w+)?";
            var arr = Regex.Matches(strText, pattern)
                .OfType<Match>().
                Select(m => m.Value).
                ToArray();
            //преобразовываем MathCollection в массив
            return arr;
        }
        public static string[] DATA(this string strText)//дата в формате
        {
            string pattern = @"([012]\d|3[0-1])[/](01|03|05|07|08|10|12)[/]((1[6-9]|[2-9]\d)\d{2})|([0-2]\d|30)[/](04|06|09|11)[/]((1[6-9]|[2-9]\d)\d{2})|(29[/]02[/]((1[6-9]|[2-9]\d)(04|08|[13579][26]|[2468][480])|(16|[2468][048]|[3579][26])00)|(0\d|1\d|2[0-8])[/]02[/]((1[6-9]|[2-9]\d)\d{2}))";
            var arr = Regex.Matches(strText, pattern)
                .OfType<Match>().
                Select(m => m.Value).
                ToArray();
            //преобразовываем MathCollection в массив
            return arr;
        }
        public static string[] RUB(this string strText)//цены в рублях
        {
            string pattern = @"(0|[1-9]\d*)([.]\d\d*)?\s(руб)";
            var arr = Regex.Matches(strText, pattern)
                .OfType<Match>().
                Select(m => m.Value).
                ToArray();
            //преобразовываем MathCollection в массив
            return arr;
        }

        public static string[] PAS(this string strText)//пароль
        {
            string pattern = @"((?=.*\d)(?=.*[A-Z])(?=.*[a-z])[\dA-Za-z_]{8,})";
            var arr = Regex.Matches(strText, pattern)
                .OfType<Match>().
                Select(m => m.Value).
                ToArray();
            //преобразовываем MathCollection в массив
            return arr;
        }

    }
}
