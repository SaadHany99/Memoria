namespace Medical_History.Models
{
    public class MedicalRecord
    {
            public int Id { get; set; }
            public DateTime DateOfVisit { get; set; }
            public string Diagnosis { get; set; }
            public string Treatment { get; set; }
            public string? Notes { get; set; }

            public int PatientId { get; set; }
            public Patient Patient { get; set; }

            public int DoctorId { get; set; }
            public Doctor Doctor { get; set; }

            public int HospitalId { get; set; }
            public Hospital Hospital { get; set; }
        

    }
}
