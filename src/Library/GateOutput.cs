namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Contiene un valor lógico ya evaluado para reutilizarlo como entrada.
    /// </summary>
    public class GateOutput : ILogicValue
    {
        private readonly bool valueToStore;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="GateOutput"/>.
        /// </summary>
        /// <param name="value">Valor lógico que se almacenará.</param>
        public GateOutput(bool value)
        {
            this.valueToStore = value;
        }

        /// <summary>
        /// Obtiene el valor almacenado.
        /// </summary>
        public bool value
        {
            get
            {
                return this.valueToStore;
            }
        }

        /// <summary>
        /// Obtiene el valor almacenado con convención PascalCase.
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