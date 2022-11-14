namespace TrabalhoFinalAeds.Entities {
    public class TesteRestaurante {
        public static void Run() {
            Restaurant BuchinhoCheio = new Restaurant("Buchinho Cheio", "Barker Street 221B");
            Table t4 = new Table(4, DateTime.Now, Enums.TableStatus.Free);
            t4.AddClient(new Client("Eduardo", "EduEmail.com"));
            t4.AddClient(new Client("Eduardo2", "Edu2Email.com"));
            t4.AddClient(new Client("Bongo", "Bongo.com"));
            t4.AddConsumption(new DrinkItem("Fanta laranja", 4.5, 250));
            t4.AddConsumption(new FoodItem("Pizza Gigante", 45.68, 300));
            t4.AddConsumption(new FoodItem("Pudim", 17.8, 50));
            BuchinhoCheio.AddTable(t4);

            Table t5 = new Table(5, DateTime.Now, Enums.TableStatus.Reserved);
            t5.AddClient(new Client("Thales", "ThEmail.com"));
            t5.AddConsumption(new DrinkItem("Vinho do Porto", 120.65, 1000));
            t5.AddConsumption(new FoodItem("Porçao de Peixes", 68.2, 750));
            t5.CloseCommand();
            BuchinhoCheio.AddTable(t5);

            Console.WriteLine(BuchinhoCheio);
        }
    }
}
