using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ApplyBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddApply(Apply ApplyModel)
        {
            return ApplyDAL.AddApply(ApplyModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteApply(int Id)
        {
            return ApplyDAL.DeleteApply(Id);
        }

        
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Apply GetIdByUserIdAndHireId(int UserId, int HireId)
        {
            return ApplyDAL.GetIdByUserIdAndHireId(UserId, HireId);
        }

        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Apply> PageSelectApply(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return ApplyDAL.PageSelectApply(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateApply(Apply ApplyModel)
        {
            return ApplyDAL.UpdateApply(ApplyModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Apply> AllData(string NewWHere)
        {
            return ApplyDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return ApplyDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Apply GetIdByApply(int Id)
        {
            return ApplyDAL.GetIdByApply(Id);
        }
    }
}