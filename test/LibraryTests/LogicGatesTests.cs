using NUnit.Framework;
using Ucu.Poo.Exercise;

namespace Ucu.Poo.Exercise.Tests
{
    public class LogicGatesTests
    {
        [Test]
        public void AndGate_InputsTrueTrue_OutputTrue()
        {
            AndGate gate = new AndGate(new TrueValue(), new TrueValue());

            Assert.That(gate.output, Is.True);
            Assert.That(gate.Output, Is.True);
        }

        [Test]
        public void OrGate_InputsFalseTrue_OutputTrue()
        {
            OrGate gate = new OrGate(new FalseValue(), new TrueValue());

            Assert.That(gate.output, Is.True);
            Assert.That(gate.Output, Is.True);
        }

        [Test]
        public void NotGate_InputTrue_OutputFalse()
        {
            NotGate gate = new NotGate(new TrueValue());

            Assert.That(gate.output, Is.False);
            Assert.That(gate.Output, Is.False);
        }

        [Test]
        public void GarageGate_ConditionCPressedAAndBRest_OutputTrue()
        {
            GarageGate gate = new GarageGate(new FalseValue(), new FalseValue(), new TrueValue());

            Assert.That(gate.output, Is.True);
            Assert.That(gate.Output, Is.True);
        }

        [Test]
        public void GarageGate_ConditionAAndBAndCPulsed_OutputTrue()
        {
            GarageGate gate = new GarageGate(new TrueValue(), new TrueValue(), new TrueValue());

            Assert.That(gate.output, Is.True);
            Assert.That(gate.Output, Is.True);
        }

        [Test]
        public void GarageGate_OtherCombinations_OutputFalse()
        {
            GarageGate gate = new GarageGate(new TrueValue(), new FalseValue(), new FalseValue());

            Assert.That(gate.output, Is.False);
            Assert.That(gate.Output, Is.False);
        }

        [Test]
        public void GarageGate_TruthTableFromDiagram_MatchesExpectedValues()
        {
            bool[,] expectedTable =
            {
                { false, false, false, false },
                { false, false, true, false },
                { false, true, false, false },
                { false, true, true, false },
                { true, false, false, true },
                { true, false, true, false },
                { true, true, false, false },
                { true, true, true, true },
            };

            for (int i = 0; i < expectedTable.GetLength(0); i++)
            {
                bool c = expectedTable[i, 0];
                bool b = expectedTable[i, 1];
                bool a = expectedTable[i, 2];
                bool expected = expectedTable[i, 3];

                ILogicValue inputA = CreateLogicValue(a);
                ILogicValue inputB = CreateLogicValue(b);
                ILogicValue inputC = CreateLogicValue(c);
                GarageGate gate = new GarageGate(inputA, inputB, inputC);

                Assert.That(gate.output, Is.EqualTo(expected), "Falla en la tabla de verdad del circuito del garaje.");
            }
        }

        private static ILogicValue CreateLogicValue(bool value)
        {
            if (value)
            {
                return new TrueValue();
            }

            return new FalseValue();
        }
    }
}
