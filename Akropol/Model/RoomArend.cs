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
    
    public partial class RoomArend
    {
        public RoomArend()
        {
            this.Fond = new HashSet<Fond>();
        }
    
        public int id { get; set; }
        public bool Arend { get; set; }
    
        public virtual ICollection<Fond> Fond { get; set; }
    }
}
