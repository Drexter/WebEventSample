using System;
using WebApplication1.Infrastructure.Events;

namespace WebApplication1.Infrastructure.ViewInterfaces
{
    public interface IDefaultView
    {
        string SomeText { get; set; }
        event EventHandler<ShowTextEventArgs> ViewShowText;
    }
}
