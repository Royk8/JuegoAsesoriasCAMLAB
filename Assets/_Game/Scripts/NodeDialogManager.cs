using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeDialogManager : MonoBehaviour
{
    public DialogBehaviour manager;
    public DialogNodeGraph dialog;


    void Start()
    {
        manager.StartDialog(dialog);
    }


}
