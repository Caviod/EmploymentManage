using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class InfoDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddInfo(Info InfoModel)
        {
            string sql = string.Format("insert into  Info (InfoContent,UserId,EnterpriseId,InfoTime,InfoType )values('{0}',{1},{2},'{3}',{4})", InfoModel.InfoContent, InfoModel.UserId, InfoModel.EnterpriseId, InfoModel.InfoTime,InfoModel.InfoType);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateInfo(Info InfoModel)
        {
            string sql = string.Format(" UPDATE Info  set InfoContent='{0}',UserId={1},EnterpriseId={2},InfoTime='{3}',InfoType={4} where InfoId={5} ", InfoModel.InfoContent, InfoModel.UserId, InfoModel.EnterpriseId, InfoModel.InfoTime, InfoModel.InfoType, InfoModel.InfoId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteInfo(int Id)
        {
            string sql = string.Format("delete from Info where InfoId={0}", Id);
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
                sql = "select count(*) from Info where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Info";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Info> PageSelectInfo(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Info> list = new List<Info>(); 
	    string sql = string.Format("SELECT top {0} * FROM Info where InfoId not in( select top {1} InfoId from Info where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Info GetIdByInfo(int Id)
        {
            string sql = string.Format("SELECT * FROM Info where InfoId={0} ",Id);
            Info InfoModel = new Info();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                InfoModel= GetMode(table);
            }
            return InfoModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Info> AllData(string NewWHere)
        {
            List<Info> list = new List<Info>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Info where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Info";
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
        private static List<Info> GetList(DataTable table)
        {
            List<Info> list = new List<Info>();
            foreach (DataRow row in table.Rows)
            {
                Info InfoModel = new Info(); 
                InfoModel.InfoId = Convert.ToInt32(row["InfoId"]); 
                InfoModel.InfoContent = Convert.ToString(row["InfoContent"]); 
                InfoModel.UserId = Convert.ToInt32(row["UserId"]); 
                InfoModel.EnterpriseId = Convert.ToInt32(row["EnterpriseId"]); 
                InfoModel.InfoTime = Convert.ToDateTime(row["InfoTime"]);
                InfoModel.InfoType = Convert.ToInt32(row["InfoType"]);
                list.Add(InfoModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Info GetMode(DataTable table)
        {
            Info InfoModel = new Info();
            foreach (DataRow row in table.Rows)
            {
                InfoModel.InfoId = Convert.ToInt32(row["InfoId"]); 
                InfoModel.InfoContent = Convert.ToString(row["InfoContent"]); 
                InfoModel.UserId = Convert.ToInt32(row["UserId"]); 
                InfoModel.EnterpriseId = Convert.ToInt32(row["EnterpriseId"]); 
                InfoModel.InfoTime = Convert.ToDateTime(row["InfoTime"]);
                InfoModel.InfoType = Convert.ToInt32(row["InfoType"]);

            }
            return InfoModel;
        }
    }
}