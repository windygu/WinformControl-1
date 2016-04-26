using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Drawing;
using System.Diagnostics;

namespace CtrlResource
{
    /// <summary>
    /// 快速获取当前程序集中图片的辅助类型
    /// </summary>
    public static class AssemblyHelper
    {
        #region 变量
        /// <summary>
        /// 程序集名称
        /// </summary>
        private static readonly string _AssemblyName = "CtrlResource";
        private static Assembly _assembly = null;
        private static Dictionary<string, Image> _dict = null;
        #endregion

        #region 构造函数
        static AssemblyHelper()
        {
            _dict = new Dictionary<string, Image>();
            //_AssemblyName = Assembly.GetName().Name;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 当前程序集
        /// </summary>
        private static Assembly Assembly
        {
            get
            {
                if (_assembly == null)
                    _assembly = Assembly.GetExecutingAssembly();
                return _assembly;
            }
        }
        /// <summary>
        /// 所有当前程序集中已经被缓存上的图片集合
        /// </summary>
        public static Dictionary<string, Image> Dict
        {
            get { return AssemblyHelper._dict; }
            set { AssemblyHelper._dict = value; }
        }
        #endregion

        #region 方法
        public static Image GetImage(string name)
        {
            return GetImage(name, true);
        }
        /// <summary>
        /// 获取当前程序集里面指定的图片
        /// </summary>
        /// <param name="name">指定要获取程序集中图片的名称</param>
        /// /// <param name="isDesign">是否是设计模式</param>
        /// <returns>返回当前程序集里指定名称的图片</returns>
        public static Image GetImage(string name, bool isDesign)
        {
            //Debug.WriteLine(_AssemblyName);
            string assemblyImage = _AssemblyName + "." + name;
            Image image = null;
            if (isDesign)
            {//设计模式
                using (Stream stream = Assembly.GetManifestResourceStream(assemblyImage))
                {
                    if (stream != null)
                    {
                        image = Image.FromStream(stream);
                    }
                }
            }
            else
            {//运行模式
                if (_dict.ContainsKey(assemblyImage))
                {
                    image = _dict[assemblyImage];
                }
                if (image == null)
                {
                    using (Stream stream = Assembly.GetManifestResourceStream(assemblyImage))
                    {
                        if (stream != null)
                        {
                            _dict[assemblyImage] = image = Image.FromStream(stream);
                        }
                    }
                }
            }
            return image;
        }
        #endregion
    }
}
