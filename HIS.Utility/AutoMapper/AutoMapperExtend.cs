using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utility
{
    public static class AutoMapperExtend
    {
        public static T Mapper<T>(this object obj)
        {
            return AutoMapperHelper.Instance.Mapper.Map<T>(obj);
        }
        public static TDestination JoinMapper<TSource, TDestination>(this TDestination destination, TSource source)
        {
            return AutoMapperHelper.Instance.Mapper.Map(source, destination);
        }
    }
}
