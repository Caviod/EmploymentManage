using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ReplyBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddReply(Reply ReplyModel)
        {
            return ReplyDAL.AddReply(ReplyModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteReply(int Id)
        {
            return ReplyDAL.DeleteReply(Id);
        }

        /// <summary> 
        /// 根据留言ID删除 
        ///</summary>
        public static int DeleteReplyByMsgId(int MsgId)
        {
            return ReplyDAL.DeleteReplyByMsgId(MsgId);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Reply> PageSelectReply(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return ReplyDAL.PageSelectReply(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateReply(Reply ReplyModel)
        {
            return ReplyDAL.UpdateReply(ReplyModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Reply> AllData(string NewWHere)
        {
            return ReplyDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return ReplyDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Reply GetIdByReply(int Id)
        {
            return ReplyDAL.GetIdByReply(Id);
        }
    }
}