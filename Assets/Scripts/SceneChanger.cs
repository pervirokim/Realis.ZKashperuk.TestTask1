using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void MoveTo(string name)
    {
        if(name is not null)
        SceneManager.LoadScene(name.Trim());
    }
}
