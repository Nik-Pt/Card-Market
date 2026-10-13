# Card Market

A marketplace for trading cards: users build a collection, create decks, list cards for sale, make offers, complete orders and more later on (combo practice etc.). Built as a portfolio project with ASP.NET Core, with React, Node.js and Angular clients added on top.

**Status:** early development (Epic 0, project setup). Live demo: _coming soon_.

## Tech stack

| Area | Technology |
|---|---|
| API | ASP.NET Core Web API (.NET 10), EF Core |
| Database | PostgreSQL (Docker for local development) |
| Auth | ASP.NET Core Identity, JWT access and refresh tokens |
| Web client | React + TypeScript _(planned)_ |
| Real-time service | Node.js + WebSockets _(planned)_ |
| Admin dashboard | Angular _(planned)_ |
| Tooling | Docker Compose, GitHub Actions, xUnit |

## Architecture

_Diagram coming in a later epic._ For now:

- `backend/` is the REST API, split into Api, Core and Infrastructure projects.
- Business rules live in Core, database and external clients in Infrastructure.
- The API is versioned under `/api/v1` and documented with OpenAPI.

## Getting started

**Prerequisit