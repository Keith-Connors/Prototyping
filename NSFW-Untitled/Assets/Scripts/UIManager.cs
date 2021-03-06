﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

//[RequireComponent(typeof(GameManager))]
public class UIManager : MonoBehaviour
{
    private GameManager m_GameManager;
    private Container m_Container;
    public Canvas IntroCanvas;//, MainScreenCanvas;
    

    public InputField Player1, Player2, Player3, Player4;
    public Button Add_Player2Button, Add_Player3Button, Add_Player4Button;
    public Button Minus_Player2Button, Minus_Player3Button, Minus_Player4Button;

    public GameObject InformationPanel;
    private void Start()
    {
        
        
        IntroCanvas = GameObject.Find("Intro-Canvas").GetComponent<Canvas>();
        m_Container = GameObject.Find("Container").GetComponent<Container>();

        InformationPanel = GameObject.Find("Information-Panel");
        InformationPanel.gameObject.SetActive(false);
        
        Player1 = GameObject.Find("Player_Name-1").GetComponent<InputField>();
        Player2 = GameObject.Find("Player_Name-2").GetComponent<InputField>();
        Player3 = GameObject.Find("Player_Name-3").GetComponent<InputField>();
        Player4 = GameObject.Find("Player_Name-4").GetComponent<InputField>();
        
        Add_Player2Button = GameObject.Find("Add_Player-2").GetComponent<Button>();
        Add_Player3Button = GameObject.Find("Add_Player-3").GetComponent<Button>();
        Add_Player4Button = GameObject.Find("Add_Player-4").GetComponent<Button>();
        
        Minus_Player2Button = GameObject.Find("Minus_Player-2").GetComponent<Button>();
        Minus_Player3Button = GameObject.Find("Minus_Player-3").GetComponent<Button>();
        Minus_Player4Button = GameObject.Find("Minus_Player-4").GetComponent<Button>();

        // Player1.gameObject.SetActive(true);
        Player2.gameObject.SetActive(false);
        Player3.gameObject.SetActive(false);
        Player4.gameObject.SetActive(false);

        //Add_Player2Button.gameObject.SetActive(false);
        Add_Player3Button.gameObject.SetActive(false);
        Add_Player4Button.gameObject.SetActive(false);
        
        Minus_Player2Button.gameObject.SetActive(false);
        Minus_Player3Button.gameObject.SetActive(false);
        Minus_Player4Button.gameObject.SetActive(false);
    }


    public void AddPlayer2()
    {
        Player2.gameObject.SetActive(true);
        Add_Player2Button.gameObject.SetActive(false);
        Add_Player3Button.gameObject.SetActive(true);
        Minus_Player2Button.gameObject.SetActive(true);
    }

    public void MinusPlayer2()
    {
        Player2.gameObject.SetActive(false);
        Add_Player2Button.gameObject.SetActive(true);
        Add_Player3Button.gameObject.SetActive(false);
        Minus_Player2Button.gameObject.SetActive(false);
    }
    
    public void AddPlayer3()
    {
        Player3.gameObject.SetActive(true);
        Add_Player3Button.gameObject.SetActive(false);
        Add_Player4Button.gameObject.SetActive(true);
        Minus_Player2Button.gameObject.SetActive(false);
        Minus_Player3Button.gameObject.SetActive(true);
    }
    public void MinusPlayer3()
    {
        Player3.gameObject.SetActive(false);
        Minus_Player3Button.gameObject.SetActive(false);
        Minus_Player2Button.gameObject.SetActive(true);
        Add_Player4Button.gameObject.SetActive(false);
        Add_Player3Button.gameObject.SetActive(true);
    }
    
    public void AddPlayer4()
    {
        Player4.gameObject.SetActive(true);
        Minus_Player4Button.gameObject.SetActive(true);
        Add_Player4Button.gameObject.SetActive(false);
        Minus_Player3Button.gameObject.SetActive(false);
    }
    public void MinusPlayer4()
    {
        Player4.gameObject.SetActive(false);
        Minus_Player4Button.gameObject.SetActive(false);
        Add_Player4Button.gameObject.SetActive(true);
        Minus_Player3Button.gameObject.SetActive(true);
    }


    private void Update()
    {
        
    }
}
