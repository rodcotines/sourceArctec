using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibAnim : MonoBehaviour
{
    private Animator Anim;
    private bool isGroundFloorVisible = true;
    private bool isSecondFloorVisible = true;
    private bool isThirdFloorVisible = true;
    private bool isFourthFloorVisible = true;
    private bool isFifthFloorVisible = true;

    // Reference to your UI buttons
    public GameObject groundFloorButton;
    public GameObject secondFloorButton;
    public GameObject thirdFloorButton;
    public GameObject fourthFloorButton;
    public GameObject fifthFloorButton;
    public GameObject buttonOverlay;

    public GameObject infoButtons;

    

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0f;

        // Hide buttons initially
        ToggleButtonsVisibility(false);
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any additional logic here if needed
    }

    // Function to toggle the visibility of buttons
    void ToggleButtonsVisibility(bool isVisible)
    {
        groundFloorButton.SetActive(isVisible);
        secondFloorButton.SetActive(isVisible);
        thirdFloorButton.SetActive(isVisible);
        fourthFloorButton.SetActive(isVisible);
        fifthFloorButton.SetActive(isVisible);
        buttonOverlay.SetActive(isVisible);
        infoButtons.SetActive(isVisible);
       
    }

    

    // Function to handle target found event
    public void OnTargetFound()
    {
        // Show buttons when target is found
        ToggleButtonsVisibility(true);
    }

    // Function to handle target lost event
    public void OnTargetLost()
    {
        // Hide buttons when target is lost
        ToggleButtonsVisibility(false);
    }

    public void ToggleGroundFloor()
    {
        if (isGroundFloorVisible)
        {
            // If the second floor is visible, hide it
            Anim.Play("GroundAnim", -1, 0f);
            Anim.speed = 1f;
        }
        else
        {
            // If the second floor is hidden, show it
            Anim.Play("GroundAnimShow", -1, 0f);
            Anim.speed = 1f;
        }

        // Toggle the state
        isGroundFloorVisible = !isGroundFloorVisible;
    }

    public void ToggleSecondFloor()
    {
        if (isSecondFloorVisible)
        {
            // If the second floor is visible, hide it
            Anim.Play("2ndAnim", -1, 0f);
            Anim.speed = 1f;
        }
        else
        {
            // If the second floor is hidden, show it
            Anim.Play("2ndAnimShow", -1, 0f);
            Anim.speed = 1f;
        }

        // Toggle the state
        isSecondFloorVisible = !isSecondFloorVisible;
    }

    public void ToggleThirdFloor()
    {
        if (isThirdFloorVisible)
        {
            // If the third floor is visible, hide it
            Anim.Play("3rdAnim", -1, 0f);
            Anim.speed = 1f;
        }
        else
        {
            // If the third floor is hidden, show it
            Anim.Play("3rdAnimShow", -1, 0f);
            Anim.speed = 1f;
        }

        // Toggle the state
        isThirdFloorVisible = !isThirdFloorVisible;
    }

    public void ToggleFourthFloor()
    {
        if (isFourthFloorVisible)
        {
            // If the fourth floor is visible, hide it
            Anim.Play("4thAnim", -1, 0f);
            Anim.speed = 1f;
        }
        else
        {
            // If the fourth floor is hidden, show it
            Anim.Play("4thAnimShow", -1, 0f);
            Anim.speed = 1f;
        }

        // Toggle the state
        isFourthFloorVisible = !isFourthFloorVisible;
    }

    public void ToggleFifthFloor()
    {
        if (isFifthFloorVisible)
        {
            // If the fifth floor is visible, hide it
            Anim.Play("5thAnim", -1, 0f);
            Anim.speed = 1f;
        }
        else
        {
            // If the fifth floor is hidden, show it
            Anim.Play("5thAnimShow", -1, 0f);
            Anim.speed = 1f;
        }

        // Toggle the state
        isFifthFloorVisible = !isFifthFloorVisible;
    }
}
