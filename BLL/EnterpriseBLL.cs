using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class EnterpriseBLL
    {
        /// <summary> 
        /// ��� 
        ///</summary> 
        public static int AddEnterprise(Enterprise EnterpriseModel)
        {
            return EnterpriseDAL.AddEnterprise(EnterpriseModel);
        }
        /// <summary> 
        /// ��������ɾ�� 
        ///</summary> 
        public static int DeleteEnterprise(int Id)
        {
            return EnterpriseDAL.DeleteEnterprise(Id);
        }
        /// <summary> 
        /// ��ҳ 
        ///</summary> 
        public static List<Enterprise> PageSelectEnterprise(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return EnterpriseDAL.PageSelectEnterprise(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// �޸� 
        ///</summary> 
        public static int UpdateEnterprise(Enterprise EnterpriseModel)
        {
            return EnterpriseDAL.UpdateEnterprise(EnterpriseModel);
        }
        /// <summary> 
        /// ��ѯȫ��
        ///</summary>
        public static List<Enterprise> AllData(string NewWHere)
        {
            return EnterpriseDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// ��ѯ���� 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return EnterpriseDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// ����������ѯʵ�� 
        ///</summary> 
        public static Enterprise GetIdByEnterprise(int Id)
        {
            return EnterpriseDAL.GetIdByEnterprise(Id);
        }

        /// <summary>
        /// ��֤�û��Ƿ��ܵ�¼�ɹ�
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Pwd"></param>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool GetUsersLogin(string SutCode, string Pwd, out  Enterprise sudents)
        {
            sudents = EnterpriseDAL.GetIdBySutCode(SutCode);
            if (sudents != null && sudents.Pwd == Pwd)
            {
                return true;
            }
            return false;
        }


        //�����֤�Ƿ����
        public static bool IsTrue(string SutCode)
        {
            Enterprise sud = EnterpriseDAL.GetIdBySutCode(SutCode);
            if (sud != null && sud.EnterpriseId != 0)
            {
                return true;
            }
            return false;
        }



        // �޸���֤�Ƿ����
        public static bool IsTrue(string SutCode, int SutId)
        {
            Enterprise sud = EnterpriseDAL.GetIdBySutCode(SutCode);
            if (sud != null && sud.EnterpriseId != 0 && sud.EnterpriseId != SutId)
            {
                return true;
            }
            return false;
        }
    }
}