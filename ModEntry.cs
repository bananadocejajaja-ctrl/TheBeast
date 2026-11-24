
using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace TheBeast
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.DayStarted += OnDayStarted;

            Monitor.Log(
                "The Beast has awakened.",
                LogLevel.Info
            );
        }

        private void OnDayStarted(
            object? sender,
            DayStartedEventArgs e
        )
        {
            Monitor.Log(
                "Something is watching the valley...",
                LogLevel.Info
            );
        }
    }
}
