using Core.Dao.Impls;
using UnityEngine;
using Zenject;

namespace Game.Dao.HeroParams.Impls
{
    public class HeroParamsState : APersistenceState<IHeroParamsDao, HeroParamsVo>, IHeroParamsState, IInitializable
    {
        private const int START_VALUE_HEALTH = 100;

        private HeroParamsVo _vo;

        public HeroParamsState(IHeroParamsDao dao) : base(dao)
        {
        }

        public void Initialize()
        {
            _vo = Dao.Exist() ? Dao.Load() : new HeroParamsVo()
                {
                    health = START_VALUE_HEALTH,
                    experience = 0
                };
        }

        public int Health
        {
            get => _vo.health;
            set
            {
                _vo.health += value;
                Debug.Log("HP - " + _vo.health);
                SetDirty();
            }
        }

        public int Experience
        {
            get => _vo.experience;
            set
            {
                _vo.experience += value;
                Debug.Log("Ex - " + _vo.experience);
                SetDirty();
            }
        }

        protected override HeroParamsVo ConvertToState() => _vo;
    }
}