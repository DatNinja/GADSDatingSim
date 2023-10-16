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
    public GameObject Fade;
    public GameObject John;
    public GameObject Angela;
    public GameObject Judge;
    [SerializeField] TextMeshProUGUI Dialog;
    [SerializeField] TextMeshProUGUI nameOne;
    [SerializeField] TextMeshProUGUI nameTwo;
    int dialogPage = 0;

    void Start()
    {
        Dialog.text = "[You are playing as John, a gay married to your loving husband Sam]";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && SceneManager.GetActiveScene().name == "John")
        {
            dialogPage++;

            switch (dialogPage)
            {
                case 1:
                    Dialog.text = "[You and Sam have decied to look into adopting a child]";
                    break;

                case 2:
                    Dialog.text = "[You have decieded to head to the Orphan to find out what the process entails while Sam is at work]";
                    break;

                case 3:
                    Dialog.text = "[You have decieded to head to the Orphan to find out what the process entails while Sam is at work]";
                    break;

                case 4:
                    Dialog.text = "[You approach the orphanage nervously, and spot a kind looking old nun tending to the garden outside]";
                    OrphanageExterior.SetActive(true);
                    Fade.SetActive(false);
                    break;

                case 5:
                    Dialog.text = "This is it, John. Just take a deep breath and go for it";
                    John.SetActive(true);
                    break;

                case 6:
                    Dialog.text = "Hi, I'm John. My husband Sam and I heard wonderful things about this place and wanted to know more about adopting a child";
                    nameBoxOne.SetActive(true);
                    break;

                case 7:
                    Dialog.text = "[The nun turns her attention toward John with a warm smile]";
                    nameBoxOne.SetActive(false);
                    break;

                case 8:
                    Dialog.text = "It's a pleasure to meet you. Please, call me Sister Angela. I'm delighted that you're considering adoption. Shall we head inside to discuss the process?";
                    Angela.SetActive(true);
                    nameBoxTwo.SetActive(true);
                    break;

                case 9:
                    Dialog.text = "[You and Sister Angela head into the orphanage and take a seat in her office]";
                    OrphanageExterior.SetActive(false);
                    OrphanageInteriror.SetActive(true);
                    nameBoxTwo.SetActive(false);
                    break;

                case 10:
                    Dialog.text = "So, Sister Angela, can you walk us through the legal process involved in adoption before we meet any children?";
                    nameBoxOne.SetActive(true);
                    break;

                case 11:
                    Dialog.text = "So, Sister Angela, can you walk us through the legal process involved in adoption before we meet any children?";
                    nameBoxOne.SetActive(true);
                    break;

                case 12:
                    Dialog.text = "[Mother Angela nods warmly]";
                    nameBoxOne.SetActive(false);
                    break;

                case 13:
                    Dialog.text = "Of course, John. I'd be happy to";
                    nameBoxTwo.SetActive(true);
                    break;

                case 14:
                    Dialog.text = "The legal process is a crucial part of adoption. It ensures the best interests of both you and the child";
                    break;

                case 15:
                    Dialog.text = "First, you'll need to complete an adoption application and provide all the necessary documentation, such as background checks, references, and financial statements";
                    break;

                case 16:
                    Dialog.text = "Once your application is accepted, you'll undergo a series of home visits by a caseworker";
                    break;

                case 17:
                    Dialog.text = "This helps ensure that your home is safe and suitable for a child. These visits may feel a bit intimidating, but they're essential for the child's well-being";
                    break;

                case 18:
                    Dialog.text = "After that, there will be an evaluation period where the caseworker reviews all the gathered information and makes a recommendation";
                    break;

                case 19:
                    Dialog.text = "If all goes well, you'll then be presented to a panel for final approval";
                    break;

                case 20:
                    Dialog.text = "[You listen intently, try to absorb every piece of information that Sister Angela tells you]";
                    nameBoxTwo.SetActive(false);
                    break;

                case 21:
                    Dialog.text = "I see. So, once we're approved, what happens next?";
                    nameBoxOne.SetActive(true);
                    break;

                case 22:
                    Dialog.text = "Once you're approved, the waiting begins. It's important to understand that the matching process can take time, as it depends on finding the right child for your family";
                    nameBoxTwo.SetActive(true);
                    break;

                case 23:
                    Dialog.text = "When a potential match is found, you'll have the opportunity to meet the child and spend time together before making a final decision";
                    break;

                case 24:
                    Dialog.text = "[You feel reassured after having the whole process explained to you]";
                    nameBoxTwo.SetActive(false);
                    break;

                case 25:
                    Dialog.text = "That sounds fair, Sister Angela. We want to make sure it's the right fit for both us and the child";
                    nameBoxOne.SetActive(true);
                    break;

                case 26:
                    Dialog.text = "[You feel concern begin to creep in as you notice that Sister Angela's expression seems more reserved all of a sudden]";
                    nameBoxOne.SetActive(false);
                    break;

                case 27:
                    Dialog.text = "John, I do appreciate your and Sam's desire to provide a loving home for a child";
                    nameBoxTwo.SetActive(true);
                    break;

                case 28:
                    Dialog.text = "But I must be honest with you. Our approach to adoption is rooted in certain traditions, and there may be some reservations about same-sex couples within the organization.";
                    break;

                case 29:
                    Dialog.text = "[You heart sinks with disappointment]";
                    nameBoxTwo.SetActive(false);
                    break;

                case 30:
                    Dialog.text = "[This is exactly what Sam was worried would happen]";
                    break;

                case 31:
                    Dialog.text = "You mean because we're a same-sex couple, you're not sure about us adopting?";
                    nameBoxOne.SetActive(true);
                    break;

                case 32:
                    Dialog.text = "I want you to know that personally, I believe that  every child deserves a loving family";
                    nameBoxTwo.SetActive(true);
                    break;

                case 33:
                    Dialog.text = "However, the organization might have reservations about your and Sam's relationship";
                    break;

                case 34:
                    Dialog.text = "I understand, Sister Angela";
                    nameBoxOne.SetActive(true);
                    break;

                case 35:
                    Dialog.text = "We'll respect your organization's rules, but we want to show that we can provide a loving and stable home for a child, just like any other couple.";
                    break;

                case 36:
                    Dialog.text = "Your determination is admirable, John";
                    nameBoxTwo.SetActive(true);
                    break;

                case 37:
                    Dialog.text = "I wish you the best for the coming process";
                    break;

                case 38:
                    Dialog.text = "[Sister Angela stands up and open the door for you to leave]";
                    nameBoxTwo.SetActive(false);
                    break;

                case 39:
                    Dialog.text = "Thank you Sister, I'll come back when we've sorted out all the paperwork";
                    nameBoxOne.SetActive(true);
                    break;

                case 40:
                    Dialog.text = "[You head back to your apartment to tell Sam about what what you leanred at the orphanage]";
                    nameBoxOne.SetActive(false);
                    Fade.SetActive(true);
                    OrphanageInteriror.SetActive(false);
                    John.SetActive(false);
                    Angela.SetActive(false);
                    break;

                case 41:
                    Dialog.text = "[You feel disappointed, but determined that you'll be able to prove that you are fit to care for a child]";
                    break;

                case 42:
                    Dialog.text = "[Sam is not so optimistic]";
                    break;
            }
        }
    }
}
