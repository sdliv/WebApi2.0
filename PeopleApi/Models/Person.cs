using System;
namespace PeopleApi.Models
{
	public class Person
	{
		public long Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public bool isRegistered { get; set; }
		public string? Secret { get; set; }
		public Person()
		{
		}
	}
}

