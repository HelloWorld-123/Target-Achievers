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
    public sealed partial class BlankPage1 : Page
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

        questionlist.Add("A solution when diluted with H2O and boiled, it gives a white precipitate. On addition of excess NH4Cl/NH4OH. the volume of precipitate decreases leaving behind a white gelatinous precipitate. Identify the precipitate which dissolves in NH4OH/NH4Cl");
op1list.Add("Zn(OH)2") ;
op2list.Add("Al(OH)3") ;
op3list.Add("Mg(OH)2") ;
op4list.Add("Ca(OH)2") ;
corlist.Add("Zn(OH)2") ;

questionlist.Add("When benzene sulfonic acid and p-nitrophenol are treated with NaHCO3, the gases released respectively are") ;
op1list.Add("SO2, NO2") ;
op2list.Add("SO2, NO");
op3list.Add("SO2, CO2");
op4list.Add ("CO2, CO2") ;
corlist.Add("CO2, CO2");

questionlist.Add("A monatomic ideal gas undergoes a process in which the ratio of P to V at any instant is constant and equals to 1. What is the molar heat capacity of the gas?") ;
op1list.Add("4R/2") ;
op2list.Add("3R") ;
op3list.Add("5R/2") ; 
op4list.Add("0") ;
corlist.Add("4R/2") ;

questionlist.Add("(I) 1,2-dihydroxy benzene (II) 1,3-dihydroxy benzene (III) 1,4-dihydroxy benzene (IV) Hydroxy benzene The increasing order of boiling points of above mentioned alcohols is") ;
op1list.Add("I < II < III < IV") ;
op2list.Add("I < II < IV < III") ;
op3list.Add("IV < I < II < III") ; 
op4list.Add("IV < II < I < III") ;
corlist.Add("IV < I < II < III") ;


questionlist.Add( "The IUPAC name of C6H5COCl is") ;
op1list.Add("Benzoyl chloride") ;
op2list.Add("Benzene chloro ketone") ;
op3list.Add("Benzene carbonyl chloride") ;
op4list.Add("Chloro phenyl ketone") ;
corlist.Add("Benzene carbonyl chloride") ;

questionlist.Add("CuSO4 decolourises on addition of KCN, the product is") ;
op1list.Add("[Cu(CN)4]2−") ;
op2list.Add("Cu2+ get reduced to form [Cu(CN)4]3−") ;
op3list.Add( "Cu(CN)2") ;
op4list.Add("CuCN") ;
corlist.Add("CuCN") ;

questionlist.Add("If the bond length of CO bond in carbon monoxide is 1.128A, then what is the value of CO bond length in Fe(CO)5");
op1list.Add("1.15A") ;
op2list.Add("1.128A") ;
op3list.Add("1.72A") ;
op4list.Add("1.118A") ;
corlist.Add("1.15A") ;

questionlist.Add("The smallest ketone and its next homologue are reacted with NH2OH to form oxime") ;
op1list.Add("Two different oximes are formed") ; 
op2list.Add("Three different oximes are formed") ;
op3list.Add("Two oximes are optically active") ; 
op4list.Add("All oximes are optically active") ;
corlist.Add("Three different oximes are formed") ;

questionlist.Add("The number of structural isomers for C6H14 is") ;
op1list.Add("3") ;
op2list.Add("4") ;
op3list.Add("5") ;
op4list.Add("6") ;
corlist.Add("5") ;

questionlist.Add("When 20 g of naphthoic acid (C11H8O2) is dissolved in 50 g of benzene (Kf = 1.72 K kg mol−1), a freezing point depression of 2 K is observed. The van’t Hoff factor (i) is");
op1list.Add("0.5") ;
op2list.Add("1") ;
op3list.Add("2") ;
op4list.Add("3") ;
corlist.Add("0.5") ;

questionlist.Add("Among the following, the paramagnetic compound is") ;
op1list.Add("Na2O2") ;
op2list.Add("O3") ;
op3list.Add("N2O") ;
op4list.Add("KO2") ;
corlist.Add("KO2") ;

