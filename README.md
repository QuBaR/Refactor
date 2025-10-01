# Refactor Uppgift

Detta är en uppgift i refactoring av befintlig kod. Följ stegen nedan för att genomföra uppgiften.

## Arbetsflöde

1.  **Clona** repot https://github.com/QuBaR/Refactor.
2.  **Skapa branch:** `feature/<namn>-cleanup-<regel>` (ex: `feature/ali-cleanup-magic-strings`).
3.  **Gör små, meningsfulla commits**.
4.  **Skapa PR** mot `main`. Fyll i PR-mallen.
5.  **Fixa ev. konflikter**, säkerställ att koden bygger och att PR är up to date.
6.  **Merge** när review är godkänd.


### Namngivning & vokabulär
-   Byt `list1` ? `orders`, `sts` ? `Status`, `amt` ? `Amount`, `cust` ? `CustomerId`.
-   Använd samma vokabulär överallt: `customer`, inte `cust`/`person`/`user` blandat.

### Enums & konstanter (Avoid magic strings/numbers)
-   Skapa `enum OrderStatus { Pending = 0, Approved = 1 }`.
-   Använd konstanter/`readonly` för menyval och meddelanden.

### Return early & minska nästling
-   Använd tidiga returer/guard clauses i menyn.
-   Bryt ut logik till små metoder.

### Sökbara, uttalbara namn
-   `s` ? `totalApprovedAmount`
-   `x` ? `menuChoice`
-   `f` ? `approvedOrdersForCustomer`

### Konsekvent casing & undvik Hungarian
-   **.NET:** `PascalCase` för typ/egenskap/metod, `camelCase` för variabler/parametrar.
-   Ta bort `strName`/`intCount`-stil om den dyker upp.

### Undvik onödig kontext
-   I `Order`: `Id`, `Status`, `Amount`, `CustomerId` (ej `OrderId`, `OrderAmount` inne i `Order`).

### Gör domänspråket tydligt
-   Metoder som `CalculateApprovedTotal()`, `PrintApprovedOrdersForCustomer(string customerId)`.

## Git-checkpoints (minimikrav: 6 meningsfulla commits)

Exempel på commit-meddelanden:

-   `refactor: rename fields to meaningful names (Order.Id/Status/Amount/CustomerId)`
-   `feat: add OrderStatus enum and replace magic numbers`
-   `refactor: extract CalculateApprovedTotal()`
-   `refactor: early returns to reduce nesting in menu handling`
-   `style: apply .NET casing conventions (PascalCase/camelCase)`

## Snabb “self-review” i PR (eleven bockar av)

### Sammanfattning
Vad har du ändrat och varför?

### Checklista
- [ ] Små, fokuserade commits med tydliga meddelanden
- [ ] Namn är tydliga/uttalbara/sökbara
- [ ] Magic strings/nums borttagna (konstanter/enum)
- [ ] Djup nästling minskad, return early använt
- [ ] Samma vokabulär för samma sak (customer/order)
- [ ] Inga Hungarian prefix, konsekvent casing (.NET)
- [ ] README uppdaterad vid behov

### Risker/side-effects
Finns beteendeförändring? Hur testade du?
