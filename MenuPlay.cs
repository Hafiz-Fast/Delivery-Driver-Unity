using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPlay : MonoBehaviour
{
    public void Getgame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Close()
    {
        Application.Quit();
    }
}
