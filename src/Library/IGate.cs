namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Representa una compuerta lógica con una salida booleana.
    /// </summary>
    public interface IGate : ILogicValue
    {
        bool output { get; }
        bool Output { get; }
    }
}