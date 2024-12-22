using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileRegi : Page
{
    public TMP_InputField Email;
    public TMP_InputField Password;
    public TMP_InputField ConfirmPassword;
    public TextMeshProUGUI NotificationPassword;
    public TextMeshProUGUI NotificationEmail;
    private bool confirmEmail=false;
    private bool confirmPassword = false;

    private void Awake()
    {
        buttonBackActive = true;
        buttonNewActive = false;
        labelActive = true;
        labelText = "Регистрация";
    }
    public void CheckPassword()
    {
        if (ConfirmPassword.text == Password.text && Password.text!="" && ConfirmPassword.text != "")
        {
            NotificationPassword.enabled=false;
            confirmPassword = true;
        }
        else
        {
            NotificationPassword.text = "Пароли не совпадают";
            NotificationPassword.enabled = true;
            confirmPassword = false;
        }
    }
    public void CheckEmail()
    {
        if (Email.text != null)
        {
            NotificationEmail.enabled = false;
            confirmEmail = true;
        }
        else
        {
            NotificationEmail.enabled = true;
            confirmEmail = false;
        }
    }
    public void Registration()
    {
        try
        {
            if (confirmEmail && confirmPassword)
            {
                FirebaseManager.Instance.RegisterUser(Email.text, Password.text);
                Main.main.user.authorized = true;
                Main.main.OpenEntrance();
            }
            else
            {
                Debug.Log("Passord");
                Debug.Log(confirmPassword);
                Debug.Log("Email");
                Debug.Log(confirmEmail);
            }
            NotificationPassword.enabled = false;
        }
        catch
        {
            NotificationPassword.text = "Указанный email занят,указан неверно или введен слабый пароль";
            NotificationPassword.enabled = true;
        }


    }
}
