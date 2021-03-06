using System;
using ObjCRuntime;

[assembly: LinkWith (
    "mopub.a", 
    LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.Arm64, 
    SmartLink = true,
    Frameworks = "AudioToolbox AVFoundation CoreGraphics CoreLocation CoreTelephony EventKit EventKitUI Foundation iAd MediaPlayer MessageUI MobileCoreServices QuartzCore SystemConfiguration UIKit",
    WeakFrameworks = "AdSupport StoreKit PassKit Social")]
