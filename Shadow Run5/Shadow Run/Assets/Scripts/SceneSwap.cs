using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
     
}
