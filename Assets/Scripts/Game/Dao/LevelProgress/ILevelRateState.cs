namespace Game.Dao.LevelProgress
{
    public interface ILevelRateState
    {
        int GetLevelRate(int levelIndex);
        void SetLevelRate(int levelIndex, int result);
    }
}