

namespace MediatorProyectoFinal
{
    public abstract class IColleague
    {
        private IMediator mediator;

        public IMediator Mediator
        {
            get;
        }

        public IColleague(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void Comunicar(string mensaje)
        {
            this.mediator.Enviar(mensaje, this);
        }
        public abstract void Recibir(string mensaje);
    }
}
