using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ApplyDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddApply(Apply ApplyModel)
        {
            string sql = string.Format("insert into  Apply (UserId,HireId,ApplyTime,State )values({0},{1},'{2}','{3}')",ApplyModel.UserId,ApplyModel.HireId,ApplyModel.ApplyTime,ApplyModel.State);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateApply(Apply ApplyModel)
        {
            string sql = string.Format(" UPDATE Apply  set UserId={0},HireId={1},ApplyTime='{2}',State='{3}' where ApplyId={4} ",ApplyModel.UserId,ApplyModel.HireId,ApplyModel.ApplyTime,ApplyModel.State  ,ApplyModel.ApplyId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteApply(int Id)
        {
            string sql = string.Format("delete from Apply where ApplyId={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select count(*) from Apply where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Apply";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Apply> PageSelectApply(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Apply> list = new List<Apply>(); 
	    string sql = string.Format("SELECT top {0} * FROM Apply where ApplyId not in( select top {1} ApplyId from Apply where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Apply GetIdByApply(int Id)
        {
            string sql = string.Format("SELECT * FROM Apply where ApplyId={0} ",Id);
            Apply ApplyModel = new Apply();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                ApplyModel= GetMode(table);
            }
            return ApplyModel;
        }


        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Apply GetIdByUserIdAndHireId(int UserId, int HireId)
        {
            string sql = string.Format("SELECT * FROM Apply where UserId={0} and  HireId={1}", UserId, HireId);
            Apply ApplyModel = new Apply();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                ApplyModel = GetMode(table);
            }
            return ApplyModel;
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Apply> AllData(string NewWHere)
        {
            List<Apply> list = new List<Apply>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Apply where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Apply";
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
        private static List<Apply> GetList(DataTable table)
        {
            List<Apply> list = new List<Apply>();
            foreach (DataRow row in table.Rows)
            {
                Apply ApplyModel = new Apply(); 
                ApplyModel.ApplyId = Convert.ToInt32(row["ApplyId"]); 
                ApplyModel.UserId = Convert.ToInt32(row["UserId"]); 
                ApplyModel.HireId = Convert.ToInt32(row["HireId"]); 
                ApplyModel.ApplyTime = Convert.ToDateTime(row["ApplyTime"]); 
                ApplyModel.State = Convert.ToString(row["State"]); 
                list.Add(ApplyModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Apply GetMode(DataTable table)
        {
            Apply ApplyModel = new Apply();
            foreach (DataRow row in table.Rows)
            {
                ApplyModel.ApplyId = Convert.ToInt32(row["ApplyId"]); 
                ApplyModel.UserId = Convert.ToInt32(row["UserId"]); 
                ApplyModel.HireId = Convert.ToInt32(row["HireId"]); 
                ApplyModel.ApplyTime = Convert.ToDateTime(row["ApplyTime"]); 
                ApplyModel.State = Convert.ToString(row["State"]); 

            }
            return ApplyModel;
        }
    }
}