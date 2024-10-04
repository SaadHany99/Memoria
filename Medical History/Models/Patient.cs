using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medical_History.Models
{
    public class Patient
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }

            public ICollection<MedicalRecord>? MedicalRecords { get; set; }
        

    }
}
