//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class family
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public family()
        {
            this.familyhistory = new HashSet<familyhistory>();
            this.characterfamily = new HashSet<characterfamily>();
        }
    
        public string FamilyName { get; set; }
        public Nullable<int> FamilyLevel { get; set; }
        public Nullable<int> FamilyInventory { get; set; }
        public Nullable<int> FamilySizeMax { get; set; }
        public string FamilyAnnounce { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<familyhistory> familyhistory { get; set; }
        public virtual warehouse warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<characterfamily> characterfamily { get; set; }
    }
}
