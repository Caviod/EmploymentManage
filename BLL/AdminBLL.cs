using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class AdminBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddAdmin(Admin AdminModel)
        {
            return AdminDAL.AddAdmin(AdminModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteAdmin(int Id)
        {
            return AdminDAL.DeleteAdmin(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Admin> PageSelectAdmin(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return AdminDAL.PageSelectAdmin(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateAdmin(Admin AdminModel)
        {
            return AdminDAL.UpdateAdmin(AdminModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Admin> AllData(string NewWHere)
        {
            return AdminDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return AdminDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Admin GetIdByAdmin(int Id)
        {
            return AdminDAL.GetIdByAdmin(Id);
        }

        /// <summary>
        /// �ж��Ƿ��¼�ɹ�
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strPwd"></param>
        /// <param name="admin"></param>
        /// <returns></returns>
        public static bool GetUsersLogin(string strName, string strPwd, out Admin admin)
        {

            admin = AdminDAL.GetByName(strName);
            if (admin != null && admin.Pwd == strPwd)
            {
                return true;
            }
            return false;
        }
       
    }
}