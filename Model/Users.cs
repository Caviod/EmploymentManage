using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Users
    {
        public Users() { } //无参构造函数


        #region Model 
        private int _UserId;
        private string _UserName;
        private string _Pwd;
        private string _HeadImg;
        private string _RealName;
        private string _Sex;
        private string _IdCard;
        private int _Age;
        private string _Political;
        private string _Education;
        private string _Major;
        private string _Colleges;
        private string _IsEmployment;
        private string _Phone;
        private string _Email;
        private string _Introduce;
        private DateTime _RegisteredTime;


        private string _Experience;
        private string _GraduationTime;
        private string _Penetration;
        private string _Address;
        private DateTime _Birth;


        /// <summary>
        /// 
        /// </summary>
        public string Experience
        {
            set { _Experience = value; }
            get { return _Experience; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string GraduationTime
        {
            set { _GraduationTime = value; }
            get { return _GraduationTime; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Penetration
        {
            set { _Penetration = value; }
            get { return _Penetration; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _Address = value; }
            get { return _Address; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Birth
        {
            set { _Birth = value; }
            get { return _Birth; }
        }



        /// <summary>
        /// 
        /// </summary>
        public int UserId
        {
            set { _UserId = value; }
            get { return _UserId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _UserName = value; }
            get { return _UserName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Pwd
        {
            set { _Pwd = value; }
            get { return _Pwd; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string HeadImg
        {
            set { _HeadImg = value; }
            get { return _HeadImg; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string RealName
        {
            set { _RealName = value; }
            get { return _RealName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Sex
        {
            set { _Sex = value; }
            get { return _Sex; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string IdCard
        {
            set { _IdCard = value; }
            get { return _IdCard; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Age
        {
            set { _Age = value; }
            get { return _Age; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Political
        {
            set { _Political = value; }
            get { return _Political; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Education
        {
            set { _Education = value; }
            get { return _Education; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Major
        {
            set { _Major = value; }
            get { return _Major; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Colleges
        {
            set { _Colleges = value; }
            get { return _Colleges; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string IsEmployment
        {
            set { _IsEmployment = value; }
            get { return _IsEmployment; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Phone
        {
            set { _Phone = value; }
            get { return _Phone; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            set { _Email = value; }
            get { return _Email; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Introduce
        {
            set { _Introduce = value; }
            get { return _Introduce; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime RegisteredTime
        {
            set { _RegisteredTime = value; }
            get { return _RegisteredTime; }
        }


        #endregion 
    }
}