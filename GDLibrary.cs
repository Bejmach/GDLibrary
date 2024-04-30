using Godot;
using System;

public static class GDLibrary
{
    public static float slope(float time){
        time = time%1;
        return time;
    }
    public static float pingPong(float time){
        time = time%1;
        if(time>.5f){
            time = 1-time;
        }
        return time*2;
    }
    public static float lerpf(float firstFloat, float secondFloat, float by){
        return firstFloat * (1 - by) + secondFloat * by;
    }
    public static Vector2 lerpv2(Vector2 firstVector, Vector2 secondVector, float by){
        firstVector.X = firstVector.X * (1-by)+secondVector.X * by;
        firstVector.Y = firstVector.Y * (1-by)+secondVector.Y * by;
        return firstVector;
    }
    public static Vector3 lerpv3(Vector3 firstVector, Vector3 secondVector, float by){
        firstVector.X = firstVector.X * (1-by)+secondVector.X * by;
        firstVector.Y = firstVector.Y * (1-by)+secondVector.Y * by;
        firstVector.Z = firstVector.Z * (1-by)+secondVector.Z * by;
        return firstVector;
    }
    public static Vector3 staticLerpv3(Vector3 firstVector, Vector3 secondVector, float by){
        //get normalized vector of direction to second vector
        Vector3 tempVector = secondVector - firstVector;
        tempVector = tempVector.Normalized();
        //move first vector by normalized direction times distance
        firstVector+=tempVector*by;
        return firstVector;
    }
    public static float clampf(float variable, float min, float max){
        if(min>max){
            return 0;
        }
        if(variable<min){
            return min;
        }
        else if(variable>max){
            return max;
        }
        else{
            return variable;
        }
    }
}
