using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneMoveManager : MonoBehaviour
{
   public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
