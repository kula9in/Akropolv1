//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Akropol.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Manager
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> Id_role { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
