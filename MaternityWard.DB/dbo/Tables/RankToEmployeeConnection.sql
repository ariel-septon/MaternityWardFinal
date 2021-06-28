CREATE TABLE [dbo].[RankToEmployeeConnection] (
    [RankToEmployeeID] INT NOT NULL,
    [EmployeeID]       INT NOT NULL,
    [RankID]           INT NOT NULL,
    PRIMARY KEY CLUSTERED ([RankToEmployeeID] ASC),
    CONSTRAINT [FK_RankToEmployeeConnection_Employees] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID])
);

