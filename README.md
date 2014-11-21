#finanzkontrollen
================

##Financial Controls

It's a small financial control system, built using DDD, ASP.NET MVC, API, REST and other technology.

Currently It's separated this way:

###Repository

- FinanzKontrollen.Repository.Model
This contain all 'POCO' mapped from database.

- FinanzKontrollen.Repository.Contract
This contain all contracts implemented by the real repository.

- FinanzKontrollen.Repository.Default
Finally this implement all database access using MySQL as DEFAULT and DAPPER as micro ORM.

###Domain

- FinanzKontrollen.Domain.DataTransferObject
This contain all objects with will be passed to the application.

- FinanzKontrollen.Domain.Contract
This contain all contracts implemented by the real domain

- FinanzKontrollen.Domain.Default
Finally this implement the whole Domain set of business, domain validations and so on.

###Infrastructure

- FinanzKontrollen.Infrastructure.MapperExtension
This contain the map from POCO to DTO and from DTO to POCO, using mainly in Domain package.

###Application

- FinanzKontrollen.Presentation.Model
This contain all Model used to communicate between Application and the final user/view.

- FinanzKontrollen.Presentation.WebApi
The Rest implementation of the system.

- FinanzKontrollen.Presentation.RestClientApi
A API for the rest implementation.

###View 

- FinanzKontrollenTests
A final client test using the API.

- FinanzKontrollen.View.WebSite
(Not yet created)
A final web client with view, css, html, forms, js etc all normal stuff used on a website. The intention is use some MVVM js API.

Feel free to contact me to ask or contribute with something =D.
