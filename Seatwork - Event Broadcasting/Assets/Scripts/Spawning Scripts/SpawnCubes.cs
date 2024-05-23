using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnCubes : MonoBehaviour
{
    [SerializeField] private GameObject template;
    [SerializeField]private List<GameObject> cubeList;

    public const string CUBE_SPAWNS_KEY = "CUBE_SPAWNS_KEY";
   

        // Start is called before the first frame update
    void Start() 
    {
        this.template.SetActive(false);

        EventBroadcaster.Instance.AddObserver(EventNames.XX22_Events.ON_SPAWN_CUBES_BUTTON_PRESSED, this.OnSpawnEvent);
    }

    // Update is called once per frame
    void Update() 
    { 
    }

    void OnDestroy()
    {
       EventBroadcaster.Instance.RemoveObserver(EventNames.XX22_Events.ON_SPAWN_CUBES_BUTTON_PRESSED);
       this.template.SetActive(false);
    }


    private void OnSpawnEvent(Parameters parameters)
    {
        int cubeSpawners = parameters.GetIntExtra(CUBE_SPAWNS_KEY,1);

        for (int i = 0; i < cubeSpawners; i++)
        {
            GameObject instance = GameObject.Instantiate(this.template, this.transform);
            instance.SetActive(true);
            this.cubeList.Add(instance);
        }

    }

  
}
