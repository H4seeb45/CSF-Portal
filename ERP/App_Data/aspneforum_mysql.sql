/*NOTE: this script creates all the necessary tables, but it DOES NOT create any database*/

CREATE TABLE ForumAdministrators (
	UserID int NOT NULL PRIMARY KEY
);

CREATE TABLE ForumGroups (
	GroupID int auto_increment NOT NULL PRIMARY KEY,
	GroupName varchar (50) NOT NULL,
	OrderByNumber int NOT NULL DEFAULT 0
);

CREATE TABLE Forums (
	ForumID int auto_increment NOT NULL PRIMARY KEY,
	Title varchar (50)  NOT NULL ,
	Description varchar (255) NOT NULL ,
	Premoderated bool NOT NULL DEFAULT 0,
	GroupID int NOT NULL,
	MembersOnly bool NOT NULL DEFAULT 0,
	OrderByNumber int NOT NULL DEFAULT 0,
	RestrictTopicCreation bool NOT NULL DEFAULT 0,
	IconFile varchar(50) NULL
);

CREATE TABLE ForumSubforums(
	ParentForumID int NOT NULL,
	SubForumID int NOT NULL
);

CREATE TABLE ForumMessages (
	MessageID int auto_increment NOT NULL PRIMARY KEY,
	TopicID int NOT NULL ,
	UserID int NOT NULL ,
	Body text NOT NULL ,
	CreationDate datetime NOT NULL ,
	Visible bool NOT NULL DEFAULT 1,
	IPAddress varchar(50),
	Rating int NOT NULL DEFAULT 0,
	AcceptedAnswer bool NOT NULL DEFAULT 0
);

CREATE TABLE ForumModerators (
	UserID int NOT NULL ,
	ForumID int NOT NULL 
);

CREATE TABLE ForumSubscriptions (
	UserID int NOT NULL ,
	TopicID int NOT NULL 
);

CREATE TABLE ForumComplaints (
	UserID int NOT NULL ,
	MessageID int NOT NULL,
	ComplainText text NOT NULL
);

CREATE TABLE ForumGroupPermissions (
	ForumID int NOT NULL ,
	GroupID int NOT NULL ,
	AllowReading bool NOT NULL ,
	AllowPosting bool NOT NULL
);

CREATE TABLE ForumUserGroups (
	GroupID int auto_increment NOT NULL PRIMARY KEY,
	Title varchar (50) NOT NULL
);

CREATE TABLE ForumUsersInGroup (
	GroupID int NOT NULL ,
	UserID int NOT NULL
);

CREATE TABLE ForumNewTopicSubscriptions (
	UserID int NOT NULL ,
	ForumID int NOT NULL 
);

CREATE TABLE ForumNewForumMsgSubscriptions (
	UserID int NOT NULL ,
	ForumID int NOT NULL 
);

CREATE TABLE ForumTopics (
	TopicID int auto_increment NOT NULL PRIMARY KEY,
	ForumID int NOT NULL ,
	UserID int NOT NULL ,
	Subject varchar (255) NOT NULL ,
	Visible bool NOT NULL ,
	LastMessageID int NOT NULL DEFAULT 0,
	IsSticky int NOT NULL DEFAULT 0,
	IsClosed bit NOT NULL DEFAULT 0,
	ViewsCount int NOT NULL DEFAULT 0,
	RepliesCount int NOT NULL DEFAULT 0
);

CREATE TABLE ForumUsers (
	UserID int auto_increment NOT NULL PRIMARY KEY,
	UserName varchar (50) NOT NULL ,
	FirstName varchar(100) NULL,
	LastName varchar(100) NULL,
	Email varchar (50) NOT NULL ,
	Password varchar (50) NOT NULL ,
	Homepage varchar (255) NULL ,
	Interests varchar (255) NULL ,
	PostsCount int NOT NULL DEFAULT 0,
	RegistrationDate timestamp NOT NULL DEFAULT current_timestamp,
	Disabled bool NOT NULL DEFAULT 0,
	ActivationCode varchar(50) NOT NULL DEFAULT '',
	AvatarFileName varchar(255) NULL,
	Signature varchar(1000) NULL,
	LastLogonDate datetime NULL,
	ReputationCache int NOT NULL DEFAULT 0,
	OpenIdUserName varchar(255) NULL,
	HidePresence bit NOT NULL DEFAULT 0,
	UseGravatar bit NOT NULL DEFAULT 1,
	TwitterUserName varchar(255) NULL,
	FacebookID varchar(255) NULL
);

