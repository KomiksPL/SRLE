﻿using UnityEngine;

namespace SRLE;

public static class Extensions
{
    public static Vector3 ToVector3(this BuildObject.Vector3Save @this) => new Vector3(@this.x, @this.y, @this.z);

    public static BuildObject.Vector3Save ToVector3Save(this Vector3 @this) => new BuildObject.Vector3Save
    {
        x = @this.x,
        y = @this.y,
        z = @this.z
    };
    public static string GetFullName(this GameObject obj)
    {
        string str = obj.name;
        for (Transform parent = obj.transform.parent;
             parent != null;
             parent = parent.parent)
        {
            str = parent.gameObject.name + "/" + str;
        }

        return str;
    }

}