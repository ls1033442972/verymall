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
    
    public partial class MemberActivityDegreeInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long UserId { get; set; }
        public bool OneMonth { get; set; }
        public bool ThreeMonth { get; set; }
        public bool SixMonth { get; set; }
        public Nullable<System.DateTime> OneMonthEffectiveTime { get; set; }
        public Nullable<System.DateTime> ThreeMonthEffectiveTime { get; set; }
        public Nullable<System.DateTime> SixMonthEffectiveTime { get; set; }
    }
}
