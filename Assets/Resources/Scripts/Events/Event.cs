using System.Security.Cryptography;
using Unity.VisualScripting;
using Firebase.Firestore;


[System.Serializable]
public class Event
{
    public string event_name;        // Название мероприятия
    public string event_age_limit;   // Возрастное ограничение
    public string event_max_members; // Максимальное количество участников
    public string event_cost;        // Стоимость мероприятия
    public string event_date;        // Дата мероприятия
    public string event_adres;       // Адрес мероприятия
    public string event_description;  // Описание мероприятия

    // Конструктор для инициализации полей класса
    public Event(string name, string age_limit, string max_members, string cost, string date, string address, string description)
    {
        this.event_name = name;
        this.event_age_limit = age_limit;
        this.event_max_members = max_members;
        this.event_cost = cost;
        this.event_date = date;
        this.event_adres = address;  // Исправлено на 'address'
        this.event_description = description;
    }

}