namespace TrabalhoFinalAeds.Entities {
    public class FoodItem : Item{
        public double Mg { get; private set; }
        public FoodItem(string name, double value, double mg) : base(name, value) {
            Mg = mg;
        }
        public override string ToString() {
            return $"{Name}, {Mg.ToString("F2")} mg - {Value.ToString("F2")}";
        }
    }
}
