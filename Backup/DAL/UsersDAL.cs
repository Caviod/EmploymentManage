using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UsersDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddUsers(Users UsersModel)
        {
            string sql = string.Format("insert into  Users (UserName,Pwd,HeadImg,RealName,Sex,IdCard,Age,Political,Education,Major,Colleges,IsEmployment,Phone,Email,Introduce,RegisteredTime,Experience,GraduationTime,Penetration,Birth,Address)values('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}')", UsersModel.UserName, UsersModel.Pwd, UsersModel.HeadImg, UsersModel.RealName, UsersModel.Sex, UsersModel.IdCard, UsersModel.Age, UsersModel.Political, UsersModel.Education, UsersModel.Major, UsersModel.Colleges, UsersModel.IsEmployment, UsersModel.Phone, UsersModel.Email, UsersModel.Introduce.Replace("'", ""), UsersModel.RegisteredTime, UsersModel.Experience, UsersModel.GraduationTime, UsersModel.Penetration, UsersModel.Birth, UsersModel.Address);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateUsers(Users UsersModel)
        {
            string sql = string.Format(" UPDATE Users  set UserName='{0}',Pwd='{1}',HeadImg='{2}',RealName='{3}',Sex='{4}',IdCard='{5}',Age={6},Political='{7}',Education='{8}',Major='{9}',Colleges='{10}',IsEmployment='{11}',Phone='{12}',Email='{13}',Introduce='{14}',RegisteredTime='{15}',Experience='{16}',GraduationTime='{17}',Penetration='{18}',Birth='{19}',Address='{20}' where UserId={21} ", UsersModel.UserName, UsersModel.Pwd, UsersModel.HeadImg, UsersModel.RealName, UsersModel.Sex, UsersModel.IdCard, UsersModel.Age, UsersModel.Political, UsersModel.Education, UsersModel.Major, UsersModel.Colleges, UsersModel.IsEmployment, UsersModel.Phone, UsersModel.Email, UsersModel.Introduce.Replace("'", ""), UsersModel.RegisteredTime, UsersModel.Experience, UsersModel.GraduationTime, UsersModel.Penetration, UsersModel.Birth, UsersModel.Address, UsersModel.UserId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteUsers(int Id)
        {
            string sql = string.Format("delete from Users where UserId={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }


        /// <summary> 
        /// 根据用户名查询实体 
        ///</summary>
        public static Users GetIdBySutCode(string SutCode)
        {
            string sql = string.Format("SELECT * FROM Users where UserName collate Chinese_PRC_CS_AS_WS = '{0}'", SutCode);
            Users SudentsModel = new Users();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                SudentsModel = GetMode(table);
            }
            return SudentsModel;
        }

        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select count(*) from Users where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Users";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Users> PageSelectUsers(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Users> list = new List<Users>(); 
	    string sql = string.Format("SELECT top {0} * FROM Users where UserId not in( select top {1} UserId from Users where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Users GetIdByUsers(int Id)
        {
            string sql = string.Format("SELECT * FROM Users where UserId={0} ",Id);
            Users UsersModel = new Users();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                UsersModel= GetMode(table);
            }
            return UsersModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Users> AllData(string NewWHere)
        {
            List<Users> list = new List<Users>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Users where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Users";
            }
            using (DataTable table = DBHelper.GetDataSet(sql))
            {

                list = GetList(table);
            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static List<Users> GetList(DataTable table)
        {
            List<Users> list = new List<Users>();
            foreach (DataRow row in table.Rows)
            {
                Users UsersModel = new Users(); 
                UsersModel.UserId = Convert.ToInt32(row["UserId"]); 
                UsersModel.UserName = Convert.ToString(row["UserName"]); 
                UsersModel.Pwd = Convert.ToString(row["Pwd"]); 
                UsersModel.HeadImg = Convert.ToString(row["HeadImg"]); 
                UsersModel.RealName = Convert.ToString(row["RealName"]); 
                UsersModel.Sex = Convert.ToString(row["Sex"]); 
                UsersModel.IdCard = Convert.ToString(row["IdCard"]); 
                UsersModel.Age = Convert.ToInt32(row["Age"]); 
                UsersModel.Political = Convert.ToString(row["Political"]); 
                UsersModel.Education = Convert.ToString(row["Education"]); 
                UsersModel.Major = Convert.ToString(row["Major"]); 
                UsersModel.Colleges = Convert.ToString(row["Colleges"]); 
                UsersModel.IsEmployment = Convert.ToString(row["IsEmployment"]); 
                UsersModel.Phone = Convert.ToString(row["Phone"]); 
                UsersModel.Email = Convert.ToString(row["Email"]); 
                UsersModel.Introduce = Convert.ToString(row["Introduce"]); 
                UsersModel.RegisteredTime = Convert.ToDateTime(row["RegisteredTime"]);
                UsersModel.Experience = Convert.ToString(row["Experience"]);
                UsersModel.GraduationTime = Convert.ToString(row["GraduationTime"]);
                UsersModel.Penetration = Convert.ToString(row["Penetration"]);
                UsersModel.Address = Convert.ToString(row["Address"]);
                UsersModel.Birth = Convert.ToDateTime(row["Birth"]); 
                list.Add(UsersModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Users GetMode(DataTable table)
        {
            Users UsersModel = new Users();
            foreach (DataRow row in table.Rows)
            {
                UsersModel.UserId = Convert.ToInt32(row["UserId"]); 
                UsersModel.UserName = Convert.ToString(row["UserName"]); 
                UsersModel.Pwd = Convert.ToString(row["Pwd"]); 
                UsersModel.HeadImg = Convert.ToString(row["HeadImg"]); 
                UsersModel.RealName = Convert.ToString(row["RealName"]); 
                UsersModel.Sex = Convert.ToString(row["Sex"]); 
                UsersModel.IdCard = Convert.ToString(row["IdCard"]); 
                UsersModel.Age = Convert.ToInt32(row["Age"]); 
                UsersModel.Political = Convert.ToString(row["Political"]); 
                UsersModel.Education = Convert.ToString(row["Education"]); 
                UsersModel.Major = Convert.ToString(row["Major"]); 
                UsersModel.Colleges = Convert.ToString(row["Colleges"]); 
                UsersModel.IsEmployment = Convert.ToString(row["IsEmployment"]); 
                UsersModel.Phone = Convert.ToString(row["Phone"]); 
                UsersModel.Email = Convert.ToString(row["Email"]); 
                UsersModel.Introduce = Convert.ToString(row["Introduce"]); 
                UsersModel.RegisteredTime = Convert.ToDateTime(row["RegisteredTime"]);
                UsersModel.Experience = Convert.ToString(row["Experience"]);
                UsersModel.GraduationTime = Convert.ToString(row["GraduationTime"]);
                UsersModel.Penetration = Convert.ToString(row["Penetration"]);
                UsersModel.Address = Convert.ToString(row["Address"]);
                UsersModel.Birth = Convert.ToDateTime(row["Birth"]); 

            }
            return UsersModel;
        }
    }
}