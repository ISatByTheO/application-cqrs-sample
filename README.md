# Microservice Template
This is a boiler plate for PayBright microservices.

## Done
1. Logical seperations:
   * Api.
   * Business.
   * Domain.
   * Infrastructure.

2. Clean Configurations.
3. MedatR
4. Global Filters.
5. Swagger.
6. Fluent Validation.
7. Design Time Configurations (including cmds)
8. Buiness seedwork / Foundations
9. Domain seedwork / Foundations
10. Infrastructure seedwork.
11. Docker Support.
12. Environment variables.
13. DDD
   * Abstract Entity
   * IBusinessRule
14. Generic Repository (Handy for Aggregates)

## In Development
1. BaseHttpClient (Mostly done) 
   * RestSharp/XML
   * RestSharp/JSON
2. Test Abstractions (Ties into MediatR.

## ToDo
1. MediatR abstractions
   * Abstract IRequestHandler
   * Abstract IRequest
    * ICommandHandler : IRequestHandler
    * IQueryHandler : IRequestHandler
2. Default Github Workflows.
3. Sql Connection Factory.
4. Dapper abstractions (needed for read / write ORM seperations)
5. Showcase branch (see the abstractions implemented)
   * Remove current showcase code (demo reasons only)
6. Automapper.

## Discussions
1. Global exception handling?
2. Transaction control?
3. Entity cascades?
    
