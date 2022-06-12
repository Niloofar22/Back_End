using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.Model

public class User
{
	{
	public int Id { get; set; }
	public string Userame { get; set; }
	public string Password { get; set; }
	public List<User> Users { get; set; }
	}
}
