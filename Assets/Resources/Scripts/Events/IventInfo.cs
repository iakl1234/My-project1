using TMPro;
using UnityEngine;

public class IventInfo : Page
{

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Max_members;
    public TextMeshProUGUI Age_limit;
    public TextMeshProUGUI Cost;
    public TextMeshProUGUI Date;
    public TextMeshProUGUI Adres;
    public TextMeshProUGUI Description;
    public GameObject Photo;
    public GameObject Like_image;


    private void Awake()
    {
        buttonBackActive = true;
        buttonNewActive = false;
        labelActive = true;
    }
    public void Init(Event newEvent)
    {
        this.Name.text = newEvent.event_name;
        Main.main.Rename_header(newEvent.event_name);
        this.Max_members.text = newEvent.event_max_members;
        this.Age_limit.text = newEvent.event_age_limit;
        this.Cost.text = newEvent.event_cost;
        this.Date.text = newEvent.event_date;
        this.Adres.text = newEvent.event_adres;
        this.Description.text = newEvent.event_description;

        //if (newEvent.event_like) this.Like_image.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<Sprite>("Icon/Ivent_info/Like_on");
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
