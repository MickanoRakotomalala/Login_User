CREATE TABLE [dbo].[Users] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50)    NOT NULL,
    [LastName]     VARCHAR (50)    NOT NULL,
    [GenderMale]   BIT             NULL,
    [GenderFemale] BIT             NULL,
    [Contact]      VARCHAR (50)    NOT NULL,
    [Address]      VARCHAR (50)    NOT NULL,
    [Password]     VARCHAR (50)    NOT NULL,
    [Profil]       VARBINARY (MAX) NOT NULL,
    [User]         BIT             NULL,
    [Supervisor]   BIT             NULL,
    [Admin]        BIT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

