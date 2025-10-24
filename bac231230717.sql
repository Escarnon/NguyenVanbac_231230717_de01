create database nguyenvanbac_231230717_de01
 use nguyenvanbac_231230717_de01
CREATE TABLE NvbComputer (
    nvbComId INT PRIMARY KEY,
    nvbComName NVARCHAR(100),
    nvbComPrice DECIMAL(12,2),
    nvbComImage NVARCHAR(255),
    nvbComStatus BIT
);


INSERT INTO nvbComputer (nvbComId, nvbComName, nvbComPrice, nvbComImage, nvbComStatus)
VALUES
(1, N'a', 15000000, N'a.jpg', 1), 
(2, N'b', 18500000, N'b.jpg', 1),
(3, N'c', 16500000, N'c.jpg', 0);
ALTER TABLE NvbComputer
ADD CONSTRAINT PK_NvbComputer PRIMARY KEY (nvbComId);
