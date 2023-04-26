using System;
namespace InsyGroupTwoProject.Model
{
	public class Client
	{

        public Client()
        {
            autoIncreament++;
            Id = autoIncreament;

        }

        private static int autoIncreament = 006000000;

		public int Id { get; set; }

        public string Username { get; set; }

		public string Password { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		

    }
}

