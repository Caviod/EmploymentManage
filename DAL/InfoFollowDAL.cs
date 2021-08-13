using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class InfoFollowDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddInfoFollow(InfoFollow InfoFollowModel)
        {
            string sql = string.Format("insert into  InfoFollow (FollowContent,FollowId,FollowType,InfoId,FollowTime )values('{0}',{1},{2},{3},'{4}')",InfoFollowModel.FollowContent,InfoFollowModel.FollowId,InfoFollowModel.FollowType,InfoFollowModel.InfoId,InfoFollowModel.FollowTime);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateInfoFollow(InfoFollow InfoFollowModel)
        {
            string sql = string.Format(" UPDATE InfoFollow  set FollowContent='{0}',FollowId={1},FollowType={2},InfoId={3},FollowTime='{4}' where InfoFollowId={5} ",InfoFollowModel.FollowContent,InfoFollowModel.FollowId,InfoFollowModel.FollowType,InfoFollowModel.InfoId,InfoFollowModel.FollowTime  ,InfoFollowModel.InfoFollowId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteInfoFollow(int Id)
        {
            string sql = string.Format("delete from InfoFollow where InfoFollowId={0}", Id);
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
                sql = "select count(*) from InfoFollow where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from InfoFollow";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<InfoFollow> PageSelectInfoFollow(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<InfoFollow> list = new List<InfoFollow>(); 
	    string sql = string.Format("SELECT top {0} * FROM InfoFollow where InfoFollowId not in( select top {1} InfoFollowId from InfoFollow where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static InfoFollow GetIdByInfoFollow(int Id)
        {
            string sql = string.Format("SELECT * FROM InfoFollow where InfoFollowId={0} ",Id);
            InfoFollow InfoFollowModel = new InfoFollow();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                InfoFollowModel= GetMode(table);
            }
            return InfoFollowModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<InfoFollow> AllData(string NewWHere)
        {
            List<InfoFollow> list = new List<InfoFollow>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from InfoFollow where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from InfoFollow";
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
        private static List<InfoFollow> GetList(DataTable table)
        {
            List<InfoFollow> list = new List<InfoFollow>();
            foreach (DataRow row in table.Rows)
            {
                InfoFollow InfoFollowModel = new InfoFollow(); 
                InfoFollowModel.InfoFollowId = Convert.ToInt32(row["InfoFollowId"]); 
                InfoFollowModel.FollowContent = Convert.ToString(row["FollowContent"]); 
                InfoFollowModel.FollowId = Convert.ToInt32(row["FollowId"]); 
                InfoFollowModel.FollowType = Convert.ToInt32(row["FollowType"]); 
                InfoFollowModel.InfoId = Convert.ToInt32(row["InfoId"]); 
                InfoFollowModel.FollowTime = Convert.ToDateTime(row["FollowTime"]); 
                list.Add(InfoFollowModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static InfoFollow GetMode(DataTable table)
        {
            InfoFollow InfoFollowModel = new InfoFollow();
            foreach (DataRow row in table.Rows)
            {
                InfoFollowModel.InfoFollowId = Convert.ToInt32(row["InfoFollowId"]); 
                InfoFollowModel.FollowContent = Convert.ToString(row["FollowContent"]); 
                InfoFollowModel.FollowId = Convert.ToInt32(row["FollowId"]); 
                InfoFollowModel.FollowType = Convert.ToInt32(row["FollowType"]); 
                InfoFollowModel.InfoId = Convert.ToInt32(row["InfoId"]); 
                InfoFollowModel.FollowTime = Convert.ToDateTime(row["FollowTime"]); 

            }
            return InfoFollowModel;
        }
    }
}