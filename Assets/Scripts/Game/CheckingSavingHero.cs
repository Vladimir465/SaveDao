using Game.Dao.HeroParams;
using UnityEngine;
using Zenject;

namespace Game
{
    public class CheckingSavingHero : MonoBehaviour
    {
        [Inject] private IHeroParamsState _heroParamsState;
        
        public void TakeAwayHealth()
        {
            _heroParamsState.Health = -10;
        }
        
        public void AddExperience()
        {
            _heroParamsState.Experience = 10;
        }
    }
}