sql
-- Файл: test_database.sql
CREATE TABLE IF NOT EXISTS Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL UNIQUE,
    Email TEXT NOT NULL UNIQUE,
    PasswordHash TEXT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    IsActive BOOLEAN DEFAULT 1
);
CREATE TABLE IF NOT EXISTS TestResults (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    UserId INTEGER NOT NULL,
    TestName TEXT NOT NULL,
    Score INTEGER NOT NULL,
    MaxScore INTEGER NOT NULL,
    TestDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);
CREATE TABLE IF NOT EXISTS Logs (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    EventType TEXT NOT NULL,
    EventMessage TEXT,
    EventTime DATETIME DEFAULT CURRENT_TIMESTAMP
);
-- Индексы для оптимизации
CREATE INDEX idx_users_username ON Users(Username);
CREATE INDEX idx_testresults_userid ON TestResults(UserId);
CREATE INDEX idx_logs_time ON Logs(EventTime);
Тестовые данные (INSERT):

sql
INSERT INTO Users (Username, Email, PasswordHash, IsActive) VALUES
('agamzalova', 'anna@example.com', 'hash123', 1),
('testuser', 'test@example.com', 'hash456', 1);
INSERT INTO TestResults (UserId, TestName, Score, MaxScore) VALUES
(1, 'Module1_LinearAlgorithm', 6, 6),
(1, 'Module2_Branching', 6, 6),
(1, 'Module3_Loops', 5, 6),
(2, 'Module1_LinearAlgorithm', 4, 6);
