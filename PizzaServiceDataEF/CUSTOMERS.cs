//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaServiceDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMERS()
        {
            this.ORDER_HEADERS = new HashSet<ORDER_HEADERS>();
        }
    
        public int C_ID { get; set; }
        public string C_NAME { get; set; }
        public string C_PHONE { get; set; }
        public string C_EMAIL { get; set; }
        public Nullable<int> C_USERID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_HEADERS> ORDER_HEADERS { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
