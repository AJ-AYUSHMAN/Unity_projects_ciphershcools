using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntorUIScript : MonoBehaviour
{
    public GameObject instructionPanel;

    public void ToogleInstructionPanel(int toogle)
    {
        if (toogle == 1)
        {
            instructionPanel.SetActive(false);
        }
        else
        {
            instructionPanel.SetActive(true);
        }
    }

    public void ChangeCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        int nextIndex = currentScene.buildIndex + 1;

        SceneManager.LoadScene(nextIndex);
    }

}
