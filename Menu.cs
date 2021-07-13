using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //for SceneManager

public class Menu : MonoBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) == true)
            {
                GlobalVariables.ShipPrefabName = hit.transform.gameObject.name;
                SceneManager.LoadScene("level01");
            }
        }
    }
}