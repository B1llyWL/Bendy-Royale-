using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterMenu : MonoBehaviour
{

    public int Back;
    public int SammyLawrence;
    public int Bendy;
    public int AllisonAngel;
    public int AliceAngel;
    public int HenryStein;
    public int AudreyDrew;
    public int BruteBoris;
    public int BorisTheWolf;

    public void ToBack()
    {
        SceneManager.LoadScene(0);
    }
    public void ToBruteBoris()
    {
        SceneManager.LoadScene(BruteBoris);
    }

    public void ToBendy()
    {

        SceneManager.LoadScene(Bendy);

    }


    public void ToSammyLawrence()
    {

        SceneManager.LoadScene(SammyLawrence);

    }

    public void ToAllisonAngel()
    {

        SceneManager.LoadScene(AllisonAngel);

    }

    public void ToAliceAngel()
    {

        SceneManager.LoadScene(AliceAngel);

    }

    public void ToHenryStein()
    {

        SceneManager.LoadScene(HenryStein);

    }

    public void ToAudreyDrew()
    {

        SceneManager.LoadScene(AudreyDrew);

    }

    public void ToBorisTheWolf()
    {

        SceneManager.LoadScene(BorisTheWolf);

    }
}


