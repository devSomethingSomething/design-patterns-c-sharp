namespace Facade
{
    public class Program
    {
        private static void Main()
        {
            new RoomFacade(
                new Light(),
                new Light(),
                new PC(),
                new Speakers()).Setup();
        }
    }

    public class Light
    {
        public void On() { }

        public void Off() { }
    }

    public class PC
    {
        public void On() { }

        public void Off() { }
    }

    public class Speakers
    {
        public void On() { }

        public void Off() { }

        public void SetVolume(int newVolume) { }

        public void Mute() { }
    }

    public class RoomFacade
    {
        private Light deskLight;
        private Light roomLight;

        private PC pc;

        private Speakers speakers;

        public RoomFacade(Light deskLight, Light roomLight, PC pc, Speakers speakers)
        {
            this.deskLight = deskLight;
            this.roomLight = roomLight;

            this.pc = pc;

            this.speakers = speakers;
        }

        public void Setup()
        {
            deskLight.On();
            roomLight.On();

            pc.On();

            speakers.On();
            speakers.SetVolume(50);
        }
    }
}
