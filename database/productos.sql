BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `Productos` (
	`Codigo`	TEXT UNIQUE,
	`Nombre`	TEXT,
	`Precio`	REAL
);
COMMIT;