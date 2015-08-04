using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_ds_import
	/// </summary>
	public partial class his_ds_import
	{
		public his_ds_import()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_ds_import");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_ds_import model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.IMPORT_CODE != null)
			{
				strSql1.Append("IMPORT_CODE,");
				strSql2.Append("'"+model.IMPORT_CODE+"',");
			}
			if (model.IMPORT_TYPE != null)
			{
				strSql1.Append("IMPORT_TYPE,");
				strSql2.Append("'"+model.IMPORT_TYPE+"',");
			}
			if (model.MANUFACTURE_CODE != null)
			{
				strSql1.Append("MANUFACTURE_CODE,");
				strSql2.Append("'"+model.MANUFACTURE_CODE+"',");
			}
			if (model.MANUFACTURE_NAME != null)
			{
				strSql1.Append("MANUFACTURE_NAME,");
				strSql2.Append("'"+model.MANUFACTURE_NAME+"',");
			}
			if (model.INVOICE_NO != null)
			{
				strSql1.Append("INVOICE_NO,");
				strSql2.Append("'"+model.INVOICE_NO+"',");
			}
			if (model.ACCOUNT_FLAG != null)
			{
				strSql1.Append("ACCOUNT_FLAG,");
				strSql2.Append("'"+model.ACCOUNT_FLAG+"',");
			}
			if (model.ACCOUNT_DATE != null)
			{
				strSql1.Append("ACCOUNT_DATE,");
				strSql2.Append("'"+model.ACCOUNT_DATE+"',");
			}
			if (model.ISPAY_FLAG != null)
			{
				strSql1.Append("ISPAY_FLAG,");
				strSql2.Append("'"+model.ISPAY_FLAG+"',");
			}
			if (model.PAY_TIME != null)
			{
				strSql1.Append("PAY_TIME,");
				strSql2.Append("'"+model.PAY_TIME+"',");
			}
			if (model.CONTRACT_NO != null)
			{
				strSql1.Append("CONTRACT_NO,");
				strSql2.Append("'"+model.CONTRACT_NO+"',");
			}
			if (model.IMPORT_FLAG != null)
			{
				strSql1.Append("IMPORT_FLAG,");
				strSql2.Append("'"+model.IMPORT_FLAG+"',");
			}
			if (model.COST != null)
			{
				strSql1.Append("COST,");
				strSql2.Append(""+model.COST+",");
			}
			if (model.CREATE_BY != null)
			{
				strSql1.Append("CREATE_BY,");
				strSql2.Append("'"+model.CREATE_BY+"',");
			}
			if (model.CREATE_DATE != null)
			{
				strSql1.Append("CREATE_DATE,");
				strSql2.Append("'"+model.CREATE_DATE+"',");
			}
			if (model.PURCHASER != null)
			{
				strSql1.Append("PURCHASER,");
				strSql2.Append("'"+model.PURCHASER+"',");
			}
			if (model.PURCHASE_DATE != null)
			{
				strSql1.Append("PURCHASE_DATE,");
				strSql2.Append("'"+model.PURCHASE_DATE+"',");
			}
			if (model.CANCEL_OPRATOR != null)
			{
				strSql1.Append("CANCEL_OPRATOR,");
				strSql2.Append("'"+model.CANCEL_OPRATOR+"',");
			}
			if (model.CANCEL_DATE != null)
			{
				strSql1.Append("CANCEL_DATE,");
				strSql2.Append("'"+model.CANCEL_DATE+"',");
			}
			if (model.HOSPITAL_CODE != null)
			{
				strSql1.Append("HOSPITAL_CODE,");
				strSql2.Append("'"+model.HOSPITAL_CODE+"',");
			}
			strSql.Append("insert into his_ds_import(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HIS.Model.his_ds_import model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_ds_import set ");
			if (model.IMPORT_CODE != null)
			{
				strSql.Append("IMPORT_CODE='"+model.IMPORT_CODE+"',");
			}
			else
			{
				strSql.Append("IMPORT_CODE= null ,");
			}
			if (model.IMPORT_TYPE != null)
			{
				strSql.Append("IMPORT_TYPE='"+model.IMPORT_TYPE+"',");
			}
			else
			{
				strSql.Append("IMPORT_TYPE= null ,");
			}
			if (model.MANUFACTURE_CODE != null)
			{
				strSql.Append("MANUFACTURE_CODE='"+model.MANUFACTURE_CODE+"',");
			}
			else
			{
				strSql.Append("MANUFACTURE_CODE= null ,");
			}
			if (model.MANUFACTURE_NAME != null)
			{
				strSql.Append("MANUFACTURE_NAME='"+model.MANUFACTURE_NAME+"',");
			}
			else
			{
				strSql.Append("MANUFACTURE_NAME= null ,");
			}
			if (model.INVOICE_NO != null)
			{
				strSql.Append("INVOICE_NO='"+model.INVOICE_NO+"',");
			}
			else
			{
				strSql.Append("INVOICE_NO= null ,");
			}
			if (model.ACCOUNT_FLAG != null)
			{
				strSql.Append("ACCOUNT_FLAG='"+model.ACCOUNT_FLAG+"',");
			}
			else
			{
				strSql.Append("ACCOUNT_FLAG= null ,");
			}
			if (model.ACCOUNT_DATE != null)
			{
				strSql.Append("ACCOUNT_DATE='"+model.ACCOUNT_DATE+"',");
			}
			else
			{
				strSql.Append("ACCOUNT_DATE= null ,");
			}
			if (model.ISPAY_FLAG != null)
			{
				strSql.Append("ISPAY_FLAG='"+model.ISPAY_FLAG+"',");
			}
			else
			{
				strSql.Append("ISPAY_FLAG= null ,");
			}
			if (model.PAY_TIME != null)
			{
				strSql.Append("PAY_TIME='"+model.PAY_TIME+"',");
			}
			else
			{
				strSql.Append("PAY_TIME= null ,");
			}
			if (model.CONTRACT_NO != null)
			{
				strSql.Append("CONTRACT_NO='"+model.CONTRACT_NO+"',");
			}
			else
			{
				strSql.Append("CONTRACT_NO= null ,");
			}
			if (model.IMPORT_FLAG != null)
			{
				strSql.Append("IMPORT_FLAG='"+model.IMPORT_FLAG+"',");
			}
			else
			{
				strSql.Append("IMPORT_FLAG= null ,");
			}
			if (model.COST != null)
			{
				strSql.Append("COST="+model.COST+",");
			}
			else
			{
				strSql.Append("COST= null ,");
			}
			if (model.CREATE_BY != null)
			{
				strSql.Append("CREATE_BY='"+model.CREATE_BY+"',");
			}
			else
			{
				strSql.Append("CREATE_BY= null ,");
			}
			if (model.CREATE_DATE != null)
			{
				strSql.Append("CREATE_DATE='"+model.CREATE_DATE+"',");
			}
			else
			{
				strSql.Append("CREATE_DATE= null ,");
			}
			if (model.PURCHASER != null)
			{
				strSql.Append("PURCHASER='"+model.PURCHASER+"',");
			}
			else
			{
				strSql.Append("PURCHASER= null ,");
			}
			if (model.PURCHASE_DATE != null)
			{
				strSql.Append("PURCHASE_DATE='"+model.PURCHASE_DATE+"',");
			}
			else
			{
				strSql.Append("PURCHASE_DATE= null ,");
			}
			if (model.CANCEL_OPRATOR != null)
			{
				strSql.Append("CANCEL_OPRATOR='"+model.CANCEL_OPRATOR+"',");
			}
			else
			{
				strSql.Append("CANCEL_OPRATOR= null ,");
			}
			if (model.CANCEL_DATE != null)
			{
				strSql.Append("CANCEL_DATE='"+model.CANCEL_DATE+"',");
			}
			else
			{
				strSql.Append("CANCEL_DATE= null ,");
			}
			if (model.HOSPITAL_CODE != null)
			{
				strSql.Append("HOSPITAL_CODE='"+model.HOSPITAL_CODE+"',");
			}
			else
			{
				strSql.Append("HOSPITAL_CODE= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ID='"+ model.ID+"' ");
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_ds_import ");
			strSql.Append(" where ID='"+ID+"' " );
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_ds_import ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HIS.Model.his_ds_import GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,IMPORT_CODE,IMPORT_TYPE,MANUFACTURE_CODE,MANUFACTURE_NAME,INVOICE_NO,ACCOUNT_FLAG,ACCOUNT_DATE,ISPAY_FLAG,PAY_TIME,CONTRACT_NO,IMPORT_FLAG,COST,CREATE_BY,CREATE_DATE,PURCHASER,PURCHASE_DATE,CANCEL_OPRATOR,CANCEL_DATE,HOSPITAL_CODE ");
			strSql.Append(" from his_ds_import ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_ds_import model=new HIS.Model.his_ds_import();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HIS.Model.his_ds_import DataRowToModel(DataRow row)
		{
			HIS.Model.his_ds_import model=new HIS.Model.his_ds_import();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["IMPORT_CODE"]!=null)
				{
					model.IMPORT_CODE=row["IMPORT_CODE"].ToString();
				}
				if(row["IMPORT_TYPE"]!=null)
				{
					model.IMPORT_TYPE=row["IMPORT_TYPE"].ToString();
				}
				if(row["MANUFACTURE_CODE"]!=null)
				{
					model.MANUFACTURE_CODE=row["MANUFACTURE_CODE"].ToString();
				}
				if(row["MANUFACTURE_NAME"]!=null)
				{
					model.MANUFACTURE_NAME=row["MANUFACTURE_NAME"].ToString();
				}
				if(row["INVOICE_NO"]!=null)
				{
					model.INVOICE_NO=row["INVOICE_NO"].ToString();
				}
				if(row["ACCOUNT_FLAG"]!=null)
				{
					model.ACCOUNT_FLAG=row["ACCOUNT_FLAG"].ToString();
				}
				if(row["ACCOUNT_DATE"]!=null && row["ACCOUNT_DATE"].ToString()!="")
				{
					model.ACCOUNT_DATE=DateTime.Parse(row["ACCOUNT_DATE"].ToString());
				}
				if(row["ISPAY_FLAG"]!=null)
				{
					model.ISPAY_FLAG=row["ISPAY_FLAG"].ToString();
				}
				if(row["PAY_TIME"]!=null && row["PAY_TIME"].ToString()!="")
				{
					model.PAY_TIME=DateTime.Parse(row["PAY_TIME"].ToString());
				}
				if(row["CONTRACT_NO"]!=null)
				{
					model.CONTRACT_NO=row["CONTRACT_NO"].ToString();
				}
				if(row["IMPORT_FLAG"]!=null)
				{
					model.IMPORT_FLAG=row["IMPORT_FLAG"].ToString();
				}
				if(row["COST"]!=null && row["COST"].ToString()!="")
				{
					model.COST=decimal.Parse(row["COST"].ToString());
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["PURCHASER"]!=null)
				{
					model.PURCHASER=row["PURCHASER"].ToString();
				}
				if(row["PURCHASE_DATE"]!=null && row["PURCHASE_DATE"].ToString()!="")
				{
					model.PURCHASE_DATE=DateTime.Parse(row["PURCHASE_DATE"].ToString());
				}
				if(row["CANCEL_OPRATOR"]!=null)
				{
					model.CANCEL_OPRATOR=row["CANCEL_OPRATOR"].ToString();
				}
				if(row["CANCEL_DATE"]!=null && row["CANCEL_DATE"].ToString()!="")
				{
					model.CANCEL_DATE=DateTime.Parse(row["CANCEL_DATE"].ToString());
				}
				if(row["HOSPITAL_CODE"]!=null)
				{
					model.HOSPITAL_CODE=row["HOSPITAL_CODE"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,IMPORT_CODE,IMPORT_TYPE,MANUFACTURE_CODE,MANUFACTURE_NAME,INVOICE_NO,ACCOUNT_FLAG,ACCOUNT_DATE,ISPAY_FLAG,PAY_TIME,CONTRACT_NO,IMPORT_FLAG,COST,CREATE_BY,CREATE_DATE,PURCHASER,PURCHASE_DATE,CANCEL_OPRATOR,CANCEL_DATE,HOSPITAL_CODE ");
			strSql.Append(" FROM his_ds_import ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM his_ds_import ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from his_ds_import T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

