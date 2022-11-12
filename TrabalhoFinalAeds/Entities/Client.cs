namespace TrabalhoFinalAeds.Entities {
    public class Client {
        public string? Name { get; private set; }
        public string? Email { get; private set; }

        public Client() { }
        public Client(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return $"Client's Name: {Name}\nClient's Email: {Email}";
        }

    }
}
