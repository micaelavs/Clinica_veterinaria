using ClientPatientManagement.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ClientPatientManagement.Core.Model
{
    public partial class Room : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }


    [MetadataType(typeof(RoomMetadata))]
    public partial class Room
    {
        public class RoomMetadata
        {
            [Key]
            public int Id { get; set; }

            [StringLength(50)]
            public string Name { get; set; }

            [StringLength(50)]
            public string Location { get; set; }
        }
    }

}