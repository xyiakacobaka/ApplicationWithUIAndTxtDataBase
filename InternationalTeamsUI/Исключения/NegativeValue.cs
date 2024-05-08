using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTeamsUI.Исключения
{

	[Serializable]
	public class NegativeValue : ApplicationException
    {
		public NegativeValue() { }
		public NegativeValue(string message) : base(message) { }
		public NegativeValue(string message, Exception inner) : base(message, inner) { }
		protected NegativeValue(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
