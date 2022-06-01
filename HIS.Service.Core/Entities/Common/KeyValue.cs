using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 键值对
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    [Serializable]
    public class KeyValue<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public KeyValue()
        {

        }
        public KeyValue(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }
        public override string ToString()
        {
            return this.Value.AsNotNullString();
        }
    }
    /// <summary>
    /// 键值对
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TCode"></typeparam>
    [Serializable]
    public class KeyValue<TKey, TValue, TCode>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public TCode Code { get; set; }
        public KeyValue()
        {

        }
        public KeyValue(TKey key, TValue value, TCode code)
        {
            this.Key = key;
            this.Value = value;
            this.Code = code;
        }
        public override string ToString()
        {
            return this.Value.AsNotNullString();
        }
    }
    /// <summary>
    /// 字符串型键值对
    /// </summary>
    [Serializable]
    public class StringItem : KeyValue<string, string, string>
    {
        public StringItem(string key, string value, string code = "")
            : base(key, value, code)
        {

        }

        public override string ToString()
        {
            return Value ?? base.ToString();
        }
    }
    /// <summary>
    /// 长整型键值对
    /// </summary>
    [Serializable]
    public class LongItem : KeyValue<long, string, string>
    {
        public LongItem(long key, string value, string code = "")
            : base(key, value, code)
        {

        }
        public LongItem()
          : base()
        {

        }
        public override string ToString()
        {
            return this.Value.AsString("");
        }
        public override int GetHashCode()
        {
            return this.Key.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this == null)
                return false;
            LongItem longItem = obj as LongItem;
            if (longItem == null)
                return false;
            if (longItem.Key == this.Key)
                return true;
            else
                return false;
        }
    }

}
