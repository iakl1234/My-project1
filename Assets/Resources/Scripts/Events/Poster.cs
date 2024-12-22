using System.Threading.Tasks;
using Firebase.Database;
using Google.MiniJSON;
using UnityEngine;
using Newtonsoft.Json;
using System.Collections.Generic;
using Firebase.Extensions;

public class Poster : Page
{
    public GameObject PosterContainer;
    private GameObject Prefab;

    void Awake()
    {
        buttonBackActive = false;
        buttonNewActive = true;
        labelActive = true;
        labelText = "Афиша";
        FirebaseManager.Instance.GetEvents(snapshot =>
        {
            if (snapshot != null)
            {
                foreach (var child in snapshot.Children)
                {
                    Event myEvent = JsonConvert.DeserializeObject<Event>(child.Value.ToString());
                    Prefab = Instantiate(Resources.Load<GameObject>("Prefabs/Event"), PosterContainer.transform.position, Quaternion.identity);
                    Prefab.GetComponent<CardEvent>().Init(myEvent);
                    Prefab.transform.SetParent(PosterContainer.transform, false);
                }
            }
            else
            {
                Debug.LogError("No events found or failed to retrieve.");
            }
        });

    }
    internal override void onClick()
    {
        Main.main.OpenCreateEvent();
    }


}
