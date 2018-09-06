using System.ComponentModel.DataAnnotations.Schema;

namespace AuditApp.API.Models
{
   [Table("API_Audit", Schema = "EFAudit")]
    public class Audit
    {
        public long Id {get; set;}
        public string ActionDescription {get; set;}

        public string RequestOwner {get; set;}

   
    }
}