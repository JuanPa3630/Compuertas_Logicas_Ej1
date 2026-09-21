namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Representa el valor lógico falso.
    /// </summary>
    public class FalseValue : ILogicValue
    {
        /// <summary>
        /// Obtiene el valor falso.
        /// </summary>
        public bool value
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene el valor falso con convención PascalCase.
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