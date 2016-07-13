using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Basic
{
    /// <summary>
    /// 表格
    /// </summary>
    public class Table
    {
        /// <summary>
        /// thead
        /// </summary>
        public List<Row> Thead { get; set; }
        /// <summary>
        /// tbody
        /// </summary>
        public List<Row> Tbody { get; set; }
        /// <summary>
        /// tfoot
        /// </summary>
        public List<Row> Tfoot { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public Table()
        {
            Thead = new List<Row>();
            Tbody = new List<Row>();
            Tfoot = new List<Row>();
        }
    }
}
