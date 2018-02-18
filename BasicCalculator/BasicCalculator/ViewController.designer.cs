// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BasicCalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddBTN { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MultiplyBTN { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField num1TF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField num2TF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel resultLBL { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton subtractBTN { get; set; }

        [Action ("AddBTN_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddBTN_TouchUpInside (UIKit.UIButton sender);

        [Action ("MultiplyBTN_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MultiplyBTN_TouchUpInside (UIKit.UIButton sender);

        [Action ("SubtractBTN_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SubtractBTN_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddBTN != null) {
                AddBTN.Dispose ();
                AddBTN = null;
            }

            if (MultiplyBTN != null) {
                MultiplyBTN.Dispose ();
                MultiplyBTN = null;
            }

            if (num1TF != null) {
                num1TF.Dispose ();
                num1TF = null;
            }

            if (num2TF != null) {
                num2TF.Dispose ();
                num2TF = null;
            }

            if (resultLBL != null) {
                resultLBL.Dispose ();
                resultLBL = null;
            }

            if (subtractBTN != null) {
                subtractBTN.Dispose ();
                subtractBTN = null;
            }
        }
    }
}