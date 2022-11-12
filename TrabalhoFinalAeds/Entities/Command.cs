using System.Collections.Generic;
using System.Text;

using TrabalhoFinalAeds.Entities.Enums;

namespace TrabalhoFinalAeds.Entities {
    public class Command {
        public List<string> Consumption { get; private set; } = new List<string>();
        public double Value { get; private set; } = 0;
        public CommandStatus Status { get; private set; } = CommandStatus.Open;

        public void AddConsumption(string consumption, double value) {
            Consumption.Add(consumption);
            Value += value;
        }
        public string[] ListConsumption() {
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
            sb.AppendLine($"Command status: {Status}");
            sb.AppendLine($"Consumption:");
            
            if(Consumption.Count > 0) {
                foreach(string s in Consumption) {
                    sb.AppendLine(s);
                }
            }else {
                sb.AppendLine("Nothing yet.");
            }

            sb.Append($"Total value: {Value.ToString("F2")}");

            return sb.ToString();
        }
    }
}
