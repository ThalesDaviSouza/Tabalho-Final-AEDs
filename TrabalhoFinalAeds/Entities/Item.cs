﻿namespace TrabalhoFinalAeds.Entities {
    public class Item {
        public string Name { get; private protected set; }
        public double Value { get; private protected set; }

        public Item(string name, double value) {
            Name = name;
            Value = value;
        }

        public override string ToString() {
            return $"{Name} - {Value.ToString("F2")}";
        }
    }
}
