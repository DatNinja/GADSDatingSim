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
    public GameObject CourtExterior;
    public GameObject CourtMainDesk;
    public GameObject CourtRoom;
    public GameObject Fade;
    public GameObject John;
    public GameObject Angela;
    public GameObject Judge;
    public GameObject Secretary;
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
                    Dialog.text = "[You have decieded to head to the Orphanage to find out what the process entails while Sam is at work]";
                    break;

                case 3:
                    Dialog.text = "[You approach the orphanage nervously, and spot a kind looking old nun tending to the garden outside]";
                    OrphanageExterior.SetActive(true);
                    Fade.SetActive(false);
                    break;

                case 4:
                    Dialog.text = "This is it, John. Just take a deep breath and go for it";
                    John.SetActive(true);
                    nameBoxOne.SetActive(true);
                    break;

                case 5:
                    Dialog.text = "Hi, I'm John. My husband Sam and I heard wonderful things about this place and wanted to know more about adopting a child";                    
                    break;

                case 6:
                    Dialog.text = "[The nun turns her attention toward John with a warm smile]";
                    nameBoxOne.SetActive(false);
                    break;

                case 7:
                    Dialog.text = "It's a pleasure to meet you. Please, call me Sister Angela. I'm delighted that you're considering adoption. Shall we head inside to discuss the process?";
                    Angela.SetActive(true);
                    nameBoxTwo.SetActive(true);
                    break;

                case 8:
                    Dialog.text = "[You and Sister Angela head into the orphanage and take a seat in her office]";
                    OrphanageExterior.SetActive(false);
                    OrphanageInteriror.SetActive(true);
                    nameBoxTwo.SetActive(false);
                    break;

                case 9:
                    Dialog.text = "So, Sister Angela, can you walk us through the legal process involved in adoption before we meet any children?";
                    nameBoxOne.SetActive(true);
                    break;

                case 10:
                    Dialog.text = "[Mother Angela nods warmly]";
                    nameBoxOne.SetActive(false);
                    break;

                case 11:
                    Dialog.text = "Of course, John. I'd be happy to";
                    nameBoxTwo.SetActive(true);
                    break;

                case 12:
                    Dialog.text = "The legal process is a crucial part of adoption. It ensures the best interests of both you and the child";
                    break;

                case 13:
                    Dialog.text = "First, you'll need to complete an adoption application and provide all the necessary documentation, such as background checks, references, and financial statements";
                    break;

                case 14:
                    Dialog.text = "Once your application is accepted, you'll undergo a series of home visits by a caseworker";
                    break;

                case 15:
                    Dialog.text = "This helps ensure that your home is safe and suitable for a child. These visits may feel a bit intimidating, but they're essential for the child's well-being";
                    break;

                case 16:
                    Dialog.text = "After that, there will be an evaluation period where the caseworker reviews all the gathered information and makes a recommendation";
                    break;

                case 17:
                    Dialog.text = "If all goes well, you'll then be presented to a panel for final approval";
                    break;

                case 18:
                    Dialog.text = "[You listen intently, try to absorb every piece of information that Sister Angela tells you]";
                    nameBoxTwo.SetActive(false);
                    break;

                case 19:
                    Dialog.text = "I see. So, once we're approved, what happens next?";
                    nameBoxOne.SetActive(true);
                    break;

                case 20:
                    Dialog.text = "Once you're approved, the waiting begins. It's important to understand that the matching process can take time, as it depends on finding the right child for your family";
                    nameBoxOne.SetActive(false);
                    nameBoxTwo.SetActive(true);
                    break;

                case 21:
                    Dialog.text = "When a potential match is found, you'll have the opportunity to meet the child and spend time together before making a final decision";
                    break;

                case 22:
                    Dialog.text = "[You feel reassured after having the whole process explained to you]";
                    nameBoxTwo.SetActive(false);
                    break;

                case 23:
                    Dialog.text = "That sounds fair, Sister Angela. We want to make sure it's the right fit for both us and the child";
                    nameBoxOne.SetActive(true);
                    break;

                case 24:
                    Dialog.text = "[You feel concern begin to creep in as you notice that Sister Angela's expression seems more reserved all of a sudden]";
                    nameBoxOne.SetActive(false);
                    break;

                case 25:
                    Dialog.text = "John, I do appreciate your and Sam's desire to provide a loving home for a child";
                    nameBoxTwo.SetActive(true);
                    break;

                case 26:
                    Dialog.text = "But I must be honest with you. Our approach to adoption is rooted in certain traditions, and there may be some reservations about same-sex couples within the organization.";
                    break;

                case 27:
                    Dialog.text = "[You heart sinks with disappointment]";
                    nameBoxTwo.SetActive(false);
                    break;

                case 28:
                    Dialog.text = "[This is exactly what Sam was worried would happen]";
                    break;

                case 29:
                    Dialog.text = "You mean because we're a same-sex couple, you're not sure about us adopting?";
                    nameBoxOne.SetActive(true);
                    break;

                case 30:
                    Dialog.text = "I want you to know that personally, I believe that  every child deserves a loving family";
                    nameBoxOne.SetActive(false);
                    nameBoxTwo.SetActive(true);
                    break;

                case 31:
                    Dialog.text = "However, the organization might have reservations about your and Sam's relationship";
                    break;

                case 32:
                    Dialog.text = "I understand, Sister Angela";
                    nameBoxOne.SetActive(true);
                    nameBoxTwo.SetActive(false);
                    break;

                case 33:
                    Dialog.text = "We'll respect your organization's rules, but we want to show that we can provide a loving and stable home for a child, just like any other couple.";
                    break;

                case 34:
                    Dialog.text = "Your determination is admirable, John";
                    nameBoxOne.SetActive(false);
                    nameBoxTwo.SetActive(true);
                    break;

                case 35:
                    Dialog.text = "I wish you the best for the coming process";
                    break;

                case 36:
                    Dialog.text = "[Sister Angela stands up and open the door for you to leave]";
                    nameBoxTwo.SetActive(false);
                    break;

                case 37:
                    Dialog.text = "Thank you Sister, I'll come back when we've sorted out all the paperwork";
                    nameBoxOne.SetActive(true);
                    break;

                case 38:
                    Dialog.text = "[You head back to your apartment to tell Sam about what what you leanred at the orphanage]";
                    nameBoxOne.SetActive(false);
                    Fade.SetActive(true);
                    OrphanageInteriror.SetActive(false);
                    John.SetActive(false);
                    Angela.SetActive(false);
                    break;

                case 39:
                    Dialog.text = "[You feel disappointed, but determined that you'll be able to prove that you are fit to care for a child]";
                    break;

                case 40:
                    Dialog.text = "[Sam is not so optimistic]";
                    break;

                case 41:
                    Dialog.text = "[Over the next few days you and Sam fill out the paper work and send it off to the childrens court of approval]";
                    break;

                case 42:
                    Dialog.text = "[Weeks go by without a response]";
                    break;

                case 43:
                    Dialog.text = "[Sam gets more and more dispondent each day]";
                    break;

                case 44:
                    Dialog.text = "[Until finally you get a call from the court asking you to come in]";
                    break;

                case 45:
                    Dialog.text = "This is it, the next step in the process. I need to stay focused and make sure everything is in order";
                    Fade.SetActive(false);
                    CourtExterior.SetActive(true);
                    John.SetActive(true);
                    nameBoxOne.SetActive(true);
                    break;

                case 46:
                    Dialog.text = "[You head inside the court house and approach the woman at the main desk]";
                    CourtExterior.SetActive(false);
                    CourtMainDesk.SetActive(true);
                    nameBoxOne.SetActive(false);
                    break;

                case 47:
                    Dialog.text = "Good afternoon, sir. How can I assist you today?";
                    Secretary.SetActive(true);
                    nameBoxTwo.SetActive(true);
                    nameTwo.text = "Court Clerk";
                    break;

                case 48:
                    Dialog.text = "Hi, I'm John, and I'm here to finalize my adoption report. I have all the necessary documents right here";
                    nameBoxOne.SetActive(true);
                    nameBoxTwo.SetActive(false);
                    break;

                case 49:
                    Dialog.text = "Thank you, John. I'll just need a moment to review these";
                    nameBoxOne.SetActive(false);
                    nameBoxTwo.SetActive(true);
                    break;

                case 50:
                    Dialog.text = "[You watch as the clerk goes through all the documents]";
                    nameBoxTwo.SetActive(false);
                    break;

                case 51:
                    Dialog.text = "It's crucial that everything is in order. We've come so far, and this means the world to us.";
                    nameBoxOne.SetActive(true);
                    break;

                case 52:
                    Dialog.text = "[The woman looks back up at you and hands you back the documents as well as a slip with a room number on it]";
                    nameBoxOne.SetActive(false);
                    break;

                case 53:
                    Dialog.text = "Everything seems to be in order, John. You can proceed to the assigned courtroom";
                    nameBoxTwo.SetActive(true);
                    break;

                case 54:
                    Dialog.text = "Thank you. I hope everything goes smoothly. This is the final step, and we're so close to becoming parents";
                    nameBoxOne.SetActive(true);
                    nameBoxTwo.SetActive(false);
                    break;

                case 55:
                    Dialog.text = "[You make your way down down the halls of the court until you find the correct room]";
                    Fade.SetActive(true);
                    CourtMainDesk.SetActive(false);
                    John.SetActive(false);
                    Secretary.SetActive(false);
                    nameBoxOne.SetActive(false);
                    break;

                case 56:
                    Dialog.text = "[As you entire the room you are met by a well dressed man sitting behind a desk]";
                    break;

                case 57:
                    Dialog.text = "[As you entire the room you are met by a well dressed man sitting behind a desk]";
                    break;
            }
        }
    }
}
