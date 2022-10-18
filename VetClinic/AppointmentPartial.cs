using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic
{
    public partial class Appointment
    {
        public Appointment(int id, int vet_id, int owner_id, int pet_id, DateTime when, string note, Pet pet, Owner owner, Vet vet, ICollection<Prescription> prescriptions)
        {
            this.id = id;
            this.vet_id = vet_id;
            this.owner_id = owner_id;
            this.pet_id = pet_id;
            this.when = when;
            this.note = note;
            Pet = pet;
            Owner = owner;
            Vet = vet;
            Prescriptions = prescriptions;
        }
        public Appointment(int id, int vet_id, int owner_id, int pet_id, DateTime when, string note)
        {
            this.id = id;
            this.vet_id = vet_id;
            this.owner_id = owner_id;
            this.pet_id = pet_id;
            this.when = when;
            this.note = note;

        }
    }
}
