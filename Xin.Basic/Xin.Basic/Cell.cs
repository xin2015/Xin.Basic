using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Basic
{
    /// <summary>
    /// 单元格
    /// </summary>
    public class Cell
    {
        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 跨行
        /// </summary>
        public int Rowspan { get; set; }
        /// <summary>
        /// 跨列
        /// </summary>
        public int Colspan { get; set; }
        /// <summary>
        /// 列
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value">值</param>
        public Cell(string value)
        {
            Value = value;
            Rowspan = 1;
            Colspan = 1;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="rowspan">跨行</param>
        /// <param name="colspan">跨列</param>
        public Cell(string value, int rowspan, int colspan)
        {
            Value = value;
            Rowspan = rowspan;
            Colspan = colspan;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="rowspan">跨行</param>
        /// <param name="colspan">跨列</param>
        /// <param name="index">列</param>
        public Cell(string value, int rowspan, int colspan, int index) : this(value, rowspan, colspan)
        {
            Index = index;
        }
    }
}
