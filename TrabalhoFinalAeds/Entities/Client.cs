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
