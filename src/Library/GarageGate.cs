namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Representa la lógica de apertura del garaje: se abre si C está pulsado y A/B están en reposo,
    /// o si A, B y C están pulsados simultáneamente.
    /// </summary>
    public class GarageGate : IGate
    {
        private readonly ILogicValue a;
        private readonly ILogicValue b;
        private readonly ILogicValue c;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="GarageGate"/>.
        /// </summary>
        /// <param name="a">Estado del botón A.</param>
        /// <param name="b">Estado del botón B.</param>
        /// <param name="c">Estado del botón C.</param>
        public GarageGate(ILogicValue a, ILogicValue b, ILogicValue c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Obtiene si la puerta debe abrirse.
        /// </summary>
        public bool output
        {
            get
            {
                bool condition1 = this.c.value && !this.a.value && !this.b.value;
                bool condition2 = this.a.value && this.b.value && this.c.value;
                return condition1 || condition2;
            }
        }

        /// <summary>
        /// Obtiene si la puerta debe abrirse con convención PascalCase.
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
