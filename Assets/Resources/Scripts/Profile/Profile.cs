using UnityEngine;

public class Profile: Page
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        buttonBackActive = false;
        buttonNewActive = false;
        labelActive = true;
        labelText = "Профиль";
    }
}
