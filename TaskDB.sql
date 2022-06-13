CREATE SCHEMA `testTask` DEFAULT CHARACTER SET utf8 ;
USE `testTask` ;

CREATE TABLE `testTask`.`Customers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(500) NOT NULL,
  PRIMARY KEY (`id`));

CREATE TABLE `testTask`.`Orders` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `CustomerId` INT NOT NULL,
  PRIMARY KEY (`id`, `CustomerId`),
  INDEX `fk_Orders_Customers_idx` (`CustomerId` ASC) VISIBLE,
  CONSTRAINT `fk_Orders_Customers`
    FOREIGN KEY (`CustomerId`)
    REFERENCES `testTask`.`Customers` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

select Name as Customers from customers c left join orders on c.id = CustomerId where CustomerId is null;