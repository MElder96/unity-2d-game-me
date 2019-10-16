﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance; 

    private int _totalBombs;
    private int _collectedBombs;

    public TextMeshProUGUI bombCount;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        _totalBombs = FindObjectsOfType<Collectible>().Length;
        DisplayBombCount();
    }
    void DisplayBombCount()
    {
        bombCount.SetText(_collectedBombs + " / " + _totalBombs);
    }

    public void HandleBombCollected()
    {
        _collectedBombs++;
        //_collectedBombs = _collectedBombs + 1;
        //another way of adding 
        DisplayBombCount();
<<<<<<< Updated upstream
        if (_collectedBombs == _totalBombs)
        {
           // bombCount.setText("you win!");
=======
       
        if (_collectedBombs == _totalBombs)
        {
            SoundManager.Instance.PlayWinSound();
        }

        if(_collectedBombs == _totalBombs)
        {
            YouWinMenu.Instance.Show();
>>>>>>> Stashed changes
        }
    }
}
