using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bank : MonoBehaviour
{
    [SerializeField]private Text bankText;

    private int _Bank
    {
        get { return PlayerPrefs.GetInt("Bank"); }
        set { PlayerPrefs.SetInt("Bank", value); }
    }
    void Start()
    {
        bankText.text=_Bank.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToBank(int price)
    {
        int newBank=_Bank+ price;
        bankText.DOCounter(_Bank, newBank, 0.4f).
                 OnPlay(() =>
                 {
                     bankText.transform.DOScale(1.5f, 0.3f).
                              OnComplete(() =>
                              {
                                  bankText.transform.DOScale(1, 0.3f);
                              });
                 }).
                 OnComplete(() =>
                 {
                     _Bank = newBank;

                 });
    }
}
