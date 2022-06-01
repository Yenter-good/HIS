using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class AdministrativeDivisionEntity
    {
        protected long id;
        protected long creatorUserId;
        protected DateTime creationTime;
        protected long lastModifierUserId;
        protected DateTime lastModificationTime;
        protected int dataStatus;
        protected int no;
        protected string name;
        protected string fullName;
        protected int levelType;
        protected string code;
        protected string parentCode;
        protected string searchCode;

        public AdministrativeDivisionEntity()
        {
        }

        //ID
        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        //创建人编号 当前用户ID
        public long CreatorUserId
        {
            get { return creatorUserId; }
            set { creatorUserId = value; }
        }
        //创建时间 默认为当前时间
        public DateTime CreationTime
        {
            get { return creationTime; }
            set { creationTime = value; }
        }
        //最后修改人编号
        public long LastModifierUserId
        {
            get { return lastModifierUserId; }
            set { lastModifierUserId = value; }
        }
        //最后修改时间 默认为当前时间
        public DateTime LastModificationTime
        {
            get { return lastModificationTime; }
            set { lastModificationTime = value; }
        }
        //数据状态 数据状态 0失效 1启用
        public int DataStatus
        {
            get { return dataStatus; }
            set { dataStatus = value; }
        }
        //排序号
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public int LevelType
        {
            get { return levelType; }
            set { levelType = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string ParentCode
        {
            get { return parentCode; }
            set { parentCode = value; }
        }
        public string SearchCode
        {
            get { return searchCode; }
            set { searchCode = value; }
        }
    }
}
