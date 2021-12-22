SELECT name AS Customers FROM Customers 
WHERE Id NOT IN (SELECT CustomerId FROM Orders);