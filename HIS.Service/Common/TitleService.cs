using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    public class TitleService : ITitleService
    {
        public List<TitleEntity> GetAll()
        {
            return DBHelper.Instance.HIS.From<Dic_Title>().OrderBy(p => p.TitleLevel).ToList().Select(p => new TitleEntity()
            {
                Scope = (Scope)p.Scope,
                SearchCode = p.SearchCode,
                TitleId = p.Id,
                TitleLevel = p.TitleLevel,
                TitleName = p.Name
            }).ToList();
        }
    }
}
