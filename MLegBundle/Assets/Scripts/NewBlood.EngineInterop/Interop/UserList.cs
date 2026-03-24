using Interop.core;
using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct UserList : UserList.Interface, IUpCastable<UserList>, UserListBase.Interface, IUpCastable<UserListBase>
	{
		public interface Interface : IUpCastable<UserList>, UserListBase.Interface, IUpCastable<UserListBase>
		{
		}

		[BaseField]
		private UserListBase __UserListBase;

		public vector<UserListBase.Entry> m_Entries;

		unsafe ref UserList IUpCastable<UserList>.Cast()
		{
			return ref *(UserList*)null;
		}

		unsafe ref UserListBase IUpCastable<UserListBase>.Cast()
		{
			return ref *(UserListBase*)null;
		}
	}
}
