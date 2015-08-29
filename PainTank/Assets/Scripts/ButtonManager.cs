using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour
{

    public void Button_Play()
    {
        Application.LoadLevel("Battleground");
    }
    public void Button_Quit()
    {
        Application.Quit();
    }
    public void Button_Credits()
    {
        Application.LoadLevel("Credits");
    }
}
