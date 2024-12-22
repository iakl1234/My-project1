using TMPro;
using UnityEngine;

public class ProfileAutentification : Page
{
    public TMP_InputField Email;
    public TMP_InputField Password;
    public TextMeshProUGUI Notification;
    private void Awake()
    {
        buttonBackActive = true;
        buttonNewActive = false;
        labelActive = true;
        labelText = "Авторизация";
    }
    public void Autorization()
    {

        if (Email.text == "" || Password.text=="")
        {
            Notification.enabled = true;
        }
        else
        {
            Debug.Log(Email.text);
            FirebaseManager.Instance.SignInUser(Email.text, Password.text);
            Main.main.user.authorized = true;
            Main.main.OpenEntrance();
        }
    }

}
