namespace Medical_History.Models
{
    public class Doctor
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Specialization { get; set; }
            public string? ContactNumber { get; set; }
            public string? Address { get; set; }

           public ICollection<MedicalRecord>? MedicalRecords { get; set; }
    }
}
