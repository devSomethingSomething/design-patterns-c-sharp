using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class AFrame : Robot
    {
        private IRobotComponentFactory robotComponentFactory;

        public AFrame(IRobotComponentFactory robotComponentFactory)
        {
            this.robotComponentFactory = robotComponentFactory;
        }

        public override string Build()
        {
            material = robotComponentFactory.CreateMaterial();

            return $"Build robot with: {material.GetDescription()}";
        }
    }
}