questionlist.Add("The species having bond order different from that in CO is") ;
op1list.Add("NO-") ;
op2list.Add("NO+") ;
op3list.Add("CN-") ;
op4list.Add("N2") ;
corlist.Add("NO-") ;

questionlist.Add("The percentage of p-character in the orbitals forming P−P bonds in P4 is") ;
op1list.Add("25") ;
op2list.Add("33") ;
op3list.Add("50") ;
op4list.Add("75") ;
corlist.Add("75") ;

questionlist.Add("Extraction of zinc from zinc blende is achieved by") ;
op1list.Add("electrolytic reduction") ;
op2list.Add("roasting followed by reduction with carbon") ;
op3list.Add("roasting followed by reduction with another metal") ;
op4list.Add("roasting followed by self-reduction") ;
corlist.Add("roasting followed by reduction with carbon") ;

questionlist.Add("STATEMENT-1: p-Hydroxybenzoic acid has a lower boiling point than o-hydroxybenzoic acid.\n STATEMENT-2: o-Hydroxybenzoic acid has intramolecular hydrogen bonding") ;
op1list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;
op2list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;
op3list.Add("Statement-1 is True, Statement -2 is False") ;
op4list.Add("Statement-1 is False, Statement-2 is True") ;
corlist.Add("Statement-1 is False, Statement-2 is True") ;

questionlist.Add("STATEMENT-1: Micelles are formed by surfactant molecules above the critical micellar concentration (CMC).\n STATEMENT-2: The conductivity of a solution having surfactant molecules decreases sharply at the CMC.") ;
op1list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;
op2list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;
op3list.Add("Statement-1 is True, Statement-2 is False") ;
op4list.Add("Statement-1 is False, Statement-2 is True") ;
corlist.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;

questionlist.Add("STATEMENT-1: Boron always forms covalent bond. \n STATEMENT-2: The small size of B3+ favours formation of covalent bond") ;
op1list.Add( "Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;
op2list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;
op3list.Add("Statement-1 is True, Statement-2 is True") ;
op4list.Add("Statement-1 is False, Statement-2 is True") ;
corlist.Add("Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;

questionlist.Add("STATEMENT-1: In water, orthoboric acid behaves as a weak monobasic acid. \n STATEMENT-2: In water, orthoboric acid acts as a proton donor") ;
op1list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;
op2list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;
op3list.Add("Statement-1is True, Statement-2 is False") ;
op4list.Add("Statement-1 is False, Statement-2 is True") ;
corlist.Add("Statement-1 is True, Statement-2 is False") ; 

questionlist.Add("In a mixture of H−He+ gas (He+ is singly ionized He atom), H atoms and He+ ions are excited to their respective first excited states. Subsequently, H atoms transfer their total excitation energy to He+ ions (by collisions). Assume that the Bohr model of atom is exactly valid. The quantum number n of the state finally populated in He+ ions is") ;
op1list.Add("2") ;
op2list.Add("3") ;
op3list.Add("4") ;
op4list.Add("5") ;
corlist.Add("4") ;

questionlist.Add("Consider a reaction aG + bH → Products. When concentration of both the reactants G and H is doubled, the rate increases by eight times. However, when concentration of G is doubled keeping the concentration of H fixed, the rate is doubled. The overall order of the reaction is") ;
op1list.Add("0") ;
op2list.Add("1") ;
op3list.Add("2") ;
op4list.Add("3") ;
corlist.Add("3") ;

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



        
        

        public BlankPage1()
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
            l = count*100/ttl;
            string s = count.ToString();
            string k = ttl.ToString();
            string j = l.ToString();
            dt.Stop();
            MessageDialog md = new MessageDialog(  s+" correct answer(s) out of "+k + " questions" + "\n Pecentage = " +j+"%" ,"Score card : " );
            await md.ShowAsync();
            this.Frame.Navigate(typeof(BlankPage7));
        }    

      
    }

}





