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
    
    public partial class Fond
    {
        public int id { get; set; }
        public string floor { get; set; }
        public Nullable<System.DateTime> year_build { get; set; }
        public string quntyti_rooms { get; set; }
        public string price_cadastr { get; set; }
        public string price_arend { get; set; }
        public string price_market { get; set; }
        public Nullable<int> id_RoomArend { get; set; }
        public Nullable<int> id_Bathroom { get; set; }
        public Nullable<int> id_Location { get; set; }
        public Nullable<int> id_aircondit { get; set; }
    
        public virtual Aircondit Aircondit { get; set; }
        public virtual Bathroom Bathroom { get; set; }
        public virtual Location Location { get; set; }
        public virtual RoomArend RoomArend { get; set; }
    }
}
