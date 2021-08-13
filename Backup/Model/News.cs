using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class News
    {
        public News() { } //无参构造函数


        #region Model 
        private int _NewsId;
        private string _NewsTitle;
        private string _Author;
        private string _Source;
        private string _NewsContent;
        private DateTime _ReleaseTime;

        /// <summary>
        /// 
        /// </summary>
        public int NewsId
        {
            set { _NewsId = value; }
            get { return _NewsId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NewsTitle
        {
            set { _NewsTitle = value; }
            get { return _NewsTitle; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Author
        {
            set { _Author = value; }
            get { return _Author; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Source
        {
            set { _Source = value; }
            get { return _Source; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NewsContent
        {
            set { _NewsContent = value; }
            get { return _NewsContent; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ReleaseTime
        {
            set { _ReleaseTime = value; }
            get { return _ReleaseTime; }
        }

        #endregion 
    }
}