using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Dto
{
    public class OwnerDto
    {
        // copied from Owner.cs which is in Models folder
        // Note - Only copy the attributes which related to the model only 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }

        
    }
}
