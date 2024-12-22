using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CardEvent : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Max_members;
    public TextMeshProUGUI Age_limit;
    public TextMeshProUGUI Cost;
    public TextMeshProUGUI Date;
    public TextMeshProUGUI Adres;
    public GameObject Photo;
    public GameObject Like_image;
    public Event newEvent;

    public void Init(Event newEvent)
    {
        this.Name.text = newEvent.event_name;
        this.Max_members.text = newEvent.event_max_members;
        this.Age_limit.text = newEvent.event_age_limit;
        this.Cost.text = newEvent.event_cost;
        this.Date.text = newEvent.event_date;
        this.Adres.text = newEvent.event_adres;
        //if (newEvent.event_like) this.Like_image.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<Sprite>("Icon/Ivent_info/Like_on");
        this.newEvent = newEvent;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //newEvent = new Event("1","12","122","122","22.22.22","Ivanovo","Mde");
    }
    public void OpenEventInfo()
    {
        Main.main.OpenIventInfo(newEvent);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
