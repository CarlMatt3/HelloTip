﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaImage : MonoBehaviour
{

    public GameObject canvasImage;
    public TourManager tourManager;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void ShowImage(){
        canvasImage.SetActive(true);
        tourManager.OpenMedia();
    }

    public void HideImage(){
        canvasImage.SetActive(false);
        tourManager.ReturnToSite();
    }
}
