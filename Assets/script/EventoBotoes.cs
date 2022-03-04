using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EventoBotoes
{
    private Button coletorBT;
    private Button lenhadorBT;
    private Button pedreroBT;  
    public void setarEventosBT(Trabalho trabalho){
        coletorBT = GameObject.Find("ColetorBT").GetComponent<Button>();
        coletorBT.onClick.AddListener(() => trabalho.comprarTrabalhador(0,1));
        lenhadorBT = GameObject.Find("LenhadorBT").GetComponent<Button>();
        lenhadorBT.onClick.AddListener(() => trabalho.comprarTrabalhador(1,1));
        pedreroBT = GameObject.Find("PedreroBT").GetComponent<Button>();
        pedreroBT.onClick.AddListener(() => trabalho.comprarTrabalhador(2,1));
    }
    
}
