using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_hos_medical_record
		public partial class his_hos_medical_record
	{
   		     
		private readonly HisClient.DAL.his_hos_medical_record dal=new HisClient.DAL.his_hos_medical_record();
		public his_hos_medical_record()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HIS_HOS_CODE)
		{
			return dal.Exists(HIS_HOS_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_hos_medical_record model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_hos_medical_record model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string HIS_HOS_CODE)
		{
			
			return dal.Delete(HIS_HOS_CODE);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_hos_medical_record GetModel(string HIS_HOS_CODE)
		{
			
			return dal.GetModel(HIS_HOS_CODE);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_hos_medical_record> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_hos_medical_record> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_hos_medical_record> modelList = new List<HisClient.Model.his_hos_medical_record>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_hos_medical_record model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_hos_medical_record();					
																	model.IP= dt.Rows[n]["IP"].ToString();
																																model.HIS_HOS_CODE= dt.Rows[n]["HIS_HOS_CODE"].ToString();
																																model.Case_Code= dt.Rows[n]["Case_Code"].ToString();
																																model.Patient_Name= dt.Rows[n]["Patient_Name"].ToString();
																																model.MD_Dept_ID= dt.Rows[n]["MD_Dept_ID"].ToString();
																																model.MD_SickRoom_ID= dt.Rows[n]["MD_SickRoom_ID"].ToString();
																																model.ME_Bed_ID= dt.Rows[n]["ME_Bed_ID"].ToString();
																												if(dt.Rows[n]["In_Date"].ToString()!="")
				{
					model.In_Date=DateTime.Parse(dt.Rows[n]["In_Date"].ToString());
				}
																																if(dt.Rows[n]["Out_Date"].ToString()!="")
				{
					model.Out_Date=DateTime.Parse(dt.Rows[n]["Out_Date"].ToString());
				}
																																				model.Status= dt.Rows[n]["Status"].ToString();
																												if(dt.Rows[n]["In_Hospital_Order"].ToString()!="")
				{
					model.In_Hospital_Order=int.Parse(dt.Rows[n]["In_Hospital_Order"].ToString());
				}
																																				model.Create_by= dt.Rows[n]["Create_by"].ToString();
																												if(dt.Rows[n]["Update_date"].ToString()!="")
				{
					model.Update_date=DateTime.Parse(dt.Rows[n]["Update_date"].ToString());
				}
																																				model.Update_by= dt.Rows[n]["Update_by"].ToString();
																																model.is_removed= dt.Rows[n]["is_removed"].ToString();
																																model.Help_Code= dt.Rows[n]["Help_Code"].ToString();
																												if(dt.Rows[n]["Create_date"].ToString()!="")
				{
					model.Create_date=DateTime.Parse(dt.Rows[n]["Create_date"].ToString());
				}
																																				model.Charge_Doctor_Name= dt.Rows[n]["Charge_Doctor_Name"].ToString();
																																model.Charge_Nurse_ID= dt.Rows[n]["Charge_Nurse_ID"].ToString();
																																model.Charge_Nurse_Name= dt.Rows[n]["Charge_Nurse_Name"].ToString();
																																model.Patient_Pay_Type= dt.Rows[n]["Patient_Pay_Type"].ToString();
																																model.NURSING_CLASS= dt.Rows[n]["NURSING_CLASS"].ToString();
																																model.PATIENT_CONDITION= dt.Rows[n]["PATIENT_CONDITION"].ToString();
																																model.ACCL_ACCT_ID= dt.Rows[n]["ACCL_ACCT_ID"].ToString();
																																model.TYPE= dt.Rows[n]["TYPE"].ToString();
																																model.CHANGE_DEPT_HELP= dt.Rows[n]["CHANGE_DEPT_HELP"].ToString();
																																model.IN_WAY= dt.Rows[n]["IN_WAY"].ToString();
																																model.IN_WAY_Doctor= dt.Rows[n]["IN_WAY_Doctor"].ToString();
																																model.IS_INFECTION= dt.Rows[n]["IS_INFECTION"].ToString();
																																model.INTRODUCER= dt.Rows[n]["INTRODUCER"].ToString();
																																model.ATTENDING_DOCTOR_ID= dt.Rows[n]["ATTENDING_DOCTOR_ID"].ToString();
																																model.IN_HOS_AGE= dt.Rows[n]["IN_HOS_AGE"].ToString();
																																model.MD_DEPT_NAME= dt.Rows[n]["MD_DEPT_NAME"].ToString();
																																model.MD_BED_CODE= dt.Rows[n]["MD_BED_CODE"].ToString();
																																model.MD_SICKROOM_NAME= dt.Rows[n]["MD_SICKROOM_NAME"].ToString();
																												if(dt.Rows[n]["DOC_EDIT_IS"].ToString()!="")
				{
					model.DOC_EDIT_IS=int.Parse(dt.Rows[n]["DOC_EDIT_IS"].ToString());
				}
																																				model.DOC_EDIT_Account= dt.Rows[n]["DOC_EDIT_Account"].ToString();
																												if(dt.Rows[n]["Nurse_EDIT_IS"].ToString()!="")
				{
					model.Nurse_EDIT_IS=int.Parse(dt.Rows[n]["Nurse_EDIT_IS"].ToString());
				}
																																				model.Nurse_EDITAccount= dt.Rows[n]["Nurse_EDITAccount"].ToString();
																						
				
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
#endregion
   
	}
}