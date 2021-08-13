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
        /// 添加 
        ///</summary> 
        public static int AddNews(News NewsModel)
        {
            return NewsDAL.AddNews(NewsModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteNews(int Id)
        {
            return NewsDAL.DeleteNews(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<News> PageSelectNews(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return NewsDAL.PageSelectNews(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateNews(News NewsModel)
        {
            return NewsDAL.UpdateNews(NewsModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<News> AllData(string NewWHere)
        {
            return NewsDAL.AllData(NewWHere);
        }
         /// <summary>
        /// 查询全部
        /// </summary>
        public static List<News> AllData(int i, string NewWHere)
        {
            return NewsDAL.AllData(i, NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return NewsDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static News GetIdByNews(int Id)
        {
            return NewsDAL.GetIdByNews(Id);
        }
    }
}