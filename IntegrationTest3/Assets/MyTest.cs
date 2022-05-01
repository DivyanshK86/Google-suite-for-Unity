using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using TMPro;

public class MyTest : MonoBehaviour
{
    public TextMeshProUGUI tmp;

    public void Start()
    {
        PlayGamesPlatform.Activate();
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
    }

    internal void ProcessAuthentication(bool status)
    {
        if (status)
        {
            // Continue with Play Games Services
            tmp.text = Social.localUser.userName;
        }
        else
        {
            // Disable your integration with Play Games Services or show a login button
            // to ask users to sign-in. Clicking it should call
            // PlayGamesPlatform.Instance.ManuallyAuthenticate(ProcessAuthentication).
            tmp.text = "sign in failed";
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            tmp.text = Social.localUser.userName;
    }
}
