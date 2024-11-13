namespace NcSafari.Animals.Ability
{
    [Obsolete("Use IHunt, ISwim, or IFly instead", true)]
    internal interface IMove
    {
        void Move();
    }
}
