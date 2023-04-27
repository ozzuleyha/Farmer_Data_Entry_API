namespace Farmer_Data_Entry_API.Entities
{
    public class Farmer
    {
        public Guid FarmerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public string FathersName { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNumber { get; set; }
        public int CompanyId { get; set; }
        public int VillageId { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
