using ClientPatientManagement.Core.Interfaces;
using SharedKernel.Enums;

namespace ClientPatientManagement.Core.Model
{
    public class Patient : IEntity
    {
        public Patient()
        {
        }

        public int Id { get; set; }
        public Client Owner { get; private set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}