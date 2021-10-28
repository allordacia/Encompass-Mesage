using System.Drawing;

namespace Encompass.Messages.MessageDetailObjects
{
    public class MessageDetail : IMessageDetail
    {
        public string Id { get; set; }
        public ActionType Action { get; set; }
        public DisplayType Display { get; set; }
        public bool CanDismiss { get; set; }

        public string Title { get; set; }
        public string Link { get; set; } = string.Empty;
        public string Text { get; set; }

        public Color TitleBarColor { get; set; }
        public Color TitleBarTextColor { get; set; }
        public Color BackgroundColor { get; set; }
        public Color TextColor { get; set; }
    }
}
