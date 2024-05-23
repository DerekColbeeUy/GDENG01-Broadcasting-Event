using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private GameObject template;
    [SerializeField] private List<GameObject> objectList;

    public const string NUM_SPAWNS_KEY = "NUM_SPAWNS_KEY";

    // Start is called before the first frame update
    void Start()
    {
        this.template.SetActive(false);

        EventBroadcaster.Instance.AddObserver(EventNames.XX22_Events.ON_SPAWN_BALLS_BUTTON_PRESSED, this.OnSpawnBallsEvent);
    }

    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.XX22_Events.ON_SPAWN_BALLS_BUTTON_PRESSED);
        this.template.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSpawnBallsEvent(Parameters param)
    {
        int numberSpawns = param.GetIntExtra(NUM_SPAWNS_KEY, 1);

        for (int i = 0; i < numberSpawns; i++)
        {

            GameObject instance = GameObject.Instantiate(this.template, this.transform);
            instance.SetActive(true);
            this.objectList.Add(instance);
        }
        
    }
}
