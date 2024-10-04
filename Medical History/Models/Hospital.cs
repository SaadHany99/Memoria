namespace Medical_History.Models
{
    public class Hospital
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public string? ContactNumber { get; set; }

            public ICollection<MedicalRecord>? MedicalRecords { get; set; }
        

    }
}
