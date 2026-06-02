
--pirveli etapi
CREATE DATABASE Quiz;
GO

USE Quiz;
GO

--User table sheqmna
CREATE TABLE [User]
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(100) NOT NULL,
    RegistrationDate DATE NOT NULL,
    [Rank] DECIMAL(2,1) NULL
        CHECK ([Rank] BETWEEN 0.0 AND 5.0),
    CreatedAt DATETIME NOT NULL
);
GO

--Question table sheqmna
CREATE TABLE Questions
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    QuestionText VARCHAR(500) NOT NULL,
    Point INT NOT NULL
);
GO

--Answer table sheqmna
CREATE TABLE Answers
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    AnswerText VARCHAR(300) NOT NULL,
    IsCorrect BIT NOT NULL,
    QuestionId INT NOT NULL,

    CONSTRAINT FK_Answers_Questions
        FOREIGN KEY (QuestionId)
        REFERENCES Questions(Id)
);
GO


--GameSession table sheqmna
CREATE TABLE GameSession
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    QuestionsCount INT NOT NULL,
    Score INT NOT NULL,
    SessionStart DATETIME NOT NULL,
    SessionEnd DATETIME NULL,

    CONSTRAINT FK_GameSession_User
        FOREIGN KEY (UserId)
        REFERENCES [User](Id)
);
GO


--meore etapi

INSERT INTO [User] ([Name], RegistrationDate, [Rank], CreatedAt)
VALUES 
('Nika', '2025-01-10', 4.5, GETDATE()),
('Ana', '2025-02-15', 3.8, GETDATE()),
('Giorgi', '2025-03-01', 5.0, GETDATE());


INSERT INTO Questions (QuestionText, Point)
VALUES
('What is 2 + 2?', 1),
('What is the capital of Georgia?', 2),
('Which language is used for web apps?', 2);


-- Question 1
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId)
VALUES
('3', 0, 1),
('4', 1, 1),
('5', 0, 1);

-- Question 2
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId)
VALUES
('Tbilisi', 1, 2),
('Batumi', 0, 2),
('Kutaisi', 0, 2);

-- Question 3
INSERT INTO Answers (AnswerText, IsCorrect, QuestionId)
VALUES
('Python', 1, 3),
('HTML', 1, 3),
('Photoshop', 0, 3);


INSERT INTO GameSession (UserId, QuestionsCount, Score, SessionStart, SessionEnd)
VALUES
(1, 3, 2, GETDATE(), DATEADD(MINUTE, 5, GETDATE())),
(2, 3, 3, GETDATE(), DATEADD(MINUTE, 7, GETDATE()));

--mesame etapi

--N1
--SELECT [Name], [Rank]
--FROM [User];

--N2
--SELECT DISTINCT [Rank]
--FROM [User];

--N3
--SELECT *
--FROM [User]
--WHERE [Rank] > 3.0;

--N4
--SELECT *
--FROM GameSession
--ORDER BY Score DESC;

--N5
--SELECT *
--FROM GameSession
--WHERE Score > 20
--  AND QuestionsCount = 5;

--N6
--SELECT *
--FROM Questions
--WHERE Point = 1
--   OR Point = 2;

--N7
--SELECT *
--FROM Questions
--WHERE NOT Point = 5;

--N8
--SELECT *
--FROM GameSession
--WHERE SessionEnd IS NULL;

--N9
--INSERT INTO [User] ([Name], RegistrationDate, [Rank], CreatedAt)
--VALUES ('Dato', '2026-06-02', 4.2, GETDATE());

--N10
--UPDATE [User]
--SET [Rank] = 5.0
--WHERE Id = 1;

--N11
--DELETE FROM GameSession
--WHERE Score = 0;

--N12
--SELECT 
--    COUNT(*),
--    AVG(Score),
--    MAX(Score)
--FROM GameSession;

--N13 sxvadasxva tablebshi radgan arian erti logikit ver davwere
--SELECT 'User' AS Source, [Name] AS Value
--FROM [User]
--WHERE [Name] LIKE 'G%'

--UNION

--SELECT 'Question', QuestionText
--FROM Questions
--WHERE QuestionText NOT LIKE '%?%';

--N14
--SELECT *
--FROM [User]
--WHERE [Rank] IN (1.0, 2.0, 3.0, 4.0, 5.0);

--N15
--SELECT *
--FROM [User]
--WHERE [Rank] BETWEEN 2.5 AND 4.5;

--N16
--SELECT 
--    GameSession.Id,
--    [User].[Name],
--    GameSession.Score,
--    GameSession.QuestionsCount,
--    GameSession.SessionStart,
--    GameSession.SessionEnd
--FROM GameSession
--INNER JOIN [User]
--    ON GameSession.UserId = [User].Id;

--N17
--SELECT 
--    [User].[Id],
--    [User].[Name],
--    GameSession.Id AS SessionId,
--    GameSession.Score,
--    GameSession.QuestionsCount,
--    GameSession.SessionStart,
--    GameSession.SessionEnd
--FROM [User]
--LEFT JOIN GameSession
--    ON [User].Id = GameSession.UserId;

--N18
--SELECT 
--    [User].Id,
--    [User].[Name],
--    COUNT(GameSession.Id) AS TotalGames,
--    SUM(GameSession.Score) AS TotalScore
--FROM [User]
--LEFT JOIN GameSession
--    ON [User].Id = GameSession.UserId
--GROUP BY 
--    [User].Id,
--    [User].[Name];

--N19
--SELECT 
--    [User].Id,
--    [User].[Name],
--    COUNT(GameSession.Id) AS TotalGames
--FROM [User]
--LEFT JOIN GameSession
--    ON [User].Id = GameSession.UserId
--GROUP BY 
--    [User].Id,
--    [User].[Name]
--HAVING COUNT(GameSession.Id) > 1;