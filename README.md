# HackerAPI
This is demo hacker api 
# HackerNews API with Docker 

This repository contains a .NET solution with Dockerized projects for the HackerNews API with MediatR and CQRS.

## HackerNews API

### Project Structure
- **HackerNews.Api:** Main API project.
- **HackerNews.Domain:** Domain models and business logic.
- **HackerNews.Application:** Application services, CQRS commands, and queries.
- **HackerNews.Infrastructure:** Implementation of infrastructure concerns (e.g., repository, HTTP client).

### Dockerizing the HackerNews API

#### Build and Run
```bash
cd HackerNews.Api
docker build -t hackernews-api .
docker run -p 5000:80 hackernews-api
