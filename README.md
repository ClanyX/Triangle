# Triangle

A console application written in C#/.NET that:

* 🎯 Determines the type of a triangle (equilateral, isosceles, scalene)
* ➕ Calculates perimeter and area
* 🎛️ Written as a mini‑project (CPE1130 Programming Logic and Design)

---

## 📦 Instalace

1. Klonuj repozitář:

   ```bash
   git clone https://github.com/ClanyX/Triangle.git
   cd Triangle
   ```
2. Otevři řešení v Visual Studio nebo pomocí CLI (.NET SDK):

   ```bash
   dotnet build
   ```

> **Poznámka:** Projekt je v C#, pravděpodobně založený na .NET (`net6.0`, `.NET Framework` apod.). Uprav podle verze ve tvém `.csproj`.

---

## 🚀 Jak používat

Spusť aplikaci (např. přes terminál):

```bash
dotnet run --project Triangle
```

Poté následuj instrukce v konzoli:

1. Zadej délky tří stran (např. `3 4 5`)
2. Aplikace ověří, zda lze trojúhelník tvořit, pokud ano:

   * Vypíše typ trojúhelníku
   * Vypočítá a zobrazí obvod
   * Vypočítá a zobrazí obsah

---

## 🧪 Příklady

```text
Zadej délky stran: 3 4 5
→ Trojúhelník je: Scalene
→ Obvod: 12
→ Obsah: 6
```

```text
Zadej délky stran: 5 5 5
→ Trojúhelník je: Equilateral
→ Obvod: 15
→ Obsah: 10.825...
```

---

## 🛠️ Vnitřní struktura

* `Program.cs` – hlavní logika, vstup‑výstup + výpočet
* `Triangle.cs` – (doplnit) třída pro ověřování a výpočet trojúhelníků
* (v případě dalších souborů přidej stručný popis)

---

## 📫 Příspěvky

1. Forkni tento repozitář
2. Vytvoř větev (`git checkout -b feature/nazev`)
3. Proveď změny a commitni (`git commit -am 'Přidán nový příkaz'`)
4. Pošli pull request

---

## 📄 Licence

Tento projekt je zveřejněn bez licence – můžeš ho používat a modifikovat, ale autor neručí za žádné chyby.
"""
