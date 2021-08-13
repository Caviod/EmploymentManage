using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class NewsBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddNews(News NewsModel)
        {
            return NewsDAL.AddNews(NewsModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteNews(int Id)
        {
            return NewsDAL.DeleteNews(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<News> PageSelectNews(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return NewsDAL.PageSelectNews(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateNews(News NewsModel)
        {
            return NewsDAL.UpdateNews(NewsModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<News> AllData(string NewWHere)
        {
            return NewsDAL.AllData(NewWHere);
        }
         /// <summary>
        /// ��ѯȫ��
        /// </summary>
        public static List<News> AllData(int i, string NewWHere)
        {
            return NewsDAL.AllData(i, NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return NewsDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static News GetIdByNews(int Id)
        {
            return NewsDAL.GetIdByNews(Id);
        }
    }
}