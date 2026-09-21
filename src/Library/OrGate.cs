namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Implementa la compuerta lógica OR.
    /// </summary>
    public class OrGate : IGate
    {
        private readonly ILogicValue input1;
        private readonly ILogicValue input2;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="OrGate"/>.
        /// </summary>
        /// <param name="input1">Primer valor de entrada.</param>
        /// <param name="input2">Segundo valor de entrada.</param>
        public OrGate(ILogicValue input1, ILogicValue input2)
        {
            this.input1 = input1;
            this.input2 = input2;
        }

        /// <summary>
        /// Obtiene el resultado de la evaluación.
        /// </summary>
        public bool output
        {
            get
            {
                return this.input1.value || this.input2.value;
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
