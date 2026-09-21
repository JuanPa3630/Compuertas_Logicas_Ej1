namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Implementa la compuerta lógica NOT.
    /// </summary>
    public class NotGate : IGate
    {
        private readonly ILogicValue input;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="NotGate"/>.
        /// </summary>
        /// <param name="input">Valor de entrada.</param>
        public NotGate(ILogicValue input)
        {
            this.input = input;
        }

        /// <summary>
        /// Obtiene el resultado de la evaluación.
        /// </summary>
        public bool output
        {
            get
            {
                return !this.input.value;
            }
        }

        /// <summary>
        /// Obtiene el resultado con convención PascalCase.
        /// </summary>
        public bool Output
        {
            get
            {
                return this.output;
            }
        }

        /// <summary>
        /// Obtiene el resultado como valor lógico.
        /// </summary>
        public bool value
        {
            get
            {
                return this.output;
            }
        }

        /// <summary>
        /// Obtiene el resultado como valor lógico con convención PascalCase.
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
