//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class table_Order
    {
        public int Id { get; set; }

        [DisplayName("訂單編號")]
        public string OrderGuid { get; set; }

        [DisplayName("會員帳號")]
        public string UserId { get; set; }

        [DisplayName("收件人姓名")]
        public string Receiver { get; set; }

        [DisplayName("收件人信箱")]
        public string Email { get; set; }

        [DisplayName("收件人地址")]
        public string Address { get; set; }

        [DisplayName("訂單日期")]
        public Nullable<System.DateTime> Date { get; set; }
    }
}
