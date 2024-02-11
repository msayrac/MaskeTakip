using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person();

			person1.FirstName = "Ali";


			PTTManager manager = new PTTManager(new PersonManager());

			manager.Givemask(person1);





			Console.ReadLine();

			
		}

	}
	
}
















