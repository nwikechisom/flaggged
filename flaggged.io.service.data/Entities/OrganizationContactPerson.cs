namespace flaggged.io.service.data.Entities
{
    public class OrganizationContactPerson : AuditableEntity
    {
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
    }
}