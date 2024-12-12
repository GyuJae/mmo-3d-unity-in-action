using System;
using JetBrains.Annotations;
using UnityEngine;

public class InputManger
{
   [CanBeNull] public Action KeyAction = null;

   public void OnUpdate()
   {
      if (Input.anyKey == false) return;

      KeyAction?.Invoke();
   }
}
