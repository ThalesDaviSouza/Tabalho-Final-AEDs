namespace TrabalhoFinalAeds.Entities {
    public class FoodCommand : Command{
        public override void AddConsumption(Item consumption) {
            FoodItem? item = consumption as FoodItem; 
            if(item != null) {
                base.AddConsumption(consumption as FoodItem);
            }
        }
    }
}
