using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class InfoFollow
    {
        public InfoFollow() { } //无参构造函数


        #region Model 
        private int _InfoFollowId;
        private string _FollowContent;
        private int _FollowId;
        private int _FollowType;
        private int _InfoId;
        private DateTime _FollowTime;

        /// <summary>
        /// 
        /// </summary>
        public int InfoFollowId
        {
            set { _InfoFollowId = value; }
            get { return _InfoFollowId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FollowContent
        {
            set { _FollowContent = value; }
            get { return _FollowContent; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int FollowId
        {
            set { _FollowId = value; }
            get { return _FollowId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int FollowType
        {
            set { _FollowType = value; }
            get { return _FollowType; }
        }

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
        public DateTime FollowTime
        {
            set { _FollowTime = value; }
            get { return _FollowTime; }
        }

        #endregion 
    }
}