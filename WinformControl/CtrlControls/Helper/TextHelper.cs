using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtrlControls.Helper
{
    class TextHelper
    {
        /// <summary>
        /// 计算字符串的长度
        /// </summary>
        /// <param name="text">需要计算的字符串</param>
        /// <returns>字符串的长度</returns>
        public static int GetStringLen(string text)
        {
            int len = 0;
            for (int i = 0; i < text.Length; i++)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(text.Substring(i, 1));
                if (bytes.Length > 1)
                    len += 2;
                else
                    len += 1;
            }
            return len;
        }

    }
}
