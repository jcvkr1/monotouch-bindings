using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libFlurryAppCircle.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, SmartLink = true)]
