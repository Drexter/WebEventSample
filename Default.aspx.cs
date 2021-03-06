﻿using System;
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
            var handler = ViewShowText;
            if (handler != null)
            {
                handler(this, new ShowTextEventArgs(TxtText1));
            }
        }
               
        #endregion
        
        #region IDefaultView Implementation

        public string TxtText1
        {
            get { return txtText1.Text; }
            set { txtText1.Text = value; }
        }

        public string SomeText
        {
            set { lblText.Text = value; }
            get { return lblText.Text; }
        }
        
        #endregion
    }
}