using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onSpawnBallsButtonClicked()
    {
        Parameters Param = new Parameters();
        EventBroadcaster.Instance.PostEvent(EventNames.XX22_Events.ON_SPAWN_BALLS_BUTTON_PRESSED, Param);

    }

    public void onSpawnCubesButtonClicked()
    {
        Parameters Param = new Parameters();
        EventBroadcaster.Instance.PostEvent(EventNames.XX22_Events.ON_SPAWN_CUBES_BUTTON_PRESSED, Param);

    }

    public void onMainMenuButtonClicked()
    {
        Parameters Param = new Parameters();
        EventBroadcaster.Instance.PostEvent(EventNames.XX22_Events.ON_MAIN_MENU_BUTTON_PRESSED, Param);

    }
}
