using Autofac;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HIS.Core
{
    public class ServiceLocator
    {
        public static IContainer Current { get; set; }

        public static T GetService<T>()
        {
            return Current.Resolve<T>();
        }

        public static bool IsRegistered<T>()
        {
            return Current.IsRegistered<T>();
        }

        public static bool IsRegistered<T>(string key)
        {
            return Current.IsRegisteredWithKey<T>(key);
        }

        public static bool IsRegistered(Type type)
        {
            return Current.IsRegistered(type);
        }

        public static bool IsRegisteredWithKey(string key, Type type)
        {
            return Current.IsRegisteredWithKey(key, type);
        }

        public static T GetService<T>(string key)
        {

            return Current.ResolveKeyed<T>(key);
        }

        public static object GetService(Type type)
        {
            return Current.Resolve(type);
        }

        public static object GetService(string key, Type type)
        {
            return Current.ResolveKeyed(key, type);
        }

        /// <summary>
        /// 创建指定对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> Resolve<T>()
        {
            return Current.Resolve<IList<T>>();
        }
        /// <summary>
        /// 获取符合当前类型注册的所有类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static List<Type> GetRegisteredTypes(Type type)
        {
            var registrations = Current.ComponentRegistry
            .RegistrationsFor(new TypedService(type));
            List<Type> types = new List<Type>();
            foreach (var registration in registrations)
            {
                var activator = registration.Activator as ReflectionActivator;
                if (activator != null)
                {
                    //这里的type就是我们想要得到的
                    types.Add(activator.LimitType);
                }
            }
            return types;
        }
        /// <summary>
        /// 获取符合当前泛型类型注册的所有类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<Type> GetRegisteredTypes<T>()
        {
            return GetRegisteredTypes(typeof(T));
        }
    }
}