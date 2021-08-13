using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class MessageDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddMessage(Message MessageModel)
        {
            string sql = string.Format("insert into  Message (MsgTitle,MsgContent,UserId,MsgTime )values('{0}','{1}',{2},'{3}')",MessageModel.MsgTitle,MessageModel.MsgContent.Replace("'",""),MessageModel.UserId,MessageModel.MsgTime);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateMessage(Message MessageModel)
        {
            string sql = string.Format(" UPDATE Message  set MsgTitle='{0}',MsgContent='{1}',UserId={2},MsgTime='{3}' where MsgId={4} ", MessageModel.MsgTitle, MessageModel.MsgContent.Replace("'", ""), MessageModel.UserId, MessageModel.MsgTime, MessageModel.MsgId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteMessage(int Id)
        {
            string sql = string.Format("delete from Message where MsgId={0}", Id);
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
                sql = "select count(*) from Message where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Message";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Message> PageSelectMessage(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Message> list = new List<Message>(); 
	    string sql = string.Format("SELECT top {0} * FROM Message where MsgId not in( select top {1} MsgId from Message where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Message GetIdByMessage(int Id)
        {
            string sql = string.Format("SELECT * FROM Message where MsgId={0} ",Id);
            Message MessageModel = new Message();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                MessageModel= GetMode(table);
            }
            return MessageModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Message> AllData(string NewWHere)
        {
            List<Message> list = new List<Message>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Message where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Message";
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
        private static List<Message> GetList(DataTable table)
        {
            List<Message> list = new List<Message>();
            foreach (DataRow row in table.Rows)
            {
                Message MessageModel = new Message(); 
                MessageModel.MsgId = Convert.ToInt32(row["MsgId"]); 
                MessageModel.MsgTitle = Convert.ToString(row["MsgTitle"]); 
                MessageModel.MsgContent = Convert.ToString(row["MsgContent"]); 
                MessageModel.UserId = Convert.ToInt32(row["UserId"]); 
                MessageModel.MsgTime = Convert.ToDateTime(row["MsgTime"]); 
                list.Add(MessageModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Message GetMode(DataTable table)
        {
            Message MessageModel = new Message();
            foreach (DataRow row in table.Rows)
            {
                MessageModel.MsgId = Convert.ToInt32(row["MsgId"]); 
                MessageModel.MsgTitle = Convert.ToString(row["MsgTitle"]); 
                MessageModel.MsgContent = Convert.ToString(row["MsgContent"]); 
                MessageModel.UserId = Convert.ToInt32(row["UserId"]); 
                MessageModel.MsgTime = Convert.ToDateTime(row["MsgTime"]); 

            }
            return MessageModel;
        }
    }
}