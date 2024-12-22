using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Extensions;
using Firebase.Firestore;
using Newtonsoft.Json;
using UnityEngine;


public class FirebaseManager : MonoBehaviour
{

    private  DatabaseReference databaseReference;
    private FirebaseAuth auth;
    const string url = "https://afisha-da516-default-rtdb.firebaseio.com/";
    public static FirebaseManager Instance;
    private FirebaseFirestore firestore;
    void Awake()
    {
        Instance = this;
        firestore = FirebaseFirestore.DefaultInstance;
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            Debug.Log("ff");
            if (task.IsFaulted)
            {
                Debug.LogError("Firebase initialization failed: " + task.Exception);
            }
            else if (task.IsCompleted)
            {
                databaseReference = FirebaseDatabase.GetInstance(url).RootReference;
            }
        });    
    }



    public void RegisterUser(string email,string password)
    {
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWithOnMainThread(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            // Пользователь успешно зарегистрирован
            FirebaseUser newUser = task.Result.User;
            Debug.LogFormat("Firebase user created successfully: {0} ({1})", newUser.DisplayName, newUser.UserId);
        });
    }
    public void SignInUser(string email, string password)
    {
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWithOnMainThread(task => {
            if (task.IsCanceled)
            {
                Debug.Log("SignInWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.Log("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            // Пользователь успешно вошел в систему
            FirebaseUser user = task.Result.User;
            Debug.LogFormat("User signed in successfully: {0} ({1})", user.DisplayName, user.UserId);
            
        });
    }
    public void AddEvent(Event newEvent)
    {

        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted)
            {
                Debug.LogError("Firebase initialization failed: " + task.Exception);
            }
            else if (task.IsCompleted)
            {
                databaseReference = FirebaseDatabase.GetInstance(url).RootReference;
                // Используем метод Push для создания уникального идентификатора
                string uniqueKey = Instance.databaseReference.Child("events").Push().Key; 
                string jsonData = JsonConvert.SerializeObject(newEvent);

                // Отправка данных в Firebase
                databaseReference.Child("events").Child(uniqueKey).SetValueAsync(jsonData).ContinueWithOnMainThread(task =>
                {
                    if (task.IsFaulted)
                    {
                        Debug.LogError("Data sending failed: " + task.Exception);
                    }
                    else if (task.IsCompleted)
                    {
                        Debug.Log("Data sent successfully!");
                    }
                });
            }
        });
    }

    public void GetEvents(System.Action<DataSnapshot> onComplete)
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted)
            {
                Debug.LogError("Firebase initialization failed: " + task.Exception);
                onComplete?.Invoke(null); // Передаем null в случае ошибки
            }
            else if (task.IsCompleted)
            {
                databaseReference.Child("events").GetValueAsync().ContinueWithOnMainThread(task =>
                {
                    if (task.IsCompleted && !task.IsFaulted)
                    {
                        DataSnapshot snapshot = task.Result;
                        onComplete?.Invoke(snapshot); // Вызываем коллбэк с результатом
                    }
                    else
                    {
                        Debug.LogError("Failed to retrieve events.");
                        onComplete?.Invoke(null); // Передаем null в случае ошибки
                    }
                });
            }
        });

    }

}
