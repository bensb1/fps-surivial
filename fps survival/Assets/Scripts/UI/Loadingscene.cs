using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadingscene : MonoBehaviour
{
     // [SerializeField] private string my_level;
  public void changeMenuScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}

