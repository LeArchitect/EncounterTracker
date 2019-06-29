CREATE TABLE characters (
 store_name VARCHAR (255) PRIMARY KEY NOT NULL,
 hp INT NOT NULL,
 initiative INT NOT NULL,
 condition VARCHAR (255),
 condition2 VARCHAR (255),
 condition3 VARCHAR (255),
 fails INT,
 success INT
);