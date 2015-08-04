using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_medinfo
	/// </summary>
	public partial class his_comm_medinfo
	{
		public his_comm_medinfo()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_medinfo");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_comm_medinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.MED_CODE != null)
			{
				strSql1.Append("MED_CODE,");
				strSql2.Append("'"+model.MED_CODE+"',");
			}
			if (model.MED_NAME != null)
			{
				strSql1.Append("MED_NAME,");
				strSql2.Append("'"+model.MED_NAME+"',");
			}
			if (model.HELP_CODE != null)
			{
				strSql1.Append("HELP_CODE,");
				strSql2.Append("'"+model.HELP_CODE+"',");
			}
			if (model.MENUFACTURE_CODE != null)
			{
				strSql1.Append("MENUFACTURE_CODE,");
				strSql2.Append("'"+model.MENUFACTURE_CODE+"',");
			}
			if (model.MED_SPC != null)
			{
				strSql1.Append("MED_SPC,");
				strSql2.Append("'"+model.MED_SPC+"',");
			}
			if (model.MED_UNIT != null)
			{
				strSql1.Append("MED_UNIT,");
				strSql2.Append("'"+model.MED_UNIT+"',");
			}
			if (model.DOSAGE_CODE != null)
			{
				strSql1.Append("DOSAGE_CODE,");
				strSql2.Append("'"+model.DOSAGE_CODE+"',");
			}
			if (model.APPROVAL_NUMBER != null)
			{
				strSql1.Append("APPROVAL_NUMBER,");
				strSql2.Append("'"+model.APPROVAL_NUMBER+"',");
			}
			if (model.EFFICACY_CODE != null)
			{
				strSql1.Append("EFFICACY_CODE,");
				strSql2.Append("'"+model.EFFICACY_CODE+"',");
			}
			if (model.ORIGIN != null)
			{
				strSql1.Append("ORIGIN,");
				strSql2.Append("'"+model.ORIGIN+"',");
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
			if (model.MEDINFO_CODE != null)
			{
				strSql1.Append("MEDINFO_CODE,");
				strSql2.Append("'"+model.MEDINFO_CODE+"',");
			}
			if (model.PAKAGE_UNIT != null)
			{
				strSql1.Append("PAKAGE_UNIT,");
				strSql2.Append("'"+model.PAKAGE_UNIT+"',");
			}
			if (model.PAKAGE_PM_NUMBER != null)
			{
				strSql1.Append("PAKAGE_PM_NUMBER,");
				strSql2.Append(""+model.PAKAGE_PM_NUMBER+",");
			}
			if (model.DEFAULT_DOSAGE_AMOUNT != null)
			{
				strSql1.Append("DEFAULT_DOSAGE_AMOUNT,");
				strSql2.Append(""+model.DEFAULT_DOSAGE_AMOUNT+",");
			}
			strSql.Append("insert into his_comm_medinfo(");
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
		public bool Update(HIS.Model.his_comm_medinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_medinfo set ");
			if (model.MED_CODE != null)
			{
				strSql.Append("MED_CODE='"+model.MED_CODE+"',");
			}
			else
			{
				strSql.Append("MED_CODE= null ,");
			}
			if (model.MED_NAME != null)
			{
				strSql.Append("MED_NAME='"+model.MED_NAME+"',");
			}
			else
			{
				strSql.Append("MED_NAME= null ,");
			}
			if (model.HELP_CODE != null)
			{
				strSql.Append("HELP_CODE='"+model.HELP_CODE+"',");
			}
			else
			{
				strSql.Append("HELP_CODE= null ,");
			}
			if (model.MENUFACTURE_CODE != null)
			{
				strSql.Append("MENUFACTURE_CODE='"+model.MENUFACTURE_CODE+"',");
			}
			else
			{
				strSql.Append("MENUFACTURE_CODE= null ,");
			}
			if (model.MED_SPC != null)
			{
				strSql.Append("MED_SPC='"+model.MED_SPC+"',");
			}
			else
			{
				strSql.Append("MED_SPC= null ,");
			}
			if (model.MED_UNIT != null)
			{
				strSql.Append("MED_UNIT='"+model.MED_UNIT+"',");
			}
			else
			{
				strSql.Append("MED_UNIT= null ,");
			}
			if (model.DOSAGE_CODE != null)
			{
				strSql.Append("DOSAGE_CODE='"+model.DOSAGE_CODE+"',");
			}
			else
			{
				strSql.Append("DOSAGE_CODE= null ,");
			}
			if (model.APPROVAL_NUMBER != null)
			{
				strSql.Append("APPROVAL_NUMBER='"+model.APPROVAL_NUMBER+"',");
			}
			else
			{
				strSql.Append("APPROVAL_NUMBER= null ,");
			}
			if (model.EFFICACY_CODE != null)
			{
				strSql.Append("EFFICACY_CODE='"+model.EFFICACY_CODE+"',");
			}
			else
			{
				strSql.Append("EFFICACY_CODE= null ,");
			}
			if (model.ORIGIN != null)
			{
				strSql.Append("ORIGIN='"+model.ORIGIN+"',");
			}
			else
			{
				strSql.Append("ORIGIN= null ,");
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
			if (model.MEDINFO_CODE != null)
			{
				strSql.Append("MEDINFO_CODE='"+model.MEDINFO_CODE+"',");
			}
			else
			{
				strSql.Append("MEDINFO_CODE= null ,");
			}
			if (model.PAKAGE_UNIT != null)
			{
				strSql.Append("PAKAGE_UNIT='"+model.PAKAGE_UNIT+"',");
			}
			else
			{
				strSql.Append("PAKAGE_UNIT= null ,");
			}
			if (model.PAKAGE_PM_NUMBER != null)
			{
				strSql.Append("PAKAGE_PM_NUMBER="+model.PAKAGE_PM_NUMBER+",");
			}
			else
			{
				strSql.Append("PAKAGE_PM_NUMBER= null ,");
			}
			if (model.DEFAULT_DOSAGE_AMOUNT != null)
			{
				strSql.Append("DEFAULT_DOSAGE_AMOUNT="+model.DEFAULT_DOSAGE_AMOUNT+",");
			}
			else
			{
				strSql.Append("DEFAULT_DOSAGE_AMOUNT= null ,");
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
			strSql.Append("delete from his_comm_medinfo ");
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
			strSql.Append("delete from his_comm_medinfo ");
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
		public HIS.Model.his_comm_medinfo GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,MED_CODE,MED_NAME,HELP_CODE,MENUFACTURE_CODE,MED_SPC,MED_UNIT,DOSAGE_CODE,APPROVAL_NUMBER,EFFICACY_CODE,ORIGIN,CREATE_BY,CREATE_DATE,MEDINFO_CODE,PAKAGE_UNIT,PAKAGE_PM_NUMBER,DEFAULT_DOSAGE_AMOUNT ");
			strSql.Append(" from his_comm_medinfo ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_comm_medinfo model=new HIS.Model.his_comm_medinfo();
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
		public HIS.Model.his_comm_medinfo DataRowToModel(DataRow row)
		{
			HIS.Model.his_comm_medinfo model=new HIS.Model.his_comm_medinfo();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MED_CODE"]!=null)
				{
					model.MED_CODE=row["MED_CODE"].ToString();
				}
				if(row["MED_NAME"]!=null)
				{
					model.MED_NAME=row["MED_NAME"].ToString();
				}
				if(row["HELP_CODE"]!=null)
				{
					model.HELP_CODE=row["HELP_CODE"].ToString();
				}
				if(row["MENUFACTURE_CODE"]!=null)
				{
					model.MENUFACTURE_CODE=row["MENUFACTURE_CODE"].ToString();
				}
				if(row["MED_SPC"]!=null)
				{
					model.MED_SPC=row["MED_SPC"].ToString();
				}
				if(row["MED_UNIT"]!=null)
				{
					model.MED_UNIT=row["MED_UNIT"].ToString();
				}
				if(row["DOSAGE_CODE"]!=null)
				{
					model.DOSAGE_CODE=row["DOSAGE_CODE"].ToString();
				}
				if(row["APPROVAL_NUMBER"]!=null)
				{
					model.APPROVAL_NUMBER=row["APPROVAL_NUMBER"].ToString();
				}
				if(row["EFFICACY_CODE"]!=null)
				{
					model.EFFICACY_CODE=row["EFFICACY_CODE"].ToString();
				}
				if(row["ORIGIN"]!=null)
				{
					model.ORIGIN=row["ORIGIN"].ToString();
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["MEDINFO_CODE"]!=null)
				{
					model.MEDINFO_CODE=row["MEDINFO_CODE"].ToString();
				}
				if(row["PAKAGE_UNIT"]!=null)
				{
					model.PAKAGE_UNIT=row["PAKAGE_UNIT"].ToString();
				}
				if(row["PAKAGE_PM_NUMBER"]!=null && row["PAKAGE_PM_NUMBER"].ToString()!="")
				{
					model.PAKAGE_PM_NUMBER=int.Parse(row["PAKAGE_PM_NUMBER"].ToString());
				}
				if(row["DEFAULT_DOSAGE_AMOUNT"]!=null && row["DEFAULT_DOSAGE_AMOUNT"].ToString()!="")
				{
					model.DEFAULT_DOSAGE_AMOUNT=decimal.Parse(row["DEFAULT_DOSAGE_AMOUNT"].ToString());
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
			strSql.Append("select ID,MED_CODE,MED_NAME,HELP_CODE,MENUFACTURE_CODE,MED_SPC,MED_UNIT,DOSAGE_CODE,APPROVAL_NUMBER,EFFICACY_CODE,ORIGIN,CREATE_BY,CREATE_DATE,MEDINFO_CODE,PAKAGE_UNIT,PAKAGE_PM_NUMBER,DEFAULT_DOSAGE_AMOUNT ");
			strSql.Append(" FROM his_comm_medinfo ");
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
			strSql.Append("select count(1) FROM his_comm_medinfo ");
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
			strSql.Append(")AS Row, T.*  from his_comm_medinfo T ");
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

