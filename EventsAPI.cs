using _Scripts.Singletons;
using SpiderAPI.Spider;
using UnityEngine.SceneManagement;

namespace SpiderAPI.Events;

public class EventsAPI {
    public delegate void OnLoadLevel(string levelName);
    public static event OnLoadLevel onLoadLevel;
    public delegate void OnStateChanged(GameController.GameState currentState, GameController.GameState lastState);
    public static event OnStateChanged onStateChanged;
    public static GameController.GameState currentState;
    public static GameController.GameState lastState;
    internal static void UpdateState(GameController.GameState state) {lastState = currentState; currentState = state; onStateChanged.Invoke(currentState, lastState);}
    internal static void OnSceneChanged(Scene scene, LoadSceneMode mode) {
        if (scene.name.ToLower().Contains("level")) {
            onLoadLevel.Invoke(scene.name.ToLower());
            PlayerAPI.SetPlayerSize(3f); 
        }
    }
    
}