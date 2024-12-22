using UnityEngine;

public class Page : MonoBehaviour
{
    internal bool buttonBackActive;
    internal bool buttonNewActive;
    internal bool labelActive;
    internal string labelText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Main.main.HeaderSetting(buttonBackActive, buttonNewActive, labelActive, labelText);
        Main.main.Button_new.onClick.RemoveAllListeners();
        Main.main.Button_new.onClick.AddListener(() => onClick());
    }
    private void OnEnable()
    {
        Main.main.HeaderSetting(buttonBackActive, buttonNewActive, labelActive, labelText);
        Main.main.Button_new.onClick.RemoveAllListeners();
        Main.main.Button_new.onClick.AddListener(() => onClick());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    internal virtual void onClick()
    {
    }
}
