using System;
namespace PeopleApi.Models
{
	public class PersonDTO
	{
		public long Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
        public bool isRegistered { get; set; }

        public PersonDTO()
		{
		}
	}
}

