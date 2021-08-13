using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Hire
    {
        public Hire() { } //无参构造函数


        #region Model 
        private int _HireId;
        private string _Job;
        private string _JobType;
        private string _HireCount;
        private string _Age;
        private string _Sex;
        private string _Education;
        private string _Experience;
        private string _Treatment;
        private string _Address;
        private string _Note;
        private string _Conditions;
        private DateTime _ReleaseTime;
        private DateTime _CutTime;
        private int _EnterpriseId;

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
        public string Job
        {
            set { _Job = value; }
            get { return _Job; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string JobType
        {
            set { _JobType = value; }
            get { return _JobType; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string HireCount
        {
            set { _HireCount = value; }
            get { return _HireCount; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Age
        {
            set { _Age = value; }
            get { return _Age; }
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
        public string Education
        {
            set { _Education = value; }
            get { return _Education; }
        }

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
        public string Treatment
        {
            set { _Treatment = value; }
            get { return _Treatment; }
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
        public string Conditions
        {
            set { _Conditions = value; }
            get { return _Conditions; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ReleaseTime
        {
            set { _ReleaseTime = value; }
            get { return _ReleaseTime; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CutTime
        {
            set { _CutTime = value; }
            get { return _CutTime; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int EnterpriseId
        {
            set { _EnterpriseId = value; }
            get { return _EnterpriseId; }
        }

        #endregion 
    }
}