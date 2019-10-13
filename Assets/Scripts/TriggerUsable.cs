using UnityEngine.UI;
using VRTK;
using UnityEngine;

public class TriggerUsable : VRTK_InteractableObject
{
   
  
   
    private void OnEnable()
    {
        InteractableObjectUsed += Seleccionado;
    }

    private void Seleccionado(object sender, InteractableObjectEventArgs e)
    {
        
        Debug.Log("toque el objeto "+this.name);
    }

    private void OnDisable()
    {
        InteractableObjectUsed -= Seleccionado;
    }
}
