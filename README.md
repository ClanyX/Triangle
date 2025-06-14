# Triangle

A console application written in C#/.NET that:

* 🎯 Determines the type of a triangle (equilateral, isosceles, scalene)
* ➕ Calculates perimeter and area
* 🎛️ Written as a mini‑project (CPE1130 Programming Logic and Design)

---

## 📦 Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/ClanyX/Triangle.git
   cd Triangle
   ```
2. Open the solution in Visual Studio or use the CLI (.NET SDK):

   ```bash
   dotnet build
   ```

> **Note:** This project is written in C# and likely targets .NET (`net6.0`, `.NET Framework`, etc.). Adjust based on the version in your `.csproj` file.

---

## 🚀 How to Use

Run the application (e.g., via terminal):

```bash
dotnet run --project Triangle
```

Then follow the console instructions:

1. Enter the lengths of the three sides (e.g., `3 4 5`)
2. The app will validate if a triangle can be formed, and if so:

   * It prints the triangle type
   * Calculates and displays the perimeter
   * Calculates and displays the area

---

## 🧪 Examples

```text
Enter side lengths: 3 4 5
→ Triangle type: Scalene
→ Perimeter: 12
→ Area: 6
```

```text
Enter side lengths: 5 5 5
→ Triangle type: Equilateral
→ Perimeter: 15
→ Area: 10.825...
```

---

## 🛠️ Internal Structure

* `Form1.cs` – main logic, input/output, and calculations
* `Triangle` – class for triangle validation and computations
* (add brief description of any other files if needed)

---

## 📫 Contributions

1. Fork this repository
2. Create a new branch (`git checkout -b feature/your-feature-name`)
3. Make your changes and commit (`git commit -am 'Add new feature'`)
4. Submit a pull request

---

## 📜 License

This project is licensed under the [MIT License](LICENSE).

## 👤 Author

Created with 💻 by [ClanyX](https://github.com/ClanyX)
"""
