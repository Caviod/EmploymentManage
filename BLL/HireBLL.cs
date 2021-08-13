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
        /// ��� 
        ///</summary> 
        public static int AddHire(Hire HireModel)
        {
            return HireDAL.AddHire(HireModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteHire(int Id)
        {
            return HireDAL.DeleteHire(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Hire> PageSelectHire(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return HireDAL.PageSelectHire(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateHire(Hire HireModel)
        {
            return HireDAL.UpdateHire(HireModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Hire> AllData(string NewWHere)
        {
            return HireDAL.AllData(NewWHere);

        }
         /// <summary>
        /// ��ѯȫ��
        /// </summary>
        public static List<Hire> AllData(int i, string NewWHere)
        {
            return HireDAL.AllData(i, NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return HireDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Hire GetIdByHire(int Id)
        {
            return HireDAL.GetIdByHire(Id);
        }
    }
}