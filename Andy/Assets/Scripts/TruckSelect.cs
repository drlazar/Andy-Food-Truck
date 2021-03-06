using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TruckSelect : MonoBehaviour
{
    public GameObject LeftTruck;
    public GameObject MidTruck;
    public GameObject RightTruck;
    public GameObject TruckSelected;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void SceneSwitch()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void SetTruck()
    {
        if (LeftTruck.transform.position == new Vector3(0.0f, 0.5f, 0.0f))
        {
            TruckSelected = LeftTruck;
        }
        else if (MidTruck.transform.position == new Vector3(0.0f, 0.5f, 0.0f))
        {
            TruckSelected = MidTruck;
        }
        else 
        {
            TruckSelected = RightTruck;
        }
    }
}
