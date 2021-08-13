using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class EnterpriseDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddEnterprise(Enterprise EnterpriseModel)
        {
            string sql = string.Format("insert into  Enterprise (UserName,Pwd,EnterpriseNo,EnterpriseName,Industry,Nature,Sizes,SetUpTime,Moneys,Email,Address,Note,RegisteredTime )values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}','{10}','{11}','{12}')", EnterpriseModel.UserName, EnterpriseModel.Pwd, EnterpriseModel.EnterpriseNo, EnterpriseModel.EnterpriseName, EnterpriseModel.Industry, EnterpriseModel.Nature, EnterpriseModel.Sizes, EnterpriseModel.SetUpTime, EnterpriseModel.Moneys, EnterpriseModel.Email, EnterpriseModel.Address, EnterpriseModel.Note.Replace("'", ""), EnterpriseModel.RegisteredTime);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateEnterprise(Enterprise EnterpriseModel)
        {
            string sql = string.Format(" UPDATE Enterprise  set UserName='{0}',Pwd='{1}',EnterpriseNo='{2}',EnterpriseName='{3}',Industry='{4}',Nature='{5}',Sizes='{6}',SetUpTime='{7}',Moneys={8},Email='{9}',Address='{10}',Note='{11}',RegisteredTime='{12}' where EnterpriseId={13} ",EnterpriseModel.UserName,EnterpriseModel.Pwd,EnterpriseModel.EnterpriseNo,EnterpriseModel.EnterpriseName,EnterpriseModel.Industry,EnterpriseModel.Nature,EnterpriseModel.Sizes,EnterpriseModel.SetUpTime,EnterpriseModel.Moneys,EnterpriseModel.Email,EnterpriseModel.Address,EnterpriseModel.Note.Replace("'",""),EnterpriseModel.RegisteredTime  ,EnterpriseModel.EnterpriseId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteEnterprise(int Id)
        {
            string sql = string.Format("delete from Enterprise where EnterpriseId={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据用户名查询实体 
        ///</summary>
        public static Enterprise GetIdBySutCode(string SutCode)
        {
            string sql = string.Format("SELECT * FROM Enterprise where UserName collate Chinese_PRC_CS_AS_WS = '{0}'", SutCode);
            Enterprise SudentsModel = new Enterprise();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                SudentsModel = GetMode(table);
            }
            return SudentsModel;
        }

        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select count(*) from Enterprise where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Enterprise";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Enterprise> PageSelectEnterprise(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Enterprise> list = new List<Enterprise>(); 
	    string sql = string.Format("SELECT top {0} * FROM Enterprise where EnterpriseId not in( select top {1} EnterpriseId from Enterprise where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Enterprise GetIdByEnterprise(int Id)
        {
            string sql = string.Format("SELECT * FROM Enterprise where EnterpriseId={0} ",Id);
            Enterprise EnterpriseModel = new Enterprise();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                EnterpriseModel= GetMode(table);
            }
            return EnterpriseModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Enterprise> AllData(string NewWHere)
        {
            List<Enterprise> list = new List<Enterprise>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Enterprise where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Enterprise";
            }
            using (DataTable table = DBHelper.GetDataSet(sql))
            {

                list = GetList(table);
            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static List<Enterprise> GetList(DataTable table)
        {
            List<Enterprise> list = new List<Enterprise>();
            foreach (DataRow row in table.Rows)
            {
                Enterprise EnterpriseModel = new Enterprise(); 
                EnterpriseModel.EnterpriseId = Convert.ToInt32(row["EnterpriseId"]); 
                EnterpriseModel.UserName = Convert.ToString(row["UserName"]); 
                EnterpriseModel.Pwd = Convert.ToString(row["Pwd"]); 
                EnterpriseModel.EnterpriseNo = Convert.ToString(row["EnterpriseNo"]); 
                EnterpriseModel.EnterpriseName = Convert.ToString(row["EnterpriseName"]); 
                EnterpriseModel.Industry = Convert.ToString(row["Industry"]); 
                EnterpriseModel.Nature = Convert.ToString(row["Nature"]); 
                EnterpriseModel.Sizes = Convert.ToString(row["Sizes"]);
                EnterpriseModel.SetUpTime = Convert.ToString(row["SetUpTime"]); 
                EnterpriseModel.Moneys = Convert.ToInt32(row["Moneys"]); 
                EnterpriseModel.Email = Convert.ToString(row["Email"]); 
                EnterpriseModel.Address = Convert.ToString(row["Address"]); 
                EnterpriseModel.Note = Convert.ToString(row["Note"]); 
                EnterpriseModel.RegisteredTime = Convert.ToDateTime(row["RegisteredTime"]); 
                list.Add(EnterpriseModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Enterprise GetMode(DataTable table)
        {
            Enterprise EnterpriseModel = new Enterprise();
            foreach (DataRow row in table.Rows)
            {
                EnterpriseModel.EnterpriseId = Convert.ToInt32(row["EnterpriseId"]); 
                EnterpriseModel.UserName = Convert.ToString(row["UserName"]); 
                EnterpriseModel.Pwd = Convert.ToString(row["Pwd"]); 
                EnterpriseModel.EnterpriseNo = Convert.ToString(row["EnterpriseNo"]); 
                EnterpriseModel.EnterpriseName = Convert.ToString(row["EnterpriseName"]); 
                EnterpriseModel.Industry = Convert.ToString(row["Industry"]); 
                EnterpriseModel.Nature = Convert.ToString(row["Nature"]); 
                EnterpriseModel.Sizes = Convert.ToString(row["Sizes"]);
                EnterpriseModel.SetUpTime = Convert.ToString(row["SetUpTime"]); 
                EnterpriseModel.Moneys = Convert.ToInt32(row["Moneys"]); 
                EnterpriseModel.Email = Convert.ToString(row["Email"]); 
                EnterpriseModel.Address = Convert.ToString(row["Address"]); 
                EnterpriseModel.Note = Convert.ToString(row["Note"]); 
                EnterpriseModel.RegisteredTime = Convert.ToDateTime(row["RegisteredTime"]); 

            }
            return EnterpriseModel;
        }
    }
}