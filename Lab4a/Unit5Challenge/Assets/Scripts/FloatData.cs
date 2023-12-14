using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
   public float value;
   public object Value { get; set; }


   public void UpdateValue(float num)
   {
      value += num;
   }
}
