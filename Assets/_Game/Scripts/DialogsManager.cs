using Doublsb.Dialog;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogsManager : MonoBehaviour
{
    public DialogManager dialogManager;
    // Start is called before the first frame update
    Func<string, string> color = c => $"/color:{c}/";
    void Start()
    {
        string green = color("green");
        DialogData dialogData = new DialogData($"Hi, my name is {green}/size:up/Roy/size:down//color:white//click/, Nice to meet you!/click//close/", "Roy");
        dialogManager.Show(dialogData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
