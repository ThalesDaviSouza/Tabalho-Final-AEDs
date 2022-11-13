using System.Collections.Generic;
using System.Text;

namespace TrabalhoFinalAeds.Entities {
    public class Restaurant {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public List<Table> Tables { get; private set; } = new List<Table>();
        
        public Restaurant(string name, string adress) {
            Name = name;
            Adress = adress;
        }

        public void AddTable(Table table) {
            Tables.Add(table);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name}, {Adress}");
            foreach(Table t in Tables) {
                sb.AppendLine(t.ToString());
            }

            return sb.ToString();
        }
    }
}
