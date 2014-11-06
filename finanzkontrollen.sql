-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema finanzkontrolle
-- -----------------------------------------------------
DROP database `finanzkontrolle`;
CREATE SCHEMA IF NOT EXISTS `finanzkontrolle` DEFAULT CHARACTER SET utf8 ;
USE `finanzkontrolle` ;

CREATE TABLE tag (
	Id INT(11) NOT NULL AUTO_INCREMENT,
	Name VARCHAR(10) NULL DEFAULT NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE operation_type (
	Id INT(11) NOT NULL,
	Name VARCHAR(25),
	PRIMARY KEY (Id)	
);

CREATE TABLE operation (
	Id INT(11) NOT NULL AUTO_INCREMENT,
	Name VARCHAR(10),
	Description VARCHAR(10),
	ReferenceDate DATETIME,
	PayDate DATETIME,
	Type INT(11),
	Ammount DECIMAL(10),
	PRIMARY KEY (Id),
	CONSTRAINT FK_operation_type_id FOREIGN KEY (Type) REFERENCES operation_type (Id)
);

CREATE TABLE operation_tag (
	Id INT(11) NOT NULL AUTO_INCREMENT,
	TagId INT(11) NOT NULL,
	OperationId INT(11) NOT NULL,
	PRIMARY KEY (Id),
	INDEX IX_operation_tab_unique (TagId ASC, OperationId ASC),
	CONSTRAINT FK_operation_tag_tag_id FOREIGN KEY (TagId) REFERENCES tag (Id),
	CONSTRAINT FK_operation_tag_operation_id FOREIGN KEY (OperationId) REFERENCES operation (Id)
);

CREATE TABLE account (
	Id INT(11) NOT NULL PRIMARY KEY,
	Name VARCHAR(25)
);

CREATE TABLE user (
	Id INT(11) NOT NULL AUTO_INCREMENT,
	Name VARCHAR(100),
	Email VARCHAR(100),
	Password VARCHAR(100),
	PRIMARY KEY (Id)
);

CREATE TABLE user_account (
	Id INT NOT NULL AUTO_INCREMENT,
	UserId INT(11) NOT NULL,
	AccountId INT(11) NOT NULL,
	PRIMARY KEY (Id),
	INDEX IX_user_account_unique (UserId ASC, AccountId ASC),
	CONSTRAINT FK_user_account_user_id FOREIGN KEY (UserId) REFERENCES user (Id),
	CONSTRAINT FK_user_account_account_id FOREIGN KEY (AccountId) REFERENCES account (Id)
);