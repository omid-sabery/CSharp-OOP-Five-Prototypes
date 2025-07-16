# 🧪 Csharp-OOP-Five-Prototypes

This repository contains five object-oriented C# prototypes built using **.NET 9** and developed in **Visual Studio Community 2022 (v17.14.9, 64-bit)**. Inspired by **RB Whitaker’s _The C# Player’s Guide_**, each prototype explores core programming concepts like encapsulation, enums, validation, state management, and interactive console programming.

---

## 📁 Project Overview

| Prototype           | Description |
|---------------------|-------------|
| 🟢 `Point`          | Represents 2D coordinates using immutable properties. Demonstrates value-like class behavior. |
| 🔴 `Color`          | Models RGB color values with predefined static options and full encapsulation. |
| 🃏 `Card`           | Combines enums and class logic to simulate cards with color and rank (numbers and symbols). |
| 🚪 `Door`           | Interactive passcode-protected door simulation with state transitions (open, close, lock, unlock). |
| 🔐 `PasswordValidator` | Enforces custom password rules using regular expressions and logic. Fully interactive via console. |

---

## 🧠 Skills Demonstrated

### 🧑‍💻 Technical Skills
- C#
- .NET 9
- Object-Oriented Programming (OOP)
- Console Application Development
- Custom Data Structures (`class`, `enum`)
- Regular Expressions (Regex)
- User Input Handling
- Input Validation
- Basic Security Concepts (password rules)

### 🧱 Software Design Concepts
- Encapsulation
- Separation of Concerns
- Immutability (read-only properties)
- Method Overriding (custom `ToString()` for clean output)
- Clean code practices (e.g., `ToString()` overrides)

### ⚙️ Tools & Environment
- Microsoft Visual Studio 2022 (v17.14.9)
- .NET CLI
- Git (if version-controlled)

### 🧩 Soft & Transferable Skills
- Problem Solving
- Code Design Thinking
- Interactive CLI Workflows

---

## 🔐 Password Rules

The `PasswordValidator` enforces these rules:

- Password must be **between 6 and 13 characters**
- Must contain at least one:
  - Lowercase letter
  - Uppercase letter (excluding `'T'`)
  - Digit
- Must **not** contain:
  - `'T'`
  - `'&'`

### ✔️ Valid Examples
- `Abc123`
- `GoodPwd9`
- `Hello1U`

### ❌ Invalid Examples
- `Tpass123` → contains `'T'`
- `abc123` → no uppercase letter
- `123456` → no letters
- `A&c12` → too short and contains `'&'`

---

## 🚀 Getting Started

### 📦 Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or any C#-capable IDE
- Git (optional)

### ▶️ Run the Application

```bash
git clone https://github.com/omid-sabery/CSharp-OOP-Five-Prototypes.git
cd Csharp-OOP-Five-Prototypes
dotnet run
