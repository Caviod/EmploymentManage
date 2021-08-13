using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Apply
    {
        public Apply() { } //无参构造函数


        #region Model 
        private int _ApplyId;
        private int _UserId;
        private int _HireId;
        private DateTime _ApplyTime;
        private string _State;

        /// <summary>
        /// 
        /// </summary>
        public int ApplyId
        {
            set { _ApplyId = value; }
            get { return _ApplyId; }
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
        public int HireId
        {
            set { _HireId = value; }
            get { return _HireId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ApplyTime
        {
            set { _ApplyTime = value; }
            get { return _ApplyTime; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string State
        {
            set { _State = value; }
            get { return _State; }
        }

        #endregion 
    }
}