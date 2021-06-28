CREATE TABLE [dbo].[Shifts] (
    [ShiftID]    INT NOT NULL,
    [EmployeeID] INT NOT NULL,
    [HourIn]     INT NOT NULL,
    [HourOut]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ShiftID] ASC),
    CONSTRAINT [FK_Shifts_Employee] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID])
);

