using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class NewsDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddNews(News NewsModel)
        {
            string sql = string.Format("insert into  News (NewsTitle,Author,Source,NewsContent,ReleaseTime )values('{0}','{1}','{2}','{3}','{4}')",NewsModel.NewsTitle,NewsModel.Author,NewsModel.Source,NewsModel.NewsContent,NewsModel.ReleaseTime);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateNews(News NewsModel)
        {
            string sql = string.Format(" UPDATE News  set NewsTitle='{0}',Author='{1}',Source='{2}',NewsContent='{3}',ReleaseTime='{4}' where NewsId={5} ",NewsModel.NewsTitle,NewsModel.Author,NewsModel.Source,NewsModel.NewsContent,NewsModel.ReleaseTime  ,NewsModel.NewsId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteNews(int Id)
        {
            string sql = string.Format("delete from News where NewsId={0}", Id);
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
                sql = "select count(*) from News where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from News";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<News> PageSelectNews(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<News> list = new List<News>(); 
	    string sql = string.Format("SELECT top {0} * FROM News where NewsId not in( select top {1} NewsId from News where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static News GetIdByNews(int Id)
        {
            string sql = string.Format("SELECT * FROM News where NewsId={0} ",Id);
            News NewsModel = new News();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                NewsModel= GetMode(table);
            }
            return NewsModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<News> AllData(string NewWHere)
        {
            List<News> list = new List<News>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from News where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from News";
            }
            using (DataTable table = DBHelper.GetDataSet(sql))
            {

                list = GetList(table);
            }
            return list;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<News> AllData(int i, string NewWHere)
        {
            List<News> list = new List<News>();

            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select top " + i + " * from News where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select top " + i + " * from News";
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
        private static List<News> GetList(DataTable table)
        {
            List<News> list = new List<News>();
            foreach (DataRow row in table.Rows)
            {
                News NewsModel = new News(); 
                NewsModel.NewsId = Convert.ToInt32(row["NewsId"]); 
                NewsModel.NewsTitle = Convert.ToString(row["NewsTitle"]); 
                NewsModel.Author = Convert.ToString(row["Author"]); 
                NewsModel.Source = Convert.ToString(row["Source"]); 
                NewsModel.NewsContent = Convert.ToString(row["NewsContent"]); 
                NewsModel.ReleaseTime = Convert.ToDateTime(row["ReleaseTime"]); 
                list.Add(NewsModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static News GetMode(DataTable table)
        {
            News NewsModel = new News();
            foreach (DataRow row in table.Rows)
            {
                NewsModel.NewsId = Convert.ToInt32(row["NewsId"]); 
                NewsModel.NewsTitle = Convert.ToString(row["NewsTitle"]); 
                NewsModel.Author = Convert.ToString(row["Author"]); 
                NewsModel.Source = Convert.ToString(row["Source"]); 
                NewsModel.NewsContent = Convert.ToString(row["NewsContent"]); 
                NewsModel.ReleaseTime = Convert.ToDateTime(row["ReleaseTime"]); 

            }
            return NewsModel;
        }
    }
}