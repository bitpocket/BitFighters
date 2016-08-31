namespace Game
{
    public interface IGameHeader
    {
        string Name { get; set; }
        string Description { get; set; }
        int MinPlayer { get; set; }
        int MaxPlayer { get; set; }
    }
}