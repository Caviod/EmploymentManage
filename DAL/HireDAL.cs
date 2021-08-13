using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class HireDAL
    {


        /// <summary>
        /// 添加 
        ///</summary>
        public static int AddHire(Hire HireModel)
        {
            string sql = string.Format("insert into  Hire (Job,JobType,HireCount,Age,Sex,Education,Experience,Treatment,Address,Note,Conditions,ReleaseTime,CutTime,EnterpriseId )values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}',{13})", HireModel.Job, HireModel.JobType, HireModel.HireCount, HireModel.Age, HireModel.Sex, HireModel.Education, HireModel.Experience, HireModel.Treatment, HireModel.Address, HireModel.Note.Replace("'", ""), HireModel.Conditions.Replace("'", ""), HireModel.ReleaseTime, HireModel.CutTime, HireModel.EnterpriseId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据ID修改 
        ///</summary>
        public static int UpdateHire(Hire HireModel)
        {
            string sql = string.Format(" UPDATE Hire  set Job='{0}',JobType='{1}',HireCount='{2}',Age='{3}',Sex='{4}',Education='{5}',Experience='{6}',Treatment='{7}',Address='{8}',Note='{9}',Conditions='{10}',ReleaseTime='{11}',CutTime='{12}',EnterpriseId={13} where HireId={14} ", HireModel.Job, HireModel.JobType, HireModel.HireCount, HireModel.Age, HireModel.Sex, HireModel.Education, HireModel.Experience, HireModel.Treatment, HireModel.Address, HireModel.Note.Replace("'", ""), HireModel.Conditions.Replace("'", ""), HireModel.ReleaseTime, HireModel.CutTime, HireModel.EnterpriseId, HireModel.HireId);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 根据主键删除 
        ///</summary>
        public static int DeleteHire(int Id)
        {
            string sql = string.Format("delete from Hire where HireId={0}", Id);
            return DBHelper.ExecuteCommand(sql);
        }

        /// <summary> 
        /// 查询条数 
        ///</summary>
        public static int CountNumber(string NewWHere)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select count(*) from Hire where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select count(*) from Hire";

            }
            return DBHelper.GetIntScalar(sql);
        }

        /// <summary>
        /// 分页 
        ///</summary> 
        public static List<Hire> PageSelectHire(int pageSize, int pageIndex, string WhereSrc, string PXzd, string PXType)
        {
            List<Hire> list = new List<Hire>(); 
	    string sql = string.Format("SELECT top {0} * FROM Hire where HireId not in( select top {1} HireId from Hire where 1=1 {2} order by {3} {4}) and 1=1 {2} order by {3} {4} ",pageSize, pageSize*pageIndex,WhereSrc, PXzd,PXType);
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                list = GetList(table);
            }
            return list;
        }

        /// <summary> 
        /// 根据主键查询实体 
        ///</summary>
        public static Hire GetIdByHire(int Id)
        {
            string sql = string.Format("SELECT * FROM Hire where HireId={0} ",Id);
            Hire HireModel = new Hire();
            using (DataTable table = DBHelper.GetDataSet(sql))
            {
                HireModel= GetMode(table);
            }
            return HireModel;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Hire> AllData(string NewWHere)
        {
            List<Hire> list = new List<Hire>();

             string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
               sql = "select * from Hire where 1=1 "+NewWHere;
            }
            else
            {
               sql = "select * from Hire";
            }
            using (DataTable table = DBHelper.GetDataSet(sql))
            {

                list = GetList(table);
            }
            return list;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<Hire> AllData(int i, string NewWHere)
        {
            List<Hire> list = new List<Hire>();

            string sql = "";
            if (!string.IsNullOrEmpty(NewWHere))
            {
                sql = "select top " + i + " * from Hire where 1=1 " + NewWHere;
            }
            else
            {
                sql = "select top " + i + " * from Hire";
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
        private static List<Hire> GetList(DataTable table)
        {
            List<Hire> list = new List<Hire>();
            foreach (DataRow row in table.Rows)
            {
                Hire HireModel = new Hire(); 
                HireModel.HireId = Convert.ToInt32(row["HireId"]); 
                HireModel.Job = Convert.ToString(row["Job"]); 
                HireModel.JobType = Convert.ToString(row["JobType"]); 
                HireModel.HireCount = Convert.ToString(row["HireCount"]); 
                HireModel.Age = Convert.ToString(row["Age"]); 
                HireModel.Sex = Convert.ToString(row["Sex"]); 
                HireModel.Education = Convert.ToString(row["Education"]); 
                HireModel.Experience = Convert.ToString(row["Experience"]); 
                HireModel.Treatment = Convert.ToString(row["Treatment"]); 
                HireModel.Address = Convert.ToString(row["Address"]); 
                HireModel.Note = Convert.ToString(row["Note"]); 
                HireModel.Conditions = Convert.ToString(row["Conditions"]); 
                HireModel.ReleaseTime = Convert.ToDateTime(row["ReleaseTime"]); 
                HireModel.CutTime = Convert.ToDateTime(row["CutTime"]); 
                HireModel.EnterpriseId = Convert.ToInt32(row["EnterpriseId"]); 
                list.Add(HireModel);

            }
            return list;
        }
        /// <summary> 
        /// 私有方法 
        ///</summary>
        private static Hire GetMode(DataTable table)
        {
            Hire HireModel = new Hire();
            foreach (DataRow row in table.Rows)
            {
                HireModel.HireId = Convert.ToInt32(row["HireId"]); 
                HireModel.Job = Convert.ToString(row["Job"]); 
                HireModel.JobType = Convert.ToString(row["JobType"]); 
                HireModel.HireCount = Convert.ToString(row["HireCount"]); 
                HireModel.Age = Convert.ToString(row["Age"]); 
                HireModel.Sex = Convert.ToString(row["Sex"]); 
                HireModel.Education = Convert.ToString(row["Education"]); 
                HireModel.Experience = Convert.ToString(row["Experience"]); 
                HireModel.Treatment = Convert.ToString(row["Treatment"]); 
                HireModel.Address = Convert.ToString(row["Address"]); 
                HireModel.Note = Convert.ToString(row["Note"]); 
                HireModel.Conditions = Convert.ToString(row["Conditions"]); 
                HireModel.ReleaseTime = Convert.ToDateTime(row["ReleaseTime"]); 
                HireModel.CutTime = Convert.ToDateTime(row["CutTime"]); 
                HireModel.EnterpriseId = Convert.ToInt32(row["EnterpriseId"]); 

            }
            return HireModel;
        }
    }
}