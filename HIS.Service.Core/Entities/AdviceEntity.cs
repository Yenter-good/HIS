using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class AdviceEntity
    {
        //ID
        public long Id { get; set; }
        //医嘱Code
        public string Code { get; set; }
        //状态 状态 0停用 1启用 2作废
        public DataStatus DataStatus { get; set; }

        //医嘱名称
        public string Name { get; set; }

        //组合价格
        public decimal Price { get; set; }

        //拼音码
        public string SearchCode { get; set; }

        //五笔码
        public string WubiCode { get; set; }

        //组合项目类型 医嘱项目类型  1检验 2检查 3处置 4护理 5膳食 6嘱托 7手术 8其他
        public AdviceType Type { get; set; }

        //标本类型 （检验类型时填写）标本类型
        public LongItem Sample { get; set; }

        //试管类型 （检验类型时填写）试管类型
        public LongItem Buret { get; set; }

        //检查部位 （检查类型时填写）检查部位
        public LongItem Part { get; set; }

        //设备类型 （检查类型时填写）设备类型
        public LongItem Modality { get; set; }

        //门诊可用标志
        public bool OFlag { get; set; }

        //住院可用标志
        public bool IFlag { get; set; }

        //手术室可用标志
        public bool SFlag { get; set; }

        //医技可用标志
        public bool MFlag { get; set; }
        /// <summary>
        /// 名称长度
        /// </summary>
        public int Length { get; set; }
    }
}
