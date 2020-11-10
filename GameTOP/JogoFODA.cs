namespace GameTOP
{
   
       public class JogoFODA
    {
        private readonly Jogador _jogador;
    
    public class JogoFoda
  
        public JogoFoda(Jogador jogador)
        {
            _jogador = jogador;
        }
        public void IniciarJogo()
        {
            _jogador.corre();
            _jogador.chuta();
            _jogador.passe();
        }

    }
}