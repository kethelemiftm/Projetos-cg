using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class scenemaneger : MonoBehaviour
{
    public static scenemaneger instance = null;

    [SerializeField]
   private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0f);
   [SerializeField]
   private Transform Tape = null; 

   public UIcomponents uicomponents;

   scenedata sceneData = new scenedata();
    void Awake() {
        Assert.IsNotNull(Tape);
        if (instance == null) {
            instance = this;
        }
    }


    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
        DisplayHudData();
    }

    public void IncrementCoinCount() {
        sceneData.coinCount++;
    }

    void DisplayHudData() {
        uicomponents.hud.txtCoinCount.text = "x " + sceneData.coinCount;
    }
}
