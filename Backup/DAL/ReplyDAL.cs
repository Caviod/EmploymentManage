using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ReplyDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddReply(Reply ReplyModel)
        {
            string sql = string.Format("insert into  Reply (ReplyContent,UserId,ReplyTime,MsgId )values('{0}',{1},'{2}',{3})",ReplyModel.ReplyContent,ReplyModel.UserId,ReplyModel.ReplyTime,ReplyModel.MsgId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateReply(Reply ReplyModel)
        {
            string sql = string.Format(" UPDATE Reply  set ReplyContent='{0}',UserId={1},ReplyTime='{2}',MsgId={3} where ReplyId={4} ",ReplyModel.ReplyContent,ReplyModel.UserId,ReplyModel.ReplyTime,ReplyModel.MsgId  ,ReplyModel.ReplyId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteReply(int Id)
        {
            string sql = string.Format("delete from Reply where ReplyId={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据留言ID删除 
        ///</summary>
        public static int DeleteReplyByMsgId(int MsgId)
        {
            string sql = string.Format("delete from Reply where MsgId={0}", MsgId);
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
                sql = "select count(*) from Reply where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Reply";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Reply> PageSelectReply(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Reply> list = new List<Reply>(); 
	    string sql = string.Format("SELECT top {0} * FROM Reply where ReplyId not in( select top {1} ReplyId from Reply where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Reply GetIdByReply(int Id)
        {
            string sql = string.Format("SELECT * FROM Reply where ReplyId={0} ",Id);
            Reply ReplyModel = new Reply();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                ReplyModel= GetMode(table);
            }
            return ReplyModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Reply> AllData(string NewWHere)
        {
            List<Reply> list = new List<Reply>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Reply where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Reply";
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
        private static List<Reply> GetList(DataTable table)
        {
            List<Reply> list = new List<Reply>();
            foreach (DataRow row in table.Rows)
            {
                Reply ReplyModel = new Reply(); 
                ReplyModel.ReplyId = Convert.ToInt32(row["ReplyId"]); 
                ReplyModel.ReplyContent = Convert.ToString(row["ReplyContent"]); 
                ReplyModel.UserId = Convert.ToInt32(row["UserId"]); 
                ReplyModel.ReplyTime = Convert.ToDateTime(row["ReplyTime"]); 
                ReplyModel.MsgId = Convert.ToInt32(row["MsgId"]); 
                list.Add(ReplyModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Reply GetMode(DataTable table)
        {
            Reply ReplyModel = new Reply();
            foreach (DataRow row in table.Rows)
            {
                ReplyModel.ReplyId = Convert.ToInt32(row["ReplyId"]); 
                ReplyModel.ReplyContent = Convert.ToString(row["ReplyContent"]); 
                ReplyModel.UserId = Convert.ToInt32(row["UserId"]); 
                ReplyModel.ReplyTime = Convert.ToDateTime(row["ReplyTime"]); 
                ReplyModel.MsgId = Convert.ToInt32(row["MsgId"]); 

            }
            return ReplyModel;
        }
    }
}