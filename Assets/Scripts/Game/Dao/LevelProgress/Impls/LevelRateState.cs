using System;
using System.Collections.Generic;
using Core.Dao.Impls;
using Zenject;

namespace Game.Dao.LevelProgress.Impls
{
    public class LevelRateState : APersistenceState<ILevelRateDao, LevelRateVo>, ILevelRateState, IInitializable
    {
        private LevelRateVo _vo;

        public LevelRateState(ILevelRateDao dao) : base(dao)
        {
        }

        public void Initialize()
        {
            _vo = Dao.Exist() ? Dao.Load() : new LevelRateVo() {results = new List<int>()};
        }

        public int GetLevelRate(int levelIndex)
            => _vo.results.Count <= levelIndex ? 0 : _vo.results[levelIndex];

        public void SetLevelRate(int levelIndex, int result)
        {
            if (_vo.results.Count <= levelIndex)
                _vo.results.Add(result);
            else
                _vo.results[levelIndex] = result;
            
            SetDirty();
        }

        protected override LevelRateVo ConvertToState()
            => _vo;
    }
}