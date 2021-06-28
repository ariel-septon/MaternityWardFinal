CREATE TABLE [dbo].[Employees] (
    [EmployeeID]      INT           NOT NULL,
    [EmployeeType]    NVARCHAR (50) NOT NULL,
    [CategoryID]      INT           NOT NULL,
    [WorkHours]       INT           NULL,
    [IsHourlyPaid]    BIT           NOT NULL,
    [ConstantBasePayment] FLOAT (53)    NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC),
    CONSTRAINT [FK_Employees_Categories] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Categories] ([CategoryID])
);