CREATE TABLE ForumPersonalMessages (
	MessageID int auto_increment NOT NULL PRIMARY KEY,
	FromUserID int NOT NULL ,
	ToUserID int NOT NULL ,
	Body text NOT NULL ,
	CreationDate datetime NOT NULL ,
	New bool NOT NULL DEFAULT 1 ,
	HiddenBySender bool NOT NULL DEFAULT 0 ,
	HiddenByRecipient bool NOT NULL DEFAULT 0
);

CREATE TABLE ForumUploadedFiles (
	FileID int auto_increment NOT NULL PRIMARY KEY,
	FileName varchar (255) NOT NULL ,
	MessageID int NOT NULL ,
	UserID int NOT NULL 
);

CREATE TABLE ForumUploadedPersonalFiles (
	FileID int auto_increment NOT NULL PRIMARY KEY,
	FileName varchar (255) NOT NULL ,
	MessageID int NOT NULL ,
	UserID int NOT NULL 
);

CREATE TABLE ForumPolls (
	PollID int auto_increment NOT NULL PRIMARY KEY,
	TopicID int NOT NULL,
	Question varchar(255) NOT NULL
);

CREATE TABLE ForumPollOptions (
	OptionID int auto_increment NOT NULL PRIMARY KEY,
	PollID int NOT NULL,
	OptionText varchar(255) NOT NULL
);

CREATE TABLE ForumPollAnswers (
	UserID int NOT NULL,
	OptionID int NOT NULL
);

CREATE TABLE ForumMessageRating (
	MessageID int NOT NULL,
	VoterUserID int NOT NULL,
	Score int NOT NULL
);

CREATE TABLE ForumSettings (
	LastDigestSentDate datetime NULL
);

CREATE TABLE ForumAchievements (
	AchievementID int NOT NULL,
	UserID int NOT NULL ,
	DateCreated DateTime NOT NULL,
	TimesAchieved int NOT NULL
);

/*adding complex keys*/
ALTER TABLE ForumAchievements ADD 
	PRIMARY KEY 
	(
		AchievementID,
		UserID
	);


ALTER TABLE ForumMessageRating ADD 
	PRIMARY KEY 
	(
		MessageID,
		VoterUserID
	);

ALTER TABLE ForumPollAnswers ADD 
	PRIMARY KEY 
	(
		UserID,
		OptionID
	);

ALTER TABLE ForumModerators ADD 
	PRIMARY KEY 
	(
		UserID,
		ForumID
	);

ALTER TABLE ForumSubscriptions ADD 
	PRIMARY KEY 
	(
		UserID,
		TopicID
	);

ALTER TABLE ForumNewTopicSubscriptions ADD 
	PRIMARY KEY 
	(
		UserID,
		ForumID
	);

ALTER TABLE ForumNewForumMsgSubscriptions ADD 
	PRIMARY KEY 
	(
		UserID,
		ForumID
	);

ALTER TABLE ForumGroupPermissions ADD 
	PRIMARY KEY 
	(
		ForumID,
		GroupID
	);

ALTER TABLE ForumUsersInGroup ADD 
	PRIMARY KEY 
	(
		UserID,
		GroupID
	);
	
ALTER TABLE ForumSubforums ADD 
	PRIMARY KEY 
	(
		ParentForumID,
		SubForumID
	);

INSERT INTO ForumUsers (UserName, Email, Password)
VALUES ('admin', 'admin@none', '21232F297A57A5A743894A0E4A801FC3');

INSERT INTO ForumAdministrators (UserID)
VALUES (1);


CREATE TABLE ForumConfig (
	CfgKey varchar(255) NOT NULL PRIMARY KEY,
	CfgValue text NULL
	);