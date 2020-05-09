# Ocelot Api Gateway Example

This project is an example of Ocelot API Gateway implementation. It takes requests (API calls) and routes them to the microservices (BasketAPI and ProductAPI). Thanks to API Gateway our application has a single entrypoint.

## Development

Run all projects separately with `dotnet run` command on its own project directory.

- Basket API -> http://localhost:5006/api/basket
- Product API -> http://localhost:5005/api/product
- Ocelot ApiGateway -> http://localhost:5000/

Now we have three application running on above given ports. We'll access these applications via Api Gateway (localhost:5000). These routes are defined in "ocelot.json" file in the OcelotApiGateway project. We can access our services llike below:

- http://localhost:5000/test/product
- http://localhost:5000/test/product/7
- http://localhost:5000/test/basket
- http://localhost:5000/test/basket/7
