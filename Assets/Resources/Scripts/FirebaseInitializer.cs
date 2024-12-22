using Firebase;
using Firebase.Database;
using Firebase.Extensions;
using Firebase.Firestore;
using UnityEngine;


public class FirebaseInitializer : MonoBehaviour
{
    //private DatabaseReference reference;
    //public static FirebaseFirestore db;
    //// Создание нового события
    //private Event newEvent = new Event(
    //    "Concert",
    //    true,
    //    "18+",
    //    "100",
    //    "0",
    //    "December 19, 2024 at 12:00:00 AM UTC+3",
    //    "[0° N, 0° E]",
    //    "A great concert!"
    //);
    //void Awake()
    //{
    //    Debug.Log("ffff");
    //    // Проверка зависимостей
    //    FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task => {
    //        var dependencyStatus = task.Result;
    //        Debug.Log("ffff");
    //        if (dependencyStatus == DependencyStatus.Available)
    //        {
    //            Debug.Log("ffff");
    //            // Инициализация Firestore
    //            db = FirebaseFirestore.DefaultInstance; 
    //            Debug.Log("Firebase Firestore initialized successfully.");
    //        }
    //        else
    //        {
    //            Debug.Log("aaaaa");
    //            Debug.Log($"Could not resolve all Firebase dependencies: {dependencyStatus}");
    //        }
    //    });
    //}
    //public void NewEvent()
    //{


    //    // Добавление события в Firestore
    //    AddEvent(newEvent);
    //}

    //// Пример метода добавления события
    //public void AddEvent(Event eventData)
    //{
    //    if (FirebaseInitializer.db == null)
    //    {
    //        Debug.LogError("Firebase Firestore is not initialized.");
    //        return;
    //    }

    //    DocumentReference docRef = FirebaseInitializer.db.Collection("events").Document(eventData.event_name);

    //    // Сохранение данных о мероприятии
    //    docRef.SetAsync(eventData).ContinueWithOnMainThread(task => {
    //        if (task.IsCompleted)
    //        {
    //            Debug.Log("Event added successfully.");
    //        }
    //        else
    //        {
    //            Debug.LogError("Failed to add event.");
    //        }
    //    });
    //}
}
