
namespace MediatorProyectoFinal
{
    class Usuario : IColleague
    {
        public Usuario(IMediator mediator) : base(mediator)
        {

        }
        public override void Recibir(string mensaje)
        {
            Console.WriteLine("El usuario ha recibido el mensaje: " + mensaje);
        }
    }
}
