using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;

namespace HisClient.Controls
{
    public partial class zqctext : DevExpress.XtraEditors.TextEdit
    {
        public zqctext()
        {
            InitializeComponent();
        }

        public zqctext(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            m_EnterToTable = true;
        }
        private const string m_PropertyName = "加载属性";

        private bool m_EnterToTable;
        /// <summary>
        /// 是否用Enter模拟Tab键
        /// </summary>
        [
        Category(m_PropertyName),
        Description("是否用Enter键代替Tab键")
        ]
        public bool EnterToTable
        {
            get
            {
                return m_EnterToTable;
            }
            set
            {
                m_EnterToTable = value;
            }
        }

        private string id = string.Empty;
        [
        Category(m_PropertyName),
        Description("附加一个ID存储属性")
        ]
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
