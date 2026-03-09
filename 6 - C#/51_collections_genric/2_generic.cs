using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_collections_genric
{
	public class GenricExample<T>
	{

		// private data members
		private T data;

		// using properties
		public T value
		{

			// using accessors
			get
			{
				return this.data;
			}
			set
			{
				this.data = value;
			}
		}
	}
}
