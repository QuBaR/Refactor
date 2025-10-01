# Refactor Uppgift

Detta �r en uppgift i refactoring av befintlig kod. F�lj stegen nedan f�r att genomf�ra uppgiften.

## Arbetsfl�de

1.  **Fork & clone** ditt repo.
2.  **Skapa branch:** `feature/<namn>-cleanup-<regel>` (ex: `feature/ali-cleanup-magic-strings`).
3.  **G�r sm�, meningsfulla commits** (minst 6).
4.  **Skapa PR** mot `main`. Fyll i PR-mallen.
5.  **Fixa ev. konflikter**, s�kerst�ll att koden bygger och att PR �r up to date.
6.  **Merge** n�r review �r godk�nd.

## F�rb�ttringspass (kopplat till dina punkter)

Eleven v�ljer minst fyra omr�den (g�rna fler) och g�r en commit per omr�de:

### Namngivning & vokabul�r
-   Byt `list1` ? `orders`, `sts` ? `Status`, `amt` ? `Amount`, `cust` ? `CustomerId`.
-   Anv�nd samma vokabul�r �verallt: `customer`, inte `cust`/`person`/`user` blandat.

### Enums & konstanter (Avoid magic strings/numbers)
-   Skapa `enum OrderStatus { Pending = 0, Approved = 1 }`.
-   Anv�nd konstanter/`readonly` f�r menyval och meddelanden.

### Return early & minska n�stling
-   Anv�nd tidiga returer/guard clauses i menyn.
-   Bryt ut logik till sm� metoder.

### S�kbara, uttalbara namn
-   `s` ? `totalApprovedAmount`
-   `x` ? `menuChoice`
-   `f` ? `approvedOrdersForCustomer`

### Konsekvent casing & undvik Hungarian
-   **.NET:** `PascalCase` f�r typ/egenskap/metod, `camelCase` f�r variabler/parametrar.
-   Ta bort `strName`/`intCount`-stil om den dyker upp.

### Undvik on�dig kontext
-   I `Order`: `Id`, `Status`, `Amount`, `CustomerId` (ej `OrderId`, `OrderAmount` inne i `Order`).

### G�r dom�nspr�ket tydligt
-   Metoder som `CalculateApprovedTotal()`, `PrintApprovedOrdersForCustomer(string customerId)`.

### Bonus
-   (Valfritt bonussteg: l�gg till ett litet testprojekt och testa `CalculateApprovedTotal()`).

## Git-checkpoints (minimikrav: 6 meningsfulla commits)

Exempel p� commit-meddelanden:

-   `refactor: rename fields to meaningful names (Order.Id/Status/Amount/CustomerId)`
-   `feat: add OrderStatus enum and replace magic numbers`
-   `refactor: extract CalculateApprovedTotal()`
-   `refactor: early returns to reduce nesting in menu handling`
-   `style: apply .NET casing conventions (PascalCase/camelCase)`
-   `docs: update README with usage & reasoning`

## Bed�mning (IG/G/VG)

-   **IG:** F� eller inga f�rb�ttringar, bristf�lligt Git-fl�de, PR saknas/inkomplett.
-   **G:** Minst 4 tydliga f�rb�ttringar, 6+ fokuserade commits, PR-mall ifylld, koden bygger och �r uppdaterad mot `main`.
-   **VG:** Samtliga f�rb�ttringsomr�den adresserade v�l, utm�rkt commit-historik och PR-motivering, ev. sm� tester/dokumentation/extra f�rb�ttringar.

## Snabb �self-review� i PR (eleven bockar av)

-   [ ] **Namn:** tydliga, uttalbara, s�kbara, samma vokabul�r
-   [ ] **Magic strings/numbers** borttagna (enum/const)
-   [ ] **Mindre n�stling**, �return early�
-   [ ] **Konsekvent** `PascalCase`/`camelCase`, ingen Hungarian
-   [ ] **README** beskriver vad och varf�r
