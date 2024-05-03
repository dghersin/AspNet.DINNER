using AspNet.DINNER.Models;

namespace AspNet.DINNER.Services
{
    public class DinnerService
    {
        public List<Dinner> GenerateDinnerMenu()
        {
            List<Dinner> dinnerMenu = new List<Dinner>();

            // Dodavanje jela u večernji meni
            dinnerMenu.Add(new Dinner { Id = 1, Name = "Pileći file s povrćem", Description = "Pečeni pileći file uz raznovrsno povrće", Price = 12.99, Comment = "Odlično jelo, toplo preporučujem!" });
            dinnerMenu.Add(new Dinner { Id = 2, Name = "Losos s rižom", Description = "Grilani losos poslužen s rižom i salatom", Price = 15.49, Comment = "Vrlo ukusno, definitivno ću ponovno naručiti." });
            dinnerMenu.Add(new Dinner { Id = 3, Name = "Piletina Alfredo", Description = "Tjestenina s umakom od vrhnja, piletinom i parmezanom", Price = 14.99, Comment = "Solidno jelo, ali nije me previše oduševilo." });
            dinnerMenu.Add(new Dinner { Id = 4, Name = "Teleći odrezak s pire krumpirom", Description = "Teleći odrezak na žaru uz pire krumpir", Price = 18.99, Comment = "Nisam bio zadovoljan, meso je bilo prežestoko." });
            dinnerMenu.Add(new Dinner { Id = 5, Name = "Pizza Margherita", Description = "Pizza s umakom od rajčice, mozzarellom i svježim bosiljkom", Price = 10.99, Comment = "Klasik koji nikad ne razočara!" });
            
            return dinnerMenu;
        }
    }
}
