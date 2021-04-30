INSERT INTO public."Categories"("CategoryName", "Description")VALUES ('Beverages', 'Icecekler');
INSERT INTO public."Categories"("CategoryName", "Description")VALUES ('Foods', 'Yiyecekler');
INSERT INTO public."Categories"("CategoryName", "Description")VALUES ('Electronics', 'Elektronik');
INSERT INTO public."Categories"("CategoryName", "Description")VALUES ('Appliances', 'Beyaz Esya');

INSERT INTO public."Products"("ProductName", "Price", "UnitsInStock", "CategoryID", "IsActive") VALUES ('Ice Tea', 5.00, 76, 1, 'True');
INSERT INTO public."Products"("ProductName", "Price", "UnitsInStock", "CategoryID", "IsActive") VALUES ('Chocolate', 1.00, 10, 2, 'False');
INSERT INTO public."Products"("ProductName", "Price", "UnitsInStock", "CategoryID", "IsActive") VALUES ('Sprite', 4.00, 87, 1, 'False');
INSERT INTO public."Products"("ProductName", "Price", "UnitsInStock", "CategoryID", "IsActive") VALUES ('iPhone', 999, 15, 3, 'True');
INSERT INTO public."Products"("ProductName", "Price", "UnitsInStock", "CategoryID", "IsActive") VALUES ('SD Card', 35.99, 32, 3, 'False');
INSERT INTO public."Products"("ProductName", "Price", "UnitsInStock", "CategoryID", "IsActive") VALUES ('Fridge', 7659.00, 55, 4, 'False');
INSERT INTO public."Products"("ProductName", "Price", "UnitsInStock", "CategoryID", "IsActive") VALUES ('Oven', 4000.00, 129, 4, 'True');
INSERT INTO public."Products"("ProductName", "Price", "UnitsInStock", "CategoryID", "IsActive") VALUES ('Washing Machine', 3299.00, 51, 4, 'False');
