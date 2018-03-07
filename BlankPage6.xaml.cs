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
    public sealed partial class BlankPage6 : Page
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



          questionlist.Add("The number of distinct real values of λ, for which the vectors − λ2ˆi + ˆj +ˆk , ˆi − λ2 ˆj +ˆk and ˆi + ˆj − λ2ˆk are coplanar, is");
op1list.Add("zero");
op2list.Add("one");
op3list.Add("two");
op4list.Add("three");
corlist.Add("two");

questionlist.Add("One Indian and four American men and their wives are to be seated randomly around a circular table. Then the conditional probability that the Indian man seated adjacent to his wife given that each American man is seated adjacent to his wife is");
op1list.Add("1/2");
op2list.Add("1/3");
op3list.Add("2/5");
op4list.Add("1/5");
corlist.Add("2/5");

questionlist.Add("The letters of the word COCHIN are permuted and all the permutations are arranged in an alphabetical order as in an English dictionary. The number of words that appear before the word COCHIN is");
op1list.Add("360");
op2list.Add("192");
op3list.Add("96");
op4list.Add("48");
corlist.Add("96");

questionlist.Add("Let ABCD be a quadrilateral with area 18, with side AB parallel to the side CD and AB = 2CD. Let AD be perpendicular to AB and CD. If a circle is drawn inside the quadrilateral ABCD touching all the sides, then its radius is");
op1list.Add("3");
op2list.Add("2");
op3list.Add("3/2");
op4list.Add("1");
corlist.Add("2");

questionlist.Add("Consider the system of equations ax + by = 0, cx + dy = 0, where a, b, c, d ∈ {0, 1}. STATEMENT – 1: The probability that the system of equations has a unique solution is 3/8 \n STATEMENT – 2: The probability that the system of equations has a solution is 1.");
op1list.Add("Statement-1 is True, Statement -2 is True; Statement-2 is a correct explanation for Statement-1");
op2list.Add("Statement -1 is True, Statement -2 is True; Statement-2 is NOT a correct explanation for Statement-1");
op3list.Add("Statement -1 is True, Statement -2 is False");
op4list.Add("Statement -1 is False, Statement -2 is True");
corlist.Add("Statement -1 is True, Statement -2 is True; Statement-2 is NOT a correct explanation for Statement-1");

questionlist.Add("Consider three planes\n P1: x − y + z = 1 \n P2: x + y − z = −1 \n P3: x − 3y + 3z = 2. Let L1, L2, L3 be the lines of intersection of the planes P2 and P3, P3 and P1, and P1 and P2, respectively.\n STATEMENT -1 : At least two of the lines L1, L2 and L3 are non-parallel. and \n STATEMENT -2 : The three planes do not have a common point.");
op1list.Add("Statement-1 is True, Statement -2 is True; Statement-2 is a correct explanation for Statement-1");
op2list.Add("Statement -1 is True, Statement -2 is True; Statement-2 is NOT a correct explanation for Statement-1");
op3list.Add("Statement -1 is True, Statement -2 is False");
op4list.Add("Statement -1 is False, Statement -2 is True");
corlist.Add("Statement -1 is False, Statement -2 is True");

questionlist.Add("An experiment has 10 equally likely outcomes. Let A and B be two non-empty events of the experiment. If A consists of 4 outcomes, the number of outcomes that B must have so that A and B are independent, is");
op1list.Add("2, 4 or 8");
op2list.Add("3, 6 or 9");
op3list.Add("4 or 8");
op4list.Add("5 or 10");
corlist.Add("5 or 10");

questionlist.Add("Consider three points P = (−sin(β − α), − cosβ), Q = (cos(β − α), sinβ) and R = (cos(β − α + θ), sin(β − θ)), where 0 < α, β, θ <π/4. Then");
op1list.Add("P lies on the line segment RQ");
op2list.Add("Q lies on the line segment PR");
op3list.Add("R lies on the line segment QP");
op4list.Add("P, Q, R are non-collinear");
corlist.Add("P, Q, R are non-collinear");

questionlist.Add("Consider L1 : 2x + 3y + p − 3 = 0 L2 : 2x + 3y + p + 3 = 0, where p is a real number, and C : x2 + y2 + 6x − 10y + 30 = 0. STATEMENT−1 : If line L1 is a chord of circle C, then line L2 is not always a diameter of circle C. and STATEMENT−2 : If line L1 is a diameter of circle C, then line L2 is not a chord of circle C.");
op1list.Add(" STATEMENT−1 is True, STATEMENT−2 is True; STATEMENT−2 is a correct explanation for STATEMENT−1");
op2list.Add(" STATEMENT−1 is True, STATEMENT−2 is True; STATEMENT−2 is NOT a correct explanation for STATEMENT−1.");
op3list.Add("STATEMENT−1 is True, STATEMENT−2 is False");
op4list.Add("STATEMENT−1 is False, STATEMENT−2 is True");
corlist.Add("STATEMENT−1 is True, STATEMENT−2 is False");

questionlist.Add("Suppose four distinct positive numbers a1, a2, a3, a4 are in G.P. Let b1 = a1, b2 = b1 + a2, b3 = b2 + a3 and b4 = b3 + a4. STATEMENT−1 : The numbers b1, b2, b3, b4 are neither in A.P. nor in G.P. and STATEMENT−2 : The numbers b1, b2, b3, b4 are in H.P.");
op1list.Add("STATEMENT−1 is True, STATEMENT−2 is True; STATEMENT−2 is a correct explanation for STATEMENT−1");
op2list.Add("STATEMENT−1 is True, STATEMENT−2 is True; STATEMENT−2 is NOT a correct explanation for STATEMENT−1.");
op3list.Add("STATEMENT−1 is True, STATEMENT−2 is False");
op4list.Add("TATEMENT−1 is False, STATEMENT−2 is True");
corlist.Add("STATEMENT−1 is True, STATEMENT−2 is False");

 questionlist.Add("Given an isosceles triangle, whose one angle is 120° and radius of its incircle = 3 . Then the area of the triangle in sq. units is");
