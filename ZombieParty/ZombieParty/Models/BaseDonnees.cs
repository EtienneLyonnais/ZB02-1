namespace ZombieParty.Models
{
    public class BaseDonnees
    {
        public Guid idInstance { get; set; }
        public List<ZombieType> ZombieTypes { get; set; }
        public List<Zombie> Zombies { get; set; }

        public BaseDonnees()
        {
            idInstance = Guid.NewGuid();

            //Initialiser des listes vides
            Zombies = new List<Zombie>();
            ZombieTypes = new List<ZombieType>();

            //Remplir la liste des ZombieTypes
            {
                ZombieTypes.Add(new ZombieType() { TypeName = "Virus", Id = 1 });
                ZombieTypes.Add(new ZombieType() { TypeName = "Contact", Id = 2 });
                ZombieTypes.Add(new ZombieType() { TypeName = "Radioactif", Id = 3 });
            };

            //Remplir la liste des Zombies
            Zombies.Add(new Zombie() { Name = "LeChuck", Point = 5, ZombieTypeId = 2 });
            Zombies.Add(new Zombie() { Name = "Lenore", Point = 4, ZombieTypeId = 2 });
            Zombies.Add(new Zombie() { Name = "Draugr", Point = 2, ZombieTypeId = 3 });
            Zombies.Add(new Zombie() { Name = "Ragamuffin", Point = 5, ZombieTypeId = 1 });
            Zombies.Add(new Zombie() { Name = "Taxidermy", Point = 1, ZombieTypeId = 2 });
            Zombies.Add(new Zombie() { Name = "chien de l'enfer", Point = 7, ZombieTypeId = 1 });
            Zombies.Add(new Zombie() { Name = "Avogadro", Point = 9, ZombieTypeId = 3 });
        }

    }
}
