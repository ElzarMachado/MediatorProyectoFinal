

namespace MediatorProyectoFinal
{
    public class UsuarioAdmin : IColleague
    {
        public UsuarioAdmin(IMediator mediator) : base(mediator)
        {

        }
        public override void Recibir(string mensaje)
        {
            Console.WriteLine("El administrador ha recibido el mensaje: " + mensaje);

        }
    }
    
}

