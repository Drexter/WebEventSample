using System;
using WebApplication1.Infrastructure.Events;
using WebApplication1.Presenter;
using WebApplication1.Infrastructure.ViewInterfaces;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page, IDefaultView
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            new DefaultPresenter(this);
           
        }

        #region Publish Events
        public event EventHandler<ShowTextEventArgs> ViewShowText;

        protected void btnShowText_Click(object sender, EventArgs e)
        {
            OnShowTextViewEvent();
        }
        
        protected void OnShowTextViewEvent()
        {
            if (ViewShowText != null)
            {
                ViewShowText(this, new ShowTextEventArgs(SomeText));
            }
        }
        
        #endregion
        
        #region IDefaultView Implementation

        public string SomeText
        {
            set { lblText.Text = value; }
            get { return lblText.Text; }
        }
        
        #endregion
    }
}