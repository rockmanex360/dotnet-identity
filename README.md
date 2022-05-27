# .Net Core Identity

Monolith application that built using .Net Core version 3.1 focus on implement **Identity** system for authentication. 

<br>

## Table of contents
- [Description](#description)
- [What's Included](#whats-included)
- [Dependencies](#dependencies)
- [Future Expand](#future-expand)

<br>

## Description
This application is monolith type, built using [**Clean Architecture**](https://www.example.com) and implement a default setting of [**Identity Approach**](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio) for the authentication. The purpose of making this application is for implementing the knowledge that i've learned and this project will be my personal guide for using identity approach in future projects.

<br>

## What's Included

```text
LoginWithIdentityPractices
├──- LoginWithIdentityPractices.Core
│    ├── Constants/
│    └── Properties/
├─── LoginWithIdentityPractices.Identity
│    ├── Extensions/
│    ├── Identity/
│    │   ├── Model/
│    │   │   └── Authentication/
│    │   ├── Seed/
│    │   └── Services/
│    └── Properties/
└─── LoginWithIdentityPractices.WebAPI
     ├── Config/
     ├── Controller/
     └── Properties/
```
Clean architecture puts the business logic and application model at the center of the application. Instead of having business logic depend on data access or other infrastructure concerns, this dependency is inverted: infrastructure and implementation details depend on the Application Core. [**Source**](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)

<br>

## Dependencies

This project is using several nuget package to support the implementations : 

1. Identity Project 
    - Microsoft.AspNetCore.Identity (2.2.0)
    - Microsoft.AspNetCore.Identity.EntityFrameworkCore (5.0.17)
    - Microsoft.EntityFrameworkCore (5.0.17)
    - Microsoft.Extensions.Configuration (5.0.0)
    - Microsoft.Extensions.Configuration.Json (5.0.0)
    - Microsoft.Extensions.DependencyInjection (5.0.2)
    - Microsoft.Extensions.Options (5.0.0)
2. WebAPI Project
    - Microsoft.EntityFrameworkCore (5.0.17)
    - Microsoft.EntityFrameworkCore.Tools (5.0.17)
    - Pomelo.EntityFrameworkCore.MySql (5.0.4)
    - Pomelo.EntityFrameworkCore.MySql.Design (1.1.2)

<br>

## Future Expand

Because the project is focusing on implement identity approach, many method or feature that might be added like implementing MediatR, FluentValidation, Custom Middleware for create a default responses. For now, i'm just let the project like.

<br>

## Thank you !
