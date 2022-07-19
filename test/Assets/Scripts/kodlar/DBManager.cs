using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using UnityEngine.UI;

public class DBManager : MonoBehaviour
{
    public DatabaseReference usersRef;
    public InputField usernameInput, EmailInput, BscAddress;
    
    
    void Start()
    {
        StartCoroutine(Initilization());
    }

    private IEnumerator Initilization()
    {
        var task= FirebaseApp.CheckAndFixDependenciesAsync();
        while(!task.IsCompleted)
        {
            yield return null;
        }
        if(task.IsCanceled || task.IsFaulted)
        {
            Debug.LogError("Database Error: " + task.Exception);
        }
        
        var dependencyStatus = task.Result;
        if(dependencyStatus == DependencyStatus.Available)
        {
            usersRef = FirebaseDatabase.DefaultInstance.GetReference("Users");
            Debug.Log("Database çalışıyor.");
        }
        else
        {
            Debug.LogError("Database Error:");
        }

    }

    public void SaveUser()
    {
        string username = usernameInput.text;
        string Email = EmailInput.text;
        string Bsc = BscAddress.text;
        string rekor =  PlayerPrefs.GetInt("yuksekSkor").ToString();
        string altin= PlayerPrefs.GetInt("yuksekAltin").ToString();
        Dictionary<string,object> user = new Dictionary<string, object>();
        user["username"] = username;
        user["Email"] = Email;
        user["Bsc"] = Bsc;
        user["rekor"]=rekor;
        user["altin"]=altin;

        string key = usersRef.Push().Key;
        usersRef.Child(key).UpdateChildrenAsync(user);
        Debug.Log("Kayıt Başarılı");
        usernameInput.text=" ";
        EmailInput.text=" ";
        BscAddress.text=" ";

    }

}
