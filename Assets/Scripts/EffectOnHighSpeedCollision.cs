using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOnHighSpeedCollision : MonoBehaviour {

    public LayerMask targetLayers;

    void Start()
    {

    }

    void Update()
    {
        
    }

    /// <summary>
    /// Returns true if the given layer is contained in the mask, false otherwise.
    /// </summary>
    /// <param name="layer"></param>
    /// <param name="mask"></param>
    /// <returns></returns>
    bool IsLayerInLayerMask(int layer, LayerMask mask)
    {
        //Une opériation qui compare l'index du layer avec un masque (ex 10010011, les 1 étant les layers contenus dans le masque).
        return mask == (mask | (1 << layer));
    }
}
