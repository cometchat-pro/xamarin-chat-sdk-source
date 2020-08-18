using System;
using ObjCRuntime;

namespace CometChatPro
{
	[Native]
	public enum BaseMessageTypes : ulong
	{
		TextMessage = 0,
		MediaMessage = 1,
		ActionMessage = 2,
		Call = 3,
		CustomMessage = 4,
		None = 5
	}

	[Native]
	public enum ConversationType : ulong
	{
		User = 0,
		Group = 1,
		None = 2
	}

	[Native]
	public enum MemberScope : ulong
	{
		Admin = 0,
		Moderator = 1,
		Participant = 2
	}

	[Native]
	public enum UserStatus : ulong
	{
		Online = 0,
		Offline = 1,
		Available = 2
	}

	[Native]
	public enum ConnectionStatus : ulong
	{
		Connecting = 0,
		Connected = 1,
		Disconnected = 2
	}

	[Native]
	public enum CallType : ulong
	{
		Audio = 0,
		Video = 1
	}

	[Native]
	public enum ModeCategory : ulong
	{
		Default = 0,
		HighVol = 1,
		Flaky = 2
	}

	[Native]
	public enum groupType : ulong
	{
		ublic = 0,
		rivate = 1,
		assword = 2
	}

	[Native]
	public enum Blocked : ulong
	{
		ByMe = 0,
		Me = 1,
		Both = 2
	}

	[Native]
	public enum MessageType : ulong
	{
		Text = 0,
		Image = 1,
		Video = 2,
		Audio = 3,
		File = 4,
		Custom = 5,
		GroupMember = 6
	}

	[Native]
	public enum MessageCategory : ulong
	{
		Message = 0,
		Action = 1,
		Call = 2,
		Custom = 3
	}

	[Native]
	public enum SubscriptionType : ulong
	{
		AllUsers = 0,
		OnlyFriends = 1,
		Role = 2,
		None = 3
	}

	[Native]
	public enum GroupMemberScopeType : ulong
	{
		Admin = 0,
		Moderator = 1,
		Participant = 2
	}

	[Native]
	public enum callStatus : ulong
	{
		Initiated = 0,
		Ongoing = 1,
		Unanswered = 2,
		Rejected = 3,
		Busy = 4,
		Cancelled = 5,
		Ended = 6
	}

	[Native]
	public enum ActionEntityType : ulong
	{
		User = 0,
		Group = 1,
		GroupMember = 2,
		Message = 3
	}

	[Native]
	public enum actionType : ulong
	{
		Joined = 0,
		Left = 1,
		Kicked = 2,
		Banned = 3,
		Unbanned = 4,
		ScopeChanged = 5,
		MessageEdited = 6,
		MessageDeleted = 7,
		Added = 8
	}

	[Native]
	public enum ReceiverType : ulong
	{
		User = 0,
		Group = 1
	}

	[Native]
	public enum XMPPMsgType : ulong
	{
		Chat = 0,
		GroupChat = 1
	}

	[Native]
	public enum ReceiptType : ulong
	{
		Delivered = 0,
		Read = 1
	}
}
