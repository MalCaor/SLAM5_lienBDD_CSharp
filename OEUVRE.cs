//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLAM5_lienBDD_CSharp
{
    using System;
    using System.Collections.Generic;
    
    public partial class OEUVRE
    {
        public int idOeuvre { get; set; }
        public int idType { get; set; }
        public Nullable<int> idCompositeur { get; set; }
        public string titreOeuvre { get; set; }
        public Nullable<int> anComposition { get; set; }
        public string texte { get; set; }
    
        public virtual COMPOSITEUR COMPOSITEUR { get; set; }
        public virtual TYPEOEUVRE TYPEOEUVRE { get; set; }
    }
}
