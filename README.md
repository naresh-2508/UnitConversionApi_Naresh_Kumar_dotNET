Unit Conversion API
Production-style ASP.NET Core 8 Web API using:

SOLID Principles
Strategy Pattern
Dependency Injection
Global Exception Middleware
Swagger
xUnit Test Project Structure
Docker Support
Run
dotnet restore

dotnet build

dotnet run

Navigate to: https://localhost:5001/swagger


About Project : 

# Unit Conversion API

## Overview

Unit Conversion API is a RESTful ASP.NET Core 8 Web API that allows users to convert numerical values between different units of measurement. The application currently supports Length, Temperature, and Weight/Mass conversions and is designed with extensibility in mind so that additional conversion categories and units can be added with minimal code changes.

## Features

* Convert values between different units of measurement
* Support for Length, Temperature, and Weight conversions
* RESTful API design
* Swagger/OpenAPI documentation
* Dependency Injection
* Strategy Pattern implementation for conversion logic
* Global exception handling
* Clean and maintainable project structure
* Unit test project setup
* Docker support for containerized deployment

## Design Approach

The application follows SOLID principles and uses the Strategy Pattern to separate conversion logic by category. Each conversion category is implemented as an independent converter, making the solution easy to extend and maintain.

A Conversion Service acts as the central component that selects the appropriate converter based on the requested conversion category. Dependency Injection is used to manage service registration and object creation.

## Future Enhancements

* Support for hundreds of units and conversion categories
* Database-driven unit configuration
* Caching for frequently used conversions
* Authentication and authorization
* API versioning
* Comprehensive unit and integration tests
* CI/CD pipeline integration
