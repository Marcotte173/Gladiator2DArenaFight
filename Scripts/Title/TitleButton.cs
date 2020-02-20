using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public void TwoPlayer()
    {
        AgentInfo.players = 2;
        SceneManager.LoadScene("Select");
    }

    public void ThreePlayer()
    {
        AgentInfo.players = 3;
        SceneManager.LoadScene("Select");
    }

    public void FourPlayer()
    {
        AgentInfo.players = 4;
        SceneManager.LoadScene("Select");
    }
}
