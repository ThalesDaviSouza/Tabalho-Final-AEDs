using System.Collections.Generic;
using System.Text;

using TrabalhoFinalAeds.Entities.Enums;

namespace TrabalhoFinalAeds.Entities {
    public class Command {
        public List<Item> Consumption { get; private set; }
        public double Value { get; private set; }
        public CommandStatus Status { get; private set; }

        public Command() {
            Consumption = new List<Item>();
            Status = CommandStatus.Open;
            Value = 0;
        }
        
        public virtual void AddConsumption(Item consumption) {
            Consumption.Add(consumption);
            Value += consumption.Value;
        }
        public Item[] ListConsumption() {
            return Consumption.ToArray();
        }
        public void OpenCommand() {
            Status = CommandStatus.Open;
        }
        public void CloseCommand() {
            Status = CommandStatus.Closed;
        }
        public double CalculateTenPercent() {
            return (Value * 0.1);
        }
        public double SplitBill(double numberPersons) {
            return Value / numberPersons;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            if(Consumption.Count > 0) {
                foreach(Item i in Consumption) {
                    sb.AppendLine(i.ToString());
                }
                sb.AppendLine($"Tip: {CalculateTenPercent().ToString("F2")}");
                sb.Append($"Total value: {(Value+CalculateTenPercent()).ToString("F2")}");
            }else {
                sb.AppendLine("Nothing yet.");
            }

            return sb.ToString();
        }
    }
}
