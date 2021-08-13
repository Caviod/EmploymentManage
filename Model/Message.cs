using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Message
    {
        public Message() { } //无参构造函数


        #region Model 
        private int _MsgId;
        private string _MsgTitle;
        private string _MsgContent;
        private int _UserId;
        private DateTime _MsgTime;

        /// <summary>
        /// 
        /// </summary>
        public int MsgId
        {
            set { _MsgId = value; }
            get { return _MsgId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MsgTitle
        {
            set { _MsgTitle = value; }
            get { return _MsgTitle; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MsgContent
        {
            set { _MsgContent = value; }
            get { return _MsgContent; }
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
        public DateTime MsgTime
        {
            set { _MsgTime = value; }
            get { return _MsgTime; }
        }

        #endregion 
    }
}