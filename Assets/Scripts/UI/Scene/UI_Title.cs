using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Title : UI_Scene
{
    enum Buttons
    {
        Start_Btn,
    }

    enum Images
    {
        Title_Image,
    }

    protected override void Init()
    {
        base.Init();

        BindButton(typeof(Buttons));
        BindImage(typeof(Images));

        
    }
}
