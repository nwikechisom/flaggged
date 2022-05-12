using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Identity;

namespace flaggged.io.service.data.Entities
{
    public class Flaggger : IdentityUser
    {
        public string OrganizationName { get; set; }
        public string Organization { get; set; }
        public string RcNumber { get; set; }
        public string OrganizationPhonenumber { get; set; }
        public string OrganizationEmail { get; set; }
        public string OrganizationPreferredUsername { get; set; }
        public OrganizationCategory OrganizationCategory { get; set; }
        public ICollection<OrganizationContactPerson> OrganizationContactPersons { get; set; } =
            new Collection<OrganizationContactPerson>();
    }
}