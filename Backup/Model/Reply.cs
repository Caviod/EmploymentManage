using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Reply
    {
        public Reply() { } //无参构造函数


        #region Model 
        private int _ReplyId;
        private string _ReplyContent;
        private int _UserId;
        private DateTime _ReplyTime;
        private int _MsgId;

        /// <summary>
        /// 
        /// </summary>
        public int ReplyId
        {
            set { _ReplyId = value; }
            get { return _ReplyId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ReplyContent
        {
            set { _ReplyContent = value; }
            get { return _ReplyContent; }
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
        public DateTime ReplyTime
        {
            set { _ReplyTime = value; }
            get { return _ReplyTime; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int MsgId
        {
            set { _MsgId = value; }
            get { return _MsgId; }
        }

        #endregion 
    }
}