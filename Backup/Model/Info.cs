using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Info
    {
        public Info() { } //无参构造函数


        #region Model 
        private int _InfoId;
        private string _InfoContent;
        private int _UserId;
        private int _EnterpriseId;
        private DateTime _InfoTime;
        private int _InfoType;

        /// <summary>
        /// 
        /// </summary>
        public int InfoId
        {
            set { _InfoId = value; }
            get { return _InfoId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string InfoContent
        {
            set { _InfoContent = value; }
            get { return _InfoContent; }
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
        public int EnterpriseId
        {
            set { _EnterpriseId = value; }
            get { return _EnterpriseId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime InfoTime
        {
            set { _InfoTime = value; }
            get { return _InfoTime; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int InfoType
        {
            set { _InfoType = value; }
            get { return _InfoType; }
        }

        #endregion 
    }
}