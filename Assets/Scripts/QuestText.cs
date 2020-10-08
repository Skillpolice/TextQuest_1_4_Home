using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;


public class QuestText : MonoBehaviour
{
    [Header("Text")]
    public Text titleText;
    public Text contentText;

    [Header("Steps")]
    public Step startStep;
    public Step currentStep;

    [Header("Image")]
    public Image backgroundImage;
    public Image textImage;



    string race;
    string classPlayer;

    int ct;


    void Start()
    {
        ct = 0;
        race = " ";
        classPlayer = " ";

        titleText.text = "Давай сыграем в игру !!!" + "\n" + "Создайте персонажа";
        titleText.fontSize = 45;

        currentStep = startStep;
        contentText.text = currentStep.stepContent;


        textImage.sprite = currentStep.nextSpriteImageText;
        backgroundImage.sprite = currentStep.nextSpriteImage;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckNumber(0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Scens2();
            CheckNumber(1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            CheckNumber(2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            CheckNumber(3);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            CheckNumber(4);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            CheckNumber(5);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Start();
        }
    }

    private void CheckNumber(int number) //проверка кода в Юнити на ложные нажатия клавишь
    {
        if (currentStep.nextSteps.Length > number)
        {
            if (currentStep.nextSteps[number] != null)
            {
                currentStep = currentStep.nextSteps[number];
                MetodElements();
            }
        }


    }

    private void MetodElements()
    {
        contentText.text = currentStep.stepContent; //Запоминаем на какой позиции находимся
        backgroundImage.sprite = currentStep.nextSpriteImage;
        textImage.sprite = currentStep.nextSpriteImageText;

        //счетчик класса
        ct++;
        if (ct == 2)
        {
            race = currentStep.name;
        }
        if (ct == 3)
        {
            classPlayer = currentStep.name;
        }
        titleText.text = "Ваш персонаж: " + "Класс- " + race + " || Раса- " + classPlayer;

    }

    //public void Scens1()
    //{
    //    currentStep = currentStep.nextSteps[0];
    //    contentText.text = currentStep.stepContent;
    //    backgroundImage.sprite = currentStep.nextSpriteImage;
    //    textImage.sprite = currentStep.nextSpriteImageText;

    //}
    //public void Scens2()
    //{
    //    currentStep = currentStep.nextSteps[1];
    //    contentText.text = currentStep.stepContent;
    //    backgroundImage.sprite = currentStep.nextSpriteImage;
    //    textImage.sprite = currentStep.nextSpriteImageText;
    //    GetCount();
    //}
    //public void Scens3()
    //{
    //    currentStep = currentStep.nextSteps[2];
    //    contentText.text = currentStep.stepContent;
    //    backgroundImage.sprite = currentStep.nextSpriteImage;
    //    textImage.sprite = currentStep.nextSpriteImageText;
    //    GetCount();
    //}


}
