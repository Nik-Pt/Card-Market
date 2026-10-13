# Card Market

A marketplace for trading cards: users build a collection, create decks, list cards for sale, make offers, and complete orders. Built as a portfolio project with ASP.NET Core, with React, Node.js and Angular clients added on top.

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

**Prerequisites:** .NET SDK 10, Docker, Git. Node.js is needed later for the frontends.

```bash
git clone git@github.com:Nik-Pt/card-market.git
cd card-market

# start the database
docker compose up -d db

# run the API
dotnet run --project backend/src/CardMarket.Api
```

Then open `http://localhost:5080/health` and the API docs at `http://localhost:5080/scalar`. Adjust the port if yours differs.

## Project structure

```
backend/      ASP.NET Core API (src/) and tests (tests/)
docs/         ERD, security notes, decision records
.github/      CI workflows and templates
```

More folders (`web/`, `notifications/`, `admin/`) appear as each part is built.

## Roadmap

Work is tracked on the GitHub Projects board, with one epic per area: setup, data model, auth, card catalog, collections, decks, marketplace, hardening, and the frontends.

## Licence

MIT