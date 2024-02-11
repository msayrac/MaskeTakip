using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class PTTManager : ISupplierService
	{

		private IApplicantService _appliantService;

		public PTTManager(IApplicantService applicantService)
		{
			_appliantService = applicantService;
		}

		public void GiveMask(Person person)
		{

			if (_appliantService.CheckPerson(person))
			{
				Console.WriteLine(person.FirstName + " maske verildi");
			}

		}


	}

}

