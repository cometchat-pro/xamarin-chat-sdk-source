using System;
using UIKit;
using Foundation;
using ObjCRuntime;


namespace CometChatPro
{
	// @interface AppEntity : NSObject
	[BaseType(typeof(NSObject))]
	interface AppEntity
	{
	}

	// @interface BaseMessage : AppEntity
	[BaseType(typeof(AppEntity))]
	[DisableDefaultCtor]
	interface BaseMessage
	{
		// @property (nonatomic) NSInteger id;
		[Export("id")]
		nint Id { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull muid;
		[Export("muid")]
		string Muid { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull senderUid;
		[Export("senderUid")]
		string SenderUid { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull receiverUid;
		[Export("receiverUid")]
		string ReceiverUid { get; set; }

		// @property (nonatomic) enum MessageType messageType;
		[Export("messageType", ArgumentSemantic.Assign)]
        MessageType MessageType1 { get; set; }

		// @property (nonatomic) enum ReceiverType receiverType;
		[Export("receiverType", ArgumentSemantic.Assign)]
		ReceiverType ReceiverType1 { get; set; }

		// @property (copy, nonatomic) NSArray<MessageReceipt *> * _Nonnull receipts;
		[Export("receipts", ArgumentSemantic.Copy)]
		MessageReceipt[] Receipts { get; set; }

		// @property (nonatomic) double deliveredToMeAt;
		[Export("deliveredToMeAt")]
		double DeliveredToMeAt { get; set; }

		// @property (nonatomic) double readByMeAt;
		[Export("readByMeAt")]
		double ReadByMeAt { get; set; }

		// @property (nonatomic) double deliveredAt;
		[Export("deliveredAt")]
		double DeliveredAt { get; set; }

		// @property (nonatomic) double readAt;
		[Export("readAt")]
		double ReadAt { get; set; }

		// @property (nonatomic) NSInteger sentAt;
		[Export("sentAt")]
		nint SentAt { get; set; }

		// @property (nonatomic) double updatedAt;
		[Export("updatedAt")]
		double UpdatedAt { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull status;
		[Export("status")]
		string Status { get; set; }

		// @property (nonatomic) enum MessageCategory messageCategory;
		[Export("messageCategory", ArgumentSemantic.Assign)]
		MessageCategory MessageCategory { get; set; }

		// @property (nonatomic, strong) User * _Nullable sender;
		[NullAllowed, Export("sender", ArgumentSemantic.Strong)]
		User Sender { get; set; }

		// @property (nonatomic, strong) AppEntity * _Nullable receiver;
		[NullAllowed, Export("receiver", ArgumentSemantic.Strong)]
		AppEntity Receiver { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nullable metaData;
		[NullAllowed, Export("metaData", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> MetaData { get; set; }

		// @property (nonatomic) double editedAt;
		[Export("editedAt")]
		double EditedAt { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull editedBy;
		[Export("editedBy")]
		string EditedBy { get; set; }

		// @property (nonatomic) double deletedAt;
		[Export("deletedAt")]
		double DeletedAt { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull deletedBy;
		[Export("deletedBy")]
		string DeletedBy { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull conversationId;
		[Export("conversationId")]
		string ConversationId { get; set; }

		// @property (nonatomic) NSInteger parentMessageId;
		[Export("parentMessageId")]
		nint ParentMessageId { get; set; }

		// @property (nonatomic) NSInteger replyCount;
		[Export("replyCount")]
		nint ReplyCount { get; set; }

		// -(instancetype _Nonnull)initWithReceiverUid:(NSString * _Nonnull)receiverUid messageType:(enum MessageType)messageType receiverType:(enum ReceiverType)receiverType __attribute__((objc_designated_initializer));
		[Export("initWithReceiverUid:messageType:receiverType:")]
		[DesignatedInitializer]
		IntPtr Constructor(string receiverUid, MessageType messageType, ReceiverType receiverType);
	}

	// @interface ActionMessage : BaseMessage
	[BaseType(typeof(BaseMessage))]
	interface ActionMessage
	{
		// @property (nonatomic, strong) AppEntity * _Nullable actionBy;
		[NullAllowed, Export("actionBy", ArgumentSemantic.Strong)]
		AppEntity ActionBy { get; set; }

		// @property (nonatomic, strong) AppEntity * _Nullable actionFor;
		[NullAllowed, Export("actionFor", ArgumentSemantic.Strong)]
		AppEntity ActionFor { get; set; }

		// @property (nonatomic, strong) AppEntity * _Nullable actionOn;
		[NullAllowed, Export("actionOn", ArgumentSemantic.Strong)]
		AppEntity ActionOn { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable message;
		[NullAllowed, Export("message")]
		string Message { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable rawData;
		[NullAllowed, Export("rawData")]
		string RawData { get; set; }

		// @property (nonatomic) enum GroupMemberScopeType oldScope;
		[Export("oldScope", ArgumentSemantic.Assign)]
		GroupMemberScopeType OldScope { get; set; }

		// @property (nonatomic) enum GroupMemberScopeType newScope;
		[Export("newScope", ArgumentSemantic.Assign)]
		GroupMemberScopeType NewScope { get; set; }

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		string StringValue { get; }
	}

	// @interface AppSettings : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface AppSettings
	{
		// -(instancetype _Nonnull)initWithBuilder:(AppSettingsBuilder * _Nonnull)builder __attribute__((objc_designated_initializer));
		[Export("initWithBuilder:")]
		[DesignatedInitializer]
		IntPtr Constructor(AppSettingsBuilder builder);
	}

	// @interface AppSettingsBuilder : NSObject
	[BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface AppSettingsBuilder
	{
		// -(AppSettingsBuilder * _Nonnull)subscribePresenceForAllUsers __attribute__((warn_unused_result));
		[Export("subscribePresenceForAllUsers")]
		AppSettingsBuilder GetSubscribePresenceForAllUsers();

		// -(AppSettingsBuilder * _Nonnull)subscribePresenceForFriends __attribute__((warn_unused_result));
		[Export("subscribePresenceForFriends")]
		AppSettingsBuilder SubscribePresenceForFriends { get; }

		// -(AppSettingsBuilder * _Nonnull)setRegionWithRegion:(NSString * _Nonnull)region __attribute__((warn_unused_result));
		[Export("setRegionWithRegion:")]
		AppSettingsBuilder SetRegionWithRegion(string region);

		// -(AppSettingsBuilder * _Nonnull)subcribePresenceForRolesWithRoles:(NSArray<NSString *> * _Nonnull)roles __attribute__((warn_unused_result));
		[Export("subcribePresenceForRolesWithRoles:")]
		AppSettingsBuilder SubcribePresenceForRolesWithRoles(string[] roles);

		// -(AppSettingsBuilder * _Nonnull)setEnableAutoJoinForGroupsWithEnableAutoJoinForGroups:(BOOL)enableAutoJoinForGroups __attribute__((warn_unused_result));
		[Export("setEnableAutoJoinForGroupsWithEnableAutoJoinForGroups:")]
		AppSettingsBuilder SetEnableAutoJoinForGroupsWithEnableAutoJoinForGroups(bool enableAutoJoinForGroups);

		// -(AppSettings * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		AppSettings Build();
	}

	// @interface Attachment : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface Attachment
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull fileName;
		[Export("fileName")]
		string FileName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull fileExtension;
		[Export("fileExtension")]
		string FileExtension { get; }

		// @property (readonly, nonatomic) double fileSize;
		[Export("fileSize")]
		double FileSize { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull fileMimeType;
		[Export("fileMimeType")]
		string FileMimeType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull fileUrl;
		[Export("fileUrl")]
		string FileUrl { get; }
	}

	// @interface BannedGroupMembersRequest : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface BannedGroupMembersRequest
	{
		// -(instancetype _Nonnull)initWithBuilder:(BannedGroupMembersRequestBuilder * _Nonnull)builder __attribute__((objc_designated_initializer));
		[Export("initWithBuilder:")]
		[DesignatedInitializer]
		IntPtr Constructor(BannedGroupMembersRequestBuilder builder);

        // -(void)fetchNextOnSuccess:(void (^ _Nonnull)(NSArray<GroupMember *> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
        //[Export("fetchNextOnSuccess:onError:")]
        //void FetchNextOnSuccess(Action<NSArray<GroupMember>> onSuccess, Action<CometChatException> onError);
	}

	// @interface BannedGroupMembersRequestBuilder : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface BannedGroupMembersRequestBuilder
	{
		// -(instancetype _Nonnull)initWithGuid:(NSString * _Nonnull)guid __attribute__((objc_designated_initializer));
		[Export("initWithGuid:")]
		[DesignatedInitializer]
		IntPtr Constructor(string guid);

		// -(BannedGroupMembersRequestBuilder * _Nonnull)setWithLimit:(NSInteger)limit __attribute__((warn_unused_result));
		[Export("setWithLimit:")]
		BannedGroupMembersRequestBuilder SetWithLimit(nint limit);

		// -(BannedGroupMembersRequestBuilder * _Nonnull)setWithSearchKeyword:(NSString * _Nonnull)searchKeyword __attribute__((warn_unused_result));
		[Export("setWithSearchKeyword:")]
		BannedGroupMembersRequestBuilder SetWithSearchKeyword(string searchKeyword);

		// -(BannedGroupMembersRequest * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		BannedGroupMembersRequest Build { get; }
	}

	// @interface CometChatPro_Swift_337 (BaseMessage)
	[Category]
	[BaseType(typeof(BaseMessage))]
	interface BaseMessage_CometChatPro_Swift_337
	{
		// @property (readonly, nonatomic) enum BaseMessageTypes messgeTypeFromBaseMessage;
		[Export("messgeTypeFromBaseMessage")]
		BaseMessageTypes GetMessgeTypeFromBaseMessage();
	}

	// @interface BlockedUserRequest : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface BlockedUserRequest
	{
		// -(instancetype _Nonnull)initWithBuilder:(BlockedUserRequestBuilder * _Nonnull)builder __attribute__((objc_designated_initializer));
		[Export("initWithBuilder:")]
		[DesignatedInitializer]
		IntPtr Constructor(BlockedUserRequestBuilder builder);

		// -(void)fetchPreviousOnSuccess:(void (^ _Nonnull)(NSArray<User *> * _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		//[Export("fetchPreviousOnSuccess:onError:")]
		//void FetchPreviousOnSuccess(Action<NSArray<User>> onSuccess, Action<CometChatException> onError);

		// -(void)fetchNextOnSuccess:(void (^ _Nonnull)(NSArray<User *> * _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		//[Export("fetchNextOnSuccess:onError:")]
		//void FetchNextOnSuccess(Action<NSArray<User>> onSuccess, Action<CometChatException> onError);
	}

	// @interface BlockedUserRequestBuilder : NSObject
	[BaseType(typeof(NSObject))]
	interface BlockedUserRequestBuilder
	{
		// -(instancetype _Nonnull)initWithLimit:(NSInteger)limit __attribute__((objc_designated_initializer));
		[Export("initWithLimit:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint limit);

		// -(BlockedUserRequestBuilder * _Nonnull)setWithLimit:(NSInteger)limit __attribute__((warn_unused_result));
		[Export("setWithLimit:")]
		BlockedUserRequestBuilder SetWithLimit(nint limit);

		// -(BlockedUserRequestBuilder * _Nonnull)setWithDirection:(enum Blocked)direction __attribute__((warn_unused_result));
		[Export("setWithDirection:")]
		BlockedUserRequestBuilder SetWithDirection(Blocked direction);

		// -(BlockedUserRequest * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		BlockedUserRequest Build { get; }
	}

	// @interface Call : BaseMessage
	[BaseType(typeof(BaseMessage))]
	interface Call
	{
		// @property (copy, nonatomic) NSString * _Nullable sessionID;
		[NullAllowed, Export("sessionID")]
		string SessionID { get; set; }

		// @property (nonatomic) enum callStatus callStatus;
		[Export("callStatus", ArgumentSemantic.Assign)]
		callStatus CallStatus { get; set; }

		// @property (nonatomic) enum CallType callType;
		[Export("callType", ArgumentSemantic.Assign)]
		CallType CallType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable action;
		[NullAllowed, Export("action")]
		string Action { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable rawData;
		[NullAllowed, Export("rawData")]
		string RawData { get; set; }

		// @property (nonatomic) double initiatedAt;
		[Export("initiatedAt")]
		double InitiatedAt { get; set; }

		// @property (nonatomic) double joinedAt;
		[Export("joinedAt")]
		double JoinedAt { get; set; }

		// @property (nonatomic, strong) AppEntity * _Nullable callInitiator;
		[NullAllowed, Export("callInitiator", ArgumentSemantic.Strong)]
		AppEntity CallInitiator { get; set; }

		// @property (nonatomic, strong) AppEntity * _Nullable callReceiver;
		[NullAllowed, Export("callReceiver", ArgumentSemantic.Strong)]
		AppEntity CallReceiver { get; set; }

		// -(instancetype _Nonnull)initWithReceiverId:(NSString * _Nonnull)receiverId callType:(enum CallType)callType receiverType:(enum ReceiverType)receiverType __attribute__((objc_designated_initializer));
		[Export("initWithReceiverId:callType:receiverType:")]
		[DesignatedInitializer]
		IntPtr Constructor(string receiverId, CallType callType, ReceiverType receiverType);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		string StringValue { get; }
	}

	// @interface CometChat : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface CometChat
	{
		// @property (readonly, nonatomic, class) BOOL isInitialised;
		[Static]
		[Export("isInitialised")]
		bool IsInitialised { get; }

		// -(instancetype _Nonnull)initWithAppId:(NSString * _Nonnull)appId onSuccess:(void (^ _Nonnull)(BOOL))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nonnull))onError __attribute__((availability(ios, unavailable))) __attribute__((objc_designated_initializer));
		[Unavailable(PlatformName.iOS)]
		[Export("initWithAppId:onSuccess:onError:")]
		[DesignatedInitializer]
		IntPtr Constructor(string appId, Action<bool> onSuccess, Action<CometChatException> onError);

		// -(instancetype _Nonnull)initWithAppId:(NSString * _Nonnull)appId appSettings:(AppSettings * _Nonnull)appSettings onSuccess:(void (^ _Nonnull)(BOOL))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nonnull))onError __attribute__((objc_designated_initializer));
		[Export("initWithAppId:appSettings:onSuccess:onError:")]
		[DesignatedInitializer]
		IntPtr Constructor(string appId, AppSettings appSettings, Action<bool> onSuccess, Action<CometChatException> onError);



	}

	// @interface CometChatPro_Swift_403 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_403
	{
	}

	// @interface CometChatPro_Swift_413 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_413
	{
	}

	// @interface CometChatPro_Swift_423 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_423
	{
	}

	// @interface CometChatPro_Swift_433 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_433
	{
	}

	// @interface CometChatPro_Swift_443 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_443
	{
	}

	// @interface CometChatPro_Swift_452 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_452
	{
	}

	// @interface CometChatPro_Swift_462 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_462
	{
		// +(void)setSourceWithResource:(NSString * _Nonnull)resource platform:(NSString * _Nonnull)platform language:(NSString * _Nonnull)language;
		[Static]
		[Export("setSourceWithResource:platform:language:")]
		void SetSourceWithResource(string resource, string platform, string language);
	}

	// @interface CometChatPro_Swift_467 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_467
	{
	}

	// @interface CometChatPro_Swift_477 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_477
	{
	}

	// @interface CometChatPro_Swift_487 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_487
	{
		// +(void)getUserWithUID:(NSString * _Nonnull)UID onSuccess:(void (^ _Nonnull)(User * _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("getUserWithUID:onSuccess:onError:")]
		void GetUserWithUID(string UID, Action<User> onSuccess, Action<CometChatException> onError);
	}

	// @interface CometChatPro_Swift_494 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_494
	{
	}

	// @interface CometChatPro_Swift_510 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_510
	{
	}

	// @interface CometChatPro_Swift_521 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_521
	{
	}

	// @interface CometChatPro_Swift_533 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_533
	{
		// +(void)getConversationWithConversationWith:(NSString * _Nonnull)conversationWith conversationType:(enum ConversationType)conversationType onSuccess:(void (^ _Nonnull)(Conversation * _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("getConversationWithConversationWith:conversationType:onSuccess:onError:")]
		void GetConversationWithConversationWith(string conversationWith, ConversationType conversationType, Action<Conversation> onSuccess, Action<CometChatException> onError);
	}

	// @interface CometChatPro_Swift_538 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_538
	{
	}

	// @interface CometChatPro_Swift_548 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_548
	{
	}

	// @interface CometChatPro_Swift_562 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_562
	{
	}

	// @interface CometChatPro_Swift_585 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_585
	{
		// +(void)createUserWithUser:(User * _Nonnull)user apiKey:(NSString * _Nonnull)apiKey onSuccess:(void (^ _Nonnull)(User * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("createUserWithUser:apiKey:onSuccess:onError:")]
		void CreateUserWithUser(User user, string apiKey, Action<User> onSuccess, Action<CometChatException> onError);

		// +(void)updateUserWithUser:(User * _Nonnull)user apiKey:(NSString * _Nonnull)apiKey onSuccess:(void (^ _Nonnull)(User * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("updateUserWithUser:apiKey:onSuccess:onError:")]
		void UpdateUserWithUser(User user, string apiKey, Action<User> onSuccess, Action<CometChatException> onError);
	}

	// @interface CometChatPro_Swift_593 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_593
	{
		// +(void)markAsReadWithMessageId:(NSInteger)messageId receiverId:(NSString * _Nonnull)receiverId receiverType:(enum ReceiverType)receiverType;
		[Static]
		[Export("markAsReadWithMessageId:receiverId:receiverType:")]
		void MarkAsReadWithMessageId(nint messageId, string receiverId, ReceiverType receiverType);

		// +(void)markAsDeliveredWithMessageId:(NSInteger)messageId receiverId:(NSString * _Nonnull)receiverId receiverType:(enum ReceiverType)receiverType;
		[Static]
		[Export("markAsDeliveredWithMessageId:receiverId:receiverType:")]
		void MarkAsDeliveredWithMessageId(nint messageId, string receiverId, ReceiverType receiverType);
	}

	// @interface CometChatPro_Swift_599 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_599
	{
	}

	// @interface CometChatPro_Swift_614 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_614
	{
		// +(void)startTypingWithIndicator:(TypingIndicator * _Nonnull)indicator;
		[Static]
		[Export("startTypingWithIndicator:")]
		void StartTypingWithIndicator(TypingIndicator indicator);

		// +(void)endTypingWithIndicator:(TypingIndicator * _Nonnull)indicator;
		[Static]
		[Export("endTypingWithIndicator:")]
		void EndTypingWithIndicator(TypingIndicator indicator);
	}

	// @interface CometChatPro_Swift_622 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_622
	{
		// +(void)kickGroupMemberWithUID:(NSString * _Nonnull)UID GUID:(NSString * _Nonnull)GUID onSuccess:(void (^ _Nonnull)(NSString * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("kickGroupMemberWithUID:GUID:onSuccess:onError:")]
		void KickGroupMemberWithUID(string UID, string GUID, Action<NSString> onSuccess, Action<CometChatException> onError);

		// +(void)banGroupMemberWithUID:(NSString * _Nonnull)UID GUID:(NSString * _Nonnull)GUID onSuccess:(void (^ _Nonnull)(NSString * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("banGroupMemberWithUID:GUID:onSuccess:onError:")]
		void BanGroupMemberWithUID(string UID, string GUID, Action<NSString> onSuccess, Action<CometChatException> onError);

		// +(void)unbanGroupMemberWithUID:(NSString * _Nonnull)UID GUID:(NSString * _Nonnull)GUID onSuccess:(void (^ _Nonnull)(NSString * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("unbanGroupMemberWithUID:GUID:onSuccess:onError:")]
		void UnbanGroupMemberWithUID(string UID, string GUID, Action<NSString> onSuccess, Action<CometChatException> onError);

		// +(void)updateGroupMemberScopeWithUID:(NSString * _Nonnull)UID GUID:(NSString * _Nonnull)GUID scope:(enum MemberScope)scope onSuccess:(void (^ _Nonnull)(NSString * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("updateGroupMemberScopeWithUID:GUID:scope:onSuccess:onError:")]
		void UpdateGroupMemberScopeWithUID(string UID, string GUID, MemberScope scope, Action<NSString> onSuccess, Action<CometChatException> onError);
	}

	// @interface CometChatPro_Swift_633 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_633
	{
		// +(void)sendTextMessageWithMessage:(TextMessage * _Nonnull)message onSuccess:(void (^ _Nonnull)(TextMessage * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("sendTextMessageWithMessage:onSuccess:onError:")]
		void SendTextMessageWithMessage(TextMessage message, Action<TextMessage> onSuccess, Action<CometChatException> onError);

		// +(void)sendMediaMessageWithMessage:(MediaMessage * _Nonnull)message onSuccess:(void (^ _Nonnull)(MediaMessage * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("sendMediaMessageWithMessage:onSuccess:onError:")]
		void SendMediaMessageWithMessage(MediaMessage message, Action<MediaMessage> onSuccess, Action<CometChatException> onError);

		// +(void)sendCustomMessageWithMessage:(CustomMessage * _Nonnull)message onSuccess:(void (^ _Nonnull)(CustomMessage * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("sendCustomMessageWithMessage:onSuccess:onError:")]
		void SendCustomMessageWithMessage(CustomMessage message, Action<CustomMessage> onSuccess, Action<CometChatException> onError);
	}

	// @interface CometChatPro_Swift_640 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_640
	{
		// +(void)loginWithUID:(NSString * _Nonnull)UID apiKey:(NSString * _Nonnull)apiKey onSuccess:(void (^ _Nonnull)(User * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nonnull))onError;
		[Static]
		[Export("loginWithUID:apiKey:onSuccess:onError:")]
		void LoginWithUID(string UID, string apiKey, Action<User> onSuccess, Action<CometChatException> onError);

		// +(void)loginWithAuthToken:(NSString * _Nonnull)authToken onSuccess:(void (^ _Nonnull)(User * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nonnull))onError;
		[Static]
		[Export("loginWithAuthToken:onSuccess:onError:")]
		void LoginWithAuthToken(string authToken, Action<User> onSuccess, Action<CometChatException> onError);

		// +(void)logoutOnSuccess:(void (^ _Nonnull)(NSString * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nonnull))onError;
		[Static]
		[Export("logoutOnSuccess:onError:")]
		void LogoutOnSuccess(Action<NSString> onSuccess, Action<CometChatException> onError);
	}

	// @interface CometChatPro_Swift_648 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_648
	{
		// +(void)updateGroupWithGroup:(Group * _Nonnull)group onSuccess:(void (^ _Nonnull)(Group * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("updateGroupWithGroup:onSuccess:onError:")]
		void UpdateGroupWithGroup(Group group, Action<Group> onSuccess, Action<CometChatException> onError);

		// +(void)deleteGroupWithGUID:(NSString * _Nonnull)GUID onSuccess:(void (^ _Nonnull)(NSString * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("deleteGroupWithGUID:onSuccess:onError:")]
		void DeleteGroupWithGUID(string GUID, Action<NSString> onSuccess, Action<CometChatException> onError);

		// +(void)createGroupWithGroup:(Group * _Nonnull)group onSuccess:(void (^ _Nonnull)(Group * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("createGroupWithGroup:onSuccess:onError:")]
		void CreateGroupWithGroup(Group group, Action<Group> onSuccess, Action<CometChatException> onError);

		// +(void)joinGroupWithGUID:(NSString * _Nonnull)GUID groupType:(enum groupType)groupType password:(NSString * _Nullable)password onSuccess:(void (^ _Nonnull)(Group * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("joinGroupWithGUID:groupType:password:onSuccess:onError:")]
		void JoinGroupWithGUID(string GUID, groupType groupType, [NullAllowed] string password, Action<Group> onSuccess, Action<CometChatException> onError);

		// +(void)getGroupWithGUID:(NSString * _Nonnull)GUID onSuccess:(void (^ _Nonnull)(Group * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("getGroupWithGUID:onSuccess:onError:")]
		void GetGroupWithGUID(string GUID, Action<Group> onSuccess, Action<CometChatException> onError);

		// +(void)leaveGroupWithGUID:(NSString * _Nonnull)GUID onSuccess:(void (^ _Nonnull)(NSString * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("leaveGroupWithGUID:onSuccess:onError:")]
		void LeaveGroupWithGUID(string GUID, Action<NSString> onSuccess, Action<CometChatException> onError);

		// +(void)getJoinedGroupsOnSuccess:(void (^ _Nonnull)(NSArray<NSString *> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("getJoinedGroupsOnSuccess:onError:")]
		void GetJoinedGroupsOnSuccess(Action<NSArray<NSString>> onSuccess, Action<CometChatException> onError);
	}

	// @interface CometChatPro_Swift_660 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_660
	{
		// +(void)initiateCallWithCall:(Call * _Nonnull)call onSuccess:(void (^ _Nonnull)(Call * _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("initiateCallWithCall:onSuccess:onError:")]
		void InitiateCallWithCall(Call call, Action<Call> onSuccess, Action<CometChatException> onError);

		// +(void)acceptCallWithSessionID:(NSString * _Nonnull)sessionID onSuccess:(void (^ _Nonnull)(Call * _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("acceptCallWithSessionID:onSuccess:onError:")]
		void AcceptCallWithSessionID(string sessionID, Action<Call> onSuccess, Action<CometChatException> onError);

		// +(void)rejectCallWithSessionID:(NSString * _Nonnull)sessionID status:(enum callStatus)status onSuccess:(void (^ _Nonnull)(Call * _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("rejectCallWithSessionID:status:onSuccess:onError:")]
		void RejectCallWithSessionID(string sessionID, callStatus status, Action<Call> onSuccess, Action<CometChatException> onError);

		// +(void)endCallWithSessionID:(NSString * _Nonnull)sessionID onSuccess:(void (^ _Nonnull)(Call * _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("endCallWithSessionID:onSuccess:onError:")]
		void EndCallWithSessionID(string sessionID, Action<Call> onSuccess, Action<CometChatException> onError);

		// +(void)startCallWithSessionID:(NSString * _Nonnull)sessionID inView:(UIView * _Nonnull)inView userJoined:(void (^ _Nonnull)(User * _Nullable))userJoined userLeft:(void (^ _Nonnull)(User * _Nullable))userLeft onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError callEnded:(void (^ _Nonnull)(Call * _Nullable))callEnded;
		[Static]
		[Export("startCallWithSessionID:inView:userJoined:userLeft:onError:callEnded:")]
		void StartCallWithSessionID(string sessionID, UIView inView, Action<User> userJoined, Action<User> userLeft, Action<CometChatException> onError, Action<Call> callEnded);

		// +(Call * _Nullable)getActiveCall __attribute__((warn_unused_result));
		[Static]
		[NullAllowed, Export("getActiveCall")]
		Call ActiveCall { get; }
	}

	// @interface CometChatPro_Swift_676 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_676
	{
		//[Wrap("WeakMessagedelegate"), Static]
		//[NullAllowed]
		//CometChatMessageDelegate Messagedelegate { get; set; }

		// @property (nonatomic, weak, class) id<CometChatMessageDelegate> _Nullable messagedelegate;
		//[Static]
		//[NullAllowed, Export("messagedelegate", ArgumentSemantic.Weak)]
		//NSObject WeakMessagedelegate { get; set; }

        //[Wrap("WeakCalldelegate"), Static]
        //[NullAllowed]
		//CometChatCallDelegate Calldelegate { get; set; }

		// @property (nonatomic, weak, class) id<CometChatCallDelegate> _Nullable calldelegate;
		[Static]
		[NullAllowed, Export("calldelegate", ArgumentSemantic.Weak)]
		NSObject WeakCalldelegate { get; set; }

		//[Wrap("WeakUserdelegate"), Static]
		//[NullAllowed]
		//CometChatUserDelegate Userdelegate { get; set; }

		// @property (nonatomic, weak, class) id<CometChatUserDelegate> _Nullable userdelegate;
		[Static]
		[NullAllowed, Export("userdelegate", ArgumentSemantic.Weak)]
		NSObject WeakUserdelegate { get; set; }

		//[Wrap("WeakGroupdelegate"), Static]
		//[NullAllowed]
		//CometChatGroupDelegate Groupdelegate { get; set; }

		// @property (nonatomic, weak, class) id<CometChatGroupDelegate> _Nullable groupdelegate;
		[Static]
		[NullAllowed, Export("groupdelegate", ArgumentSemantic.Weak)]
		NSObject WeakGroupdelegate { get; set; }

		//[Wrap("WeakConnectiondelegate"), Static]
		//[NullAllowed]
		//CometChatConnectionDelegate Connectiondelegate { get; set; }

		// @property (nonatomic, weak, class) id<CometChatConnectionDelegate> _Nullable connectiondelegate;
		//[Static]
		//[NullAllowed, Export("connectiondelegate", ArgumentSemantic.Weak)]
		//NSObject WeakConnectiondelegate { get; set; }

		//[Wrap("WeakLogindelegate"), Static]
		//[NullAllowed]
		//CometChatLoginDelegate Logindelegate { get; set; }

		// @property (nonatomic, weak, class) id<CometChatLoginDelegate> _Nullable logindelegate;
		//[Static]
		//[NullAllowed, Export("logindelegate", ArgumentSemantic.Weak)]
		//NSObject WeakLogindelegate { get; set; }
	}

	// @interface CometChatPro_Swift_698 (CometChat)
	[Category]
	[BaseType(typeof(CometChat))]
	interface CometChat_CometChatPro_Swift_698
	{
		// +(void)startServices;
		[Static]
		[Export("startServices")]
		void StartServices();

		// +(void)stopServices;
		[Static]
		[Export("stopServices")]
		void StopServices();

		// @property (readonly, nonatomic, class) BOOL isCallOngoing;
		[Static]
		[Export("isCallOngoing")]
		bool IsCallOngoing { get; }

		// @property (readonly, nonatomic, strong, class) Call * _Nullable currentCall;
		[Static]
		[NullAllowed, Export("currentCall", ArgumentSemantic.Strong)]
		Call CurrentCall { get; }

		// +(NSInteger)getLastDeliveredMessageId __attribute__((warn_unused_result));
		[Static]
		[Export("getLastDeliveredMessageId")]
		
		nint LastDeliveredMessageId { get; }

		// +(User * _Nullable)getLoggedInUser __attribute__((warn_unused_result));
		[Static]
		[NullAllowed, Export("getLoggedInUser")]
		
		User LoggedInUser { get; }

		// +(void)blockUsers:(NSArray<NSString *> * _Nonnull)users onSuccess:(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("blockUsers:onSuccess:onError:")]
		void BlockUsers(string[] users, Action<NSDictionary<NSString, NSObject>> onSuccess, Action<CometChatException> onError);

		// +(void)unblockUsers:(NSArray<NSString *> * _Nonnull)users onSuccess:(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("unblockUsers:onSuccess:onError:")]
		void UnblockUsers(string[] users, Action<NSDictionary<NSString, NSObject>> onSuccess, Action<CometChatException> onError);

		// +(BOOL)isExtensionEnabledWithExtensionId:(NSString * _Nonnull)extensionId __attribute__((warn_unused_result));
		[Static]
		[Export("isExtensionEnabledWithExtensionId:")]
		bool IsExtensionEnabledWithExtensionId(string extensionId);

		// +(void)getMessageReceipts:(NSInteger)messageId onSuccess:(void (^ _Nonnull)(NSArray<MessageReceipt *> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		//[Static]
		//[Export("getMessageReceipts:onSuccess:onError:")]
		//void GetMessageReceipts(nint messageId, Action<NSArray<MessageReceipt>> onSuccess, Action<CometChatException> onError);

		// +(void)getUnreadMessageCountForUser:(NSString * _Nonnull)uid hideMessagesFromBlockedUsers:(BOOL)hideMessagesFromBlockedUsers onSuccess:(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("getUnreadMessageCountForUser:hideMessagesFromBlockedUsers:onSuccess:onError:")]
		void GetUnreadMessageCountForUser(string uid, bool hideMessagesFromBlockedUsers, Action<NSDictionary<NSString, NSObject>> onSuccess, Action<CometChatException> onError);

		// +(void)getUnreadMessageCountForGroup:(NSString * _Nonnull)guid hideMessagesFromBlockedUsers:(BOOL)hideMessagesFromBlockedUsers onSuccess:(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("getUnreadMessageCountForGroup:hideMessagesFromBlockedUsers:onSuccess:onError:")]
		void GetUnreadMessageCountForGroup(string guid, bool hideMessagesFromBlockedUsers, Action<NSDictionary<NSString, NSObject>> onSuccess, Action<CometChatException> onError);

		// +(void)getUnreadMessageCountWithHideMessagesFromBlockedUsers:(BOOL)hideMessagesFromBlockedUsers onSuccess:(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("getUnreadMessageCountWithHideMessagesFromBlockedUsers:onSuccess:onError:")]
		void GetUnreadMessageCountWithHideMessagesFromBlockedUsers(bool hideMessagesFromBlockedUsers, Action<NSDictionary<NSString, NSObject>> onSuccess, Action<CometChatException> onError);

		// +(void)getUnreadMessageCountForAllUsersWithHideMessagesFromBlockedUsers:(BOOL)hideMessagesFromBlockedUsers onSuccess:(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("getUnreadMessageCountForAllUsersWithHideMessagesFromBlockedUsers:onSuccess:onError:")]
		void GetUnreadMessageCountForAllUsersWithHideMessagesFromBlockedUsers(bool hideMessagesFromBlockedUsers, Action<NSDictionary<NSString, NSObject>> onSuccess, Action<CometChatException> onError);

		// +(void)getUnreadMessageCountForAllGroupsWithHideMessagesFromBlockedUsers:(BOOL)hideMessagesFromBlockedUsers onSuccess:(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("getUnreadMessageCountForAllGroupsWithHideMessagesFromBlockedUsers:onSuccess:onError:")]
		void GetUnreadMessageCountForAllGroupsWithHideMessagesFromBlockedUsers(bool hideMessagesFromBlockedUsers, Action<NSDictionary<NSString, NSObject>> onSuccess, Action<CometChatException> onError);

		// +(void)editWithMessage:(BaseMessage * _Nonnull)message onSuccess:(void (^ _Nonnull)(BaseMessage * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nonnull))onError;
		[Static]
		[Export("editWithMessage:onSuccess:onError:")]
		void EditWithMessage(BaseMessage message, Action<BaseMessage> onSuccess, Action<CometChatException> onError);

		// +(void)deleteWithMessageId:(NSInteger)messageId onSuccess:(void (^ _Nonnull)(BaseMessage * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nonnull))onError;
		[Static]
		[Export("deleteWithMessageId:onSuccess:onError:")]
		void DeleteWithMessageId(nint messageId, Action<BaseMessage> onSuccess, Action<CometChatException> onError);

		// +(void)addMembersToGroupWithGuid:(NSString * _Nonnull)guid groupMembers:(NSArray<GroupMember *> * _Nonnull)groupMembers bannedUIDs:(NSArray<NSString *> * _Nullable)bannedUIDs onSuccess:(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("addMembersToGroupWithGuid:groupMembers:bannedUIDs:onSuccess:onError:")]
		void AddMembersToGroupWithGuid(string guid, GroupMember[] groupMembers, [NullAllowed] string[] bannedUIDs, Action<NSDictionary<NSString, NSObject>> onSuccess, Action<CometChatException> onError);

		// +(void)registerTokenForPushNotificationWithToken:(NSString * _Nonnull)token onSuccess:(void (^ _Nonnull)(NSString * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("registerTokenForPushNotificationWithToken:onSuccess:onError:")]
		void RegisterTokenForPushNotificationWithToken(string token, Action<NSString> onSuccess, Action<CometChatException> onError);

		// +(void)registerTokenForPushNotificationWithToken:(NSString * _Nonnull)token settings:(NSDictionary<NSString *,id> * _Nonnull)settings onSuccess:(void (^ _Nonnull)(NSString * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		[Static]
		[Export("registerTokenForPushNotificationWithToken:settings:onSuccess:onError:")]
		void RegisterTokenForPushNotificationWithToken(string token, NSDictionary<NSString, NSObject> settings, Action<NSString> onSuccess, Action<CometChatException> onError);
	}

	// @protocol CometChatCallDelegate
	[Protocol, Model]
	interface CometChatCallDelegate
	{
		// @required -(void)onIncomingCallReceivedWithIncomingCall:(Call * _Nullable)incomingCall error:(CometChatException * _Nullable)error;
		[Abstract]
		[Export("onIncomingCallReceivedWithIncomingCall:error:")]
		void OnIncomingCallReceivedWithIncomingCall([NullAllowed] Call incomingCall, [NullAllowed] CometChatException error);

		// @required -(void)onOutgoingCallAcceptedWithAcceptedCall:(Call * _Nullable)acceptedCall error:(CometChatException * _Nullable)error;
		[Abstract]
		[Export("onOutgoingCallAcceptedWithAcceptedCall:error:")]
		void OnOutgoingCallAcceptedWithAcceptedCall([NullAllowed] Call acceptedCall, [NullAllowed] CometChatException error);

		// @required -(void)onOutgoingCallRejectedWithRejectedCall:(Call * _Nullable)rejectedCall error:(CometChatException * _Nullable)error;
		[Abstract]
		[Export("onOutgoingCallRejectedWithRejectedCall:error:")]
		void OnOutgoingCallRejectedWithRejectedCall([NullAllowed] Call rejectedCall, [NullAllowed] CometChatException error);

		// @required -(void)onIncomingCallCancelledWithCanceledCall:(Call * _Nullable)canceledCall error:(CometChatException * _Nullable)error;
		[Abstract]
		[Export("onIncomingCallCancelledWithCanceledCall:error:")]
		void OnIncomingCallCancelledWithCanceledCall([NullAllowed] Call canceledCall, [NullAllowed] CometChatException error);
	}

	// @protocol CometChatConnectionDelegate
	[Protocol, Model]
	interface CometChatConnectionDelegate
	{
		// @optional -(void)connecting;
		[Export("connecting")]
		void Connecting();

		// @optional -(void)connected;
		[Export("connected")]
		void Connected();

		// @optional -(void)disconnected;
		[Export("disconnected")]
		void Disconnected();
	}

	// @protocol CustomError
	[Protocol, Model]
	interface CustomError
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull errorDescription;
		[Abstract]
		[Export("errorDescription")]
		string ErrorDescription { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull errorCode;
		[Abstract]
		[Export("errorCode")]
		string ErrorCode { get; }
	}

	// @interface CometChatException : NSObject <CustomError>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface CometChatException : CustomError
	{
		// @property (copy, nonatomic) NSString * _Nonnull errorDescription;
		[Export("errorDescription")]
		string ErrorDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull errorCode;
		[Export("errorCode")]
		string ErrorCode { get; set; }
	}

	// @protocol CometChatExtension
	[Protocol, Model]
	interface CometChatExtension
	{
		// @required -(NSString * _Nonnull)getExtensionID __attribute__((warn_unused_result));
		[Abstract]
		[Export("getExtensionID")]
		string ExtensionID { get; }

		// @optional -(void)onInitWithAppID:(NSString * _Nonnull)appID user:(User * _Nullable)user;
		[Export("onInitWithAppID:user:")]
		void OnInitWithAppID(string appID, [NullAllowed] User user);

		// @optional -(void)onLoginWithUser:(User * _Nonnull)user;
		[Export("onLoginWithUser:")]
		void OnLoginWithUser(User user);

		// @optional -(BaseMessage * _Nonnull)beforeMessageSent:(BaseMessage * _Nonnull)message __attribute__((warn_unused_result));
		[Export("beforeMessageSent:")]
		BaseMessage BeforeMessageSent(BaseMessage message);

		// @optional -(BaseMessage * _Nonnull)afterMessageSent:(BaseMessage * _Nonnull)message __attribute__((warn_unused_result));
		[Export("afterMessageSent:")]
		BaseMessage AfterMessageSent(BaseMessage message);

		// @optional -(BaseMessage * _Nonnull)onMessageReceived:(BaseMessage * _Nonnull)message __attribute__((warn_unused_result));
		[Export("onMessageReceived:")]
		BaseMessage OnMessageReceived(BaseMessage message);

		// @optional -(NSArray<BaseMessage *> * _Nonnull)onMessageListFetched:(NSArray<BaseMessage *> * _Nonnull)messages __attribute__((warn_unused_result));
		[Export("onMessageListFetched:")]
		BaseMessage[] OnMessageListFetched(BaseMessage[] messages);

		// @optional -(void)onLogout;
		[Export("onLogout")]
		void OnLogout();
	}

	// @protocol CometChatGroupDelegate
	[Protocol, Model]
	interface CometChatGroupDelegate
	{
		// @required -(void)onGroupMemberJoinedWithAction:(ActionMessage * _Nonnull)action joinedUser:(User * _Nonnull)joinedUser joinedGroup:(Group * _Nonnull)joinedGroup;
		[Abstract]
		[Export("onGroupMemberJoinedWithAction:joinedUser:joinedGroup:")]
		void OnGroupMemberJoinedWithAction(ActionMessage action, User joinedUser, Group joinedGroup);

		// @required -(void)onGroupMemberLeftWithAction:(ActionMessage * _Nonnull)action leftUser:(User * _Nonnull)leftUser leftGroup:(Group * _Nonnull)leftGroup;
		[Abstract]
		[Export("onGroupMemberLeftWithAction:leftUser:leftGroup:")]
		void OnGroupMemberLeftWithAction(ActionMessage action, User leftUser, Group leftGroup);

		// @required -(void)onGroupMemberKickedWithAction:(ActionMessage * _Nonnull)action kickedUser:(User * _Nonnull)kickedUser kickedBy:(User * _Nonnull)kickedBy kickedFrom:(Group * _Nonnull)kickedFrom;
		[Abstract]
		[Export("onGroupMemberKickedWithAction:kickedUser:kickedBy:kickedFrom:")]
		void OnGroupMemberKickedWithAction(ActionMessage action, User kickedUser, User kickedBy, Group kickedFrom);

		// @required -(void)onGroupMemberBannedWithAction:(ActionMessage * _Nonnull)action bannedUser:(User * _Nonnull)bannedUser bannedBy:(User * _Nonnull)bannedBy bannedFrom:(Group * _Nonnull)bannedFrom;
		[Abstract]
		[Export("onGroupMemberBannedWithAction:bannedUser:bannedBy:bannedFrom:")]
		void OnGroupMemberBannedWithAction(ActionMessage action, User bannedUser, User bannedBy, Group bannedFrom);

		// @required -(void)onGroupMemberUnbannedWithAction:(ActionMessage * _Nonnull)action unbannedUser:(User * _Nonnull)unbannedUser unbannedBy:(User * _Nonnull)unbannedBy unbannedFrom:(Group * _Nonnull)unbannedFrom;
		[Abstract]
		[Export("onGroupMemberUnbannedWithAction:unbannedUser:unbannedBy:unbannedFrom:")]
		void OnGroupMemberUnbannedWithAction(ActionMessage action, User unbannedUser, User unbannedBy, Group unbannedFrom);

		// @required -(void)onGroupMemberScopeChangedWithAction:(ActionMessage * _Nonnull)action user:(User * _Nonnull)user scopeChangedTo:(NSString * _Nonnull)scopeChangedTo scopeChangedFrom:(NSString * _Nonnull)scopeChangedFrom group:(Group * _Nonnull)group __attribute__((availability(ios, unavailable)));
		[Unavailable(PlatformName.iOS)]
		[Abstract]
		[Export("onGroupMemberScopeChangedWithAction:user:scopeChangedTo:scopeChangedFrom:group:")]
		void OnGroupMemberScopeChangedWithAction(ActionMessage action, User user, string scopeChangedTo, string scopeChangedFrom, Group group);

		// @required -(void)onGroupMemberScopeChangedWithAction:(ActionMessage * _Nonnull)action scopeChangeduser:(User * _Nonnull)scopeChangeduser scopeChangedBy:(User * _Nonnull)scopeChangedBy scopeChangedTo:(NSString * _Nonnull)scopeChangedTo scopeChangedFrom:(NSString * _Nonnull)scopeChangedFrom group:(Group * _Nonnull)group;
		[Abstract]
		[Export("onGroupMemberScopeChangedWithAction:scopeChangeduser:scopeChangedBy:scopeChangedTo:scopeChangedFrom:group:")]
		void OnGroupMemberScopeChangedWithAction(ActionMessage action, User scopeChangeduser, User scopeChangedBy, string scopeChangedTo, string scopeChangedFrom, Group group);

		// @required -(void)onAddedToGroupWithAction:(ActionMessage * _Nonnull)action addedBy:(User * _Nonnull)addedBy addedTo:(Group * _Nonnull)addedTo __attribute__((availability(ios, unavailable)));
		[Unavailable(PlatformName.iOS)]
		[Abstract]
		[Export("onAddedToGroupWithAction:addedBy:addedTo:")]
		void OnAddedToGroupWithAction(ActionMessage action, User addedBy, Group addedTo);

		// @required -(void)onMemberAddedToGroupWithAction:(ActionMessage * _Nonnull)action addedBy:(User * _Nonnull)addedBy addedUser:(User * _Nonnull)addedUser addedTo:(Group * _Nonnull)addedTo;
		[Abstract]
		[Export("onMemberAddedToGroupWithAction:addedBy:addedUser:addedTo:")]
		void OnMemberAddedToGroupWithAction(ActionMessage action, User addedBy, User addedUser, Group addedTo);
	}

	// @protocol CometChatLoginDelegate
	[Protocol, Model]
	interface CometChatLoginDelegate
	{
		// @required -(void)onLoginSuccessWithUser:(User * _Nonnull)user;
		[Abstract]
		[Export("onLoginSuccessWithUser:")]
		void OnLoginSuccessWithUser(User user);

		// @required -(void)onLoginFailedWithError:(CometChatException * _Nullable)error;
		[Abstract]
		[Export("onLoginFailedWithError:")]
		void OnLoginFailedWithError([NullAllowed] CometChatException error);

		// @required -(void)onLogoutSuccess;
		[Abstract]
		[Export("onLogoutSuccess")]
		void OnLogoutSuccess();

		// @required -(void)onLogoutFailedWithError:(CometChatException * _Nullable)error;
		[Abstract]
		[Export("onLogoutFailedWithError:")]
		void OnLogoutFailedWithError([NullAllowed] CometChatException error);
	}

	// @protocol CometChatMessageDelegate
	[Protocol, Model]
	interface CometChatMessageDelegate
	{
		// @optional -(void)onTextMessageReceivedWithTextMessage:(TextMessage * _Nullable)textMessage error:(CometChatException * _Nullable)error __attribute__((availability(ios, unavailable)));
		[Unavailable(PlatformName.iOS)]
		[Export("onTextMessageReceivedWithTextMessage:error:")]
		void OnTextMessageReceivedWithTextMessage([NullAllowed] TextMessage textMessage, [NullAllowed] CometChatException error);

		// @optional -(void)onMediaMessageReceivedWithMediaMessage:(MediaMessage * _Nullable)mediaMessage error:(CometChatException * _Nullable)error __attribute__((availability(ios, unavailable)));
		[Unavailable(PlatformName.iOS)]
		[Export("onMediaMessageReceivedWithMediaMessage:error:")]
		void OnMediaMessageReceivedWithMediaMessage([NullAllowed] MediaMessage mediaMessage, [NullAllowed] CometChatException error);

		// @optional -(void)onCustomMessageReceivedWithCustomMessage:(CustomMessage * _Nullable)customMessage error:(CometChatException * _Nullable)error __attribute__((availability(ios, unavailable)));
		[Unavailable(PlatformName.iOS)]
		[Export("onCustomMessageReceivedWithCustomMessage:error:")]
		void OnCustomMessageReceivedWithCustomMessage([NullAllowed] CustomMessage customMessage, [NullAllowed] CometChatException error);

		// @optional -(void)onTextMessageReceivedWithTextMessage:(TextMessage * _Nonnull)textMessage;
		[Export("onTextMessageReceivedWithTextMessage:")]
		void OnTextMessageReceivedWithTextMessage(TextMessage textMessage);

		// @optional -(void)onMediaMessageReceivedWithMediaMessage:(MediaMessage * _Nonnull)mediaMessage;
		[Export("onMediaMessageReceivedWithMediaMessage:")]
		void OnMediaMessageReceivedWithMediaMessage(MediaMessage mediaMessage);

		// @optional -(void)onCustomMessageReceivedWithCustomMessage:(CustomMessage * _Nonnull)customMessage;
		[Export("onCustomMessageReceivedWithCustomMessage:")]
		void OnCustomMessageReceivedWithCustomMessage(CustomMessage customMessage);

		// @optional -(void)onTypingStarted:(TypingIndicator * _Nonnull)typingDetails;
		[Export("onTypingStarted:")]
		void OnTypingStarted(TypingIndicator typingDetails);

		// @optional -(void)onTypingEnded:(TypingIndicator * _Nonnull)typingDetails;
		[Export("onTypingEnded:")]
		void OnTypingEnded(TypingIndicator typingDetails);

		// @optional -(void)onMessageDeliveredWithReceipt:(MessageReceipt * _Nonnull)receipt __attribute__((availability(ios, unavailable)));
		[Unavailable(PlatformName.iOS)]
		[Export("onMessageDeliveredWithReceipt:")]
		void OnMessageDeliveredWithReceipt(MessageReceipt receipt);

		// @optional -(void)onMessageReadWithReceipt:(MessageReceipt * _Nonnull)receipt __attribute__((availability(ios, unavailable)));
		[Unavailable(PlatformName.iOS)]
		[Export("onMessageReadWithReceipt:")]
		void OnMessageReadWithReceipt(MessageReceipt receipt);

		// @optional -(void)onMessageEditedWithMessage:(BaseMessage * _Nonnull)message;
		[Export("onMessageEditedWithMessage:")]
		void OnMessageEditedWithMessage(BaseMessage message);

		// @optional -(void)onMessageDeletedWithMessage:(BaseMessage * _Nonnull)message;
		[Export("onMessageDeletedWithMessage:")]
		void OnMessageDeletedWithMessage(BaseMessage message);

		// @optional -(void)onMessagesReadWithReceipt:(MessageReceipt * _Nonnull)receipt;
		[Export("onMessagesReadWithReceipt:")]
		void OnMessagesReadWithReceipt(MessageReceipt receipt);

		// @optional -(void)onMessagesDeliveredWithReceipt:(MessageReceipt * _Nonnull)receipt;
		[Export("onMessagesDeliveredWithReceipt:")]
		void OnMessagesDeliveredWithReceipt(MessageReceipt receipt);

		// @optional -(void)onMessageReadByAllWithMessageId:(NSString * _Nonnull)messageId receiverId:(NSString * _Nonnull)receiverId receiverType:(enum ReceiverType)receiverType;
		[Export("onMessageReadByAllWithMessageId:receiverId:receiverType:")]
		void OnMessageReadByAllWithMessageId(string messageId, string receiverId, ReceiverType receiverType);

		// @optional -(void)onMessageDeliveredToAllWithMessageId:(NSString * _Nonnull)messageId receiverId:(NSString * _Nonnull)receiverId receiverType:(enum ReceiverType)receiverType;
		[Export("onMessageDeliveredToAllWithMessageId:receiverId:receiverType:")]
		void OnMessageDeliveredToAllWithMessageId(string messageId, string receiverId, ReceiverType receiverType);
	}

	// @protocol CometChatUserDelegate
	[Protocol, Model]
	interface CometChatUserDelegate
	{
		// @required -(void)onUserOnlineWithUser:(User * _Nonnull)user;
		[Abstract]
		[Export("onUserOnlineWithUser:")]
		void OnUserOnlineWithUser(User user);

		// @required -(void)onUserOfflineWithUser:(User * _Nonnull)user;
		[Abstract]
		[Export("onUserOfflineWithUser:")]
		void OnUserOfflineWithUser(User user);
	}

	// @interface Conversation : AppEntity
	[BaseType(typeof(AppEntity))]
	[DisableDefaultCtor]
	interface Conversation
	{
		// @property (copy, nonatomic) NSString * _Nullable conversationId;
		[NullAllowed, Export("conversationId")]
		string ConversationId { get; set; }

		// @property (nonatomic) enum ConversationType conversationType;
		[Export("conversationType", ArgumentSemantic.Assign)]
		ConversationType ConversationType { get; set; }

		// @property (nonatomic, strong) BaseMessage * _Nullable lastMessage;
		[NullAllowed, Export("lastMessage", ArgumentSemantic.Strong)]
		BaseMessage LastMessage { get; set; }

		// @property (nonatomic, strong) AppEntity * _Nullable conversationWith;
		[NullAllowed, Export("conversationWith", ArgumentSemantic.Strong)]
		AppEntity ConversationWith { get; set; }

		// @property (nonatomic) NSInteger unreadMessageCount;
		[Export("unreadMessageCount")]
		nint UnreadMessageCount { get; set; }

		// @property (nonatomic) double updatedAt;
		[Export("updatedAt")]
		double UpdatedAt { get; set; }

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		string StringValue { get; }
	}

	// @interface ConversationRequest : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ConversationRequest
	{
		// -(instancetype _Nonnull)initWithBuilder:(ConversationRequestBuilder * _Nonnull)builder __attribute__((objc_designated_initializer));
		[Export("initWithBuilder:")]
		[DesignatedInitializer]
		IntPtr Constructor(ConversationRequestBuilder builder);

		// -(void)fetchNextOnSuccess:(void (^ _Nonnull)(NSArray<Conversation *> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		//[Export("fetchNextOnSuccess:onError:")]
		//void FetchNextOnSuccess(Action<NSArray<Conversation>> onSuccess, Action<CometChatException> onError);
	}

	// @interface ConversationRequestBuilder : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ConversationRequestBuilder
	{
		// -(instancetype _Nonnull)initWithLimit:(NSInteger)limit __attribute__((objc_designated_initializer));
		[Export("initWithLimit:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint limit);

		// -(ConversationRequestBuilder * _Nonnull)setWithLimit:(NSInteger)limit __attribute__((warn_unused_result));
		[Export("setWithLimit:")]
		ConversationRequestBuilder SetWithLimit(nint limit);

		// -(ConversationRequestBuilder * _Nonnull)setConversationTypeWithConversationType:(enum ConversationType)conversationType __attribute__((warn_unused_result));
		[Export("setConversationTypeWithConversationType:")]
		ConversationRequestBuilder SetConversationTypeWithConversationType(ConversationType conversationType);

		// -(ConversationRequest * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		
		ConversationRequest Build { get; }
	}

	// @interface User : AppEntity
	[BaseType(typeof(AppEntity))]
	[DisableDefaultCtor]
	interface User
	{
		// @property (copy, nonatomic) NSString * _Nullable uid;
		[NullAllowed, Export("uid")]
		string Uid { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable avatar;
		[NullAllowed, Export("avatar")]
		string Avatar { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable link;
		[NullAllowed, Export("link")]
		string Link { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable role;
		[NullAllowed, Export("role")]
		string Role { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Metadata { get; set; }

		// @property (nonatomic) enum UserStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		UserStatus Status { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable statusMessage;
		[NullAllowed, Export("statusMessage")]
		string StatusMessage { get; set; }

		// @property (nonatomic) double lastActiveAt;
		[Export("lastActiveAt")]
		double LastActiveAt { get; set; }

		// @property (nonatomic) BOOL hasBlockedMe;
		[Export("hasBlockedMe")]
		bool HasBlockedMe { get; set; }

		// @property (nonatomic) BOOL blockedByMe;
		[Export("blockedByMe")]
		bool BlockedByMe { get; set; }

		// -(instancetype _Nonnull)initWithUid:(NSString * _Nonnull)uid name:(NSString * _Nonnull)name __attribute__((objc_designated_initializer));
		[Export("initWithUid:name:")]
		[DesignatedInitializer]
		IntPtr Constructor(string uid, string name);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		
		string StringValue { get; }
	}

	// @interface CurrentUser : User
	[BaseType(typeof(User))]
	interface CurrentUser
	{
		// -(instancetype _Nonnull)initWithUid:(NSString * _Nonnull)uid name:(NSString * _Nonnull)name __attribute__((objc_designated_initializer));
		[Export("initWithUid:name:")]
		[DesignatedInitializer]
		IntPtr Constructor(string uid, string name);
	}

	// @interface CustomMessage : BaseMessage
	[BaseType(typeof(BaseMessage))]
	interface CustomMessage
	{
		// @property (copy, nonatomic) NSString * _Nullable type;
		[NullAllowed, Export("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nullable customData;
		[NullAllowed, Export("customData", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> CustomData { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable subType;
		[NullAllowed, Export("subType")]
		string SubType { get; set; }

		// -(instancetype _Nonnull)initWithReceiverUid:(NSString * _Nonnull)receiverUid receiverType:(enum ReceiverType)receiverType customData:(NSDictionary<NSString *,id> * _Nonnull)customData __attribute__((objc_designated_initializer));
		[Export("initWithReceiverUid:receiverType:customData:")]
		[DesignatedInitializer]
		IntPtr Constructor(string receiverUid, ReceiverType receiverType, NSDictionary<NSString, NSObject> customData);

		// -(instancetype _Nonnull)initWithReceiverUid:(NSString * _Nonnull)receiverUid receiverType:(enum ReceiverType)receiverType customData:(NSDictionary<NSString *,id> * _Nonnull)customData type:(NSString * _Nullable)type __attribute__((objc_designated_initializer));
		[Export("initWithReceiverUid:receiverType:customData:type:")]
		[DesignatedInitializer]
		IntPtr Constructor(string receiverUid, ReceiverType receiverType, NSDictionary<NSString, NSObject> customData, [NullAllowed] string type);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		
		string StringValue { get; }
	}

	// @interface Group : AppEntity
	[BaseType(typeof(AppEntity))]
	[DisableDefaultCtor]
	interface Group
	{
		// @property (copy, nonatomic) NSString * _Nonnull guid;
		[Export("guid")]
		string Guid { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable icon;
		[NullAllowed, Export("icon")]
		string Icon { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable groupDescription;
		[NullAllowed, Export("groupDescription")]
		string GroupDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable owner;
		[NullAllowed, Export("owner")]
		string Owner { get; set; }

		// @property (nonatomic) enum groupType groupType;
		[Export("groupType", ArgumentSemantic.Assign)]
		groupType GroupType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable password;
		[NullAllowed, Export("password")]
		string Password { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Metadata { get; set; }

		// @property (nonatomic) NSInteger createdAt;
		[Export("createdAt")]
		nint CreatedAt { get; set; }

		// @property (nonatomic) NSInteger updatedAt;
		[Export("updatedAt")]
		nint UpdatedAt { get; set; }

		// @property (nonatomic) NSInteger joinedAt;
		[Export("joinedAt")]
		nint JoinedAt { get; set; }

		// @property (nonatomic) enum GroupMemberScopeType scope;
		[Export("scope", ArgumentSemantic.Assign)]
		GroupMemberScopeType Scope { get; set; }

		// @property (nonatomic) BOOL hasJoined;
		[Export("hasJoined")]
		bool HasJoined { get; set; }

		// @property (nonatomic) NSInteger membersCount;
		[Export("membersCount")]
		nint MembersCount { get; set; }

		// -(instancetype _Nonnull)initWithGuid:(NSString * _Nonnull)guid name:(NSString * _Nonnull)name groupType:(enum groupType)groupType password:(NSString * _Nullable)password __attribute__((objc_designated_initializer));
		[Export("initWithGuid:name:groupType:password:")]
		[DesignatedInitializer]
		IntPtr Constructor(string guid, string name, groupType groupType, [NullAllowed] string password);

		// -(instancetype _Nonnull)initWithGuid:(NSString * _Nonnull)guid name:(NSString * _Nonnull)name groupType:(enum groupType)groupType password:(NSString * _Nullable)password icon:(NSString * _Nonnull)icon description:(NSString * _Nonnull)description __attribute__((objc_designated_initializer));
		[Export("initWithGuid:name:groupType:password:icon:description:")]
		[DesignatedInitializer]
		IntPtr Constructor(string guid, string name, groupType groupType, [NullAllowed] string password, string icon, string description);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		
		string StringValue { get; }
	}

	// @interface GroupMember : User
	[BaseType(typeof(User))]
	interface GroupMember
	{
		// @property (nonatomic) enum GroupMemberScopeType scope;
		[Export("scope", ArgumentSemantic.Assign)]
		GroupMemberScopeType Scope { get; set; }

		// @property (nonatomic) NSInteger joinedAt;
		[Export("joinedAt")]
		nint JoinedAt { get; set; }

		// -(instancetype _Nonnull)initWithUID:(NSString * _Nonnull)UID groupMemberScope:(enum GroupMemberScopeType)groupMemberScope __attribute__((objc_designated_initializer));
		[Export("initWithUID:groupMemberScope:")]
		[DesignatedInitializer]
		IntPtr Constructor(string UID, GroupMemberScopeType groupMemberScope);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		
		string StringValue { get; }
	}

	// @interface GroupMembersRequest : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface GroupMembersRequest
	{
		// -(instancetype _Nonnull)initWithBuilder:(GroupMembersRequestBuilder * _Nonnull)builder __attribute__((objc_designated_initializer));
		[Export("initWithBuilder:")]
		[DesignatedInitializer]
		IntPtr Constructor(GroupMembersRequestBuilder builder);

		// -(void)fetchNextOnSuccess:(void (^ _Nonnull)(NSArray<GroupMember *> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		//[Export("fetchNextOnSuccess:onError:")]
		//void FetchNextOnSuccess(Action<NSArray<GroupMember>> onSuccess, Action<CometChatException> onError);
	}

	// @interface GroupMembersRequestBuilder : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface GroupMembersRequestBuilder
	{
		// -(instancetype _Nonnull)initWithGuid:(NSString * _Nonnull)guid __attribute__((objc_designated_initializer));
		[Export("initWithGuid:")]
		[DesignatedInitializer]
		IntPtr Constructor(string guid);

		// -(GroupMembersRequestBuilder * _Nonnull)setWithSearchKeyword:(NSString * _Nonnull)searchKeyword __attribute__((warn_unused_result));
		[Export("setWithSearchKeyword:")]
		GroupMembersRequestBuilder SetWithSearchKeyword(string searchKeyword);

		// -(GroupMembersRequestBuilder * _Nonnull)setWithLimit:(NSInteger)limit __attribute__((warn_unused_result));
		[Export("setWithLimit:")]
		GroupMembersRequestBuilder SetWithLimit(nint limit);

		// -(GroupMembersRequest * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		
		GroupMembersRequest Build { get; }
	}

	// @interface GroupsRequest : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface GroupsRequest
	{
		// -(instancetype _Nonnull)initWithBuilder:(GroupsRequestBuilder * _Nonnull)builder __attribute__((objc_designated_initializer));
		[Export("initWithBuilder:")]
		[DesignatedInitializer]
		IntPtr Constructor(GroupsRequestBuilder builder);

		// -(void)fetchNextOnSuccess:(void (^ _Nonnull)(NSArray<Group *> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		//[Export("fetchNextOnSuccess:onError:")]
		//void FetchNextOnSuccess(Action<NSArray<Group>> onSuccess, Action<CometChatException> onError);
	}

	// @interface GroupsRequestBuilder : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface GroupsRequestBuilder
	{
		// -(instancetype _Nonnull)initWithLimit:(NSInteger)limit __attribute__((objc_designated_initializer));
		[Export("initWithLimit:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint limit);

		// -(GroupsRequestBuilder * _Nonnull)setWithLimit:(NSInteger)limit __attribute__((warn_unused_result));
		[Export("setWithLimit:")]
		GroupsRequestBuilder SetWithLimit(nint limit);

		// -(GroupsRequestBuilder * _Nonnull)setWithSearchKeyword:(NSString * _Nonnull)searchKeyword __attribute__((warn_unused_result));
		[Export("setWithSearchKeyword:")]
		GroupsRequestBuilder SetWithSearchKeyword(string searchKeyword);

		// -(GroupsRequestBuilder * _Nonnull)setWithJoinedOnly:(BOOL)joinedOnly __attribute__((warn_unused_result));
		[Export("setWithJoinedOnly:")]
		GroupsRequestBuilder SetWithJoinedOnly(bool joinedOnly);

		// -(GroupsRequest * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		
		GroupsRequest Build { get; }
	}

	// @interface MediaMessage : BaseMessage
	[BaseType(typeof(BaseMessage))]
	interface MediaMessage
	{
		// @property (copy, nonatomic) NSString * _Nullable caption;
		[NullAllowed, Export("caption")]
		string Caption { get; set; }

		// @property (nonatomic, strong) Attachment * _Nullable attachment;
		[NullAllowed, Export("attachment", ArgumentSemantic.Strong)]
		Attachment Attachment { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull filePath;
		[Export("filePath")]
		string FilePath { get; set; }

		// -(instancetype _Nonnull)initWithReceiverUid:(NSString * _Nonnull)receiverUid fileurl:(NSString * _Nonnull)fileurl messageType:(enum MessageType)messageType receiverType:(enum ReceiverType)receiverType __attribute__((objc_designated_initializer));
		[Export("initWithReceiverUid:fileurl:messageType:receiverType:")]
		[DesignatedInitializer]
		IntPtr Constructor(string receiverUid, string fileurl, MessageType messageType, ReceiverType receiverType);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		
		string StringValue { get; }
	}

	// @interface MessageReceipt : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface MessageReceipt
	{
		// @property (copy, nonatomic) NSString * _Nonnull receiverId;
		[Export("receiverId")]
		string ReceiverId { get; set; }

		// @property (nonatomic) enum ReceiverType receiverType;
		[Export("receiverType", ArgumentSemantic.Assign)]
		ReceiverType ReceiverType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull messageId;
		[Export("messageId")]
		string MessageId { get; set; }

		// @property (nonatomic, strong) User * _Nullable sender;
		[NullAllowed, Export("sender", ArgumentSemantic.Strong)]
		User Sender { get; set; }

		// @property (nonatomic) enum ReceiptType receiptType;
		[Export("receiptType", ArgumentSemantic.Assign)]
		ReceiptType ReceiptType { get; set; }

		// @property (nonatomic) NSInteger timeStamp;
		[Export("timeStamp")]
		nint TimeStamp { get; set; }

		// @property (nonatomic) double deliveredAt;
		[Export("deliveredAt")]
		double DeliveredAt { get; set; }

		// @property (nonatomic) double readAt;
		[Export("readAt")]
		double ReadAt { get; set; }

		// -(instancetype _Nonnull)initWithMessageId:(NSString * _Nonnull)messageId sender:(User * _Nonnull)sender receiverId:(NSString * _Nonnull)receiverId receiverType:(enum ReceiverType)receiverType receiptType:(enum ReceiptType)receiptType timeStamp:(NSInteger)timeStamp __attribute__((objc_designated_initializer));
		[Export("initWithMessageId:sender:receiverId:receiverType:receiptType:timeStamp:")]
		[DesignatedInitializer]
		IntPtr Constructor(string messageId, User sender, string receiverId, ReceiverType receiverType, ReceiptType receiptType, nint timeStamp);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		
		string StringValue { get; }
	}

	// @interface MessagesRequest : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface MessagesRequest
	{
		// -(instancetype _Nonnull)initWithBuilder:(MessageRequestBuilder * _Nonnull)builder __attribute__((objc_designated_initializer));
		[Export("initWithBuilder:")]
		[DesignatedInitializer]
		IntPtr Constructor(MessageRequestBuilder builder);

		// -(void)fetchPreviousOnSuccess:(void (^ _Nonnull)(NSArray<BaseMessage *> * _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		//[Export("fetchPreviousOnSuccess:onError:")]
		//void FetchPreviousOnSuccess(Action<NSArray<BaseMessage>> onSuccess, Action<CometChatException> onError);

		 //-(void) fetchNextOnSuccess:(void (^ _Nonnull)(NSArray<BaseMessage*>* _Nullable))onSuccess onError:(void (^ _Nonnull)(CometChatException* _Nullable))onError;
		//[Export("fetchNextOnSuccess:onError:")]
		//void FetchNextOnSuccess(Action<NSArray<BaseMessage>> onSuccess, Action<CometChatException> onError);
	}

	// @interface MessageRequestBuilder : NSObject
	[BaseType(typeof(NSObject))]
	interface MessageRequestBuilder
	{
		// -(MessageRequestBuilder * _Nonnull)setWithLimit:(NSInteger)limit __attribute__((warn_unused_result));
		[Export("setWithLimit:")]
		MessageRequestBuilder SetWithLimit(nint limit);

		// -(MessageRequestBuilder * _Nonnull)setWithGuid:(NSString * _Nonnull)guid __attribute__((warn_unused_result));
		[Export("setWithGuid:")]
		MessageRequestBuilder SetWithGuid(string guid);

		// -(MessageRequestBuilder * _Nonnull)setWithUid:(NSString * _Nonnull)uid __attribute__((warn_unused_result));
		[Export("setWithUid:")]
		MessageRequestBuilder SetWithUid(string uid);

		// -(MessageRequestBuilder * _Nonnull)setWithTimeStamp:(NSInteger)timeStamp __attribute__((warn_unused_result));
		[Export("setWithTimeStamp:")]
		MessageRequestBuilder SetWithTimeStamp(nint timeStamp);

		// -(MessageRequestBuilder * _Nonnull)setWithMessageID:(NSInteger)messageID __attribute__((warn_unused_result));
		[Export("setWithMessageID:")]
		MessageRequestBuilder SetWithMessageID(nint messageID);

		// -(MessageRequestBuilder * _Nonnull)setWithUnread:(BOOL)unread __attribute__((warn_unused_result));
		[Export("setWithUnread:")]
		MessageRequestBuilder SetWithUnread(bool unread);

		// -(MessageRequestBuilder * _Nonnull)hideMessagesFromBlockedUsers:(BOOL)hideMessagesFromBlockedUsers __attribute__((warn_unused_result));
		[Export("hideMessagesFromBlockedUsers:")]
		MessageRequestBuilder HideMessagesFromBlockedUsers(bool hideMessagesFromBlockedUsers);

		// -(MessageRequestBuilder * _Nonnull)setWithSearchKeyword:(NSString * _Nonnull)searchKeyword __attribute__((warn_unused_result));
		[Export("setWithSearchKeyword:")]
		MessageRequestBuilder SetWithSearchKeyword(string searchKeyword);

		// -(MessageRequestBuilder * _Nonnull)setUpdatedAfterTimeStamp:(NSInteger)timeStamp __attribute__((warn_unused_result));
		[Export("setUpdatedAfterTimeStamp:")]
		MessageRequestBuilder SetUpdatedAfterTimeStamp(nint timeStamp);

		// -(MessageRequestBuilder * _Nonnull)updatesOnlyWithOnlyUpdates:(BOOL)onlyUpdates __attribute__((warn_unused_result));
		[Export("updatesOnlyWithOnlyUpdates:")]
		MessageRequestBuilder UpdatesOnlyWithOnlyUpdates(bool onlyUpdates);

		// -(MessageRequestBuilder * _Nonnull)setCategoryWithCategory:(NSString * _Nonnull)category __attribute__((warn_unused_result));
		[Export("setCategoryWithCategory:")]
		MessageRequestBuilder SetCategoryWithCategory(string category);

		// -(MessageRequestBuilder * _Nonnull)setTypeWithType:(NSString * _Nonnull)type __attribute__((warn_unused_result));
		[Export("setTypeWithType:")]
		MessageRequestBuilder SetTypeWithType(string type);

		// -(MessageRequestBuilder * _Nonnull)setParentMessageIdWithParentMessageId:(NSInteger)parentMessageId __attribute__((warn_unused_result));
		[Export("setParentMessageIdWithParentMessageId:")]
		MessageRequestBuilder SetParentMessageIdWithParentMessageId(nint parentMessageId);

		// -(MessageRequestBuilder * _Nonnull)hideRepliesWithHide:(BOOL)hide __attribute__((warn_unused_result));
		[Export("hideRepliesWithHide:")]
		MessageRequestBuilder HideRepliesWithHide(bool hide);

		// -(MessagesRequest * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		
		MessagesRequest Build { get; }
	}

	// @interface TextMessage : BaseMessage
	[BaseType(typeof(BaseMessage))]
	interface TextMessage
	{
		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export("text")]
		string Text { get; set; }

		// -(instancetype _Nonnull)initWithReceiverUid:(NSString * _Nonnull)receiverUid text:(NSString * _Nonnull)text receiverType:(enum ReceiverType)receiverType __attribute__((objc_designated_initializer));
		[Export("initWithReceiverUid:text:receiverType:")]
		[DesignatedInitializer]
		IntPtr Constructor(string receiverUid, string text, ReceiverType receiverType);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		
		string StringValue { get; }
	}

	// @interface TypingIndicator : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface TypingIndicator
	{
		// @property (copy, nonatomic) NSString * _Nonnull receiverID;
		[Export("receiverID")]
		string ReceiverID { get; set; }

		// @property (nonatomic) enum ReceiverType receiverType;
		[Export("receiverType", ArgumentSemantic.Assign)]
		ReceiverType ReceiverType { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Metadata { get; set; }

		// @property (nonatomic, strong) User * _Nullable sender;
		[NullAllowed, Export("sender", ArgumentSemantic.Strong)]
		User Sender { get; set; }

		// -(instancetype _Nonnull)initWithReceiverID:(NSString * _Nonnull)receiverID receiverType:(enum ReceiverType)receiverType __attribute__((objc_designated_initializer));
		[Export("initWithReceiverID:receiverType:")]
		[DesignatedInitializer]
		IntPtr Constructor(string receiverID, ReceiverType receiverType);

		// -(NSString * _Nonnull)stringValue __attribute__((warn_unused_result));
		[Export("stringValue")]
		
		string StringValue { get; }
	}

	// @interface UsersRequest : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UsersRequest
	{
		// -(instancetype _Nonnull)initWithBuilder:(UsersRequestBuilder * _Nonnull)builder __attribute__((objc_designated_initializer));
		[Export("initWithBuilder:")]
		[DesignatedInitializer]
		IntPtr Constructor(UsersRequestBuilder builder);

		// -(void)fetchNextOnSuccess:(void (^ _Nonnull)(NSArray<User *> * _Nonnull))onSuccess onError:(void (^ _Nonnull)(CometChatException * _Nullable))onError;
		//[Export("fetchNextOnSuccess:onError:")]
		//void FetchNextOnSuccess(Action<NSArray<User>> onSuccess, Action<CometChatException> onError);
	}

	// @interface UsersRequestBuilder : NSObject
	[BaseType(typeof(NSObject))]
	interface UsersRequestBuilder
	{
		// -(instancetype _Nonnull)initWithLimit:(NSInteger)limit __attribute__((objc_designated_initializer));
		[Export("initWithLimit:")]
		[DesignatedInitializer]
		IntPtr Constructor(nint limit);

		// -(UsersRequestBuilder * _Nonnull)setWithLimit:(NSInteger)limit __attribute__((warn_unused_result));
		[Export("setWithLimit:")]
		UsersRequestBuilder SetWithLimit(nint limit);

		// -(UsersRequestBuilder * _Nonnull)setWithStatus:(enum UserStatus)status __attribute__((warn_unused_result));
		[Export("setWithStatus:")]
		UsersRequestBuilder SetWithStatus(UserStatus status);

		// -(UsersRequestBuilder * _Nonnull)setWithSearchKeyword:(NSString * _Nonnull)searchKeyword __attribute__((warn_unused_result));
		[Export("setWithSearchKeyword:")]
		UsersRequestBuilder SetWithSearchKeyword(string searchKeyword);

		// -(UsersRequestBuilder * _Nonnull)setWithRole:(NSString * _Nonnull)role __attribute__((warn_unused_result));
		[Export("setWithRole:")]
		UsersRequestBuilder SetWithRole(string role);

		// -(UsersRequestBuilder * _Nonnull)hideBlockedUsers:(BOOL)hide __attribute__((warn_unused_result));
		[Export("hideBlockedUsers:")]
		UsersRequestBuilder HideBlockedUsers(bool hide);

		// -(UsersRequestBuilder * _Nonnull)friendsOnly:(BOOL)friendsOnly __attribute__((warn_unused_result));
		[Export("friendsOnly:")]
		UsersRequestBuilder FriendsOnly(bool friendsOnly);

		// -(UsersRequest * _Nonnull)build __attribute__((warn_unused_result));
		[Export("build")]
		
		UsersRequest Build { get; }
	}
}
