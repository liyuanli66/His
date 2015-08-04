using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_cl_prescription
	/// </summary>
	public partial class his_cl_prescription
	{
		public his_cl_prescription()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CL_PRES_CODE,string CL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_cl_prescription");
			strSql.Append(" where CL_PRES_CODE='"+CL_PRES_CODE+"' and CL_CODE='"+CL_CODE+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_cl_prescription model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.CL_PRES_CODE != null)
			{
				strSql1.Append("CL_PRES_CODE,");
				strSql2.Append("'"+model.CL_PRES_CODE+"',");
			}
			if (model.CL_CODE != null)
			{
				strSql1.Append("CL_CODE,");
				strSql2.Append("'"+model.CL_CODE+"',");
			}
			if (model.STATUS != null)
			{
				strSql1.Append("STATUS,");
				strSql2.Append("'"+model.STATUS+"',");
			}
			if (model.APPLY_DEPT_CODE != null)
			{
				strSql1.Append("APPLY_DEPT_CODE,");
				strSql2.Append("'"+model.APPLY_DEPT_CODE+"',");
			}
			if (model.DOCTOR_CODE != null)
			{
				strSql1.Append("DOCTOR_CODE,");
				strSql2.Append("'"+model.DOCTOR_CODE+"',");
			}
			if (model.OPERATE_DEPT_CODE != null)
			{
				strSql1.Append("OPERATE_DEPT_CODE,");
				strSql2.Append("'"+model.OPERATE_DEPT_CODE+"',");
			}
			if (model.SUM_AMT != null)
			{
				strSql1.Append("SUM_AMT,");
				strSql2.Append(""+model.SUM_AMT+",");
			}
			if (model.OPT_USER != null)
			{
				strSql1.Append("OPT_USER,");
				strSql2.Append("'"+model.OPT_USER+"',");
			}
			if (model.OPT_DATE != null)
			{
				strSql1.Append("OPT_DATE,");
				strSql2.Append("'"+model.OPT_DATE+"',");
			}
			if (model.OPT_TERM != null)
			{
				strSql1.Append("OPT_TERM,");
				strSql2.Append("'"+model.OPT_TERM+"',");
			}
			if (model.OPT_ORGA != null)
			{
				strSql1.Append("OPT_ORGA,");
				strSql2.Append("'"+model.OPT_ORGA+"',");
			}
			strSql.Append("insert into his_cl_prescription(");
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
		public bool Update(HIS.Model.his_cl_prescription model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_cl_prescription set ");
			if (model.STATUS != null)
			{
				strSql.Append("STATUS='"+model.STATUS+"',");
			}
			else
			{
				strSql.Append("STATUS= null ,");
			}
			if (model.APPLY_DEPT_CODE != null)
			{
				strSql.Append("APPLY_DEPT_CODE='"+model.APPLY_DEPT_CODE+"',");
			}
			else
			{
				strSql.Append("APPLY_DEPT_CODE= null ,");
			}
			if (model.DOCTOR_CODE != null)
			{
				strSql.Append("DOCTOR_CODE='"+model.DOCTOR_CODE+"',");
			}
			else
			{
				strSql.Append("DOCTOR_CODE= null ,");
			}
			if (model.OPERATE_DEPT_CODE != null)
			{
				strSql.Append("OPERATE_DEPT_CODE='"+model.OPERATE_DEPT_CODE+"',");
			}
			else
			{
				strSql.Append("OPERATE_DEPT_CODE= null ,");
			}
			if (model.SUM_AMT != null)
			{
				strSql.Append("SUM_AMT="+model.SUM_AMT+",");
			}
			else
			{
				strSql.Append("SUM_AMT= null ,");
			}
			if (model.OPT_USER != null)
			{
				strSql.Append("OPT_USER='"+model.OPT_USER+"',");
			}
			if (model.OPT_DATE != null)
			{
				strSql.Append("OPT_DATE='"+model.OPT_DATE+"',");
			}
			if (model.OPT_TERM != null)
			{
				strSql.Append("OPT_TERM='"+model.OPT_TERM+"',");
			}
			if (model.OPT_ORGA != null)
			{
				strSql.Append("OPT_ORGA='"+model.OPT_ORGA+"',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where CL_PRES_CODE='"+ model.CL_PRES_CODE+"' and CL_CODE='"+ model.CL_CODE+"' ");
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
		public bool Delete(string CL_PRES_CODE,string CL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_cl_prescription ");
			strSql.Append(" where CL_PRES_CODE='"+CL_PRES_CODE+"' and CL_CODE='"+CL_CODE+"' " );
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
		/// 得到一个对象实体
		/// </summary>
		public HIS.Model.his_cl_prescription GetModel(string CL_PRES_CODE,string CL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" CL_PRES_CODE,CL_CODE,STATUS,APPLY_DEPT_CODE,DOCTOR_CODE,OPERATE_DEPT_CODE,SUM_AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" from his_cl_prescription ");
			strSql.Append(" where CL_PRES_CODE='"+CL_PRES_CODE+"' and CL_CODE='"+CL_CODE+"' " );
			HIS.Model.his_cl_prescription model=new HIS.Model.his_cl_prescription();
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
		public HIS.Model.his_cl_prescription DataRowToModel(DataRow row)
		{
			HIS.Model.his_cl_prescription model=new HIS.Model.his_cl_prescription();
			if (row != null)
			{
				if(row["CL_PRES_CODE"]!=null)
				{
					model.CL_PRES_CODE=row["CL_PRES_CODE"].ToString();
				}
				if(row["CL_CODE"]!=null)
				{
					model.CL_CODE=row["CL_CODE"].ToString();
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["APPLY_DEPT_CODE"]!=null)
				{
					model.APPLY_DEPT_CODE=row["APPLY_DEPT_CODE"].ToString();
				}
				if(row["DOCTOR_CODE"]!=null)
				{
					model.DOCTOR_CODE=row["DOCTOR_CODE"].ToString();
				}
				if(row["OPERATE_DEPT_CODE"]!=null)
				{
					model.OPERATE_DEPT_CODE=row["OPERATE_DEPT_CODE"].ToString();
				}
				if(row["SUM_AMT"]!=null && row["SUM_AMT"].ToString()!="")
				{
					model.SUM_AMT=decimal.Parse(row["SUM_AMT"].ToString());
				}
				if(row["OPT_USER"]!=null)
				{
					model.OPT_USER=row["OPT_USER"].ToString();
				}
				if(row["OPT_DATE"]!=null && row["OPT_DATE"].ToString()!="")
				{
					model.OPT_DATE=DateTime.Parse(row["OPT_DATE"].ToString());
				}
				if(row["OPT_TERM"]!=null)
				{
					model.OPT_TERM=row["OPT_TERM"].ToString();
				}
				if(row["OPT_ORGA"]!=null)
				{
					model.OPT_ORGA=row["OPT_ORGA"].ToString();
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
			strSql.Append("select CL_PRES_CODE,CL_CODE,STATUS,APPLY_DEPT_CODE,DOCTOR_CODE,OPERATE_DEPT_CODE,SUM_AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" FROM his_cl_prescription ");
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
			strSql.Append("select count(1) FROM his_cl_prescription ");
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
				strSql.Append("order by T.CL_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from his_cl_prescription T ");
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

