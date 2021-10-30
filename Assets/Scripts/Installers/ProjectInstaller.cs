using Game.Dao.HeroParams.Impls;
using Game.Dao.LevelProgress.Impls;
using Zenject;

namespace Installers
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindDao();
        }

        private void BindDao()
        {
            Container.BindInterfacesTo<LevelRateDao>().AsSingle().WithArguments("level_rate.json");
            Container.BindInitializableExecutionOrder<LevelRateState>(-10000);
            Container.BindInterfacesTo<LevelRateState>().AsSingle();
            Container.BindInterfacesTo<HeroParamsDao>().AsSingle().WithArguments("params_rate.json");
            Container.BindInitializableExecutionOrder<HeroParamsState>(-9999);
            Container.BindInterfacesTo<HeroParamsState>().AsSingle();
        }
    } 
}