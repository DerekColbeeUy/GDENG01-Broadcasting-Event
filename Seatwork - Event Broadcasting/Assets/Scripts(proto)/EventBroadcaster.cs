using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EventBroadcaster : MonoBehaviour
{
    private static EventBroadcaster _instance;

    public static EventBroadcaster Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("EventBroadcaster is null");
            }
            return _instance;
        }
    }

    private Dictionary<string, List<System.Action>> EventDictionary = new Dictionary<string, List<System.Action>>();

    public void AddObserver(string Event, System.Action Action)
    {
        if (EventDictionary.ContainsKey(Event))
        {
            EventDictionary[Event].Add(Action);
        }
        else
        {
            EventDictionary[Event] = new List<System.Action> { Action };
        }
    }

    public void RemoveObserver(string Event, System.Action Action)
    {
        if (EventDictionary.ContainsKey(Event))
        {
            EventDictionary[Event].Remove(Action);
            if (EventDictionary[Event].Count == 0)
            {
                EventDictionary.Remove(Event);
            }
        }
    }

    public void PostEvent(string Event, Parameter Param)
    {
        if (EventDictionary.ContainsKey(Event))
        {
            foreach (var Action in EventDictionary[Event])
            {
                Action.Invoke();
            }
        }
    }
}


