using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AdminDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddAdmin(Admin AdminModel)
        {
            string sql = string.Format("insert into  Admin (AdminName,Pwd )values('{0}','{1}')",AdminModel.AdminName,AdminModel.Pwd);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateAdmin(Admin AdminModel)
        {
            string sql = string.Format(" UPDATE Admin  set AdminName='{0}',Pwd='{1}' where AdminId={2} ",AdminModel.AdminName,AdminModel.Pwd  ,AdminModel.AdminId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteAdmin(int Id)
        {
            string sql = string.Format("delete from Admin where AdminId={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }


        /// <summary> 
        /// 根据用户名查询实体 
        ///</summary>
        public static Admin GetByName(string name)
        {
            string sql = string.Format("select * from Admin where AdminName collate Chinese_PRC_CS_AS_WS='{0}'", name);
            Admin model = new Admin();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                model = GetMode(table);
            }
            return model;
        }

        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select count(*) from Admin where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Admin";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Admin> PageSelectAdmin(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Admin> list = new List<Admin>(); 
	    string sql = string.Format("SELECT top {0} * FROM Admin where AdminId not in( select top {1} AdminId from Admin where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Admin GetIdByAdmin(int Id)
        {
            string sql = string.Format("SELECT * FROM Admin where AdminId={0} ",Id);
            Admin AdminModel = new Admin();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                AdminModel= GetMode(table);
            }
            return AdminModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Admin> AllData(string NewWHere)
        {
            List<Admin> list = new List<Admin>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Admin where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Admin";
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
        private static List<Admin> GetList(DataTable table)
        {
            List<Admin> list = new List<Admin>();
            foreach (DataRow row in table.Rows)
            {
                Admin AdminModel = new Admin(); 
                AdminModel.AdminId = Convert.ToInt32(row["AdminId"]); 
                AdminModel.AdminName = Convert.ToString(row["AdminName"]); 
                AdminModel.Pwd = Convert.ToString(row["Pwd"]); 
                list.Add(AdminModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Admin GetMode(DataTable table)
        {
            Admin AdminModel = new Admin();
            foreach (DataRow row in table.Rows)
            {
                AdminModel.AdminId = Convert.ToInt32(row["AdminId"]); 
                AdminModel.AdminName = Convert.ToString(row["AdminName"]); 
                AdminModel.Pwd = Convert.ToString(row["Pwd"]); 

            }
            return AdminModel;
        }
    }
}