using System.Collections.Generic;

namespace TrabalhoFinalAeds.Entities {
    public class Restaurante {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public List<Table> Tables { get; private set; } = new List<Table>();
        
        public Restaurante(string name, string adress) {
            Name = name;
            Adress = adress;
        }

        public void AddTable(Table table) {
            Tables.Add(table);
        }
    }
}
