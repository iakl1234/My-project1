using UnityEngine;

public class Entrance : Page
{


    private void Awake()
    {
        buttonBackActive = false;
        buttonNewActive = false;
        labelActive = true;
        labelText = "����";
    }
    public void OpenRegistration()
    {
        Main.main.Open_Registration();
    }
    public void OpenAutentification()
    {
        Main.main.Open_Authorization();
    }
}
