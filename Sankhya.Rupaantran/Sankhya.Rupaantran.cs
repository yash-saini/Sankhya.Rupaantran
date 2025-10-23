namespace Sankhya.Rupaantran
{
    /// <summary>
    /// A utility class to convert numeric values into
    /// Indian (Lakh, Crore) and International (Million, Billion) numbering systems.
    /// </summary>
    public static class SankhyaRupaantran
    {
        // --- Divisors as decimals for precision ---
        private const decimal oneLakh = 100_000m;
        private const decimal oneCrore = 10_000_000m;
        private const decimal oneMillion = 1_000_000m;
        private const decimal oneBillion = 1_000_000_000m;

        #region --- Indian Numbering System (Decimal) ---

        /// <summary>
        /// Converts a decimal value to its equivalent in Lakhs.
        /// </summary>
        /// <param name="amount">The value to convert.</param>
        /// <returns>The value in Lakhs.</returns>
        public static decimal ToLakhs(decimal amount)
        {
            return amount / oneLakh;
        }

        /// <summary>
        /// Converts a decimal value to its equivalent in Crores.
        /// </summary>
        /// <param name="amount">The value to convert.</param>
        /// <returns>The value in Crores.</returns>
        public static decimal ToCrores(decimal amount)
        {
            return amount / oneCrore;
        }

        #endregion

        #region --- International Numbering System (Decimal) ---

        /// <summary>
        /// Converts a decimal value to its equivalent in Millions.
        /// </summary>
        /// <param name="amount">The value to convert.</param>
        /// <returns>The value in Millions.</returns>
        public static decimal ToMillions(decimal amount)
        {
            return amount / oneMillion;
        }

        /// <summary>
        /// Converts a decimal value to its equivalent in Billions.
        /// </summary>
        /// <param name="amount">The value to convert.</param>
        /// <returns>The value in Billions.</returns>
        public static decimal ToBillions(decimal amount)
        {
            return amount / oneBillion;
        }
        #endregion

        #region --- String Formatting ---
        /// <summary>
        /// Formats the given amount in Lakhs as a string.
        /// </summary>
        /// <param name="amount">The value to format.</param>
        /// <param name="format">The format string to use.</param>
        /// <returns>The formatted string.</returns>
        public static string ToLakhsString(decimal amount, string format = "N2")
        {
            return $"{ToLakhs(amount).ToString(format)} Lakhs";
        }

        /// <summary>
        /// Formats the given amount in Crores as a string.
        /// </summary>
        /// <param name="amount">The value to format.</param>
        /// <param name="format">The format string to use.</param>
        /// <returns>The formatted string.</returns>
        public static string ToCroresString(decimal amount, string format = "N2")
        {
            return $"{ToCrores(amount).ToString(format)} Crores";
        }

        /// <summary>
        /// Formats the given amount in Millions as a string.
        /// </summary>
        /// <param name="amount">The value to format.</param>
        /// <param name="format">The format string to use.</param>
        /// <returns>The formatted string.</returns>
        public static string ToMillionsString(decimal amount, string format = "N2")
        {
            return $"{ToMillions(amount).ToString(format)} Millions";
        }

        /// <summary>
        /// Formats the given amount in Billions as a string.
        /// </summary>
        /// <param name="amount">The value to format.</param>
        /// <param name="format">The format string to use.</param>              
        /// <returns>The formatted string.</returns>
        public static string ToBillionsString(decimal amount, string format = "N2")
        {
            return $"{ToBillions(amount).ToString(format)} Billions";
        }

        #endregion

        #region --- Overloads for double ---
        public static decimal ToLakhs(double amount)
        {
            return (decimal)amount / oneLakh;
        }

        public static decimal ToCrores(double amount)
        {
            return (decimal)amount / oneCrore;
        }

        public static decimal ToMillions(double amount)
        {
            return (decimal)amount / oneMillion;
        }

        public static decimal ToBillions(double amount)
        {
            return (decimal)amount / oneBillion;
        }

        public static string ToLakhsString(double amount, string format = "N2")
        {
            return $"{ToLakhs(amount).ToString(format)} Lakhs";
        }

        public static string ToCroresString(double amount, string format = "N2")
        {
            return $"{ToCrores(amount).ToString(format)} Crores";
        }

        public static string ToMillionsString(double amount, string format = "N2")
        {
            return $"{ToMillions(amount).ToString(format)} Millions";
        }

        public static string ToBillionsString(double amount, string format = "N2")
        {
            return $"{ToBillions(amount).ToString(format)} Billions";
        }
        #endregion

        #region --- Overloads for float ---
        public static float ToLakhs(float amount)
        {
            return amount / (float)oneLakh;
        }
        public static float ToCrores(float amount)
        {
            return amount / (float)oneCrore;
        }
        public static float ToMillions(float amount)
        {
            return amount / (float)oneMillion;
        }
        public static float ToBillions(float amount)
        {
            return amount / (float)oneBillion;
        }
        public static string ToLakhsString(float amount, string format = "N2")
        {
            return $"{ToLakhs(amount).ToString(format)} Lakhs";
        }
        public static string ToCroresString(float amount, string format = "N2")
        {
            return $"{ToCrores(amount).ToString(format)} Crores";
        }
        public static string ToMillionsString(float amount, string format = "N2")
        {
            return $"{ToMillions(amount).ToString(format)} Millions";
        }
        public static string ToBillionsString(float amount, string format = "N2")
        {
            return $"{ToBillions(amount).ToString(format)} Billions";
        }
        #endregion

        #region --- Overloads for long ---
        public static decimal ToLakhs(long amount)
        {
            return amount / oneLakh;
        }
        public static decimal ToCrores(long amount)
        {
            return amount / oneCrore;
        }
        public static decimal ToMillions(long amount)
        {
            return amount / oneMillion;
        }
        public static decimal ToBillions(long amount)
        {
            return amount / oneBillion;
        }
        public static string ToLakhsString(long amount, string format = "N2")
        {
            return $"{ToLakhs(amount).ToString(format)} Lakhs";
        }
        public static string ToCroresString(long amount, string format = "N2")
        {
            return $"{ToCrores(amount).ToString(format)} Crores";
        }
        public static string ToMillionsString(long amount, string format = "N2")
        {
            return $"{ToMillions(amount).ToString(format)} Millions";
        }
        public static string ToBillionsString(long amount, string format = "N2")
        {
            return $"{ToBillions(amount).ToString(format)} Billions";
        }
        #endregion

        #region --- Overloads for int ---
        public static decimal ToLakhs(int amount)
        {
            return amount / oneLakh;
        }
        public static decimal ToCrores(int amount)
        {
            return amount / oneCrore;
        }
        public static decimal ToMillions(int amount)
        {
            return amount / oneMillion;
        }
        public static decimal ToBillions(int amount)
        {
            return amount / oneBillion;
        }
        public static string ToLakhsString(int amount, string format = "N2")
        {
            return $"{ToLakhs(amount).ToString(format)} Lakhs";
        }
        public static string ToCroresString(int amount, string format = "N2")
        {
            return $"{ToCrores(amount).ToString(format)} Crores";
        }
        public static string ToMillionsString(int amount, string format = "N2")
        {
            return $"{ToMillions(amount).ToString(format)} Millions";
        }
        public static string ToBillionsString(int amount, string format = "N2")
        {
            return $"{ToBillions(amount).ToString(format)} Billions";
        }
        #endregion
    }
}