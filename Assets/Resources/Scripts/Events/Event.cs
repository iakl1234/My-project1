using System.Security.Cryptography;
using Unity.VisualScripting;
using Firebase.Firestore;


[System.Serializable]
public class Event
{
    public string event_name;        // �������� �����������
    public string event_age_limit;   // ���������� �����������
    public string event_max_members; // ������������ ���������� ����������
    public string event_cost;        // ��������� �����������
    public string event_date;        // ���� �����������
    public string event_adres;       // ����� �����������
    public string event_description;  // �������� �����������

    // ����������� ��� ������������� ����� ������
    public Event(string name, string age_limit, string max_members, string cost, string date, string address, string description)
    {
        this.event_name = name;
        this.event_age_limit = age_limit;
        this.event_max_members = max_members;
        this.event_cost = cost;
        this.event_date = date;
        this.event_adres = address;  // ���������� �� 'address'
        this.event_description = description;
    }

}