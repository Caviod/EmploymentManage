using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class MessageBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddMessage(Message MessageModel)
        {
            return MessageDAL.AddMessage(MessageModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteMessage(int Id)
        {
            return MessageDAL.DeleteMessage(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Message> PageSelectMessage(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return MessageDAL.PageSelectMessage(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateMessage(Message MessageModel)
        {
            return MessageDAL.UpdateMessage(MessageModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Message> AllData(string NewWHere)
        {
            return MessageDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return MessageDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Message GetIdByMessage(int Id)
        {
            return MessageDAL.GetIdByMessage(Id);
        }
    }
}