using Firebase;
using UnityEngine;
using UnityEngine.Events;

public class FirebaseInit : MonoBehaviour
{
    public UnityEvent OnFirebaseLoaded = new();
    public UnityEvent OnFirebaseFailed = new();
    
    async void Start()
    {
        var dependencyStatus = await FirebaseApp.CheckDependenciesAsync();
        if(dependencyStatus == DependencyStatus.Available)
            OnFirebaseLoaded.Invoke();
        else
            OnFirebaseFailed.Invoke();
    }
}
