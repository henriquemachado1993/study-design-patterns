using DesignPatternsApp.Patterns.Facade.SubSystems;

namespace DesignPatternsApp.Patterns.Facade
{
    public class HomeTheaterFacade
    {
        private Amplifier Amplifier;
        private DvdPlayer DvdPlayer;
        private Projector Projector;
        private Lights Lights;

        public HomeTheaterFacade(Amplifier amplifier, DvdPlayer dvdPlayer, Projector projector, Lights lights)
        {
            this.Amplifier = amplifier;
            this.DvdPlayer = dvdPlayer;
            this.Projector = projector;
            this.Lights = lights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Preparando o Home Theater para assistir um filme...");
            Amplifier.On();
            Amplifier.SetVolume(5);
            Lights.Dim();
            Projector.On();
            Projector.WideScreenMode();
            DvdPlayer.On();
            DvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Encerrando a exibição do filme...");
            Amplifier.Off();
            Lights.On();
            Projector.Off();
            DvdPlayer.Off();
        }
    }
}
