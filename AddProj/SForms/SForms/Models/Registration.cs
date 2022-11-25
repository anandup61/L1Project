namespace SForms.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public int city { get; set; }
        public int state { get; set; }
        
        public DateTime createdDate { get; set; }
    }
}
