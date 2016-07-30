using System.Text.RegularExpressions;

namespace NickLibrary.Services
{
    public class RegexService
    {
        private Regex regex;

        /// <summary>
        /// 判斷串進來的字串是否為中文
        /// </summary>
        /// <param name="value">欲判斷得值</param>
        /// <returns>是否為中文</returns>
        public bool IsChinese(string value)
        {
            regex = new Regex("^[\u4e00-\u9fa5]+$");

            return regex.IsMatch(value);
        }
    }
}