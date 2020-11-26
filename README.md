# Microservice Template
This is a boiler plate for PayBright microservices.

## Done
1. Logical seperations:
  1. Api.
  2. Business.
  3. Domain.
  4. Infrastructure.

2. Clean Configurations.
  1. Business Rules Validations
3. MedatR
4. Global Filters.
5. Swagger.
6. Fluent Validation.
7. Design Time Configurations
8. Buiness seedwork / Foundations
9. Domain seedwork / Foundations
10. Infrastructure seedwork.
11. Docker Support.
12. Environment variables.
13. DDD
  1. Abstract Entity
  2. IBusinessRule
14. Generic Repository (Handy for Aggregates)

## In Development
1. BaseHttpClient (Mostly done)
  1. RestSharp/XML
  2. RestSharp/JSON
2. Test Abstractions (Ties into MediatR.

## ToDo
1. MediatR abstractions
  1. Abstract IRequestHandler
  2. Abstract IRequest
    1. ICommandHandler : IRequestHandler
    2. IQueryHandler : IRequestHandler
2. Default Github Workflows.
3. Sql Connection Factory.
4. Dapper abstractions (needed for read / write ORM seperations)
5. Showcase branch (see the abstractions implemented)
  1. Remove current showcase code (demo reasons only)
    
