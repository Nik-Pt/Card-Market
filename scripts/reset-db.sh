#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "$0")/.."

read -r -p "This deletes the LOCAL database and all its data. Continue? (y/N) " answer
[[ "$answer" == "y" ]] || { echo "Cancelled."; exit 1; }

export ASPNETCORE_ENVIRONMENT=Development

docker compose down -v
docker compose up -d db

echo "Waiting for the database..."
until docker compose exec -T db pg_isready -h localhost -U cardmarket -d cardmarket > /dev/null 2>&1; do
  sleep 1
done

dotnet ef database update \
  -p backend/src/CardMarket.Infrastructure \
  -s backend/src/CardMarket.Api

echo "Database rebuilt from migrations."