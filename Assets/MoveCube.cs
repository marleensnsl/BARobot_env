using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlus : MonoBehaviour
{
    public Button ButtonHoloLens1;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = ButtonHoloLens1.GetComponent<Button>();
        btn.onClick.AddListener(MoveCube);
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        // Update is called once per frame
    }
    void Update()
    {
        
    }
}
