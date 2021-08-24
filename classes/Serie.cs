namespace DIO.series
{
    public class Serie : EntidadeBase
    {
        // Atributos   
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        // Métodos
        public Serie(int id, Genero genero, string Titulo, string Descricao, int Ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            //Environment.NewLine https://docs.microsoft.com/pt-br/dotnet/api/system.environmet.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero:  " + this.Genero;
            retorno += "\nTitulo:  " + this.Titulo;
            retorno += "\nDescrição:  " + this.Descricao;
            retorno += "\nAno de Início:  " + this.Ano;
            retorno += "\nExcluido:  " + this.Excluido;
            return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }


        internal int retornaId()
        {
            return this.Id;
        }
        internal bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Exclui()
        {
            this.Excluido = true;
        }
    }
}