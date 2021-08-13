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
        /// ��� 
        ///</summary> 
        public static int AddMessage(Message MessageModel)
        {
            return MessageDAL.AddMessage(MessageModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteMessage(int Id)
        {
            return MessageDAL.DeleteMessage(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Message> PageSelectMessage(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return MessageDAL.PageSelectMessage(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateMessage(Message MessageModel)
        {
            return MessageDAL.UpdateMessage(MessageModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Message> AllData(string NewWHere)
        {
            return MessageDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return MessageDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Message GetIdByMessage(int Id)
        {
            return MessageDAL.GetIdByMessage(Id);
        }
    }
}