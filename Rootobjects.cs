//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperGridPaging
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rootobjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rootobjects()
        {
            this.Channels = new HashSet<Channels>();
        }
    
        public int ID { get; set; }
        public System.DateTime DataProcessamento { get; set; }
        public string Matricola { get; set; }
        public string Descrizione { get; set; }
        public string Disegno { get; set; }
        public string NomeFile { get; set; }
        public string Channel { get; set; }
        public string idcode { get; set; }
        public System.DateTime DataAvvitatura { get; set; }
        public string Qualitycode { get; set; }
        public string Risolutivo { get; set; }
        public string LastCmd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<Channels> Channels { get; set; }
    }
}
