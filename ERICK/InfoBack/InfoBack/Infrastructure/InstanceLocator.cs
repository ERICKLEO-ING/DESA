
namespace InfoBack.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region MyRegion
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion
        #region Contructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
