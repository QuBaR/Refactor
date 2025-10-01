# Refactor Uppgift

Detta �r en uppgift i refactoring av befintlig kod. F�lj stegen nedan f�r att genomf�ra uppgiften.

## Arbetsfl�de

1.  **Clona** repot https://github.com/QuBaR/Refactor.
2.  **Skapa branch:** `feature/<namn>-cleanup-<regel>` (ex: `feature/ali-cleanup-magic-strings`).
3.  **G�r sm�, meningsfulla commits**.
4.  **Skapa PR** mot `main`. Fyll i PR-mallen.
5.  **Fixa ev. konflikter**, s�kerst�ll att koden bygger och att PR �r up to date.
6.  **Merge** n�r review �r godk�nd.


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

## Git-checkpoints (minimikrav: 6 meningsfulla commits)

Exempel p� commit-meddelanden:

-   `refactor: rename fields to meaningful names (Order.Id/Status/Amount/CustomerId)`
-   `feat: add OrderStatus enum and replace magic numbers`
-   `refactor: extract CalculateApprovedTotal()`
-   `refactor: early returns to reduce nesting in menu handling`
-   `style: apply .NET casing conventions (PascalCase/camelCase)`

## Snabb �self-review� i PR (eleven bockar av)

### Sammanfattning
Vad har du �ndrat och varf�r?

### Checklista
- [ ] Sm�, fokuserade commits med tydliga meddelanden
- [ ] Namn �r tydliga/uttalbara/s�kbara
- [ ] Magic strings/nums borttagna (konstanter/enum)
- [ ] Djup n�stling minskad, return early anv�nt
- [ ] Samma vokabul�r f�r samma sak (customer/order)
- [ ] Inga Hungarian prefix, konsekvent casing (.NET)
- [ ] README uppdaterad vid behov

### Risker/side-effects
Finns beteendef�r�ndring? Hur testade du?
