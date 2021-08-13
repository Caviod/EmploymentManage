using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Enterprise
    {
        public Enterprise() { } //无参构造函数


        #region Model 
        private int _EnterpriseId;
        private string _UserName;
        private string _Pwd;
        private string _EnterpriseNo;
        private string _EnterpriseName;
        private string _Industry;
        private string _Nature;
        private string _Sizes;
        private string _SetUpTime;
        private int _Moneys;
        private string _Email;
        private string _Address;
        private string _Note;
        private DateTime _RegisteredTime;

        /// <summary>
        /// 
        /// </summary>
        public int EnterpriseId
        {
            set { _EnterpriseId = value; }
            get { return _EnterpriseId; }
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
        public string EnterpriseNo
        {
            set { _EnterpriseNo = value; }
            get { return _EnterpriseNo; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string EnterpriseName
        {
            set { _EnterpriseName = value; }
            get { return _EnterpriseName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Industry
        {
            set { _Industry = value; }
            get { return _Industry; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Nature
        {
            set { _Nature = value; }
            get { return _Nature; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Sizes
        {
            set { _Sizes = value; }
            get { return _Sizes; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SetUpTime
        {
            set { _SetUpTime = value; }
            get { return _SetUpTime; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Moneys
        {
            set { _Moneys = value; }
            get { return _Moneys; }
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
        public string Address
        {
            set { _Address = value; }
            get { return _Address; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Note
        {
            set { _Note = value; }
            get { return _Note; }
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