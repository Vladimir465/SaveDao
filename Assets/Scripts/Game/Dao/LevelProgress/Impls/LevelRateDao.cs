using Core.Dao.Impls;

namespace Game.Dao.LevelProgress.Impls
{
    public class LevelRateDao : APersistenceDao<LevelRateVo>, ILevelRateDao
    {
        public LevelRateDao(string fileName) : base(fileName)
        {
        }
    }
}