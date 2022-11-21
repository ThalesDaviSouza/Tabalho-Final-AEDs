/* Trabalho Final de AEDs
 * 
 * Data: 13/11/2022
 * 
 * Integrantes do grupo: 
 * - Thales Davi de Souza
 * - Eduardo Santos Birchal
 * 
 */

namespace TrabalhoFinalAeds.Entities {
    public class DrinkItem : Item{
        public double Ml { get; private set; }
        public DrinkItem(string name, double value, double ml) : base(name, value) {
            Ml = ml;
        }
        public override string ToString() {
            return $"{Name}, {Ml.ToString("F2")}mL - {Value.ToString("F2")}";
        }
    }
}
