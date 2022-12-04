namespace DataApp
{
    public class Pessoa
    {
        private byte idade;
        private string nome;

        public void SetIdade(byte idade)
        {
            if (idade > 0)
                this.idade = idade;
        }

        public byte GetIdade()
        {
            return idade;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }
    }
}
