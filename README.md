# Sankhya Rupaantran

*(This badge will work once you publish the package to NuGet.org)*

`Sankhya Rupaantran` (from Sanskrit/Hindi for "Number Transformation") is a simple, lightweight .NET utility library for converting large numbers into Indian (Lakh, Crore) and International (Million, Billion) numbering systems.

It provides easy-to-use static methods for both raw conversions and formatted strings.

## Installation

You can install the package via the .NET CLI or the NuGet Package Manager.

#### .NET CLI
```sh
dotnet add package SankhyaRupaantran
````

#### Package Manager Console

```powershell
Install-Package SankhyaRupaantran
```

-----

## How to Use

Simply add the `using` directive to your C\# file and call the static methods.

```csharp
using Sankhya.Rupaantran; // Your package namespace
```

### Quick Start: String Formatting

The most common use is to get a formatted string directly.

```csharp
decimal myAmount = 12_345_678.90m;

// --- Indian System ---
string lakhs = SankhyaRupaantran.ToLakhsString(myAmount);
// Output: "123.46 Lakhs"

string crores = SankhyaRupaantran.ToCroresString(myAmount);
// Output: "1.23 Crores"


// --- International System ---
string millions = SankhyaRupaantran.ToMillionsString(myAmount);
// Output: "12.35 Millions"
```

### Customizing String Format

The `...String` methods accept a standard numeric format string as an optional second parameter. The default is `"N2"` (a number with 2 decimal places).

```csharp
long bigAmount = 500_000_000;

// Format with no decimal places (N0)
string crores = SankhyaRupaantran.ToCroresString(bigAmount, "N0");
// Output: "50.00 Crores" 
// Note: ToLakhs(long) returns a decimal, so "N0" will still show .00 if not an even number.
// To truly get "50 Crores", you might use ToCrores(bigAmount).ToString("N0")

// Format with 4 decimal places (N4)
string millions = SankhyaRupaantran.ToMillionsString(bigAmount, "N4");
// Output: "500.0000 Millions"
```

### Raw Decimal Conversion

If you need the raw number for further calculations, use the core methods.

```csharp
decimal myAmount = 25_000_000m;

decimal inLakhs = SankhyaRupaantran.ToLakhs(myAmount);
// Value: 250.0m

decimal inCrores = SankhyaRupaantran.ToCrores(myAmount);
// Value: 2.5m
```

-----

## API Reference

The library provides convenient overloads for `decimal`, `double`, `float`, `long`, and `int`.

### Core Methods (Raw Conversion)

  * `ToLakhs(decimal amount)`: Returns `decimal`
  * `ToCrores(decimal amount)`: Returns `decimal`
  * `ToMillions(decimal amount)`: Returns `decimal`
  * `ToBillions(decimal amount)`: Returns `decimal`
  * `ToLakhs(double amount)`: Returns `decimal`
  * `ToCrores(double amount)`: Returns `decimal`
  * `ToMillions(double amount)`: Returns `decimal`
  * `ToBillions(double amount)`: Returns `decimal`
  * `ToLakhs(float amount)`: Returns `float`
  * `ToCrores(float amount)`: Returns `float`
  * `ToMillions(float amount)`: Returns `float`
  * `ToBillions(float amount)`: Returns `float`
  * `ToLakhs(long amount)`: Returns `decimal`
  * `ToCrores(long amount)`: Returns `decimal`
  * `ToMillions(long amount)`: Returns `decimal`
  * `ToBillions(long amount)`: Returns `decimal`
  * `ToLakhs(int amount)`: Returns `decimal`
  * `ToCrores(int amount)`: Returns `decimal`
  * `ToMillions(int amount)`: Returns `decimal`
  * `ToBillions(int amount)`: Returns `decimal`

### String Formatting (Returns `string`)

All string formatting methods accept an optional `format` parameter, which defaults to `"N2"`.

  * `ToLakhsString(decimal amount, string format = "N2")`
  * `ToCroresString(decimal amount, string format = "N2")`
  * `ToMillionsString(decimal amount, string format = "N2")`
  * `ToBillionsString(decimal amount, string format = "N2")`
  * `(Overloads for double, float, long, and int are also provided)`

-----

## License

This project is licensed. Check the repository for more info.
