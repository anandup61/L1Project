namespace SForms.Models
{
    public class RegistrationDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string Address { get; set; }
      //  public string Status { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
