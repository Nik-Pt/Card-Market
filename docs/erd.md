# Entity-Relationship Diagram (ERD)

erDiagram
  USER ||--o{ COLLECTION_ITEM : owns
  USER ||--o{ DECK : builds
  USER ||--o{ LISTING : sells
  USER ||--o{ OFFER : makes
  USER ||--o{ ORDER : buys_or_sells
  USER ||--o{ REFRESH_TOKEN : has
  CARD ||--o{ CARD_PRINTING : has
  CARD ||--o{ DECK_CARD : used_in
  DECK ||--o{ DECK_CARD : contains
  CARD_PRINTING ||--o{ COLLECTION_ITEM : of
  CARD_PRINTING ||--o{ LISTING : of
  LISTING ||--o{ OFFER : receives
  LISTING ||--o{ ORDER : produces
  OFFER |o--o| ORDER : results_in
