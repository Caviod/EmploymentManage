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
        /// ��� 
        ///</summary> 
        public static int AddReply(Reply ReplyModel)
        {
            return ReplyDAL.AddReply(ReplyModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteReply(int Id)
        {
            return ReplyDAL.DeleteReply(Id);
        }

        /// <summary> 
        /// ��������IDɾ�� 
        ///</summary>
        public static int DeleteReplyByMsgId(int MsgId)
        {
            return ReplyDAL.DeleteReplyByMsgId(MsgId);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Reply> PageSelectReply(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return ReplyDAL.PageSelectReply(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateReply(Reply ReplyModel)
        {
            return ReplyDAL.UpdateReply(ReplyModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Reply> AllData(string NewWHere)
        {
            return ReplyDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return ReplyDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Reply GetIdByReply(int Id)
        {
            return ReplyDAL.GetIdByReply(Id);
        }
    }
}