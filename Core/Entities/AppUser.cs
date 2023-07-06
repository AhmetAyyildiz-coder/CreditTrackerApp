using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
	// access modifier => public
	public class AppUser
	{

		// 1 kullanıcının N kredisi olabilir. 
		public List<Credit> Credits { get; set; } = new List<Credit>();
		public string Name { get; set; }
		public string Surname { get; set; }
	}
}
