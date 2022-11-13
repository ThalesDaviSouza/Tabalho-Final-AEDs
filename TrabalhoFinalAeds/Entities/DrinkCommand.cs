namespace TrabalhoFinalAeds.Entities {
    public class DrinkCommand : Command{
        public override void AddConsumption(Item consumption) {
            DrinkItem? item = consumption as DrinkItem;
            if (item != null) {
                base.AddConsumption(item);
            } 
        }
    }
}
