

namespace MediatorProyectoFinal
{
    internal class Mediator : IMediator
    {
        private List<IColleague> colleagues;
        public Mediator()
        {
            colleagues = new List<IColleague>();
        }

        public void Agregar(IColleague colleague)
        {
            this.colleagues.Add(colleague);
        }
        public void Enviar(string mensaje, IColleague colleague)
        {
            foreach(IColleague c in colleagues)
            {
                if(c != colleague)
                {
                    c.Recibir(mensaje);
                }
            }
        }
    }
}
