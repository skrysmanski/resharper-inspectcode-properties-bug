using System.Runtime.Serialization;
using CppCliLibrary;

namespace DotNetLibrary
{
	[DataContract]
	public class Account
	{
		[DataMember]
		public AccountType AccountType { get; set; }
	}
}
