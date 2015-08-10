using System;
using System.Collections.Generic;
using System.Text;
using HisClient.Model;
using HisClient.BLL;
using System.Data;

namespace HisClient
{
    /// <summary>
    /// 所有的缓冲
    /// </summary>
    public static class FormAccess
    {

        private static DataTable _BXLBList;                   // 报销类别
        private static DataTable _YPLBList;                   //药品类别
        private static DataTable _YPList;                     //所有药品
        private static DataTable _YPDetailList;              //药品详细信息
        private static DataTable _YPGXList;                  //药品功效
        private static DataTable _YPJXList;                  //药品剂型

        private static DataTable _XM1List;                   //项目(诊疗字典)表一
        private static DataTable _XM2List;                   //项目(诊疗字典)表二

        private static DataTable _JB1List;                  //疾病(字典)表一
        private static DataTable _JB2List;                  //疾病(字典)表二

        private static DataTable _YPGYSList;                //药品供应商
        private static DataTable _YKXSList;                 //药库销售

        private static DataTable _YYKSList;                 //医院科室
        private static DataTable _YYLDList;                 //医院领导

        private static DataTable _CWZDList;                 //床位字典
        private static DataTable _BLLBList;                 //病例类别;

        private static DataTable _YFList;                  //药房字典

        /// <summary>
        /// 药房字典
        /// </summary>
        public static DataTable YFList
        {
            get
            {
                if (_YFList == null)
                {
                    //_YFList = new DataTable();
                    //Zd_YyYf_BLL bll = new Zd_YyYf_BLL();
                    //_YFList = bll.GetAllList().Tables[0];
                }
                return FormAccess._YFList;
            }
            set { FormAccess._YFList = value; }
        }


        /// <summary>
        /// 病例类别
        /// </summary>
        public static DataTable BLLBList
        {
            get
            {
                if (_BLLBList == null)
                {
                    //_BLLBList = new DataTable();
                    //Zd_BxLb_BLL bll = new Zd_BxLb_BLL();
                    //_BLLBList = bll.GetAllList().Tables[0];
                }
                return FormAccess._BLLBList;
            }
            set { FormAccess._BLLBList = value; }
        }


    }
}
