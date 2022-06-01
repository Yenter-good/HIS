using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.ComponentModel;
using Newtonsoft.Json.Converters;
using System.Xml;
using System.Text;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace HIS.Utility
{
    public static class SerializeHelper
    {
        public static string BeginJsonSerializable(this object Obj, bool includeDefaultValue = false, bool includeNullValue = false)
        {
            if (Obj == null) return "";
            IsoDateTimeConverter timeFormat = new IsoDateTimeConverter();
            timeFormat.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            Newtonsoft.Json.JsonSerializerSettings jsettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                Converters = new[] { timeFormat }
                    ,
                DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
            };
            if (includeDefaultValue)
                jsettings.DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include;
            if (includeNullValue)
                jsettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Include;

            return Newtonsoft.Json.JsonConvert.SerializeObject(Obj
                , Newtonsoft.Json.Formatting.None
                , jsettings);
        }
        public static object BeginJsonDeserialize(this string str)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(str)) return null;
                return Newtonsoft.Json.JsonConvert.DeserializeObject(str);
            }
            catch
            {
                return null;
            }
        }
        public static object BeginJsonDeserialize(this string str, Type type)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(str)) return null;
                return Newtonsoft.Json.JsonConvert.DeserializeObject(str, type);
            }
            catch
            {
                return null;
            }
        }
        public static T BeginJsonDeserialize<T>(this string str)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(str)) return default(T);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(str);
            }
            catch
            {
                return default(T);
            }
        }
        public static T BeginJsonDeserialize<T>(this string str, JsonConverter[] jsonConverters)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(str)) return default(T);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(str, jsonConverters);
            }
            catch
            {
                return default(T);
            }
        }

        public static string BeginXMLSerializable(this object sourceObj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (XmlTextWriter writer = new XmlTextWriter(ms, Encoding.UTF8))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(sourceObj.GetType());
                    XmlSerializerNamespaces nameSpace = new XmlSerializerNamespaces();

                    nameSpace.Add("", "");
                    xmlSerializer.Serialize(writer, sourceObj, nameSpace);
                    return Encoding.UTF8.GetString(ms.GetBuffer()); ;
                }
            }
        }

        public static T BeginXMLDeserialize<T>(this string xml) where T : class, new()
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer xmldes = new XmlSerializer(typeof(T));
                return xmldes.Deserialize(sr) as T;
            }
        }

        public static byte[] BeginSerializable(this object Obj)
        {
            MemoryStream mStream = new MemoryStream();
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(mStream, Obj);
            return mStream.GetBuffer();
        }

        public static T BeginDeserialize<T>(this byte[] Bytes)
        {
            BinaryFormatter bFormatter = new BinaryFormatter();
            return (T)bFormatter.Deserialize(new MemoryStream(Bytes));
        }

        public static T BeginObjectByJson<T>(object asObject) where T : new()
        {
            //将object对象转换为json字符
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(asObject);
            //将json字符转换为实体对象
            var t = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            return t;
        }
    }

    public abstract class DATACreationConverter<T> : JsonConverter
    {
        /// <summary>
        /// Create an instance of objectType, based properties in the JSON object
        /// </summary>
        /// <param name="objectType">type of object expected</param>
        /// <param name="jObject">
        /// contents of JSON object that will be deserialized
        /// </param>
        /// <returns></returns>
        protected abstract T Create(Type objectType, JObject jObject);

        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader,
                                        Type objectType,
                                         object existingValue,
                                         JsonSerializer serializer)
        {
            // Load JObject from stream
            JObject jObject = JObject.Load(reader);

            // Create target object based on JObject
            T target = Create(objectType, jObject);

            // Populate the object properties
            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }

        public override void WriteJson(JsonWriter writer,
                                       object value,
                                       JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }


    }
}
