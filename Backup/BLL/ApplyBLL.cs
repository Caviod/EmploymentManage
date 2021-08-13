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
        /// ��� 
        ///</summary> 
        public static int AddApply(Apply ApplyModel)
        {
            return ApplyDAL.AddApply(ApplyModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteApply(int Id)
        {
            return ApplyDAL.DeleteApply(Id);
        }

        
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary>
        public static Apply GetIdByUserIdAndHireId(int UserId, int HireId)
        {
            return ApplyDAL.GetIdByUserIdAndHireId(UserId, HireId);
        }

        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Apply> PageSelectApply(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return ApplyDAL.PageSelectApply(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateApply(Apply ApplyModel)
        {
            return ApplyDAL.UpdateApply(ApplyModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Apply> AllData(string NewWHere)
        {
            return ApplyDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return ApplyDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Apply GetIdByApply(int Id)
        {
            return ApplyDAL.GetIdByApply(Id);
        }
    }
}