using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    private Button button;
    private  CameraManager Manager;
  //  private PlayerController player;
    [SerializeField] private GameObject titleControls;
    [SerializeField] private GameObject Revert;
    [SerializeField] private GameObject buttonExit;
    [SerializeField] private GameObject titleScreen;
    void Start()
    {
        button = GetComponent<Button>();
        Manager = GameObject.Find("Manager").GetComponent<CameraManager>();
     //   player = GameObject.Find("Player").GetComponent<PlayerController>();

        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
   

    private void SetDifficulty()
    {
        Debug.Log(button.name + " Was clicked");
     //   player.StartGame();
       Manager.StartTheGame();
        titleControls.SetActive(true);
        buttonExit.SetActive(false);
       
        Destroy(Revert.gameObject);

        titleScreen.gameObject.SetActive(false);

    }
}
