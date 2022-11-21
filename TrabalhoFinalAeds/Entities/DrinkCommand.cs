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
    public class DrinkCommand : Command{
        public override void AddConsumption(Item consumption) {
            DrinkItem? item = consumption as DrinkItem;
            if (item != null) {
                base.AddConsumption(item);
            } 
        }
    }
}
