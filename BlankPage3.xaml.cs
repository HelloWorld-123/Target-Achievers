using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App15
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage3 : Page
    {
        List<String> questionlist;
        List<String> op1list;
        List<String> op2list;
        List<String> op3list;
        List<String> op4list;
        List<String> corlist;
        DispatcherTimer dt = new DispatcherTimer();
        DispatcherTimer timedisp = new DispatcherTimer();

        void generatequestions()
        {

            questionlist = new List<string>();

            op1list = new List<string>();
            op2list = new List<string>();
            op3list = new List<string>();
            op4list = new List<string>();
            corlist = new List<string>();

            questionlist.Add("A biconvex lens of focal length f forms a circular image of sun of radius r in focal plane. Then");
op1list.Add("πr2 ∝ f");
op2list.Add("πr2 ∝ f2");
op3list.Add("if lower half part is covered by black sheet, then area of the image is equal to πr2/2");
op4list.Add("if f is doubled, intensity will increase" );
corlist.Add("πr2 ∝ f2");

questionlist.Add("Given a sample of Radium-226 having half-life of 4 days. Find the probability, a nucleus disintegrates after 2 half lives.");
op1list.Add("1");
op2list.Add("1/2");
op3list.Add("1.5");
op4list.Add("3/4");
corlist.Add("1.5");

questionlist.Add("A solid sphere of mass M, radius R and having moment of inertia about an axis passing through the centre of mass as I, is recast into a disc of thickness t, whose moment of inertia about an axis passing through its edge and perpendicular to its plane remains I. Then, radius of the disc will be");
op1list.Add("2R/sqrt15");
op2list.Add("Rsqrt(2/15)");
op3list.Add("4R/sqrt15");
op4list.Add("R/4");
corlist.Add("2R/sqrt15");


questionlist.Add("The circular divisions of shown screw gauge are 50. It moves 0.5 mm on main scale in one rotation. The diameter of the ball is");
op1list.Add("2.25 mm");
op2list.Add("2.20 mm");
op3list.Add("1.20 mm");
op4list.Add("1.25 mm");
corlist.Add("1.20 mm");



questionlist.Add("Initially, the capacitor was uncharged. Now, switch S1 is closed and S2 is kept open. If time constant of this circuit is τ, then");
op1list.Add("after time interval τ, charge on the capacitor is CV/2");
op2list.Add("after time interval 2τ, charge on the capacitor is CV(1−e−2)");
op3list.Add("the work done by the voltage source will be half of the heat dissipated when the capacitor is fully charged.");
op4list.Add("the work done by the voltage source will be half of the heat dissipated when the capacitor is fully charged.");
corlist.Add("after time interval 2τ, charge on the capacitor is CV(1−e−2)");



questionlist.Add("After the capacitor gets fully charged, S1 is opened and S2 is closed so that the inductor is connected in series with the capacitor. Then,");
op1list.Add("at t = 0, energy stored in the circuit is purely in the form of magnetic energy");
op2list.Add("at any time t > 0, current in the circuit is in the same direction");
op3list.Add("at t > 0, there is no exchange of energy between the inductor and capacitor");
op4list.Add("at any time t > 0, instantaneous current in the circuit may V sqrt(C/L)");
corlist.Add("at any time t > 0, instantaneous current in the circuit may V sqrt(C/L)");



questionlist.Add("If level of liquid starts decreasing slowly when the level of liquid is at a height h1 above the cylinder, the block just starts moving up. Then, value of h1 is");
op1list.Add("2h/3");
op2list.Add("5h/4");
op3list.Add("5h/3");
op4list.Add("5h/2");
corlist.Add("5h/3");



questionlist.Add("A spherical portion has been removed from a solid sphere having a charge distributed uniformly in its volume as shown in the figure. The electric field inside the emptied space is");
op1list.Add("zero everywhere");
op2list.Add("non-zero and uniform");
op3list.Add("non-uniform");
op4list.Add("zero only at its center");
corlist.Add("non-zero and uniform");

questionlist.Add("A small object of uniform density rolls up a curved surface with an initial velocity v. It reaches up to a maximum height of 3v2/4g with respect to the initial position. The object is");
op1list.Add("ring");
op2list.Add("solid sphere");
op3list.Add("hollow sphere");
op4list.Add("disc");
corlist.Add("disc");

questionlist.Add("In an experiment to determine the focal length (f) of a concave mirror by the u–v method, a student places the object pin A on the principal axis at a distance x from the pole P. The student looks at the pin and its inverted image from a distance keeping his/her eye in line with PA. When the student shifts his/her eye towards left, the image appears to the right of the object pin. Then,");
op1list.Add("x < f");
op2list.Add("f < x < 2f");
op3list.Add("x = 2f");
op4list.Add("x > 2f");
corlist.Add("f < x < 2f");

questionlist.Add("The largest wavelength in the ultraviolet region of the hydrogen spectrum is 122 nm. The smallest wavelength in the infrared region of the hydrogen spectrum (to the nearest integer) is");
op1list.Add("802 nm");
op2list.Add("823 nm");
op3list.Add("1882 nm");
op4list.Add("1648 nm");
corlist.Add("823 nm");

questionlist.Add("A resistance of 2 Ω is connected across one gap of a metre-bridge (the length of the wire is 100 cm) and an unknown resistance, greater than 2Ω, is connected across the other gap. When these resistance are interchanged, the balance point shifts by 20 cm. Neglecting any corrections, the unknown resistance is");
op1list.Add("3 Ω");
op2list.Add("4 Ω");
op3list.Add("5 Ω");
op4list.Add("6 Ω");
corlist.Add("3 Ω");

questionlist.Add("Consider a neutral conducting sphere. A positive point charge is placed outside the sphere. The net charge on the sphere is then,");
op1list.Add("negative and distributed uniformly over the surface of the sphere");
op2list.Add("negative and appears only at the point on the sphere closest to the point charge");
op3list.Add("negative and distributed non-uniformly over the entire surface of the sphere");
op4list.Add("zero");
corlist.Add("zero");

questionlist.Add("Two beams of red and violet colours are made to pass separately through a prism (angle of the prism is 60°). In the position of minimum deviation, the angle of refraction will be");
op1list.Add("30° for both the colours");
op2list.Add("greater for the violet colour");
op3list.Add("greater for the red colour");
op4list.Add("equal but not 30° for both the colours");
corlist.Add("30° for both the colours");

questionlist.Add("Which one of the following statements is WRONG in the context of X-rays generated from a X-ray tube?");
op1list.Add("Wavelength of characteristic X-rays decreases when the atomic number of the target increases.");
op2list.Add("Cut-off wavelength of the continuous X-rays depends on the atomic number of the target");
op3list.Add("Intensity of the characteristic X-rays depends on the electrical power given to the X-ray tube");
op4list.Add("Cut-off wavelength of the continuous X-rays depends on the energy of the electrons in the X-ray tube");
corlist.Add("Cut-off wavelength of the continuous X-rays depends on the atomic number of the target");

questionlist.Add("A vibrating string of certain length 􀁁 under a tension T resonates with a mode corresponding to the first overtone (third harmonic) of an air column of length 75 cm inside a tube closed at one end. The string also generates 4 beats per second when excited along with a tuning fork of frequency n. Now when the tension of the string is slightly increased the number of beats reduces 2 per second. Assuming the velocity of sound in air to be 340 m/s, the frequency n of the tuning fork in Hz is");
op1list.Add("344");
op2list.Add("336");
op3list.Add("117.3");
op4list.Add("109.3");
corlist.Add("344");

questionlist.Add("A radioactive sample S1 having an activity 5μCi has twice the number of nuclei as another sample S2 which has an activity of 10 μCi. The half lives of S1 and S2 can be");
op1list.Add("20 years and 5 years, respectively");
op2list.Add("20 years and 10 years, respectively");
op3list.Add("10 years each");
op4list.Add("5 years each");
corlist.Add("20 years and 5 years, respectively");

questionlist.Add("If the resultant of all the external forces acting on a system of particles is zero, then from an inertial frame, one can surely say that");
op1list.Add("linear momentum of the system does not change in time");
op2list.Add("kinetic energy of the system does not change in time");
op3list.Add("angular momentum of the system does not change in time");
op4list.Add("potential energy of the system does not change in time");
corlist.Add("linear momentum of the system does not change in time");

questionlist.Add("A piece of wire is bent in the shape of a parabola y = kx2 (y-axis vertical) with a bead of mass m on it. The bead can slide on the wire without friction. It stays at the lowest point of the parabola when the wire is at rest. The wire is now accelerated parallel to the x-axis with a constant acceleration a. The distance of the new equilibrium position of the bead, where the bead can stays at rest with respect to the wire, from the yaxis is");
op1list.Add("a/gk");
op2list.Add("a/2gk");
op3list.Add("2a/gk");
op4list.Add("a/4gk");
corlist.Add("a/2gk");

questionlist.Add("Under the influence of the coulomb field of charge +Q, a charge −q is moving around it in an elliptical orbit. Find out the correct statement(s).");
op1list.Add("The angular momentum of the charge −q is constant");
op2list.Add("The linear momentum of the charge −q is constant");
op3list.Add("The angular velocity of the charge −q is constant");
op4list.Add("The angular velocity of the charge −q is constant");
corlist.Add("The angular momentum of the charge −q is constant");

questionlist.Add("An AC voltage source of variable angular frequency ω and fixed amplitude V0 is connected in series with a capacitance C and an electric bulb of resistance R (inductance zero). When ω is increased");
op1list.Add("the bulb glows dimmer");
op2list.Add("the bulb glows brighter");
op3list.Add("total impedance of the circuit is unchanged");
op4list.Add("total impedance of the circuit increases");
corlist.Add("the bulb glows brighter");


    }



        
        

        public BlankPage3()
        {
            this.InitializeComponent();
            dt.Interval = TimeSpan.FromSeconds(15);
            timedisp.Interval = TimeSpan.FromSeconds(1);
            timedisp.Tick += timedisp_Tick;
            timedisp.Start();
            dt.Tick += dt_Tick;
            generatequestions();
        }
        void timedisp_Tick(object sender, object e)
        {
            time1.Text = DateTime.Now.ToString();
        }
       async void dt_Tick(object sender, object e)
        {
            if (_1_1.IsChecked == false && _2_1.IsChecked == false && _3_1.IsChecked == false && _4_1.IsChecked == false)
            {
                MessageDialog md = new MessageDialog("===choose an option===");
                await md.ShowAsync();
                dt.Stop();
            }
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            showNextques();
        }
        int qno;
        private void start_Click(object sender, RoutedEventArgs e)
        {
            //START QUIZ LOGIC


        }
        void showNextques()
        {
            Random r = new Random();
            int q = r.Next(0, questionlist.Count);
            txtbox1.Text = questionlist.ElementAt(q);
            _1_1.Content = op1list.ElementAt(q);
            _2_1.Content = op2list.ElementAt(q);
            _3_1.Content = op3list.ElementAt(q);
            _4_1.Content = op4list.ElementAt(q);
            qno = q;
            dt.Start();

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void _2_Checked(object sender, RoutedEventArgs e)
        {

        }




        int count = 0;
        int ttl=0;
        async void submitTheQuestion()
        {
            ttl = ttl + 1;
            dt.Stop();
            string ans;
            if (_1_1.IsChecked == true)
            {
                ans = _1_1.Content.ToString();
            }
            else if (_2_1.IsChecked == true)
            {
                ans = _2_1.Content.ToString();
            }
            else if (_3_1.IsChecked == true)
            {
                ans = _3_1.Content.ToString();
            }
            else
            {
                ans = _4_1.Content.ToString();
            }

            if (ans.Equals(corlist.ElementAt(qno)))
            {
                count =  count+1;
                MessageDialog md = new MessageDialog("===COrrect answer===");
                await md.ShowAsync();
                showNextques();
            }

            else if (_1_1.IsChecked == false && _2_1.IsChecked == false && _3_1.IsChecked == false && _4_1.IsChecked == false)
            {
                MessageDialog md = new MessageDialog("===choose an option===");
                await md.ShowAsync();

            }
            else
            {
                MessageDialog md = new MessageDialog("is correct answer\n\n===Your answer is InCOrrect===",corlist.ElementAt(qno));
                await md.ShowAsync();
                showNextques();
            }

            if (_1_1.IsChecked == true)
                _1_1.IsChecked = false;
            if (_2_1.IsChecked == true)
                _2_1.IsChecked = false;
            if (_3_1.IsChecked == true)
                _3_1.IsChecked = false;
            if (_4_1.IsChecked == true)
                _4_1.IsChecked = false;

        }

      
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            submitTheQuestion();

        }
        
        async private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ttl == 0)
            { ttl = 1; }
            float l;
            l = count * 100 / ttl;
            string s = count.ToString();
            string k = ttl.ToString();
            string j = l.ToString();
            dt.Stop();
            MessageDialog md = new MessageDialog(s + " correct answer(s) out of " + k + " questions" + "\n Pecentage = " + j + "%", "Score card : ");
            await md.ShowAsync();
            this.Frame.Navigate(typeof(BlankPage7));
        }    

      
    }

}





