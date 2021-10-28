using System.Drawing;

namespace Encompass.Messages.MessageDetailObjects
{
    public enum ActionType
    {
        Remove,
        Add
    }
    public enum DisplayType
    {
        Information,
        Success,
        Warning,
        Failure
    }

    public interface IMessageDetail
    {
        string Id { get; set; }
        ActionType Action { get; set; }
        DisplayType Display { get; set; }
        bool CanDismiss { get; set; }
        string Title { get; set; }
        string Link { get; set; }
        string Text { get; set; }

        Color TitleBarColor { get; set; }
        Color TitleBarTextColor { get; set; }
        Color BackgroundColor { get; set; }
        Color TextColor { get; set; }
    }
}
