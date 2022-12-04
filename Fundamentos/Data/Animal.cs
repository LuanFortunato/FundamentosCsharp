namespace DataApp
{
    public class Animal
    {
        public int Id { get; set; }
        public string Especie { get; set; }
        public string Habitat { get; set; }

        public int GetId()
        {
            return this.Id;
        }
    }

    public struct Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        
        public int GetId()
        {
            return this.Id;
        }
    }
}
