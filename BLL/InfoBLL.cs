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
        /// ��� 
        ///</summary> 
        public static int AddInfo(Info InfoModel)
        {
            return InfoDAL.AddInfo(InfoModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteInfo(int Id)
        {
            return InfoDAL.DeleteInfo(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Info> PageSelectInfo(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return InfoDAL.PageSelectInfo(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateInfo(Info InfoModel)
        {
            return InfoDAL.UpdateInfo(InfoModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Info> AllData(string NewWHere)
        {
            return InfoDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return InfoDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Info GetIdByInfo(int Id)
        {
            return InfoDAL.GetIdByInfo(Id);
        }
    }
}