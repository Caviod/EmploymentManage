using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class InfoFollowBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddInfoFollow(InfoFollow InfoFollowModel)
        {
            return InfoFollowDAL.AddInfoFollow(InfoFollowModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteInfoFollow(int Id)
        {
            return InfoFollowDAL.DeleteInfoFollow(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<InfoFollow> PageSelectInfoFollow(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return InfoFollowDAL.PageSelectInfoFollow(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateInfoFollow(InfoFollow InfoFollowModel)
        {
            return InfoFollowDAL.UpdateInfoFollow(InfoFollowModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<InfoFollow> AllData(string NewWHere)
        {
            return InfoFollowDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return InfoFollowDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static InfoFollow GetIdByInfoFollow(int Id)
        {
            return InfoFollowDAL.GetIdByInfoFollow(Id);
        }
    }
}