using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Admin
    {
        public Admin() { } //无参构造函数


        #region Model 
        private int _AdminId;
        private string _AdminName;
        private string _Pwd;

        /// <summary>
        /// 
        /// </summary>
        public int AdminId
        {
            set { _AdminId = value; }
            get { return _AdminId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AdminName
        {
            set { _AdminName = value; }
            get { return _AdminName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Pwd
        {
            set { _Pwd = value; }
            get { return _Pwd; }
        }

        #endregion 
    }
}