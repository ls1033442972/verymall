//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Himall.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MarketSettingMetaInfo:BaseModel
    {
        int _id;
        public new int Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public int MarketId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    
        public virtual MarketSettingInfo Himall_MarketSetting { get; set; }
    }
}