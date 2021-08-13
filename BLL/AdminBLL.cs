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
        /// 添加 
        ///</summary> 
        public static int AddAdmin(Admin AdminModel)
        {
            return AdminDAL.AddAdmin(AdminModel);
        }
        /// <summary> 
        /// 根据主键删除 
        ///</summary> 
        public static int DeleteAdmin(int Id)
        {
            return AdminDAL.DeleteAdmin(Id);
        }
        /// <summary> 
        /// 分页 
        ///</summary> 
        public static List<Admin> PageSelectAdmin(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            pageIndex = pageIndex - 1;
            return AdminDAL.PageSelectAdmin(pageSize, pageIndex, WhereSrc, PXzd, PXType);
        }
        /// <summary> 
        /// 修改 
        ///</summary> 
        public static int UpdateAdmin(Admin AdminModel)
        {
            return AdminDAL.UpdateAdmin(AdminModel);
        }
        /// <summary> 
        /// 查询全部
        ///</summary>
        public static List<Admin> AllData(string NewWHere)
        {
            return AdminDAL.AllData(NewWHere);
        }
        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            return AdminDAL.CountNumber(NewWHere);
        }
        /// <summary> 
        /// 根据主键查询实体 
        ///</summary> 
        public static Admin GetIdByAdmin(int Id)
        {
            return AdminDAL.GetIdByAdmin(Id);
        }

        /// <summary>
        /// 判断是否登录成功
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