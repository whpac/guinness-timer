# Guinness Timer

Aplikacja jest stoperem. Po prostu. Odlicza czas od zera w górę z dokładnością do sekund.

Aby ułatwić jej wykorzystanie w sytuacjach krytycznych, do zatrzymania zegara potrzeba hasła.
Powoduje to, że przypadkowe kliknięcienie nie grozi unieważnieniem trudu włożonego w organizację
wydarzenia. Podobnie, niemożliwe jest zamknięcie okna w czasie trwania odliczania.

Bez podawania hasła program można zamknąć wyłącznie z użyciem Menedżera Zadań.

Okienko stopera jest pokazywane ponad wszystkimi innymi, bez możliwości minimalizacji.

## Cel odliczania
Przed uruchomieniem odliczania można określić cel do osiągnięcia. Po przekroczeniu tego progu
odliczanie trwa dalej, ale możliwe jest wstrzymanie stopera bez podawania hasła.

## Wymagania systemowe
Aplikacja korzysta z .NET 6, który jest razem z nią spakowany, a więc nie musi być uprzednio
zainstalowany na komputerze. System operacyjny musi spełniać wymagania tej wersji platformy
.NET, które przedstawiono tutaj: https://github.com/dotnet/core/blob/main/release-notes/6.0/supported-os.md
