using Core.Dao.Impls;

namespace Game.Dao.HeroParams.Impls
{
    public class HeroParamsDao : APersistenceDao<HeroParamsVo>, IHeroParamsDao
    {
        public HeroParamsDao(string fileName) : base(fileName)
        {
        }
    }
}