using TMPro;
using UnityEngine;

public class CreateEvent : Page
{
    public TMP_InputField Name;
    public TMP_InputField Max_members;
    public TMP_InputField Age_limit;
    public TMP_InputField Cost;
    public TMP_InputField Date;
    public TMP_InputField Adres;
    public TMP_InputField Description;
    public TextMeshProUGUI Notification;
    public GameObject Photo;

    private void Awake()
    {
        buttonBackActive = true;
        buttonNewActive = false;
        labelActive = true;
        labelText = "Новое мероприятие";
    }
    public void CreateEventButton()
    {
        Debug.Log("я здесь");
        if (Name.text != "" && Age_limit.text != "" && Max_members.text != "" && Cost.text != "" && Date.text != "" && Adres.text != "" && Description.text != "")
        {
            Debug.Log("Введены правильно");
            Notification.enabled = false;
            Event newEvent = new Event(Name.text, Age_limit.text, Max_members.text, Cost.text, Date.text, Adres.text, Description.text);
            FirebaseManager.Instance.AddEvent(newEvent);
            Main.main.Back();
        }
        else {
            Debug.Log("Введены неправильно");
            Notification.enabled = true;
        }

    }

}
