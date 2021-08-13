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
        /// 添加 
        ///</summary> 
        public static int AddInfoFollow(InfoFollow InfoFollowModel)
        {
            return InfoFollowDAL.AddInfoFollow(InfoFollowModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteInfoFollow(int Id)
        {
            return InfoFollowDAL.DeleteInfoFollow(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<InfoFollow> PageSelectInfoFollow(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return InfoFollowDAL.PageSelectInfoFollow(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateInfoFollow(InfoFollow InfoFollowModel)
        {
            return InfoFollowDAL.UpdateInfoFollow(InfoFollowModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<InfoFollow> AllData(string NewWHere)
        {
            return InfoFollowDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return InfoFollowDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static InfoFollow GetIdByInfoFollow(int Id)
        {
            return InfoFollowDAL.GetIdByInfoFollow(Id);
        }
    }
}