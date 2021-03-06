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
    
    public partial class AccountInfo:BaseModel
    {
        public AccountInfo()
        {
            this.Himall_AccountPurchaseAgreement = new HashSet<AccountPurchaseAgreementInfo>();
            this.Himall_AccountDetails = new HashSet<AccountDetailInfo>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long ShopId { get; set; }
        public string ShopName { get; set; }
        public System.DateTime AccountDate { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public AccountInfo.AccountStatus Status { get; set; }
        public decimal CommissionAmount { get; set; }
        public decimal RefundAmount { get; set; }
        public string Remark { get; set; }
        public decimal FreightAmount { get; set; }
        public decimal RefundCommissionAmount { get; set; }
        public decimal AdvancePaymentAmount { get; set; }
        public decimal PeriodSettlement { get; set; }
        public decimal ProductActualPaidAmount { get; set; }
        public decimal Brokerage { get; set; }
        public decimal ReturnBrokerage { get; set; }
    
        public virtual ICollection<AccountPurchaseAgreementInfo> Himall_AccountPurchaseAgreement { get; set; }
        public virtual ICollection<AccountDetailInfo> Himall_AccountDetails { get; set; }
    }
}
