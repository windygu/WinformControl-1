using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtrlControls.Helper
{
    class Win32Helper
    {
        /// <summary>
        /// 获取低位上的值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int LOWORD(int value)
        {
            return value & 0xFFFF;
        }
        /// <summary>
        /// 获取高位上的值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int HIWORD(int value)
        {
            return value >> 16;
        }
        /// <summary>
        /// 获取低位上的值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int LOWORD(IntPtr value)
        {
            return LOWORD(unchecked((int)(long)value));
        }
        /// <summary>
        /// 获取高位上的值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int HIWORD(IntPtr value)
        {
            return HIWORD(unchecked((int)(long)value));
        }
    }
}
