using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using flaggged.io.service.data.Enums;

namespace flaggged.io.service.data.Entities
{
    public class Flagggee : AuditableEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public ICollection<ProofDocument> ProofOfDefault { get; set; } = new Collection<ProofDocument>();
        public string BVN { get; set; }
        public string FlagggeeIdentificationDocument { get; set; }
        public FlagggedStatus FlagggedStatus { get; set; }
    }
}