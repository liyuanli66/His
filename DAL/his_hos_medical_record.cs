using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_hos_medical_record
	/// </summary>
	public partial class his_hos_medical_record
	{
		public his_hos_medical_record()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_hos_medical_record");
			strSql.Append(" where HIS_HOS_CODE='"+HIS_HOS_CODE+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_hos_medical_record model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.IP != null)
			{
				strSql1.Append("IP,");
				strSql2.Append("'"+model.IP+"',");
			}
			if (model.HIS_HOS_CODE != null)
			{
				strSql1.Append("HIS_HOS_CODE,");
				strSql2.Append("'"+model.HIS_HOS_CODE+"',");
			}
			if (model.Case_Code != null)
			{
				strSql1.Append("Case_Code,");
				strSql2.Append("'"+model.Case_Code+"',");
			}
			if (model.Patient_Name != null)
			{
				strSql1.Append("Patient_Name,");
				strSql2.Append("'"+model.Patient_Name+"',");
			}
			if (model.MD_Dept_ID != null)
			{
				strSql1.Append("MD_Dept_ID,");
				strSql2.Append("'"+model.MD_Dept_ID+"',");
			}
			if (model.MD_SickRoom_ID != null)
			{
				strSql1.Append("MD_SickRoom_ID,");
				strSql2.Append("'"+model.MD_SickRoom_ID+"',");
			}
			if (model.ME_Bed_ID != null)
			{
				strSql1.Append("ME_Bed_ID,");
				strSql2.Append("'"+model.ME_Bed_ID+"',");
			}
			if (model.In_Date != null)
			{
				strSql1.Append("In_Date,");
				strSql2.Append("'"+model.In_Date+"',");
			}
			if (model.Out_Date != null)
			{
				strSql1.Append("Out_Date,");
				strSql2.Append("'"+model.Out_Date+"',");
			}
			if (model.Status != null)
			{
				strSql1.Append("Status,");
				strSql2.Append("'"+model.Status+"',");
			}
			if (model.In_Hospital_Order != null)
			{
				strSql1.Append("In_Hospital_Order,");
				strSql2.Append(""+model.In_Hospital_Order+",");
			}
			if (model.Create_by != null)
			{
				strSql1.Append("Create_by,");
				strSql2.Append("'"+model.Create_by+"',");
			}
			if (model.Update_date != null)
			{
				strSql1.Append("Update_date,");
				strSql2.Append("'"+model.Update_date+"',");
			}
			if (model.Update_by != null)
			{
				strSql1.Append("Update_by,");
				strSql2.Append("'"+model.Update_by+"',");
			}
			if (model.is_removed != null)
			{
				strSql1.Append("is_removed,");
				strSql2.Append("'"+model.is_removed+"',");
			}
			if (model.Help_Code != null)
			{
				strSql1.Append("Help_Code,");
				strSql2.Append("'"+model.Help_Code+"',");
			}
			if (model.Create_date != null)
			{
				strSql1.Append("Create_date,");
				strSql2.Append("'"+model.Create_date+"',");
			}
			if (model.Charge_Doctor_Name != null)
			{
				strSql1.Append("Charge_Doctor_Name,");
				strSql2.Append("'"+model.Charge_Doctor_Name+"',");
			}
			if (model.Charge_Nurse_ID != null)
			{
				strSql1.Append("Charge_Nurse_ID,");
				strSql2.Append("'"+model.Charge_Nurse_ID+"',");
			}
			if (model.Charge_Nurse_Name != null)
			{
				strSql1.Append("Charge_Nurse_Name,");
				strSql2.Append("'"+model.Charge_Nurse_Name+"',");
			}
			if (model.Patient_Pay_Type != null)
			{
				strSql1.Append("Patient_Pay_Type,");
				strSql2.Append("'"+model.Patient_Pay_Type+"',");
			}
			if (model.NURSING_CLASS != null)
			{
				strSql1.Append("NURSING_CLASS,");
				strSql2.Append("'"+model.NURSING_CLASS+"',");
			}
			if (model.PATIENT_CONDITION != null)
			{
				strSql1.Append("PATIENT_CONDITION,");
				strSql2.Append("'"+model.PATIENT_CONDITION+"',");
			}
			if (model.ACCL_ACCT_ID != null)
			{
				strSql1.Append("ACCL_ACCT_ID,");
				strSql2.Append("'"+model.ACCL_ACCT_ID+"',");
			}
			if (model.TYPE != null)
			{
				strSql1.Append("TYPE,");
				strSql2.Append("'"+model.TYPE+"',");
			}
			if (model.CHANGE_DEPT_HELP != null)
			{
				strSql1.Append("CHANGE_DEPT_HELP,");
				strSql2.Append("'"+model.CHANGE_DEPT_HELP+"',");
			}
			if (model.IN_WAY != null)
			{
				strSql1.Append("IN_WAY,");
				strSql2.Append("'"+model.IN_WAY+"',");
			}
			if (model.IN_WAY_Doctor != null)
			{
				strSql1.Append("IN_WAY_Doctor,");
				strSql2.Append("'"+model.IN_WAY_Doctor+"',");
			}
			if (model.IS_INFECTION != null)
			{
				strSql1.Append("IS_INFECTION,");
				strSql2.Append("'"+model.IS_INFECTION+"',");
			}
			if (model.INTRODUCER != null)
			{
				strSql1.Append("INTRODUCER,");
				strSql2.Append("'"+model.INTRODUCER+"',");
			}
			if (model.ATTENDING_DOCTOR_ID != null)
			{
				strSql1.Append("ATTENDING_DOCTOR_ID,");
				strSql2.Append("'"+model.ATTENDING_DOCTOR_ID+"',");
			}
			if (model.IN_HOS_AGE != null)
			{
				strSql1.Append("IN_HOS_AGE,");
				strSql2.Append("'"+model.IN_HOS_AGE+"',");
			}
			if (model.MD_DEPT_NAME != null)
			{
				strSql1.Append("MD_DEPT_NAME,");
				strSql2.Append("'"+model.MD_DEPT_NAME+"',");
			}
			if (model.MD_BED_CODE != null)
			{
				strSql1.Append("MD_BED_CODE,");
				strSql2.Append("'"+model.MD_BED_CODE+"',");
			}
			if (model.MD_SICKROOM_NAME != null)
			{
				strSql1.Append("MD_SICKROOM_NAME,");
				strSql2.Append("'"+model.MD_SICKROOM_NAME+"',");
			}
			if (model.DOC_EDIT_IS != null)
			{
				strSql1.Append("DOC_EDIT_IS,");
				strSql2.Append(""+model.DOC_EDIT_IS+",");
			}
			if (model.DOC_EDIT_Account != null)
			{
				strSql1.Append("DOC_EDIT_Account,");
				strSql2.Append("'"+model.DOC_EDIT_Account+"',");
			}
			if (model.Nurse_EDIT_IS != null)
			{
				strSql1.Append("Nurse_EDIT_IS,");
				strSql2.Append(""+model.Nurse_EDIT_IS+",");
			}
			if (model.Nurse_EDITAccount != null)
			{
				strSql1.Append("Nurse_EDITAccount,");
				strSql2.Append("'"+model.Nurse_EDITAccount+"',");
			}
			strSql.Append("insert into his_hos_medical_record(");
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
		public bool Update(HIS.Model.his_hos_medical_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_hos_medical_record set ");
			if (model.IP != null)
			{
				strSql.Append("IP='"+model.IP+"',");
			}
			else
			{
				strSql.Append("IP= null ,");
			}
			if (model.Case_Code != null)
			{
				strSql.Append("Case_Code='"+model.Case_Code+"',");
			}
			else
			{
				strSql.Append("Case_Code= null ,");
			}
			if (model.Patient_Name != null)
			{
				strSql.Append("Patient_Name='"+model.Patient_Name+"',");
			}
			else
			{
				strSql.Append("Patient_Name= null ,");
			}
			if (model.MD_Dept_ID != null)
			{
				strSql.Append("MD_Dept_ID='"+model.MD_Dept_ID+"',");
			}
			else
			{
				strSql.Append("MD_Dept_ID= null ,");
			}
			if (model.MD_SickRoom_ID != null)
			{
				strSql.Append("MD_SickRoom_ID='"+model.MD_SickRoom_ID+"',");
			}
			else
			{
				strSql.Append("MD_SickRoom_ID= null ,");
			}
			if (model.ME_Bed_ID != null)
			{
				strSql.Append("ME_Bed_ID='"+model.ME_Bed_ID+"',");
			}
			else
			{
				strSql.Append("ME_Bed_ID= null ,");
			}
			if (model.In_Date != null)
			{
				strSql.Append("In_Date='"+model.In_Date+"',");
			}
			else
			{
				strSql.Append("In_Date= null ,");
			}
			if (model.Out_Date != null)
			{
				strSql.Append("Out_Date='"+model.Out_Date+"',");
			}
			else
			{
				strSql.Append("Out_Date= null ,");
			}
			if (model.Status != null)
			{
				strSql.Append("Status='"+model.Status+"',");
			}
			else
			{
				strSql.Append("Status= null ,");
			}
			if (model.In_Hospital_Order != null)
			{
				strSql.Append("In_Hospital_Order="+model.In_Hospital_Order+",");
			}
			else
			{
				strSql.Append("In_Hospital_Order= null ,");
			}
			if (model.Create_by != null)
			{
				strSql.Append("Create_by='"+model.Create_by+"',");
			}
			else
			{
				strSql.Append("Create_by= null ,");
			}
			if (model.Update_date != null)
			{
				strSql.Append("Update_date='"+model.Update_date+"',");
			}
			else
			{
				strSql.Append("Update_date= null ,");
			}
			if (model.Update_by != null)
			{
				strSql.Append("Update_by='"+model.Update_by+"',");
			}
			else
			{
				strSql.Append("Update_by= null ,");
			}
			if (model.is_removed != null)
			{
				strSql.Append("is_removed='"+model.is_removed+"',");
			}
			else
			{
				strSql.Append("is_removed= null ,");
			}
			if (model.Help_Code != null)
			{
				strSql.Append("Help_Code='"+model.Help_Code+"',");
			}
			else
			{
				strSql.Append("Help_Code= null ,");
			}
			if (model.Create_date != null)
			{
				strSql.Append("Create_date='"+model.Create_date+"',");
			}
			else
			{
				strSql.Append("Create_date= null ,");
			}
			if (model.Charge_Doctor_Name != null)
			{
				strSql.Append("Charge_Doctor_Name='"+model.Charge_Doctor_Name+"',");
			}
			else
			{
				strSql.Append("Charge_Doctor_Name= null ,");
			}
			if (model.Charge_Nurse_ID != null)
			{
				strSql.Append("Charge_Nurse_ID='"+model.Charge_Nurse_ID+"',");
			}
			else
			{
				strSql.Append("Charge_Nurse_ID= null ,");
			}
			if (model.Charge_Nurse_Name != null)
			{
				strSql.Append("Charge_Nurse_Name='"+model.Charge_Nurse_Name+"',");
			}
			else
			{
				strSql.Append("Charge_Nurse_Name= null ,");
			}
			if (model.Patient_Pay_Type != null)
			{
				strSql.Append("Patient_Pay_Type='"+model.Patient_Pay_Type+"',");
			}
			else
			{
				strSql.Append("Patient_Pay_Type= null ,");
			}
			if (model.NURSING_CLASS != null)
			{
				strSql.Append("NURSING_CLASS='"+model.NURSING_CLASS+"',");
			}
			else
			{
				strSql.Append("NURSING_CLASS= null ,");
			}
			if (model.PATIENT_CONDITION != null)
			{
				strSql.Append("PATIENT_CONDITION='"+model.PATIENT_CONDITION+"',");
			}
			else
			{
				strSql.Append("PATIENT_CONDITION= null ,");
			}
			if (model.ACCL_ACCT_ID != null)
			{
				strSql.Append("ACCL_ACCT_ID='"+model.ACCL_ACCT_ID+"',");
			}
			else
			{
				strSql.Append("ACCL_ACCT_ID= null ,");
			}
			if (model.TYPE != null)
			{
				strSql.Append("TYPE='"+model.TYPE+"',");
			}
			else
			{
				strSql.Append("TYPE= null ,");
			}
			if (model.CHANGE_DEPT_HELP != null)
			{
				strSql.Append("CHANGE_DEPT_HELP='"+model.CHANGE_DEPT_HELP+"',");
			}
			else
			{
				strSql.Append("CHANGE_DEPT_HELP= null ,");
			}
			if (model.IN_WAY != null)
			{
				strSql.Append("IN_WAY='"+model.IN_WAY+"',");
			}
			else
			{
				strSql.Append("IN_WAY= null ,");
			}
			if (model.IN_WAY_Doctor != null)
			{
				strSql.Append("IN_WAY_Doctor='"+model.IN_WAY_Doctor+"',");
			}
			else
			{
				strSql.Append("IN_WAY_Doctor= null ,");
			}
			if (model.IS_INFECTION != null)
			{
				strSql.Append("IS_INFECTION='"+model.IS_INFECTION+"',");
			}
			else
			{
				strSql.Append("IS_INFECTION= null ,");
			}
			if (model.INTRODUCER != null)
			{
				strSql.Append("INTRODUCER='"+model.INTRODUCER+"',");
			}
			else
			{
				strSql.Append("INTRODUCER= null ,");
			}
			if (model.ATTENDING_DOCTOR_ID != null)
			{
				strSql.Append("ATTENDING_DOCTOR_ID='"+model.ATTENDING_DOCTOR_ID+"',");
			}
			else
			{
				strSql.Append("ATTENDING_DOCTOR_ID= null ,");
			}
			if (model.IN_HOS_AGE != null)
			{
				strSql.Append("IN_HOS_AGE='"+model.IN_HOS_AGE+"',");
			}
			else
			{
				strSql.Append("IN_HOS_AGE= null ,");
			}
			if (model.MD_DEPT_NAME != null)
			{
				strSql.Append("MD_DEPT_NAME='"+model.MD_DEPT_NAME+"',");
			}
			else
			{
				strSql.Append("MD_DEPT_NAME= null ,");
			}
			if (model.MD_BED_CODE != null)
			{
				strSql.Append("MD_BED_CODE='"+model.MD_BED_CODE+"',");
			}
			else
			{
				strSql.Append("MD_BED_CODE= null ,");
			}
			if (model.MD_SICKROOM_NAME != null)
			{
				strSql.Append("MD_SICKROOM_NAME='"+model.MD_SICKROOM_NAME+"',");
			}
			else
			{
				strSql.Append("MD_SICKROOM_NAME= null ,");
			}
			if (model.DOC_EDIT_IS != null)
			{
				strSql.Append("DOC_EDIT_IS="+model.DOC_EDIT_IS+",");
			}
			else
			{
				strSql.Append("DOC_EDIT_IS= null ,");
			}
			if (model.DOC_EDIT_Account != null)
			{
				strSql.Append("DOC_EDIT_Account='"+model.DOC_EDIT_Account+"',");
			}
			else
			{
				strSql.Append("DOC_EDIT_Account= null ,");
			}
			if (model.Nurse_EDIT_IS != null)
			{
				strSql.Append("Nurse_EDIT_IS="+model.Nurse_EDIT_IS+",");
			}
			else
			{
				strSql.Append("Nurse_EDIT_IS= null ,");
			}
			if (model.Nurse_EDITAccount != null)
			{
				strSql.Append("Nurse_EDITAccount='"+model.Nurse_EDITAccount+"',");
			}
			else
			{
				strSql.Append("Nurse_EDITAccount= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where HIS_HOS_CODE='"+ model.HIS_HOS_CODE+"' ");
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
		public bool Delete(string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_medical_record ");
			strSql.Append(" where HIS_HOS_CODE='"+HIS_HOS_CODE+"' " );
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
		public bool DeleteList(string HIS_HOS_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_medical_record ");
			strSql.Append(" where HIS_HOS_CODE in ("+HIS_HOS_CODElist + ")  ");
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
		public HIS.Model.his_hos_medical_record GetModel(string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" IP,HIS_HOS_CODE,Case_Code,Patient_Name,MD_Dept_ID,MD_SickRoom_ID,ME_Bed_ID,In_Date,Out_Date,Status,In_Hospital_Order,Create_by,Update_date,Update_by,is_removed,Help_Code,Create_date,Charge_Doctor_Name,Charge_Nurse_ID,Charge_Nurse_Name,Patient_Pay_Type,NURSING_CLASS,PATIENT_CONDITION,ACCL_ACCT_ID,TYPE,CHANGE_DEPT_HELP,IN_WAY,IN_WAY_Doctor,IS_INFECTION,INTRODUCER,ATTENDING_DOCTOR_ID,IN_HOS_AGE,MD_DEPT_NAME,MD_BED_CODE,MD_SICKROOM_NAME,DOC_EDIT_IS,DOC_EDIT_Account,Nurse_EDIT_IS,Nurse_EDITAccount ");
			strSql.Append(" from his_hos_medical_record ");
			strSql.Append(" where HIS_HOS_CODE='"+HIS_HOS_CODE+"' " );
			HIS.Model.his_hos_medical_record model=new HIS.Model.his_hos_medical_record();
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
		public HIS.Model.his_hos_medical_record DataRowToModel(DataRow row)
		{
			HIS.Model.his_hos_medical_record model=new HIS.Model.his_hos_medical_record();
			if (row != null)
			{
				if(row["IP"]!=null)
				{
					model.IP=row["IP"].ToString();
				}
				if(row["HIS_HOS_CODE"]!=null)
				{
					model.HIS_HOS_CODE=row["HIS_HOS_CODE"].ToString();
				}
				if(row["Case_Code"]!=null)
				{
					model.Case_Code=row["Case_Code"].ToString();
				}
				if(row["Patient_Name"]!=null)
				{
					model.Patient_Name=row["Patient_Name"].ToString();
				}
				if(row["MD_Dept_ID"]!=null)
				{
					model.MD_Dept_ID=row["MD_Dept_ID"].ToString();
				}
				if(row["MD_SickRoom_ID"]!=null)
				{
					model.MD_SickRoom_ID=row["MD_SickRoom_ID"].ToString();
				}
				if(row["ME_Bed_ID"]!=null)
				{
					model.ME_Bed_ID=row["ME_Bed_ID"].ToString();
				}
				if(row["In_Date"]!=null && row["In_Date"].ToString()!="")
				{
					model.In_Date=DateTime.Parse(row["In_Date"].ToString());
				}
				if(row["Out_Date"]!=null && row["Out_Date"].ToString()!="")
				{
					model.Out_Date=DateTime.Parse(row["Out_Date"].ToString());
				}
				if(row["Status"]!=null)
				{
					model.Status=row["Status"].ToString();
				}
				if(row["In_Hospital_Order"]!=null && row["In_Hospital_Order"].ToString()!="")
				{
					model.In_Hospital_Order=int.Parse(row["In_Hospital_Order"].ToString());
				}
				if(row["Create_by"]!=null)
				{
					model.Create_by=row["Create_by"].ToString();
				}
				if(row["Update_date"]!=null && row["Update_date"].ToString()!="")
				{
					model.Update_date=DateTime.Parse(row["Update_date"].ToString());
				}
				if(row["Update_by"]!=null)
				{
					model.Update_by=row["Update_by"].ToString();
				}
				if(row["is_removed"]!=null)
				{
					model.is_removed=row["is_removed"].ToString();
				}
				if(row["Help_Code"]!=null)
				{
					model.Help_Code=row["Help_Code"].ToString();
				}
				if(row["Create_date"]!=null && row["Create_date"].ToString()!="")
				{
					model.Create_date=DateTime.Parse(row["Create_date"].ToString());
				}
				if(row["Charge_Doctor_Name"]!=null)
				{
					model.Charge_Doctor_Name=row["Charge_Doctor_Name"].ToString();
				}
				if(row["Charge_Nurse_ID"]!=null)
				{
					model.Charge_Nurse_ID=row["Charge_Nurse_ID"].ToString();
				}
				if(row["Charge_Nurse_Name"]!=null)
				{
					model.Charge_Nurse_Name=row["Charge_Nurse_Name"].ToString();
				}
				if(row["Patient_Pay_Type"]!=null)
				{
					model.Patient_Pay_Type=row["Patient_Pay_Type"].ToString();
				}
				if(row["NURSING_CLASS"]!=null)
				{
					model.NURSING_CLASS=row["NURSING_CLASS"].ToString();
				}
				if(row["PATIENT_CONDITION"]!=null)
				{
					model.PATIENT_CONDITION=row["PATIENT_CONDITION"].ToString();
				}
				if(row["ACCL_ACCT_ID"]!=null)
				{
					model.ACCL_ACCT_ID=row["ACCL_ACCT_ID"].ToString();
				}
				if(row["TYPE"]!=null)
				{
					model.TYPE=row["TYPE"].ToString();
				}
				if(row["CHANGE_DEPT_HELP"]!=null)
				{
					model.CHANGE_DEPT_HELP=row["CHANGE_DEPT_HELP"].ToString();
				}
				if(row["IN_WAY"]!=null)
				{
					model.IN_WAY=row["IN_WAY"].ToString();
				}
				if(row["IN_WAY_Doctor"]!=null)
				{
					model.IN_WAY_Doctor=row["IN_WAY_Doctor"].ToString();
				}
				if(row["IS_INFECTION"]!=null)
				{
					model.IS_INFECTION=row["IS_INFECTION"].ToString();
				}
				if(row["INTRODUCER"]!=null)
				{
					model.INTRODUCER=row["INTRODUCER"].ToString();
				}
				if(row["ATTENDING_DOCTOR_ID"]!=null)
				{
					model.ATTENDING_DOCTOR_ID=row["ATTENDING_DOCTOR_ID"].ToString();
				}
				if(row["IN_HOS_AGE"]!=null)
				{
					model.IN_HOS_AGE=row["IN_HOS_AGE"].ToString();
				}
				if(row["MD_DEPT_NAME"]!=null)
				{
					model.MD_DEPT_NAME=row["MD_DEPT_NAME"].ToString();
				}
				if(row["MD_BED_CODE"]!=null)
				{
					model.MD_BED_CODE=row["MD_BED_CODE"].ToString();
				}
				if(row["MD_SICKROOM_NAME"]!=null)
				{
					model.MD_SICKROOM_NAME=row["MD_SICKROOM_NAME"].ToString();
				}
				if(row["DOC_EDIT_IS"]!=null && row["DOC_EDIT_IS"].ToString()!="")
				{
					model.DOC_EDIT_IS=int.Parse(row["DOC_EDIT_IS"].ToString());
				}
				if(row["DOC_EDIT_Account"]!=null)
				{
					model.DOC_EDIT_Account=row["DOC_EDIT_Account"].ToString();
				}
				if(row["Nurse_EDIT_IS"]!=null && row["Nurse_EDIT_IS"].ToString()!="")
				{
					model.Nurse_EDIT_IS=int.Parse(row["Nurse_EDIT_IS"].ToString());
				}
				if(row["Nurse_EDITAccount"]!=null)
				{
					model.Nurse_EDITAccount=row["Nurse_EDITAccount"].ToString();
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
			strSql.Append("select IP,HIS_HOS_CODE,Case_Code,Patient_Name,MD_Dept_ID,MD_SickRoom_ID,ME_Bed_ID,In_Date,Out_Date,Status,In_Hospital_Order,Create_by,Update_date,Update_by,is_removed,Help_Code,Create_date,Charge_Doctor_Name,Charge_Nurse_ID,Charge_Nurse_Name,Patient_Pay_Type,NURSING_CLASS,PATIENT_CONDITION,ACCL_ACCT_ID,TYPE,CHANGE_DEPT_HELP,IN_WAY,IN_WAY_Doctor,IS_INFECTION,INTRODUCER,ATTENDING_DOCTOR_ID,IN_HOS_AGE,MD_DEPT_NAME,MD_BED_CODE,MD_SICKROOM_NAME,DOC_EDIT_IS,DOC_EDIT_Account,Nurse_EDIT_IS,Nurse_EDITAccount ");
			strSql.Append(" FROM his_hos_medical_record ");
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
			strSql.Append("select count(1) FROM his_hos_medical_record ");
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
				strSql.Append("order by T.HIS_HOS_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from his_hos_medical_record T ");
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

