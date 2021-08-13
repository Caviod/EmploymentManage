using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class InfoBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddInfo(Info InfoModel)
        {
            return InfoDAL.AddInfo(InfoModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteInfo(int Id)
        {
            return InfoDAL.DeleteInfo(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Info> PageSelectInfo(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return InfoDAL.PageSelectInfo(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateInfo(Info InfoModel)
        {
            return InfoDAL.UpdateInfo(InfoModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Info> AllData(string NewWHere)
        {
            return InfoDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return InfoDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Info GetIdByInfo(int Id)
        {
            return InfoDAL.GetIdByInfo(Id);
        }
    }
}