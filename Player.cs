using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //for SceneManager

public class Player : MonoBehaviour
{
    public float xspeed = 3.5f;
    public GameObject prefabShip1 = null;
    public GameObject prefabShip2 = null;
    private GameObject model = null;

    private void Start()
    {
        switch (GlobalVariables.ShipPrefabName)
        {
            case "TFighter299":
                model = Instantiate(prefabShip1, this.transform);
                break;
            case "XFighter672":
                model = Instantiate(prefabShip2, this.transform);
                break;
        }
    }
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        this.transform.Translate(new Vector3(xspeed * x * Time.deltaTime, 0.0f, 0.0f));

        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            SceneManager.LoadScene("Menu");
        }

        SwitchShips();

    }
    private void SwitchShips()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) == true)
        {
            GameObject.Destroy(model);
            model = Instantiate(prefabShip1, this.transform, true);
            Debug.Log("ship 1 chosen");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) == true)
        {
            GameObject.Destroy(model);
            model = Instantiate(prefabShip2, this.transform, true);
            Debug.Log("ship 2 chosen");
        }
    }
}