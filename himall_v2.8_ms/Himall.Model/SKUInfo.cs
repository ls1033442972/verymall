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
    
    public partial class SKUInfo:BaseModel
    {
        string _id;
        public new string Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long ProductId { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Version { get; set; }
        public string Sku { get; set; }
        public long Stock { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public long AutoId { get; set; }
        public string ShowPic { get; set; }
        public Nullable<long> SafeStock { get; set; }
    
        public virtual ProductInfo ProductInfo { get; set; }
    }
}
