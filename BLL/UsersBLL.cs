using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class UsersBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddUsers(Users UsersModel)
        {
            return UsersDAL.AddUsers(UsersModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteUsers(int Id)
        {
            return UsersDAL.DeleteUsers(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Users> PageSelectUsers(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return UsersDAL.PageSelectUsers(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateUsers(Users UsersModel)
        {
            return UsersDAL.UpdateUsers(UsersModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Users> AllData(string NewWHere)
        {
            return UsersDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return UsersDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Users GetIdByUsers(int Id)
        {
            return UsersDAL.GetIdByUsers(Id);
        }
        /// <summary>
        /// ��֤�û��Ƿ��ܵ�¼�ɹ�
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Pwd"></param>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool GetUsersLogin(string SutCode, string Pwd, out   Users sudents)
        {
            sudents = UsersDAL.GetIdBySutCode(SutCode);
            if (sudents != null && sudents.Pwd == Pwd)
            {
                return true;
            }
            return false;
        }


        //�����֤�Ƿ����
        public static bool IsTrue(string SutCode)
        {
            Users sud = UsersDAL.GetIdBySutCode(SutCode);
            if (sud != null && sud.UserId != 0)
            {
                return true;
            }
            return false;
        }



        // �޸���֤�Ƿ����
        public static bool IsTrue(string SutCode, int SutId)
        {
            Users sud = UsersDAL.GetIdBySutCode(SutCode);
            if (sud != null && sud.UserId != 0 && sud.UserId != SutId)
            {
                return true;
            }
            return false;
        }
    }
}