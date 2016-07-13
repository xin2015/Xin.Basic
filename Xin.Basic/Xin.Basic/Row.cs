using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Basic
{
    /// <summary>
    /// 行
    /// </summary>
    public class Row
    {
        /// <summary>
        /// 行
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 单元格
        /// </summary>
        public List<Cell> Cells { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public Row()
        {
            Cells = new List<Cell>();
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="index">行</param>
        public Row(int index) : this()
        {
            Index = index;
        }

        /// <summary>
        /// 添加单元格
        /// </summary>
        /// <param name="cell">单元格</param>
        public void Add(Cell cell)
        {
            Cells.Add(cell);
        }
    }
}
