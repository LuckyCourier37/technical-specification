using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject FirstCamera;
    [SerializeField] private GameObject Person;
    [SerializeField] private GameObject LastCamera;
    [SerializeField] private OptionsUI settings;
    [SerializeField]private bool tumbler = false;
    private Vector3 SparePosition = new Vector3(20f, 1f, -16f);
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (!tumbler)
            {
                settings.ShowOptionsCopy(Person.gameObject.transform.position);
                ChangeCamera();
                tumbler = true;
            }
            else 
            {
               
                settings.CloseOptions();
                
                ChangeCamera();
                tumbler = false;
            }

        }

        if (Person.gameObject.transform.position.y < -10f )
        {
            Person.gameObject.transform.position = SparePosition;
        }
    }
    
    public void StartTheGame()
    {
        FirstCamera.SetActive(false);
        Person.SetActive(true);
    }

    private void ChangeCamera()
    {
        if (!tumbler)
        {
            FirstCamera.SetActive(true);
            LastCamera.SetActive(false);
        }
        else if (tumbler) {
            FirstCamera.SetActive(false);
            LastCamera.SetActive(true);

        }
       
    }


}
