using Delta.BLL;

namespace Delta.API.ViewModel
{
    public class PersonModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AddressId { get; set; }
    }
}