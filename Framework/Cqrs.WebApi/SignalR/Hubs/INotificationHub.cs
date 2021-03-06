﻿using System;
using Cqrs.Authentication;
using Cqrs.Events;

namespace Cqrs.WebApi.SignalR.Hubs
{
	public interface INotificationHub
	{
		/// <summary>
		/// Send out an event to specific user RSNs
		/// </summary>
		void SendUsersEvent<TSingleSignOnToken>(IEvent<TSingleSignOnToken> eventData, params Guid[] userRsnCollection)
			where TSingleSignOnToken : ISingleSignOnToken, new();

		/// <summary>
		/// Send out an event to specific user token
		/// </summary>
		void SendUserEvent<TSingleSignOnToken>(IEvent<TSingleSignOnToken> eventData, string userToken)
			where TSingleSignOnToken : ISingleSignOnToken, new();

		/// <summary>
		/// Send out an event to all users
		/// </summary>
		void SendAllUsersEvent<TSingleSignOnToken>(IEvent<TSingleSignOnToken> eventData)
			where TSingleSignOnToken : ISingleSignOnToken, new();

		/// <summary>
		/// Send out an event to all users except the specific user token
		/// </summary>
		void SendExceptThisUserEvent<TSingleSignOnToken>(IEvent<TSingleSignOnToken> eventData, string userToken)
			where TSingleSignOnToken : ISingleSignOnToken, new();
	}
}