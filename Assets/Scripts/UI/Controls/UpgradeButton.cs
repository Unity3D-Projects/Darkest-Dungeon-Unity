﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class UpgradeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image buildingIcon;
    public Image infoIcon;
    public SkeletonAnimation upgradePulse;
    public Animator iconAnimator;

    public bool IsOpened { get; set; }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buildingIcon.material.SetFloat("_BrightnessAmount", 1.35f);
        DarkestSoundManager.PlayOneShot("event:/ui/town/button_mouse_over");
    }

    public void SwitchUpgrades()
    {
        IsOpened = !IsOpened;
        iconAnimator.SetBool("IsOpened", IsOpened);
        DarkestSoundManager.PlayOneShot(IsOpened ? "event:/ui/town/page_open" : "event:/ui/town/page_close");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buildingIcon.material.SetFloat("_BrightnessAmount", 1f);
    }
}
