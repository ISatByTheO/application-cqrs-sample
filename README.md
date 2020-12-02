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


# Reference Guide 

1. CQRS - https://martinfowler.com/bliki/CQRS.html
2. Microservice/DDD - Martin Fowler 
3. Clean Code - Uncle Bob
4. EF Core - Training courses 
5. Transactional rollback - Just utilize 
6. Exception flow handling - https://enterprisecraftsmanship.com/posts/cqrs-exception-handling/
7. GUID vs ID - https://blog.codinghorror.com/primary-keys-ids-versus-guids/
8. Coding standards - Mike McCann released this in April
9. Design time factory - https://blog.tonysneed.com/2018/12/20/idesigntimedbcontextfactory-and-dependency-injection-a-love-story/ (simplified)
10. Architectural Blue Print - Mike McCann released
11. Generic Repository Pattern - Knowing when to use one is whats key https://www.programmingwithwolfgang.com/repository-pattern-net-core/ (don't include repeated try catch)
12. Logical seperation - https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice (Elaborated)
13. Aggregate Service Pattern - https://autofaccn.readthedocs.io/en/latest/advanced/aggregate-services.html
14. Aggregate Models - https://martinfowler.com/bliki/DDD_Aggregate.html
15. MediatR, when and when not to?- https://codeopinion.com/why-use-mediatr-3-reasons-why-and-1-reason-not/
16. Healthcheck on microservice? - https://medium.com/it-dead-inside/implementing-health-checks-in-asp-net-core-a8331d16a180
17. Validation tiers - https://www.infoq.com/articles/ddd-business-rules/
18. When should we use in memory testing? Only for testing code itself in unit testing some function NEVER for integration tests.
  1. https://docs.microsoft.com/en-us/ef/core/testing/
19. Preserving encapsulation in ef core - Just look at Vladimir Khorikovs work 
  1. https://enterprisecraftsmanship.com/posts/new-online-course-ddd-and-ef-core/
20. EF Core & Dapper? Our Infra should be capable of using both, without ever crossing concerns. Shawn Wildermuth has a bunch of vids on this.
21. Service Collection Extension? https://dotnetcoretutorials.com/2017/01/24/servicecollection-extension-pattern/ (Good but not great, we have made some improvements)
22. Docker? Defined by Brian
23. Github Actions? Defined by Brian
24. Single deployments (design time factory, health checks) - Brian
