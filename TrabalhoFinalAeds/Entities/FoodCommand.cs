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
    public class FoodCommand : Command{
        public override void AddConsumption(Item consumption) {
            FoodItem? item = consumption as FoodItem; 
            if(item != null) {
                base.AddConsumption(consumption as FoodItem);
            }
        }
    }
}
