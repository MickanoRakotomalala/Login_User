CREATE TABLE users (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) NOT NULL,
    [GenderMale]   BIT          NULL,
    [GenderFemale] BIT          NULL,
    [Contact]      VARCHAR (50) NOT NULL,
    [Address]      VARCHAR (50) NOT NULL,
    [Password]     VARCHAR (50) NOT NULL,
	[Profil] varbinary(max) not null,
	[User] BIT,
	[Supervisor] BIT,
	[Admin] BIT
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
