using System;

using UIKit;

namespace BasicCalculator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void AddBTN_TouchUpInside(UIButton sender)
        {
            try {
                int num1 = int.Parse(num1TF.Text);
                int num2 = int.Parse(num2TF.Text);
                resultLBL.Text = "Result(Addition) : "+(num1 + num2).ToString();

            }
            catch(Exception ex){
                Console.WriteLine(ex);
                UIAlertView alert = new UIAlertView("Alert", "Enter valid input!!", null, "Dismiss", null);
                alert.Show();
                
            }
        }

        partial void SubtractBTN_TouchUpInside(UIButton sender)
        {
            try {
                int num1 = int.Parse(num1TF.Text);
                int num2 = int.Parse(num2TF.Text);
                resultLBL.Text = "Result(Subtraction) : " + (num1 - num2).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                UIAlertView alert = new UIAlertView("Alert", "Enter valid input!!", null, "Dismiss", null);
                alert.Show();

            }
        }

        partial void MultiplyBTN_TouchUpInside(UIButton sender)
        {
            try
            {
                int num1 = int.Parse(num1TF.Text);
                int num2 = int.Parse(num2TF.Text);
                resultLBL.Text = "Result(Multiplication) : " + (num1 * num2).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                UIAlertView alert = new UIAlertView("Alert", "Enter valid input!!", null, "Dismiss", null);
                alert.Show();

            }
        }
    }
}
