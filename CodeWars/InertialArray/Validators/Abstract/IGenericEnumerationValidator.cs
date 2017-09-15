using System.Collections.Generic;

namespace CodeWars.InertialArray.Validators.Abstract
{
	public interface IGenericEnumerationValidator<in T>
	{
		bool IsValid(IEnumerable<T> enumeration);
	}
}