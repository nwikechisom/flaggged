using System;

namespace flaggged.io.service.data.Entities
{
    public class ProofDocument : AuditableEntity
    {
        public string DocumentUrl { get; set; }
        public DateTime WhenDue { get; set; }
    }
}