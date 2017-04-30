using WebApplication1.Infrastructure.Events;
using WebApplication1.Infrastructure.ViewInterfaces;

namespace WebApplication1.Presenter
{
    public class DefaultPresenter
    {
        private readonly IDefaultView _view;
        public DefaultPresenter(IDefaultView view)
        {
           _view = view;
           _view.ViewShowText += ViewShowText1;
        }

        #region Subscriber events
        
        private void ViewShowText1(object sender, ShowTextEventArgs e)
        {
            if (e.Message != null)
            {
                _view.SomeText = e.Message;
            }
        }
        
        #endregion

    }
}