# GDLibrary

this c# library DOESN'T WORK in GDScript, at least in curent form. To use it you propably need to make some NON STATIC Bridge class in c# that will have functions that returns functions from library(At least that's what GPT said). Just find some way to use c# static class in GDScript.

Library with functions written in C#
This code is in early states and will be updated in the future, when I will need more functions to my projects.
To use, just download GDLibrary.cs, put it in directory with your scripts and in your code add "using static GDLibrary" at the begining of your code 


List of functions:

lerpf(float firstFloat, flaot SecondFloat, float amount):
	returns lerped flaot by the amount

lerpv2(v2 firstVector, v2 secondVector, float amount):
	same but with vector2

lerpv3(v3 firstVector, v3 secondVector, float amount):
	same but with vector3

staticLerpv3(v3 firstVector, v3 secondVector, float amount):
	lerp with constant speed, not affected by distance

lerpV3OverAxis(v3 firstVector, v3 secondVector float by):
	lerp over axis -180 and 180 without doing whole another turn. Works only on Y axis

rotateToDirection(Transform3D transform, v3 direction, float amount):
	lerps object to turn in the direciton of v3 direciton by the amount

slope(float time):
	returns float equal to modulus of time

pingPong(float time):
	constant interpolation from 0 to 1 and againt to 0, based on unity pingPong function

clamp(float value, float min, float max):
	same as float in math library. Idk why I made that


