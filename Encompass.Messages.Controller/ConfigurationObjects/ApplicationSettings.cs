using System.Collections.Generic;

namespace Encompass.Messages.ConfigurationObjects
{
    public class ApplicationSettings
    {
        public string HeaderTitle { get; set; } = "Message Center";
        public string TriggerField { get; set; } = "CX.Update.Message";

        public List<ColorDetails> MessageColors { get; set; }

        public static ApplicationSettings CreateWithDefaults()
        {
            ApplicationSettings settings = new ApplicationSettings();

            settings.MessageColors = new List<ColorDetails>() {
                new ColorDetails() { Key = 0, BackColor = -2631681, TextColor = -16777184, TitleColor = -16777120, TitleTextColor = -1 },
                new ColorDetails() { Key = 1, BackColor = -4128832, TextColor = -16769024, TitleColor = -16752640, TitleTextColor = -1 },
                new ColorDetails() { Key = 2, BackColor = -64, TextColor = -14671872, TitleColor = -10461184, TitleTextColor = -1 },
                new ColorDetails() { Key = 3, BackColor = -16192, TextColor = -14680064, TitleColor = -10485760, TitleTextColor = -1 }
            };

            return settings;
        }
    }
}
