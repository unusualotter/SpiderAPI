using _Scripts.Singletons;
using HarmonyLib;
using SpiderAPI.Events;

namespace SpiderAPI;

[HarmonyPatch(typeof(GameController), nameof(GameController.state), MethodType.Setter)]
internal class StateReporter {
    static void Prefix(ref GameController.GameState value) {
        EventsAPI.UpdateState(value);
    }
}