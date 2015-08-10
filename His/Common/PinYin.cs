using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.International.Converters.PinYinConverter;
using System.Collections.ObjectModel;

namespace HisClient
{
    public class PinYin
    {
        string _strText = "";
        public PinYin(string strText)
        {
            _strText = strText;
        }


         bool _IsPolyphone = false;
        /// <summary>
        /// 获取这串字符是否有多音字
        /// </summary>
         public bool IsPolyphone
         {
             get { return _IsPolyphone; }
             set { _IsPolyphone = value; }
         }


        public  string GetChineseSpell()
        {
            string _pinyin = "";
            if (_strText == null || _strText.Trim() == "")
            {
                return _strText;
            }
            else
            {
                char[] chars = _strText.ToCharArray();
                foreach (char c in chars)
                {
                    if (ChineseChar.IsValidChar(c))
                    {
                        ChineseChar cn = new ChineseChar(c);
                        if (cn.IsPolyphone)
                        {
                            _IsPolyphone = true;
                        }
                        ReadOnlyCollection<string> roc = cn.Pinyins;
                        if (roc.Count > 0)
                        {
                            string first = roc[0].ToString().Substring(0, 1).ToLower();
                            _pinyin = _pinyin + first;
                        }
                        //    label1.Text = roc[0].ToString();
                    }
                    else
                    {
                        _pinyin = _pinyin + c.ToString();
                    }
                }
            }
            return _pinyin;
        }
    }
}
