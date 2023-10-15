using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public GameObject nameBoxOne;
    public GameObject nameBoxTwo;
    public GameObject OrphanageExterior;
    public GameObject OrphanageInteriror;
    public GameObject CourtRoom;
    public GameObject John;
    public GameObject Angela;
    public GameObject Judge;
    [SerializeField] TextMeshProUGUI Dialog;
    [SerializeField] TextMeshProUGUI nameOne;
    [SerializeField] TextMeshProUGUI nameTwo;
    int dialogPage = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && SceneManager.GetActiveScene().name == "John")
        {
            dialogPage++;

            switch (dialogPage)
            {
                case 1:
                    Dialog.text = "This is it, John. Just take a deep breath and go for it.";
                    break;

                case 2:
                    Dialog.text = "Hi, I'm John. My partener Sam and I heard wonderful things about this place and wanted to know more about adopting a child.";
                    break;

                case 3:
                    Dialog.text = "[Mother Angela turns her attention toward John with a warm smile.]";
                    break;

                case 4:
                    Dialog.text = "";
                    break;

                case 5:
                    Dialog.text = "";
                    break;

                case 6:
                    Dialog.text = "";
                    break;
            }
        }
    }
}
