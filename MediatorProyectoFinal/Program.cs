
namespace MediatorProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediador = new Mediator();

            IColleague xQueti = new Usuario(mediador);
            IColleague xAdmin = new UsuarioAdmin(mediador);
            IColleague xQueti2 = new UsuarioAdmin(mediador);
            IColleague xAdmin2 = new UsuarioAdmin(mediador);

            mediador.Agregar(xQueti);
            mediador.Agregar(xAdmin);
            mediador.Agregar(xQueti2);
            mediador.Agregar(xAdmin2);

            xQueti.Comunicar("que rollo krnal");

            xAdmin.Comunicar("nancy aki al 100 krnaval ytlyk");

            xQueti2.Comunicar("un saludito");

            xAdmin2.Comunicar("a la orden pal desorden");


        }
    }
}