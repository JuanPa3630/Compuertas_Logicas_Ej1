namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Representa el valor lógico verdadero.
    /// </summary>
    public class TrueValue : ILogicValue
    {
        /// <summary>
        /// Obtiene el valor verdadero.
        /// </summary>
        public bool value
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Obtiene el valor verdadero con convención PascalCase.
        /// </summary>
        public bool Value
        {
            get
            {
                return this.value;
            }
        }
    }
}