op1list.Add("7+(12sqrt(3))");
op2list.Add("12-(7sqrt(3))");
op3list.Add("12+(7sqrt(3))");
op4list.Add("12.56");
corlist.Add("12+(7sqrt(3))");

questionlist.Add("If r, s, t are prime numbers and p, q are the positive integers such that the LCM of p, q is r^2t^4s^2, then the number of ordered pair (p, q) is");
op1list.Add("252");
op2list.Add("254") ;
op3list.Add("225") ;
op4list.Add("224") ;
corlist.Add("225");

questionlist.Add("Let ω be a complex cube root of unity with ω ≠ 1. A fair die is thrown three times. If r1, r2 and r3 are the numbers obtained on the die, then the probability that ωr1 + ωr2 + ωr3 = 0 is");
op1list.Add("1/18") ;
op2list.Add("1/9") ;
op3list.Add("2/9");
op4list.Add("1/36") ;
corlist.Add("2/9") ; 

questionlist.Add("Let P, Q, R and S be the points on the plane with position vectors −2ˆi − ˆj, 4ˆi, 3ˆi + 3ˆj and −3ˆi + 2ˆj respectively. The quadrilateral PQRS must be a");
op1list.Add("parallelogram, which is neither a rhombus nor a rectangle");
op2list.Add("Square") ;
op3list.Add("rectangle, but not a square");
op4list.Add("rhombus, but not a square");
corlist.Add("parallelogram, which is neither a rhombus nor a rectangle");

questionlist.Add("If the angles A, B and C of a triangle are in an arithmetic progression and if a, b and c denote the lengths of the sides opposite to A, B and C respectively, then the value of the expression (a/c)sin 2C + (c/a)sin 2A is");
op1list.Add("1/2");
op2list.Add("sqrt(3)/2");
op3list.Add("1");
op4list.Add("sqrt(3)");
corlist.Add("sqrt(3)");

questionlist.Add("A signal which can be green or red with probability 4/5and 1/5 respectively, is received by station A and then transmitted to station B. The probability of each station receiving the signal correctly is 3/4. If the signal received at station B is green, then the probability that the original signal was green is");
op1list.Add("3/5");
op2list.Add("6/7");
op3list.Add("20/23");
op4list.Add("9/20");
corlist.Add("20/23");

questionlist.Add("Let S = {1, 2, 3, 4}. The total number of unordered pairs of disjoint subsets of S is equal to");
op1list.Add("25");
op2list.Add("34");
op3list.Add("42");
op4list.Add("41");
corlist.Add("41");

questionlist.Add("A value of b for which the equations \n x^2 + bx - 1 = 0 \n x^2 + x + b = 0, have one root in common is");
op1list.Add("-sqrt(2)");
op2list.Add("-isqrt(3)");
op3list.Add("isqrt(5)");
op4list.Add("sqrt(2)");
corlist.Add("sqrt(2)");

questionlist.Add("The total number of ways in which 5 balls of different colours can be distributed among 3 persons so that each person gets at least one ball is"); 
op1list.Add("75");
op2list.Add("150");
op3list.Add("210");
op4list.Add("243"); 
corlist.Add("150");

questionlist.Add("Let z be a complex number such that the imaginary part of z is nonzero and a = z^2 + z + 1 is real. Then a cannot take the value");
op1list.Add("-1");
op2list.Add("1/3");
op3list.Add("1/2");
op4list.Add("3/4");
corlist.Add("3/4");


        }


        

        public BlankPage6()
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
            time2.Text = DateTime.Now.ToString();
        }
        async void  dt_Tick(object sender, object e)
        {
            if (_1_2.IsChecked == false && _2_2.IsChecked == false && _3_2.IsChecked == false && _4_2.IsChecked == false)
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
            txtbox2.Text = questionlist.ElementAt(q);
            _1_2.Content = op1list.ElementAt(q);
            _2_2.Content = op2list.ElementAt(q);
            _3_2.Content = op3list.ElementAt(q);
            _4_2.Content = op4list.ElementAt(q);
            qno = q;
            dt.Start();

        }
        int count = 0;
        int ttl=0;
    
        async void submitTheQuestion()
        {
            ttl = ttl + 1;
            dt.Stop();
            string ans;
            if (_1_2.IsChecked == true)
            {
                ans = _1_2.Content.ToString();
            }
            else if (_2_2.IsChecked == true)
            {
                ans = _2_2.Content.ToString();
            }
            else if (_3_2.IsChecked == true)
            {
                ans = _3_2.Content.ToString();
            }
            else
            {
                ans = _4_2.Content.ToString();
            }


            if (ans.Equals(corlist.ElementAt(qno)))
            {
                count = count + 1;
                MessageDialog md = new MessageDialog("===COrrect answer===");
                await md.ShowAsync();
                showNextques();
            }

            else if (_1_2.IsChecked == false && _2_2.IsChecked == false && _3_2.IsChecked == false && _4_2.IsChecked == false)
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

            if (_1_2.IsChecked == true)
                _1_2.IsChecked = false;
            if (_2_2.IsChecked == true)
                _2_2.IsChecked = false;
            if (_3_2.IsChecked == true)
                _3_2.IsChecked = false;
            if (_4_2.IsChecked == true)
                _4_2.IsChecked = false;

        }

     

       async private void end_Click(object sender, RoutedEventArgs e)
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

        private void sub2_Click_1(object sender, RoutedEventArgs e)
        {
           
            submitTheQuestion();
        }

       
    }

}





