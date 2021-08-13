using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class HireBLL
    {
        /// <summary> 
        /// 添加 
        ///</summary> 
        public static int AddHire(Hire HireModel)
        {
            return HireDAL.AddHire(HireModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteHire(int Id)
        {
            return HireDAL.DeleteHire(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Hire> PageSelectHire(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return HireDAL.PageSelectHire(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateHire(Hire HireModel)
        {
            return HireDAL.UpdateHire(HireModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Hire> AllData(string NewWHere)
        {
            return HireDAL.AllData(NewWHere);

        }
         /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Hire> AllData(int i, string NewWHere)
        {
            return HireDAL.AllData(i, NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return HireDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Hire GetIdByHire(int Id)
        {
            return HireDAL.GetIdByHire(Id);
        }
    }
}