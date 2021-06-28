CREATE TABLE [dbo].[Ranks] (
    [RankID]                 INT           NOT NULL,
    [RankType]               NVARCHAR (10) NOT NULL,
    [ExtraPaymentPrecentage] NVARCHAR (10) NULL,
    [Payment]                NVARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([RankID] ASC)
);

