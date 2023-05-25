using _Scripts.Singletons;
using _Scripts.Spider;
using UnityEngine;

namespace SpiderAPI.Spider;
///<summary>
///This class contains functions related to the current player.
///</summary>
public class PlayerAPI {
    public static GameObject currentSpider;
    public static BodyMovement currentBodyMovement;
    internal static void InitAPI(string name) {
        currentBodyMovement = GameController.instance.player;
        currentSpider = currentBodyMovement.gameObject;
        
    }
    public static void SetDrunkMode(bool drunk) {
        currentBodyMovement.SetDrunk(drunk);
    }
    public static void SetPlayerSize(float size) {
        currentSpider.transform.localScale = new Vector3(size, size, size);
        currentBodyMovement.masterLegController.stepTime = 0.03f * size;
        currentBodyMovement.movementSpeed = 10f * size;
        currentBodyMovement.masterLegController.stepHeight = 0.2f * size;
        currentBodyMovement.masterLegController.stepDistance = 1f * size;
        currentBodyMovement.masterLegController.tipHeight = 0.5f * size;
    }
}