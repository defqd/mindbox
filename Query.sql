SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products AS p
LEFT JOIN Products_Categories AS pc ON pc.ProductId = p.Id
LEFT JOIN Categories AS c ON c.Id = pc.CategoryId