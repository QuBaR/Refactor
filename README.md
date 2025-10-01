# Refactor Uppgift

Detta är en uppgift i refactoring av befintlig kod. Följ stegen nedan för att genomföra uppgiften.

## Arbetsflöde

1.  **Fork & clone** ditt repo.
2.  **Skapa branch:** `feature/<namn>-cleanup-<regel>` (ex: `feature/ali-cleanup-magic-strings`).
3.  **Gör små, meningsfulla commits** (minst 6).
4.  **Skapa PR** mot `main`. Fyll i PR-mallen.
5.  **Fixa ev. konflikter**, säkerställ att koden bygger och att PR är up to date.
6.  **Merge** när review är godkänd.

## Förbättringspass (kopplat till dina punkter)

Eleven väljer minst fyra områden (gärna fler) och gör en commit per område:

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

### Bonus
-   (Valfritt bonussteg: lägg till ett litet testprojekt och testa `CalculateApprovedTotal()`).

## Git-checkpoints (minimikrav: 6 meningsfulla commits)

Exempel på commit-meddelanden:

-   `refactor: rename fields to meaningful names (Order.Id/Status/Amount/CustomerId)`
-   `feat: add OrderStatus enum and replace magic numbers`
-   `refactor: extract CalculateApprovedTotal()`
-   `refactor: early returns to reduce nesting in menu handling`
-   `style: apply .NET casing conventions (PascalCase/camelCase)`
-   `docs: update README with usage & reasoning`

## Bedömning (IG/G/VG)

-   **IG:** Få eller inga förbättringar, bristfälligt Git-flöde, PR saknas/inkomplett.
-   **G:** Minst 4 tydliga förbättringar, 6+ fokuserade commits, PR-mall ifylld, koden bygger och är uppdaterad mot `main`.
-   **VG:** Samtliga förbättringsområden adresserade väl, utmärkt commit-historik och PR-motivering, ev. små tester/dokumentation/extra förbättringar.

## Snabb “self-review” i PR (eleven bockar av)

-   [ ] **Namn:** tydliga, uttalbara, sökbara, samma vokabulär
-   [ ] **Magic strings/numbers** borttagna (enum/const)
-   [ ] **Mindre nästling**, “return early”
-   [ ] **Konsekvent** `PascalCase`/`camelCase`, ingen Hungarian
-   [ ] **README** beskriver vad och varför
