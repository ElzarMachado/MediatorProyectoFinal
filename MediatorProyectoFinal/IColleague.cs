using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
