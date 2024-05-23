using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    [SerializeField] private Text spawnText;
    [SerializeField] public InputField numberInput;
    private int counter = 1;
    public int NUM_SPAWNS = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NUM_SPAWNS = int.Parse(numberInput.text);
    }

    /*public void onNumberEditted()
    {
        NUM_SPAWNS = int.Parse(numberInput.text);
    }*/

    public void onSpawnBallsButtonClicked()
    {
        Parameters Param = new Parameters();
        Param.PutExtra(SpawnSystem.NUM_SPAWNS_KEY, NUM_SPAWNS);
        EventBroadcaster.Instance.PostEvent(EventNames.XX22_Events.ON_SPAWN_BALLS_BUTTON_PRESSED, Param);
    
    }



    public void onSpawnCubesButtonClicked()
    {
        Parameters Param = new Parameters();
        Param.PutExtra(SpawnCubes.CUBE_SPAWNS_KEY, NUM_SPAWNS);
        EventBroadcaster.Instance.PostEvent(EventNames.XX22_Events.ON_SPAWN_CUBES_BUTTON_PRESSED, Param);
    }

    public void onMainMenuButtonClicked()
    {
        Parameters Param = new Parameters();
        EventBroadcaster.Instance.PostEvent(EventNames.XX22_Events.ON_MAIN_MENU_BUTTON_PRESSED, Param);

    }
}
